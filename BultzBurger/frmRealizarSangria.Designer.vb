<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealizarSangria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRealizarSangria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Sangria = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnAdicionarItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSangria = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCadastrarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvSangria = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtValorFinal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dataPedido = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnRegistrarSangria = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgvSangria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sangria
        '
        Me.Sangria.AnimateWindow = True
        Me.Sangria.AnimationInterval = 100
        Me.Sangria.BorderRadius = 16
        Me.Sangria.ContainerControl = Me
        Me.Sangria.DockIndicatorTransparencyValue = 0.6R
        Me.Sangria.TransparentWhileDrag = True
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnAdicionarItem)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSair)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSangria)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnCadastrarFunc)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnVisualizarFunc)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Guna2ShadowPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 7
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 255
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(82, 576)
        Me.Guna2ShadowPanel1.TabIndex = 53
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
        Me.btnAdicionarItem.TabIndex = 10
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
        'btnSangria
        '
        Me.btnSangria.Animated = True
        Me.btnSangria.BorderRadius = 10
        Me.btnSangria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSangria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSangria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSangria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSangria.FillColor = System.Drawing.Color.Transparent
        Me.btnSangria.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSangria.ForeColor = System.Drawing.Color.Transparent
        Me.btnSangria.Image = CType(resources.GetObject("btnSangria.Image"), System.Drawing.Image)
        Me.btnSangria.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSangria.Location = New System.Drawing.Point(11, 216)
        Me.btnSangria.Name = "btnSangria"
        Me.btnSangria.PressedColor = System.Drawing.Color.Transparent
        Me.btnSangria.Size = New System.Drawing.Size(60, 54)
        Me.btnSangria.TabIndex = 7
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
        'btnVisualizarFunc
        '
        Me.btnVisualizarFunc.Animated = True
        Me.btnVisualizarFunc.BorderRadius = 10
        Me.btnVisualizarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVisualizarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVisualizarFunc.FillColor = System.Drawing.Color.Transparent
        Me.btnVisualizarFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVisualizarFunc.ForeColor = System.Drawing.Color.Transparent
        Me.btnVisualizarFunc.Image = CType(resources.GetObject("btnVisualizarFunc.Image"), System.Drawing.Image)
        Me.btnVisualizarFunc.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnVisualizarFunc.Location = New System.Drawing.Point(11, 114)
        Me.btnVisualizarFunc.Name = "btnVisualizarFunc"
        Me.btnVisualizarFunc.PressedColor = System.Drawing.Color.Transparent
        Me.btnVisualizarFunc.Size = New System.Drawing.Size(60, 54)
        Me.btnVisualizarFunc.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(301, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Escolha a data da Sangria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(487, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 32)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Realizar Sangria"
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
        Me.btnBuscar.Location = New System.Drawing.Point(708, 90)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(191, 36)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "BUSCAR"
        '
        'dgvSangria
        '
        Me.dgvSangria.AllowDrop = True
        Me.dgvSangria.AllowUserToAddRows = False
        Me.dgvSangria.AllowUserToDeleteRows = False
        Me.dgvSangria.AllowUserToOrderColumns = True
        Me.dgvSangria.AllowUserToResizeColumns = False
        Me.dgvSangria.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.dgvSangria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSangria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSangria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSangria.ColumnHeadersHeight = 30
        Me.dgvSangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSangria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn11})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSangria.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSangria.GridColor = System.Drawing.Color.White
        Me.dgvSangria.Location = New System.Drawing.Point(290, 141)
        Me.dgvSangria.Name = "dgvSangria"
        Me.dgvSangria.ReadOnly = True
        Me.dgvSangria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSangria.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSangria.RowHeadersVisible = False
        Me.dgvSangria.RowTemplate.Height = 30
        Me.dgvSangria.RowTemplate.ReadOnly = True
        Me.dgvSangria.Size = New System.Drawing.Size(626, 343)
        Me.dgvSangria.TabIndex = 61
        Me.dgvSangria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSangria.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSangria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSangria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSangria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSangria.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.dgvSangria.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvSangria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvSangria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSangria.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSangria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSangria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSangria.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvSangria.ThemeStyle.ReadOnly = True
        Me.dgvSangria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSangria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSangria.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSangria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSangria.ThemeStyle.RowsStyle.Height = 30
        Me.dgvSangria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSangria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 54.70953!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Valor do Pedido"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'txtValorFinal
        '
        Me.txtValorFinal.BorderRadius = 8
        Me.txtValorFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValorFinal.DefaultText = ""
        Me.txtValorFinal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtValorFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtValorFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtValorFinal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtValorFinal.FillColor = System.Drawing.Color.LightGray
        Me.txtValorFinal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValorFinal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFinal.ForeColor = System.Drawing.Color.Black
        Me.txtValorFinal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValorFinal.Location = New System.Drawing.Point(542, 505)
        Me.txtValorFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorFinal.PlaceholderText = ""
        Me.txtValorFinal.ReadOnly = True
        Me.txtValorFinal.SelectedText = ""
        Me.txtValorFinal.Size = New System.Drawing.Size(151, 36)
        Me.txtValorFinal.TabIndex = 1
        Me.txtValorFinal.Visible = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.ForeColor = System.Drawing.Color.White
        Me.lblValor.Location = New System.Drawing.Point(299, 515)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(236, 19)
        Me.lblValor.TabIndex = 63
        Me.lblValor.Text = "Valor a ser retirado do caixa: "
        Me.lblValor.Visible = False
        '
        'dataPedido
        '
        Me.dataPedido.BorderRadius = 8
        Me.dataPedido.Checked = True
        Me.dataPedido.FillColor = System.Drawing.Color.White
        Me.dataPedido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataPedido.Location = New System.Drawing.Point(525, 90)
        Me.dataPedido.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dataPedido.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dataPedido.Name = "dataPedido"
        Me.dataPedido.Size = New System.Drawing.Size(168, 36)
        Me.dataPedido.TabIndex = 0
        Me.dataPedido.Value = New Date(2023, 11, 20, 9, 41, 9, 898)
        '
        'btnRegistrarSangria
        '
        Me.btnRegistrarSangria.Animated = True
        Me.btnRegistrarSangria.BorderRadius = 8
        Me.btnRegistrarSangria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarSangria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarSangria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrarSangria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistrarSangria.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarSangria.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrarSangria.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarSangria.Location = New System.Drawing.Point(708, 505)
        Me.btnRegistrarSangria.Name = "btnRegistrarSangria"
        Me.btnRegistrarSangria.Size = New System.Drawing.Size(191, 36)
        Me.btnRegistrarSangria.TabIndex = 64
        Me.btnRegistrarSangria.Text = "REGISTRAR"
        Me.btnRegistrarSangria.Visible = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 8
        Me.Guna2Elipse1.TargetControl = Me.dgvSangria
        '
        'frmRealizarSangria
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.btnRegistrarSangria)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.txtValorFinal)
        Me.Controls.Add(Me.dgvSangria)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dataPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRealizarSangria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarSangria"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.dgvSangria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sangria As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSangria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCadastrarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRegistrarSangria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValorFinal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvSangria As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents dataPedido As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnAdicionarItem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
