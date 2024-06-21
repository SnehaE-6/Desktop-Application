<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(192, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(460, 26)
        Label1.TabIndex = 0
        Label1.Text = "Sneha E, Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F)
        Label2.Location = New Point(124, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 22)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F)
        Label3.Location = New Point(124, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 22)
        Label3.TabIndex = 2
        Label3.Text = "E-Mail"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F)
        Label4.Location = New Point(85, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 22)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F)
        Label5.Location = New Point(85, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 44)
        Label5.TabIndex = 4
        Label5.Text = "GitHub Link" & vbCrLf & "For Task 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(507, 341)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(169, 30)
        TextBox1.TabIndex = 6
        TextBox1.Text = "hh:mm:ss"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(124, 406)
        Button2.Name = "Button2"
        Button2.Size = New Size(552, 29)
        Button2.TabIndex = 7
        Button2.Text = "SUBMIT (CTRL + S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(238, 91)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(438, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(238, 158)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(438, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(238, 224)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(438, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(238, 282)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(438, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(150, 342)
        Button1.Name = "Button1"
        Button1.Size = New Size(329, 29)
        Button1.TabIndex = 12
        Button1.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 488)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Black
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
