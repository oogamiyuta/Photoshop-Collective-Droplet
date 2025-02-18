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
        ListBox1.Location = New Point(0, 86)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(800, 364)
        ListBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(537, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "スタート"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(618, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "クリア"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(0, 33)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(800, 34)
        ListBox2.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox

End Class
