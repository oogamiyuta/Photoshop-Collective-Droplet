<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        ListBox2 = New ListBox()
        BtnAddPath = New Button()
        BtnRemovePath = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(2, 1)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(409, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.AllowDrop = True
        ListBox1.Dock = DockStyle.Bottom
        ListBox1.FormattingEnabled = True
        ListBox1.HorizontalScrollbar = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(0, 145)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(800, 379)
        ListBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(632, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "スタート"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(713, 1)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "クリア"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.HorizontalScrollbar = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(0, 45)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(800, 79)
        ListBox2.TabIndex = 4
        ' 
        ' BtnAddPath
        ' 
        BtnAddPath.Location = New Point(417, 1)
        BtnAddPath.Name = "BtnAddPath"
        BtnAddPath.Size = New Size(99, 23)
        BtnAddPath.TabIndex = 5
        BtnAddPath.Text = "ドロップレット登録"
        BtnAddPath.UseVisualStyleBackColor = True
        ' 
        ' BtnRemovePath
        ' 
        BtnRemovePath.Location = New Point(522, 0)
        BtnRemovePath.Name = "BtnRemovePath"
        BtnRemovePath.Size = New Size(104, 23)
        BtnRemovePath.TabIndex = 6
        BtnRemovePath.Text = "ドロップレット削除"
        BtnRemovePath.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(2, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 7
        Label1.Text = "ログ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(2, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 15)
        Label2.TabIndex = 8
        Label2.Text = "↓ドラッグアンドドロップで画像ファイル追加"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 524)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnRemovePath)
        Controls.Add(BtnAddPath)
        Controls.Add(ListBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Photoshopまとめてドロップレット"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents BtnAddPath As Button
    Friend WithEvents BtnRemovePath As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
