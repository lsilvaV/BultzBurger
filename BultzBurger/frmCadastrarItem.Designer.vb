<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CadastrarItem = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnAdicionarItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarSangria = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCadastrarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarCredenciais = New Guna.UI2.WinForms.Guna2Button()
        Me.tabVisualizarItem = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbIdItem = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnEditarItem = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvCardapio = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precoItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabCadastrarItem = New System.Windows.Forms.TabPage()
        Me.btnAlterar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeletar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdicionar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPreco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNomeItem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tcItens = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.tabVisualizarItem.SuspendLayout()
        CType(Me.dgvCardapio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCadastrarItem.SuspendLayout()
        Me.tcItens.SuspendLayout()
        Me.SuspendLayout()
        '
        'CadastrarItem
        '
        Me.CadastrarItem.AnimateWindow = True
        Me.CadastrarItem.AnimationInterval = 200
        Me.CadastrarItem.BorderRadius = 16
        Me.CadastrarItem.ContainerControl = Me
        Me.CadastrarItem.DockIndicatorTransparencyValue = 0.6R
        Me.CadastrarItem.ResizeForm = False
        Me.CadastrarItem.TransparentWhileDrag = True
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
        Me.Guna2ShadowPanel1.TabIndex = 84
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
        'tabVisualizarItem
        '
        Me.tabVisualizarItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.tabVisualizarItem.Controls.Add(Me.Label5)
        Me.tabVisualizarItem.Controls.Add(Me.cmbIdItem)
        Me.tabVisualizarItem.Controls.Add(Me.btnEditarItem)
        Me.tabVisualizarItem.Controls.Add(Me.dgvCardapio)
        Me.tabVisualizarItem.ForeColor = System.Drawing.Color.White
        Me.tabVisualizarItem.Location = New System.Drawing.Point(144, 4)
        Me.tabVisualizarItem.Name = "tabVisualizarItem"
        Me.tabVisualizarItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVisualizarItem.Size = New System.Drawing.Size(814, 498)
        Me.tabVisualizarItem.TabIndex = 1
        Me.tabVisualizarItem.Text = "Visualizar Itens"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(99, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 23)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Selecione o ID:"
        '
        'cmbIdItem
        '
        Me.cmbIdItem.BackColor = System.Drawing.Color.Transparent
        Me.cmbIdItem.BorderRadius = 8
        Me.cmbIdItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIdItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdItem.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbIdItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbIdItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbIdItem.ForeColor = System.Drawing.Color.Black
        Me.cmbIdItem.ItemHeight = 30
        Me.cmbIdItem.Location = New System.Drawing.Point(266, 436)
        Me.cmbIdItem.Name = "cmbIdItem"
        Me.cmbIdItem.Size = New System.Drawing.Size(267, 36)
        Me.cmbIdItem.TabIndex = 5
        '
        'btnEditarItem
        '
        Me.btnEditarItem.Animated = True
        Me.btnEditarItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnEditarItem.BorderRadius = 8
        Me.btnEditarItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditarItem.ForeColor = System.Drawing.Color.White
        Me.btnEditarItem.Location = New System.Drawing.Point(549, 436)
        Me.btnEditarItem.Name = "btnEditarItem"
        Me.btnEditarItem.Size = New System.Drawing.Size(147, 36)
        Me.btnEditarItem.TabIndex = 6
        Me.btnEditarItem.Text = "Editar Item"
        '
        'dgvCardapio
        '
        Me.dgvCardapio.AllowDrop = True
        Me.dgvCardapio.AllowUserToAddRows = False
        Me.dgvCardapio.AllowUserToDeleteRows = False
        Me.dgvCardapio.AllowUserToOrderColumns = True
        Me.dgvCardapio.AllowUserToResizeColumns = False
        Me.dgvCardapio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.dgvCardapio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCardapio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvCardapio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCardapio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCardapio.ColumnHeadersHeight = 30
        Me.dgvCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCardapio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nomeItem, Me.descItem, Me.precoItem})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCardapio.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCardapio.GridColor = System.Drawing.Color.White
        Me.dgvCardapio.Location = New System.Drawing.Point(0, 0)
        Me.dgvCardapio.Name = "dgvCardapio"
        Me.dgvCardapio.ReadOnly = True
        Me.dgvCardapio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCardapio.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCardapio.RowHeadersVisible = False
        Me.dgvCardapio.RowTemplate.Height = 30
        Me.dgvCardapio.RowTemplate.ReadOnly = True
        Me.dgvCardapio.Size = New System.Drawing.Size(814, 408)
        Me.dgvCardapio.TabIndex = 54
        Me.dgvCardapio.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCardapio.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCardapio.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCardapio.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCardapio.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCardapio.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvCardapio.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvCardapio.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvCardapio.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCardapio.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCardapio.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCardapio.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCardapio.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvCardapio.ThemeStyle.ReadOnly = True
        Me.dgvCardapio.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCardapio.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCardapio.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCardapio.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCardapio.ThemeStyle.RowsStyle.Height = 30
        Me.dgvCardapio.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCardapio.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id.FillWeight = 507.6142!
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 102
        '
        'nomeItem
        '
        Me.nomeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.nomeItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.nomeItem.HeaderText = "Nome do Item"
        Me.nomeItem.Name = "nomeItem"
        Me.nomeItem.ReadOnly = True
        Me.nomeItem.Width = 202
        '
        'descItem
        '
        Me.descItem.HeaderText = "Descrição do Produto"
        Me.descItem.Name = "descItem"
        Me.descItem.ReadOnly = True
        '
        'precoItem
        '
        Me.precoItem.FillWeight = 54.70953!
        Me.precoItem.HeaderText = "Preço do Item"
        Me.precoItem.Name = "precoItem"
        Me.precoItem.ReadOnly = True
        '
        'tabCadastrarItem
        '
        Me.tabCadastrarItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.tabCadastrarItem.Controls.Add(Me.btnAlterar)
        Me.tabCadastrarItem.Controls.Add(Me.btnDeletar)
        Me.tabCadastrarItem.Controls.Add(Me.btnAdicionar)
        Me.tabCadastrarItem.Controls.Add(Me.Label4)
        Me.tabCadastrarItem.Controls.Add(Me.Label2)
        Me.tabCadastrarItem.Controls.Add(Me.Label1)
        Me.tabCadastrarItem.Controls.Add(Me.Label3)
        Me.tabCadastrarItem.Controls.Add(Me.txtDesc)
        Me.tabCadastrarItem.Controls.Add(Me.txtPreco)
        Me.tabCadastrarItem.Controls.Add(Me.txtNomeItem)
        Me.tabCadastrarItem.Controls.Add(Me.cmbTipo)
        Me.tabCadastrarItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCadastrarItem.Location = New System.Drawing.Point(144, 4)
        Me.tabCadastrarItem.Name = "tabCadastrarItem"
        Me.tabCadastrarItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastrarItem.Size = New System.Drawing.Size(814, 498)
        Me.tabCadastrarItem.TabIndex = 2
        Me.tabCadastrarItem.Text = "Modificar Itens"
        '
        'btnAlterar
        '
        Me.btnAlterar.Animated = True
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnAlterar.BorderRadius = 8
        Me.btnAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAlterar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAlterar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(589, 399)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(210, 40)
        Me.btnAlterar.TabIndex = 94
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.Visible = False
        '
        'btnDeletar
        '
        Me.btnDeletar.Animated = True
        Me.btnDeletar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnDeletar.BorderRadius = 8
        Me.btnDeletar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeletar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeletar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeletar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeletar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeletar.ForeColor = System.Drawing.Color.White
        Me.btnDeletar.Location = New System.Drawing.Point(361, 399)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(210, 40)
        Me.btnDeletar.TabIndex = 93
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.Visible = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Animated = True
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnAdicionar.BorderRadius = 8
        Me.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdicionar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdicionar.ForeColor = System.Drawing.Color.White
        Me.btnAdicionar.Location = New System.Drawing.Point(589, 399)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(210, 40)
        Me.btnAdicionar.TabIndex = 4
        Me.btnAdicionar.Text = "Adicionar ao Cardápio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Descrição do Produto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(595, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Preço:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(344, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 23)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Nome do Produto:"
        '
        'txtDesc
        '
        Me.txtDesc.BorderRadius = 8
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.DefaultText = ""
        Me.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.Location = New System.Drawing.Point(21, 197)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesc.PlaceholderText = ""
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.Size = New System.Drawing.Size(778, 167)
        Me.txtDesc.TabIndex = 3
        '
        'txtPreco
        '
        Me.txtPreco.BorderRadius = 8
        Me.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPreco.DefaultText = ""
        Me.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreco.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPreco.ForeColor = System.Drawing.Color.Black
        Me.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreco.Location = New System.Drawing.Point(599, 99)
        Me.txtPreco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPreco.PlaceholderText = ""
        Me.txtPreco.SelectedText = ""
        Me.txtPreco.Size = New System.Drawing.Size(200, 36)
        Me.txtPreco.TabIndex = 2
        '
        'txtNomeItem
        '
        Me.txtNomeItem.BorderRadius = 8
        Me.txtNomeItem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeItem.DefaultText = ""
        Me.txtNomeItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNomeItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNomeItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomeItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomeItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomeItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNomeItem.ForeColor = System.Drawing.Color.Black
        Me.txtNomeItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomeItem.Location = New System.Drawing.Point(21, 99)
        Me.txtNomeItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomeItem.Name = "txtNomeItem"
        Me.txtNomeItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomeItem.PlaceholderText = ""
        Me.txtNomeItem.SelectedText = ""
        Me.txtNomeItem.Size = New System.Drawing.Size(304, 36)
        Me.txtNomeItem.TabIndex = 0
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.Color.Transparent
        Me.cmbTipo.BorderRadius = 8
        Me.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTipo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmbTipo.ForeColor = System.Drawing.Color.Black
        Me.cmbTipo.ItemHeight = 30
        Me.cmbTipo.Location = New System.Drawing.Point(348, 99)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(234, 36)
        Me.cmbTipo.TabIndex = 1
        '
        'tcItens
        '
        Me.tcItens.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcItens.Controls.Add(Me.tabCadastrarItem)
        Me.tcItens.Controls.Add(Me.tabVisualizarItem)
        Me.tcItens.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcItens.ItemSize = New System.Drawing.Size(140, 40)
        Me.tcItens.Location = New System.Drawing.Point(111, 60)
        Me.tcItens.Name = "tcItens"
        Me.tcItens.SelectedIndex = 0
        Me.tcItens.Size = New System.Drawing.Size(962, 506)
        Me.tcItens.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tcItens.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.tcItens.TabButtonHoverState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcItens.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tcItens.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.tcItens.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tcItens.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.tcItens.TabButtonIdleState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcItens.TabButtonIdleState.ForeColor = System.Drawing.Color.White
        Me.tcItens.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent
        Me.tcItens.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tcItens.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tcItens.TabButtonSelectedState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcItens.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tcItens.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcItens.TabButtonSize = New System.Drawing.Size(140, 40)
        Me.tcItens.TabIndex = 85
        Me.tcItens.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(549, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 37)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Cardápio"
        '
        'frmCadastrarItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tcItens)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastrarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadastrarItem"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.tabVisualizarItem.ResumeLayout(False)
        Me.tabVisualizarItem.PerformLayout()
        CType(Me.dgvCardapio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCadastrarItem.ResumeLayout(False)
        Me.tabCadastrarItem.PerformLayout()
        Me.tcItens.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CadastrarItem As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnAdicionarItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarSangria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCadastrarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarCredenciais As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tcItens As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabCadastrarItem As TabPage
    Friend WithEvents btnAdicionar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPreco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNomeItem As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tabVisualizarItem As TabPage
    Friend WithEvents dgvCardapio As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nomeItem As DataGridViewTextBoxColumn
    Friend WithEvents descItem As DataGridViewTextBoxColumn
    Friend WithEvents precoItem As DataGridViewTextBoxColumn
    Friend WithEvents btnEditarItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbIdItem As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAlterar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeletar As Guna.UI2.WinForms.Guna2Button
End Class
