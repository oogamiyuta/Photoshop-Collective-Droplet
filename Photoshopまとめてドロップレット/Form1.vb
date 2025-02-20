﻿Imports System.IO
Imports System.Diagnostics
Imports System.Speech.Synthesis
Public Class Form1
    Private synthesizer As New SpeechSynthesizer()
    Private settingsFile As String = Path.Combine(Application.UserAppDataPath, "settings.csv")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaths()
    End Sub

    Private Sub LoadPaths()
        ComboBox1.Items.Clear()
        If File.Exists(settingsFile) Then
            Dim lines = File.ReadAllLines(settingsFile)
            For Each line In lines
                ComboBox1.Items.Add(line)
            Next
        End If
        If ComboBox1.Items.Count > 0 Then ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub SavePaths()
        File.WriteAllLines(settingsFile, ComboBox1.Items.Cast(Of String)())
    End Sub

    Private Sub BtnAddPath_Click(sender As Object, e As EventArgs) Handles BtnAddPath.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "ドロップレット (*.exe)|*.exe"
            ofd.Title = "追加するドロップレットファイルを選択"
            If ofd.ShowDialog() = DialogResult.OK Then
                If Not ComboBox1.Items.Contains(ofd.FileName) Then
                    ComboBox1.Items.Add(ofd.FileName)
                    SavePaths()
                End If
            End If
        End Using
    End Sub

    Private Sub BtnRemovePath_Click(sender As Object, e As EventArgs) Handles BtnRemovePath.Click
        If ComboBox1.SelectedIndex >= 0 Then
            ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
            SavePaths()
        End If
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each file In files
            If Directory.Exists(file) Then
                ListBox1.Items.Add(file) ' フォルダーもリストに追加
            ElseIf file.ToLower().EndsWith(".jpg") OrElse file.ToLower().EndsWith(".jpeg") OrElse file.ToLower().EndsWith(".png") OrElse file.ToLower().EndsWith(".bmp") OrElse file.ToLower().EndsWith(".tiff") Then
                ListBox1.Items.Add(file)
            End If
        Next
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dropletPath As String = ComboBox1.SelectedItem.ToString()
        Dim folderGroups As New Dictionary(Of String, List(Of String))()
        ListBox2.Items.Clear()
        For Each item As String In ListBox1.Items
            If File.Exists(item) Then
                Dim parentFolder As String = Directory.GetParent(item).FullName
                If Not folderGroups.ContainsKey(parentFolder) Then
                    folderGroups(parentFolder) = New List(Of String)()
                End If
                folderGroups(parentFolder).Add(item)
            End If
        Next

        For Each folder In folderGroups.Keys
            ExecuteCommand(dropletPath, folderGroups(folder))
            ListBox2.Items.Add($"{Now().ToString} 処理が完了しました: {folder}")
            SpeakNotification($"処理が完了しました: {folder}")
        Next

        ListBox1.Items.Clear()
    End Sub

    Private Sub ExecuteCommand(dropletPath As String, imageFiles As List(Of String))
        Dim droplet As String = Chr(34) & dropletPath & Chr(34)
        Dim command As String
        For Each file In imageFiles
            command &= " " & Chr(34) & file & Chr(34)
        Next

        command = command.TrimStart()

        Dim process As New Process()
        process.StartInfo.FileName = droplet
        process.StartInfo.Arguments = command
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.WaitForExit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
    ' 音声通知を生成して再生
    Private Sub SpeakNotification(message As String)
        Try
            synthesizer.SpeakAsync(message)
        Catch ex As Exception
            MessageBox.Show("音声通知の生成中にエラーが発生しました。", "エラー")
        End Try
    End Sub

End Class
