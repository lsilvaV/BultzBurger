<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Login = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.chkVisualizarSenha = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtCpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEntrar = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.AnimateWindow = True
        Me.Login.AnimationInterval = 200
        Me.Login.BorderRadius = 16
        Me.Login.ContainerControl = Me
        Me.Login.DockIndicatorTransparencyValue = 0.6R
        Me.Login.ResizeForm = False
        Me.Login.TransparentWhileDrag = True
        '
        'chkVisualizarSenha
        '
        resources.ApplyResources(Me.chkVisualizarSenha, "chkVisualizarSenha")
        Me.chkVisualizarSenha.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkVisualizarSenha.CheckedState.BorderRadius = 2
        Me.chkVisualizarSenha.CheckedState.BorderThickness = 0
        Me.chkVisualizarSenha.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkVisualizarSenha.Name = "chkVisualizarSenha"
        Me.chkVisualizarSenha.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.chkVisualizarSenha.UncheckedState.BorderRadius = 2
        Me.chkVisualizarSenha.UncheckedState.BorderThickness = 0
        Me.chkVisualizarSenha.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Guna2PictureBox3, "Guna2PictureBox3")
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Guna2PictureBox2, "Guna2PictureBox2")
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.TabStop = False
        '
        'txtCpf
        '
        Me.txtCpf.BorderColor = System.Drawing.Color.Transparent
        Me.txtCpf.BorderRadius = 7
        Me.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCpf.DefaultText = ""
        Me.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.txtCpf, "txtCpf")
        Me.txtCpf.ForeColor = System.Drawing.Color.Black
        Me.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCpf.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtCpf.PlaceholderText = ""
        Me.txtCpf.SelectedText = ""
        '
        'btnEntrar
        '
        Me.btnEntrar.Animated = True
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnEntrar.BorderRadius = 10
        Me.btnEntrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEntrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEntrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEntrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEntrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.btnEntrar, "btnEntrar")
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Name = "btnEntrar"
        '
        'lblSenha
        '
        resources.ApplyResources(Me.lblSenha, "lblSenha")
        Me.lblSenha.ForeColor = System.Drawing.Color.White
        Me.lblSenha.Name = "lblSenha"
        '
        'lblCPF
        '
        resources.ApplyResources(Me.lblCPF, "lblCPF")
        Me.lblCPF.ForeColor = System.Drawing.Color.White
        Me.lblCPF.Name = "lblCPF"
        '
        'txtSenha
        '
        Me.txtSenha.BorderColor = System.Drawing.Color.Transparent
        Me.txtSenha.BorderRadius = 7
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.DefaultText = ""
        Me.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.txtSenha, "txtSenha")
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSenha.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtSenha.PlaceholderText = ""
        Me.txtSenha.SelectedText = ""
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Guna2PictureBox1, "Guna2PictureBox1")
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ControlBox = False
        Me.Controls.Add(Me.chkVisualizarSenha)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents chkVisualizarSenha As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtCpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEntrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSenha As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents txtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
