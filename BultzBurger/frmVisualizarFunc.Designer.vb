<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisualizarFunc
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisualizarFunc))
        Me.VisualizarFunc = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.tcFunc = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabVisualizar = New System.Windows.Forms.TabPage()
        Me.dgvFunc = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.campoCPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoSenha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabEditarFunc = New System.Windows.Forms.TabPage()
        Me.btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeletar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbCargo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnAlterar = New Guna.UI2.WinForms.Guna2Button()
        Me.imgFotoFunc = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbParametro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.lblPesquisa = New System.Windows.Forms.Label()
        Me.txtPesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ofdImgFunc = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnAdicionarItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarSangria = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCadastrarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarCredenciais = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcFunc.SuspendLayout()
        Me.tabVisualizar.SuspendLayout()
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEditarFunc.SuspendLayout()
        CType(Me.imgFotoFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VisualizarFunc
        '
        Me.VisualizarFunc.AnimateWindow = True
        Me.VisualizarFunc.AnimationInterval = 200
        Me.VisualizarFunc.BorderRadius = 16
        Me.VisualizarFunc.ContainerControl = Me
        Me.VisualizarFunc.DockIndicatorTransparencyValue = 0.6R
        Me.VisualizarFunc.ResizeForm = False
        Me.VisualizarFunc.TransparentWhileDrag = True
        '
        'tcFunc
        '
        Me.tcFunc.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcFunc.Controls.Add(Me.tabVisualizar)
        Me.tcFunc.Controls.Add(Me.tabEditarFunc)
        Me.tcFunc.ItemSize = New System.Drawing.Size(140, 40)
        Me.tcFunc.Location = New System.Drawing.Point(111, 111)
        Me.tcFunc.Name = "tcFunc"
        Me.tcFunc.SelectedIndex = 0
        Me.tcFunc.Size = New System.Drawing.Size(1113, 454)
        Me.tcFunc.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tcFunc.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.tcFunc.TabButtonHoverState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcFunc.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tcFunc.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.tcFunc.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tcFunc.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.tcFunc.TabButtonIdleState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcFunc.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.tcFunc.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent
        Me.tcFunc.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tcFunc.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tcFunc.TabButtonSelectedState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcFunc.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tcFunc.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcFunc.TabButtonSize = New System.Drawing.Size(140, 40)
        Me.tcFunc.TabIndex = 50
        Me.tcFunc.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        '
        'tabVisualizar
        '
        Me.tabVisualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.tabVisualizar.Controls.Add(Me.dgvFunc)
        Me.tabVisualizar.ForeColor = System.Drawing.Color.White
        Me.tabVisualizar.Location = New System.Drawing.Point(144, 4)
        Me.tabVisualizar.Name = "tabVisualizar"
        Me.tabVisualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVisualizar.Size = New System.Drawing.Size(965, 446)
        Me.tabVisualizar.TabIndex = 1
        Me.tabVisualizar.Text = "Visualizar Funcionários"
        '
        'dgvFunc
        '
        Me.dgvFunc.AllowDrop = True
        Me.dgvFunc.AllowUserToAddRows = False
        Me.dgvFunc.AllowUserToDeleteRows = False
        Me.dgvFunc.AllowUserToOrderColumns = True
        Me.dgvFunc.AllowUserToResizeColumns = False
        Me.dgvFunc.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.dgvFunc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFunc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFunc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFunc.ColumnHeadersHeight = 32
        Me.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvFunc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.campoCPF, Me.campoNome, Me.campoEmail, Me.campoSenha, Me.campoCargo})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFunc.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFunc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFunc.GridColor = System.Drawing.Color.White
        Me.dgvFunc.Location = New System.Drawing.Point(3, 3)
        Me.dgvFunc.Name = "dgvFunc"
        Me.dgvFunc.ReadOnly = True
        Me.dgvFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFunc.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFunc.RowHeadersVisible = False
        Me.dgvFunc.RowTemplate.Height = 30
        Me.dgvFunc.RowTemplate.ReadOnly = True
        Me.dgvFunc.Size = New System.Drawing.Size(959, 440)
        Me.dgvFunc.TabIndex = 44
        Me.dgvFunc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvFunc.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvFunc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvFunc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvFunc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvFunc.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvFunc.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvFunc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvFunc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvFunc.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFunc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvFunc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvFunc.ThemeStyle.HeaderStyle.Height = 32
        Me.dgvFunc.ThemeStyle.ReadOnly = True
        Me.dgvFunc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvFunc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvFunc.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFunc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvFunc.ThemeStyle.RowsStyle.Height = 30
        Me.dgvFunc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvFunc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'campoCPF
        '
        Me.campoCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoCPF.FillWeight = 507.6142!
        Me.campoCPF.HeaderText = "CPF"
        Me.campoCPF.Name = "campoCPF"
        Me.campoCPF.ReadOnly = True
        Me.campoCPF.Width = 130
        '
        'campoNome
        '
        Me.campoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.campoNome.DefaultCellStyle = DataGridViewCellStyle3
        Me.campoNome.HeaderText = "NOME"
        Me.campoNome.Name = "campoNome"
        Me.campoNome.ReadOnly = True
        Me.campoNome.Width = 290
        '
        'campoEmail
        '
        Me.campoEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoEmail.FillWeight = 54.70953!
        Me.campoEmail.HeaderText = "E-MAIL"
        Me.campoEmail.Name = "campoEmail"
        Me.campoEmail.ReadOnly = True
        Me.campoEmail.Width = 260
        '
        'campoSenha
        '
        Me.campoSenha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoSenha.FillWeight = 54.70953!
        Me.campoSenha.HeaderText = "SENHA"
        Me.campoSenha.Name = "campoSenha"
        Me.campoSenha.ReadOnly = True
        Me.campoSenha.Width = 130
        '
        'campoCargo
        '
        Me.campoCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoCargo.FillWeight = 54.70953!
        Me.campoCargo.HeaderText = "CARGO"
        Me.campoCargo.Name = "campoCargo"
        Me.campoCargo.ReadOnly = True
        Me.campoCargo.Width = 150
        '
        'tabEditarFunc
        '
        Me.tabEditarFunc.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.tabEditarFunc.Controls.Add(Me.btnBuscar)
        Me.tabEditarFunc.Controls.Add(Me.btnDeletar)
        Me.tabEditarFunc.Controls.Add(Me.Label6)
        Me.tabEditarFunc.Controls.Add(Me.txtCpf)
        Me.tabEditarFunc.Controls.Add(Me.cmbCargo)
        Me.tabEditarFunc.Controls.Add(Me.btnAlterar)
        Me.tabEditarFunc.Controls.Add(Me.imgFotoFunc)
        Me.tabEditarFunc.Controls.Add(Me.Label5)
        Me.tabEditarFunc.Controls.Add(Me.Label4)
        Me.tabEditarFunc.Controls.Add(Me.Label3)
        Me.tabEditarFunc.Controls.Add(Me.Label7)
        Me.tabEditarFunc.Controls.Add(Me.Label8)
        Me.tabEditarFunc.Controls.Add(Me.txtEmail)
        Me.tabEditarFunc.Controls.Add(Me.txtNome)
        Me.tabEditarFunc.Controls.Add(Me.txtSenha)
        Me.tabEditarFunc.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.tabEditarFunc.Location = New System.Drawing.Point(144, 4)
        Me.tabEditarFunc.Name = "tabEditarFunc"
        Me.tabEditarFunc.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditarFunc.Size = New System.Drawing.Size(965, 446)
        Me.tabEditarFunc.TabIndex = 2
        Me.tabEditarFunc.Text = "Editar Informações"
        '
        'btnBuscar
        '
        Me.btnBuscar.Animated = True
        Me.btnBuscar.BorderRadius = 8
        Me.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBuscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(215, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 36)
        Me.btnBuscar.TabIndex = 76
        Me.btnBuscar.Text = "BUSCAR"
        '
        'btnDeletar
        '
        Me.btnDeletar.Animated = True
        Me.btnDeletar.BorderRadius = 8
        Me.btnDeletar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeletar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeletar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeletar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeletar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeletar.ForeColor = System.Drawing.Color.White
        Me.btnDeletar.Location = New System.Drawing.Point(215, 379)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(164, 36)
        Me.btnDeletar.TabIndex = 7
        Me.btnDeletar.Text = "DELETAR"
        Me.btnDeletar.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(680, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 23)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Foto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtCpf.Location = New System.Drawing.Point(61, 46)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCpf.PlaceholderText = ""
        Me.txtCpf.SelectedText = ""
        Me.txtCpf.Size = New System.Drawing.Size(147, 36)
        Me.txtCpf.TabIndex = 2
        '
        'cmbCargo
        '
        Me.cmbCargo.BackColor = System.Drawing.Color.Transparent
        Me.cmbCargo.BorderRadius = 8
        Me.cmbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCargo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCargo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCargo.ForeColor = System.Drawing.Color.Black
        Me.cmbCargo.ItemHeight = 30
        Me.cmbCargo.Location = New System.Drawing.Point(353, 46)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(223, 36)
        Me.cmbCargo.TabIndex = 3
        '
        'btnAlterar
        '
        Me.btnAlterar.Animated = True
        Me.btnAlterar.BorderRadius = 8
        Me.btnAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAlterar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAlterar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(412, 379)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(164, 36)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.Visible = False
        '
        'imgFotoFunc
        '
        Me.imgFotoFunc.Image = CType(resources.GetObject("imgFotoFunc.Image"), System.Drawing.Image)
        Me.imgFotoFunc.ImageRotate = 0!
        Me.imgFotoFunc.Location = New System.Drawing.Point(623, 82)
        Me.imgFotoFunc.Name = "imgFotoFunc"
        Me.imgFotoFunc.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.imgFotoFunc.Size = New System.Drawing.Size(300, 300)
        Me.imgFotoFunc.TabIndex = 71
        Me.imgFotoFunc.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(61, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "E-mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(61, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(61, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Nome"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(349, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Cargo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(61, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 23)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "CPF"
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
        Me.txtEmail.Location = New System.Drawing.Point(65, 234)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(511, 36)
        Me.txtEmail.TabIndex = 5
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
        Me.txtNome.Location = New System.Drawing.Point(65, 140)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.PlaceholderText = ""
        Me.txtNome.SelectedText = ""
        Me.txtNome.Size = New System.Drawing.Size(511, 36)
        Me.txtNome.TabIndex = 4
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
        Me.txtSenha.Location = New System.Drawing.Point(65, 326)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSenha.PlaceholderText = ""
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.Size = New System.Drawing.Size(511, 36)
        Me.txtSenha.TabIndex = 6
        '
        'cmbParametro
        '
        Me.cmbParametro.BackColor = System.Drawing.Color.Transparent
        Me.cmbParametro.BorderRadius = 8
        Me.cmbParametro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbParametro.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbParametro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbParametro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParametro.ForeColor = System.Drawing.Color.Black
        Me.cmbParametro.ItemHeight = 30
        Me.cmbParametro.Items.AddRange(New Object() {"CPF", "NOME"})
        Me.cmbParametro.Location = New System.Drawing.Point(879, 65)
        Me.cmbParametro.Name = "cmbParametro"
        Me.cmbParametro.Size = New System.Drawing.Size(172, 36)
        Me.cmbParametro.TabIndex = 1
        '
        'lblParametro
        '
        Me.lblParametro.AutoSize = True
        Me.lblParametro.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParametro.ForeColor = System.Drawing.Color.White
        Me.lblParametro.Location = New System.Drawing.Point(749, 72)
        Me.lblParametro.Name = "lblParametro"
        Me.lblParametro.Size = New System.Drawing.Size(124, 25)
        Me.lblParametro.TabIndex = 53
        Me.lblParametro.Text = "Parâmetro:"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.ForeColor = System.Drawing.Color.White
        Me.lblPesquisa.Location = New System.Drawing.Point(287, 70)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(107, 25)
        Me.lblPesquisa.TabIndex = 54
        Me.lblPesquisa.Text = "Pesquisa:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderRadius = 8
        Me.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPesquisa.DefaultText = ""
        Me.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisa.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesquisa.Location = New System.Drawing.Point(401, 65)
        Me.txtPesquisa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPesquisa.PlaceholderText = ""
        Me.txtPesquisa.SelectedText = ""
        Me.txtPesquisa.Size = New System.Drawing.Size(330, 36)
        Me.txtPesquisa.TabIndex = 0
        '
        'ofdImgFunc
        '
        Me.ofdImgFunc.FileName = "ofdImgFunc"
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
        Me.Guna2ShadowPanel1.TabIndex = 56
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
        Me.btnAdicionarItem.TabIndex = 57
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
        Me.btnCadastrarFunc.Location = New System.Drawing.Point(11, 18)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(536, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 37)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Visualizar Credenciais"
        '
        'frmVisualizarFunc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.lblParametro)
        Me.Controls.Add(Me.cmbParametro)
        Me.Controls.Add(Me.tcFunc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisualizarFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisualizarCredenciais"
        Me.tcFunc.ResumeLayout(False)
        Me.tabVisualizar.ResumeLayout(False)
        CType(Me.dgvFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEditarFunc.ResumeLayout(False)
        Me.tabEditarFunc.PerformLayout()
        CType(Me.imgFotoFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisualizarFunc As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents cmbParametro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tcFunc As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabVisualizar As TabPage
    Friend WithEvents dgvFunc As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tabEditarFunc As TabPage
    Friend WithEvents lblPesquisa As Label
    Friend WithEvents lblParametro As Label
    Friend WithEvents txtPesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDeletar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbCargo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAlterar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents imgFotoFunc As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents campoCPF As DataGridViewTextBoxColumn
    Friend WithEvents campoNome As DataGridViewTextBoxColumn
    Friend WithEvents campoEmail As DataGridViewTextBoxColumn
    Friend WithEvents campoSenha As DataGridViewTextBoxColumn
    Friend WithEvents campoCargo As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ofdImgFunc As OpenFileDialog
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarSangria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCadastrarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarCredenciais As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdicionarItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
