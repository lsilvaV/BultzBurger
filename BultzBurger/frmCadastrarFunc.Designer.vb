<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastrarFunc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarFunc))
        Me.txtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.imgFotoFunc = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnCadastrar = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbCargo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CadastrarFunc = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ofdImg = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnAdicionarItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarSangria = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCadastrarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarCredenciais = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.imgFotoFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.Transparent
        Me.txtSenha.BorderRadius = 8
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.DefaultText = ""
        Me.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.Location = New System.Drawing.Point(181, 326)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSenha.PlaceholderText = ""
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.Size = New System.Drawing.Size(466, 36)
        Me.txtSenha.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.Transparent
        Me.txtNome.BorderRadius = 8
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.DefaultText = ""
        Me.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(181, 228)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.PlaceholderText = ""
        Me.txtNome.SelectedText = ""
        Me.txtNome.Size = New System.Drawing.Size(466, 36)
        Me.txtNome.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(181, 430)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(466, 36)
        Me.txtEmail.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(356, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(177, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(177, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Senha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(177, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "E-mail"
        '
        'imgFotoFunc
        '
        Me.imgFotoFunc.Image = CType(resources.GetObject("imgFotoFunc.Image"), System.Drawing.Image)
        Me.imgFotoFunc.ImageRotate = 0!
        Me.imgFotoFunc.Location = New System.Drawing.Point(723, 148)
        Me.imgFotoFunc.Name = "imgFotoFunc"
        Me.imgFotoFunc.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.imgFotoFunc.Size = New System.Drawing.Size(300, 300)
        Me.imgFotoFunc.TabIndex = 58
        Me.imgFotoFunc.TabStop = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Animated = True
        Me.btnCadastrar.BorderRadius = 8
        Me.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCadastrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCadastrar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnCadastrar.ForeColor = System.Drawing.Color.White
        Me.btnCadastrar.Location = New System.Drawing.Point(316, 501)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(164, 48)
        Me.btnCadastrar.TabIndex = 5
        Me.btnCadastrar.Text = "CADASTRAR"
        '
        'cmbCargo
        '
        Me.cmbCargo.BackColor = System.Drawing.Color.Transparent
        Me.cmbCargo.BorderRadius = 8
        Me.cmbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCargo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCargo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCargo.ForeColor = System.Drawing.Color.Black
        Me.cmbCargo.ItemHeight = 30
        Me.cmbCargo.Location = New System.Drawing.Point(360, 122)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(287, 36)
        Me.cmbCargo.TabIndex = 1
        '
        'txtCpf
        '
        Me.txtCpf.BackColor = System.Drawing.Color.Transparent
        Me.txtCpf.BorderRadius = 8
        Me.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCpf.DefaultText = ""
        Me.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.ForeColor = System.Drawing.Color.Black
        Me.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpf.Location = New System.Drawing.Point(177, 122)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCpf.PlaceholderText = ""
        Me.txtCpf.SelectedText = ""
        Me.txtCpf.Size = New System.Drawing.Size(147, 36)
        Me.txtCpf.TabIndex = 0
        '
        'CadastrarFunc
        '
        Me.CadastrarFunc.AnimateWindow = True
        Me.CadastrarFunc.AnimationInterval = 200
        Me.CadastrarFunc.BorderRadius = 16
        Me.CadastrarFunc.ContainerControl = Me
        Me.CadastrarFunc.DockIndicatorTransparencyValue = 0.6R
        Me.CadastrarFunc.ResizeForm = False
        Me.CadastrarFunc.TransparentWhileDrag = True
        '
        'ofdImg
        '
        Me.ofdImg.FileName = "ofdImg"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnAdicionarItem)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSair)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnRealizarSangria)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnCadastrarFunc)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnVisualizarCredenciais)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Guna2ShadowPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 7
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 255
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(82, 576)
        Me.Guna2ShadowPanel1.TabIndex = 62
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.Animated = True
        Me.btnAdicionarItem.BorderRadius = 10
        Me.btnAdicionarItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionarItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionarItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdicionarItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdicionarItem.FillColor = System.Drawing.Color.Transparent
        Me.btnAdicionarItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdicionarItem.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdicionarItem.Image = CType(resources.GetObject("btnAdicionarItem.Image"), System.Drawing.Image)
        Me.btnAdicionarItem.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnAdicionarItem.Location = New System.Drawing.Point(11, 325)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.PressedColor = System.Drawing.Color.Transparent
        Me.btnAdicionarItem.Size = New System.Drawing.Size(60, 54)
        Me.btnAdicionarItem.TabIndex = 63
        '
        'btnSair
        '
        Me.btnSair.Animated = True
        Me.btnSair.BorderRadius = 10
        Me.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSair.FillColor = System.Drawing.Color.Transparent
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSair.ForeColor = System.Drawing.Color.Transparent
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSair.Location = New System.Drawing.Point(11, 500)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.PressedColor = System.Drawing.Color.Transparent
        Me.btnSair.Size = New System.Drawing.Size(60, 54)
        Me.btnSair.TabIndex = 8
        '
        'btnRealizarSangria
        '
        Me.btnRealizarSangria.Animated = True
        Me.btnRealizarSangria.BorderRadius = 10
        Me.btnRealizarSangria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRealizarSangria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRealizarSangria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRealizarSangria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRealizarSangria.FillColor = System.Drawing.Color.Transparent
        Me.btnRealizarSangria.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRealizarSangria.ForeColor = System.Drawing.Color.Transparent
        Me.btnRealizarSangria.Image = CType(resources.GetObject("btnRealizarSangria.Image"), System.Drawing.Image)
        Me.btnRealizarSangria.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnRealizarSangria.Location = New System.Drawing.Point(11, 216)
        Me.btnRealizarSangria.Name = "btnRealizarSangria"
        Me.btnRealizarSangria.PressedColor = System.Drawing.Color.Transparent
        Me.btnRealizarSangria.Size = New System.Drawing.Size(60, 54)
        Me.btnRealizarSangria.TabIndex = 7
        '
        'btnCadastrarFunc
        '
        Me.btnCadastrarFunc.Animated = True
        Me.btnCadastrarFunc.BorderRadius = 10
        Me.btnCadastrarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCadastrarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCadastrarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCadastrarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCadastrarFunc.FillColor = System.Drawing.Color.Transparent
        Me.btnCadastrarFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCadastrarFunc.ForeColor = System.Drawing.Color.Transparent
        Me.btnCadastrarFunc.Image = CType(resources.GetObject("btnCadastrarFunc.Image"), System.Drawing.Image)
        Me.btnCadastrarFunc.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCadastrarFunc.Location = New System.Drawing.Point(11, 22)
        Me.btnCadastrarFunc.Name = "btnCadastrarFunc"
        Me.btnCadastrarFunc.PressedColor = System.Drawing.Color.Transparent
        Me.btnCadastrarFunc.Size = New System.Drawing.Size(60, 54)
        Me.btnCadastrarFunc.TabIndex = 6
        '
        'btnVisualizarCredenciais
        '
        Me.btnVisualizarCredenciais.Animated = True
        Me.btnVisualizarCredenciais.BorderRadius = 10
        Me.btnVisualizarCredenciais.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarCredenciais.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarCredenciais.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVisualizarCredenciais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVisualizarCredenciais.FillColor = System.Drawing.Color.Transparent
        Me.btnVisualizarCredenciais.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVisualizarCredenciais.ForeColor = System.Drawing.Color.Transparent
        Me.btnVisualizarCredenciais.Image = CType(resources.GetObject("btnVisualizarCredenciais.Image"), System.Drawing.Image)
        Me.btnVisualizarCredenciais.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnVisualizarCredenciais.Location = New System.Drawing.Point(11, 114)
        Me.btnVisualizarCredenciais.Name = "btnVisualizarCredenciais"
        Me.btnVisualizarCredenciais.PressedColor = System.Drawing.Color.Transparent
        Me.btnVisualizarCredenciais.Size = New System.Drawing.Size(60, 54)
        Me.btnVisualizarCredenciais.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(780, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 23)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Foto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(372, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(388, 37)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Cadastro de Funcionários"
        '
        'frmCadastrarFunc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.cmbCargo)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.imgFotoFunc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtSenha)
        Me.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastrarFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadastrarFuncionario"
        CType(Me.imgFotoFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgFotoFunc As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnCadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbCargo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CadastrarFunc As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ofdImg As OpenFileDialog
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarSangria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCadastrarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarCredenciais As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdicionarItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
