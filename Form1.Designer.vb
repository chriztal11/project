<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel2 = New Panel()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Panel3 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label8 = New Label()
        CheckBox3 = New CheckBox()
        TextBoxPass = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(26, 79)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(746, 344)
        Panel2.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Admin", "Student"})
        ComboBox1.Location = New Point(228, 28)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(228, 23)
        ComboBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.RoyalBlue
        Button1.Location = New Point(0, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(746, 39)
        Button1.TabIndex = 9
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.RoyalBlue
        Panel3.Controls.Add(LinkLabel1)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(CheckBox3)
        Panel3.Controls.Add(TextBoxPass)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(-26, 72)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(801, 249)
        Panel3.TabIndex = 8
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Dubai", 9.749999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = SystemColors.ButtonFace
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(26, 170)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(110, 22)
        LinkLabel1.TabIndex = 15
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Dubai", 9.749999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(97, 192)
        Label8.Name = "Label8"
        Label8.Size = New Size(213, 22)
        Label8.TabIndex = 14
        Label8.Text = "Contact the school admin to reset it. " & vbCrLf
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox3.ForeColor = SystemColors.ButtonHighlight
        CheckBox3.Location = New Point(29, 142)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(110, 25)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "Show Password"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Location = New Point(97, 113)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.PasswordChar = "*"c
        TextBoxPass.Size = New Size(385, 23)
        TextBoxPass.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(97, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(385, 23)
        TextBox1.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(31, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 25)
        Label6.TabIndex = 9
        Label6.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(29, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 25)
        Label5.TabIndex = 8
        Label5.Text = "Username:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(324, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 25)
        Label4.TabIndex = 7
        Label4.Text = "Log In with Credentials"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Dubai", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(233, 25)
        Label3.TabIndex = 4
        Label3.Text = "Please select your role to continue:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 452)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(272, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(67, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(336, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 22)
        Label2.TabIndex = 3
        Label2.Text = "Welcome to Announcement Board"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(336, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 36)
        Label1.TabIndex = 2
        Label1.Text = "PulseBoard"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class