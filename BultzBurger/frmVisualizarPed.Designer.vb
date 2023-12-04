<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisualizarPed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisualizarPed))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.VisualizarPedido = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnVisualizarPedidos = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarPedido = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dgvVenda = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dgvPedidos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funcionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.campoLancheVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoQtdLanche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoAcompVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoQtdAcomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoBebidaVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campoQtdBebida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualizarPedido
        '
        Me.VisualizarPedido.AnimateWindow = True
        Me.VisualizarPedido.AnimationInterval = 200
        Me.VisualizarPedido.BorderRadius = 16
        Me.VisualizarPedido.ContainerControl = Me
        Me.VisualizarPedido.DockIndicatorTransparencyValue = 0.6R
        Me.VisualizarPedido.ResizeForm = False
        Me.VisualizarPedido.TransparentWhileDrag = True
        '
        'btnVisualizarPedidos
        '
        Me.btnVisualizarPedidos.Animated = True
        Me.btnVisualizarPedidos.BorderRadius = 10
        Me.btnVisualizarPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVisualizarPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVisualizarPedidos.FillColor = System.Drawing.Color.Transparent
        Me.btnVisualizarPedidos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVisualizarPedidos.ForeColor = System.Drawing.Color.Transparent
        Me.btnVisualizarPedidos.Image = CType(resources.GetObject("btnVisualizarPedidos.Image"), System.Drawing.Image)
        Me.btnVisualizarPedidos.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnVisualizarPedidos.Location = New System.Drawing.Point(11, 114)
        Me.btnVisualizarPedidos.Name = "btnVisualizarPedidos"
        Me.btnVisualizarPedidos.PressedColor = System.Drawing.Color.Transparent
        Me.btnVisualizarPedidos.Size = New System.Drawing.Size(60, 54)
        Me.btnVisualizarPedidos.TabIndex = 5
        '
        'btnRealizarPedido
        '
        Me.btnRealizarPedido.Animated = True
        Me.btnRealizarPedido.BorderRadius = 10
        Me.btnRealizarPedido.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRealizarPedido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRealizarPedido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRealizarPedido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRealizarPedido.FillColor = System.Drawing.Color.Transparent
        Me.btnRealizarPedido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRealizarPedido.ForeColor = System.Drawing.Color.Transparent
        Me.btnRealizarPedido.Image = CType(resources.GetObject("btnRealizarPedido.Image"), System.Drawing.Image)
        Me.btnRealizarPedido.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnRealizarPedido.Location = New System.Drawing.Point(11, 18)
        Me.btnRealizarPedido.Name = "btnRealizarPedido"
        Me.btnRealizarPedido.PressedColor = System.Drawing.Color.Transparent
        Me.btnRealizarPedido.Size = New System.Drawing.Size(60, 54)
        Me.btnRealizarPedido.TabIndex = 6
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
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSair)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnRealizarPedido)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnVisualizarPedidos)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 7
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 255
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(82, 576)
        Me.Guna2ShadowPanel1.TabIndex = 44
        '
        'dgvVenda
        '
        Me.dgvVenda.AllowDrop = True
        Me.dgvVenda.AllowUserToAddRows = False
        Me.dgvVenda.AllowUserToDeleteRows = False
        Me.dgvVenda.AllowUserToOrderColumns = True
        Me.dgvVenda.AllowUserToResizeColumns = False
        Me.dgvVenda.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.dgvVenda.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVenda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVenda.ColumnHeadersHeight = 30
        Me.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.campoLancheVenda, Me.campoQtdLanche, Me.campoAcompVenda, Me.campoQtdAcomp, Me.campoBebidaVenda, Me.campoQtdBebida})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVenda.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVenda.GridColor = System.Drawing.Color.White
        Me.dgvVenda.Location = New System.Drawing.Point(831, 68)
        Me.dgvVenda.Name = "dgvVenda"
        Me.dgvVenda.ReadOnly = True
        Me.dgvVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVenda.RowHeadersVisible = False
        Me.dgvVenda.RowTemplate.Height = 30
        Me.dgvVenda.RowTemplate.ReadOnly = True
        Me.dgvVenda.Size = New System.Drawing.Size(588, 498)
        Me.dgvVenda.TabIndex = 54
        Me.dgvVenda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvVenda.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvVenda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvVenda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvVenda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvVenda.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvVenda.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvVenda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvVenda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvVenda.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVenda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvVenda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvVenda.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvVenda.ThemeStyle.ReadOnly = True
        Me.dgvVenda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvVenda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvVenda.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVenda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvVenda.ThemeStyle.RowsStyle.Height = 30
        Me.dgvVenda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvVenda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowDrop = True
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.AllowUserToOrderColumns = True
        Me.dgvPedidos.AllowUserToResizeColumns = False
        Me.dgvPedidos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.dgvPedidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPedidos.ColumnHeadersHeight = 30
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dataPed, Me.cliente, Me.funcionario, Me.precoFinal})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPedidos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPedidos.GridColor = System.Drawing.Color.White
        Me.dgvPedidos.Location = New System.Drawing.Point(159, 68)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.RowTemplate.Height = 30
        Me.dgvPedidos.RowTemplate.ReadOnly = True
        Me.dgvPedidos.Size = New System.Drawing.Size(615, 498)
        Me.dgvPedidos.TabIndex = 53
        Me.dgvPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPedidos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPedidos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.dgvPedidos.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvPedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvPedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPedidos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPedidos.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvPedidos.ThemeStyle.ReadOnly = True
        Me.dgvPedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPedidos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvPedidos.ThemeStyle.RowsStyle.Height = 30
        Me.dgvPedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id.FillWeight = 507.6142!
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'dataPed
        '
        Me.dataPed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dataPed.DefaultCellStyle = DataGridViewCellStyle7
        Me.dataPed.HeaderText = "Data"
        Me.dataPed.Name = "dataPed"
        Me.dataPed.ReadOnly = True
        Me.dataPed.Width = 120
        '
        'cliente
        '
        Me.cliente.FillWeight = 54.70953!
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'funcionario
        '
        Me.funcionario.FillWeight = 54.70953!
        Me.funcionario.HeaderText = "CPF do Func."
        Me.funcionario.Name = "funcionario"
        Me.funcionario.ReadOnly = True
        '
        'precoFinal
        '
        Me.precoFinal.FillWeight = 54.70953!
        Me.precoFinal.HeaderText = "Preço Final"
        Me.precoFinal.Name = "precoFinal"
        Me.precoFinal.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(663, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 37)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Visualizar Pedidos"
        '
        'campoLancheVenda
        '
        Me.campoLancheVenda.FillWeight = 54.70953!
        Me.campoLancheVenda.HeaderText = "Lanche"
        Me.campoLancheVenda.Name = "campoLancheVenda"
        Me.campoLancheVenda.ReadOnly = True
        '
        'campoQtdLanche
        '
        Me.campoQtdLanche.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoQtdLanche.HeaderText = "Qtd"
        Me.campoQtdLanche.Name = "campoQtdLanche"
        Me.campoQtdLanche.ReadOnly = True
        Me.campoQtdLanche.Width = 40
        '
        'campoAcompVenda
        '
        Me.campoAcompVenda.FillWeight = 54.70953!
        Me.campoAcompVenda.HeaderText = "Acomp."
        Me.campoAcompVenda.Name = "campoAcompVenda"
        Me.campoAcompVenda.ReadOnly = True
        '
        'campoQtdAcomp
        '
        Me.campoQtdAcomp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoQtdAcomp.HeaderText = "Qtd"
        Me.campoQtdAcomp.Name = "campoQtdAcomp"
        Me.campoQtdAcomp.ReadOnly = True
        Me.campoQtdAcomp.Width = 40
        '
        'campoBebidaVenda
        '
        Me.campoBebidaVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoBebidaVenda.FillWeight = 54.70953!
        Me.campoBebidaVenda.HeaderText = "Bebida"
        Me.campoBebidaVenda.Name = "campoBebidaVenda"
        Me.campoBebidaVenda.ReadOnly = True
        Me.campoBebidaVenda.Width = 140
        '
        'campoQtdBebida
        '
        Me.campoQtdBebida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.campoQtdBebida.HeaderText = "Qtd"
        Me.campoQtdBebida.Name = "campoQtdBebida"
        Me.campoQtdBebida.ReadOnly = True
        Me.campoQtdBebida.Width = 40
        '
        'frmVisualizarPed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1465, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvVenda)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisualizarPed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VizualizarPedidos"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VisualizarPedido As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarPedido As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarPedidos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvVenda As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvPedidos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents dataPed As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents funcionario As DataGridViewTextBoxColumn
    Friend WithEvents precoFinal As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents campoLancheVenda As DataGridViewTextBoxColumn
    Friend WithEvents campoQtdLanche As DataGridViewTextBoxColumn
    Friend WithEvents campoAcompVenda As DataGridViewTextBoxColumn
    Friend WithEvents campoQtdAcomp As DataGridViewTextBoxColumn
    Friend WithEvents campoBebidaVenda As DataGridViewTextBoxColumn
    Friend WithEvents campoQtdBebida As DataGridViewTextBoxColumn
End Class
