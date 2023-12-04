<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRealizarPed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRealizarPed))
        Me.btnAdicionar = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbLanche = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCpfFunc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNomeCli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEnviar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecoFinal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbBebida = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbAcomp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RealizarPedido = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarPedido = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarPedidos = New Guna.UI2.WinForms.Guna2Button()
        Me.qtdLanche = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.qtdBebida = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.qtdAcomp = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.ListaProdutos = New System.Windows.Forms.ListView()
        Me.Lanche = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listQtdLanche = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Acomp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listQtdAcomp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bebida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listQtdBebida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ArredondaBorda = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.limparCarrinho = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.qtdLanche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qtdBebida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qtdAcomp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Animated = True
        Me.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnAdicionar.BorderRadius = 10
        Me.btnAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdicionar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdicionar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdicionar.ForeColor = System.Drawing.Color.White
        Me.btnAdicionar.Location = New System.Drawing.Point(412, 489)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(210, 40)
        Me.btnAdicionar.TabIndex = 8
        Me.btnAdicionar.Text = "Adicionar ao Carrinho"
        '
        'cmbLanche
        '
        Me.cmbLanche.BackColor = System.Drawing.Color.Black
        Me.cmbLanche.BorderRadius = 8
        Me.cmbLanche.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLanche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanche.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbLanche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbLanche.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbLanche.ForeColor = System.Drawing.Color.Black
        Me.cmbLanche.ItemHeight = 30
        Me.cmbLanche.Items.AddRange(New Object() {""})
        Me.cmbLanche.Location = New System.Drawing.Point(164, 207)
        Me.cmbLanche.Name = "cmbLanche"
        Me.cmbLanche.Size = New System.Drawing.Size(334, 36)
        Me.cmbLanche.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(160, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 23)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Bebida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(160, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 23)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Acompanhamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(160, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Lanche"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(796, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 23)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "CPF do Funcionário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(160, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Nome do Cliente:"
        '
        'txtCpfFunc
        '
        Me.txtCpfFunc.BackColor = System.Drawing.Color.Black
        Me.txtCpfFunc.BorderRadius = 8
        Me.txtCpfFunc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCpfFunc.DefaultText = ""
        Me.txtCpfFunc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCpfFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCpfFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpfFunc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpfFunc.FillColor = System.Drawing.Color.Silver
        Me.txtCpfFunc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpfFunc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCpfFunc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtCpfFunc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpfFunc.Location = New System.Drawing.Point(800, 118)
        Me.txtCpfFunc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCpfFunc.Name = "txtCpfFunc"
        Me.txtCpfFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCpfFunc.PlaceholderText = ""
        Me.txtCpfFunc.ReadOnly = True
        Me.txtCpfFunc.SelectedText = ""
        Me.txtCpfFunc.Size = New System.Drawing.Size(201, 28)
        Me.txtCpfFunc.TabIndex = 73
        '
        'txtNomeCli
        '
        Me.txtNomeCli.BackColor = System.Drawing.Color.Black
        Me.txtNomeCli.BorderRadius = 8
        Me.txtNomeCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeCli.DefaultText = ""
        Me.txtNomeCli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNomeCli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNomeCli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomeCli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomeCli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomeCli.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNomeCli.ForeColor = System.Drawing.Color.Black
        Me.txtNomeCli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomeCli.Location = New System.Drawing.Point(164, 118)
        Me.txtNomeCli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomeCli.PlaceholderText = ""
        Me.txtNomeCli.SelectedText = ""
        Me.txtNomeCli.Size = New System.Drawing.Size(597, 28)
        Me.txtNomeCli.TabIndex = 0
        '
        'btnEnviar
        '
        Me.btnEnviar.Animated = True
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnEnviar.BorderRadius = 10
        Me.btnEnviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnviar.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(782, 489)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(180, 40)
        Me.btnEnviar.TabIndex = 9
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(160, 462)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Preço Final:"
        '
        'txtPrecoFinal
        '
        Me.txtPrecoFinal.BackColor = System.Drawing.Color.Black
        Me.txtPrecoFinal.BorderRadius = 8
        Me.txtPrecoFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecoFinal.DefaultText = ""
        Me.txtPrecoFinal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrecoFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrecoFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrecoFinal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrecoFinal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecoFinal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoFinal.ForeColor = System.Drawing.Color.Black
        Me.txtPrecoFinal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrecoFinal.Location = New System.Drawing.Point(164, 489)
        Me.txtPrecoFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecoFinal.Name = "txtPrecoFinal"
        Me.txtPrecoFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecoFinal.PlaceholderText = ""
        Me.txtPrecoFinal.SelectedText = ""
        Me.txtPrecoFinal.Size = New System.Drawing.Size(230, 38)
        Me.txtPrecoFinal.TabIndex = 7
        '
        'cmbBebida
        '
        Me.cmbBebida.BackColor = System.Drawing.Color.Black
        Me.cmbBebida.BorderRadius = 8
        Me.cmbBebida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBebida.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBebida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBebida.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbBebida.ForeColor = System.Drawing.Color.Black
        Me.cmbBebida.ItemHeight = 30
        Me.cmbBebida.Items.AddRange(New Object() {""})
        Me.cmbBebida.Location = New System.Drawing.Point(164, 392)
        Me.cmbBebida.Name = "cmbBebida"
        Me.cmbBebida.Size = New System.Drawing.Size(334, 36)
        Me.cmbBebida.TabIndex = 5
        '
        'cmbAcomp
        '
        Me.cmbAcomp.BackColor = System.Drawing.Color.Black
        Me.cmbAcomp.BorderRadius = 8
        Me.cmbAcomp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAcomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAcomp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAcomp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAcomp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbAcomp.ForeColor = System.Drawing.Color.Black
        Me.cmbAcomp.ItemHeight = 30
        Me.cmbAcomp.Items.AddRange(New Object() {""})
        Me.cmbAcomp.Location = New System.Drawing.Point(164, 299)
        Me.cmbAcomp.Name = "cmbAcomp"
        Me.cmbAcomp.Size = New System.Drawing.Size(334, 36)
        Me.cmbAcomp.TabIndex = 3
        '
        'RealizarPedido
        '
        Me.RealizarPedido.AnimateWindow = True
        Me.RealizarPedido.AnimationInterval = 200
        Me.RealizarPedido.BorderRadius = 16
        Me.RealizarPedido.ContainerControl = Me
        Me.RealizarPedido.DockIndicatorTransparencyValue = 0.6R
        Me.RealizarPedido.ResizeForm = False
        Me.RealizarPedido.TransparentWhileDrag = True
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
        Me.Guna2ShadowPanel1.TabIndex = 83
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
        'qtdLanche
        '
        Me.qtdLanche.BackColor = System.Drawing.Color.Transparent
        Me.qtdLanche.BorderRadius = 8
        Me.qtdLanche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qtdLanche.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtdLanche.Location = New System.Drawing.Point(522, 207)
        Me.qtdLanche.Name = "qtdLanche"
        Me.qtdLanche.Size = New System.Drawing.Size(100, 36)
        Me.qtdLanche.TabIndex = 2
        Me.qtdLanche.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qtdLanche.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'qtdBebida
        '
        Me.qtdBebida.BackColor = System.Drawing.Color.Transparent
        Me.qtdBebida.BorderRadius = 8
        Me.qtdBebida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qtdBebida.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtdBebida.Location = New System.Drawing.Point(522, 392)
        Me.qtdBebida.Name = "qtdBebida"
        Me.qtdBebida.Size = New System.Drawing.Size(100, 36)
        Me.qtdBebida.TabIndex = 6
        Me.qtdBebida.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qtdBebida.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'qtdAcomp
        '
        Me.qtdAcomp.BackColor = System.Drawing.Color.Transparent
        Me.qtdAcomp.BorderRadius = 8
        Me.qtdAcomp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qtdAcomp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtdAcomp.Location = New System.Drawing.Point(522, 299)
        Me.qtdAcomp.Name = "qtdAcomp"
        Me.qtdAcomp.Size = New System.Drawing.Size(100, 36)
        Me.qtdAcomp.TabIndex = 4
        Me.qtdAcomp.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qtdAcomp.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'ListaProdutos
        '
        Me.ListaProdutos.BackColor = System.Drawing.Color.White
        Me.ListaProdutos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Lanche, Me.listQtdLanche, Me.Acomp, Me.listQtdAcomp, Me.Bebida, Me.listQtdBebida})
        Me.ListaProdutos.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ListaProdutos.HideSelection = False
        Me.ListaProdutos.Location = New System.Drawing.Point(648, 207)
        Me.ListaProdutos.Name = "ListaProdutos"
        Me.ListaProdutos.Size = New System.Drawing.Size(409, 221)
        Me.ListaProdutos.TabIndex = 87
        Me.ListaProdutos.UseCompatibleStateImageBehavior = False
        Me.ListaProdutos.View = System.Windows.Forms.View.Details
        '
        'Lanche
        '
        Me.Lanche.Text = "Lanche"
        Me.Lanche.Width = 100
        '
        'listQtdLanche
        '
        Me.listQtdLanche.Text = "Qtd"
        Me.listQtdLanche.Width = 33
        '
        'Acomp
        '
        Me.Acomp.Text = "Acomp"
        Me.Acomp.Width = 100
        '
        'listQtdAcomp
        '
        Me.listQtdAcomp.Text = "Qtd"
        Me.listQtdAcomp.Width = 33
        '
        'Bebida
        '
        Me.Bebida.Text = "Bebida"
        Me.Bebida.Width = 100
        '
        'listQtdBebida
        '
        Me.listQtdBebida.Text = "Qtd"
        Me.listQtdBebida.Width = 33
        '
        'ArredondaBorda
        '
        Me.ArredondaBorda.BorderRadius = 16
        Me.ArredondaBorda.TargetControl = Me.ListaProdutos
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(648, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 23)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Carrinho"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'limparCarrinho
        '
        Me.limparCarrinho.Animated = True
        Me.limparCarrinho.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.limparCarrinho.BorderRadius = 10
        Me.limparCarrinho.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.limparCarrinho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.limparCarrinho.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.limparCarrinho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.limparCarrinho.FillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.limparCarrinho.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.limparCarrinho.ForeColor = System.Drawing.Color.White
        Me.limparCarrinho.Location = New System.Drawing.Point(963, 172)
        Me.limparCarrinho.Name = "limparCarrinho"
        Me.limparCarrinho.Size = New System.Drawing.Size(94, 33)
        Me.limparCarrinho.TabIndex = 10
        Me.limparCarrinho.Text = "Limpar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(475, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 37)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Realizar Pedido"
        '
        'frmRealizarPed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.limparCarrinho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListaProdutos)
        Me.Controls.Add(Me.qtdAcomp)
        Me.Controls.Add(Me.qtdBebida)
        Me.Controls.Add(Me.qtdLanche)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.cmbLanche)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCpfFunc)
        Me.Controls.Add(Me.txtNomeCli)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecoFinal)
        Me.Controls.Add(Me.cmbBebida)
        Me.Controls.Add(Me.cmbAcomp)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRealizarPed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarPedido"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.qtdLanche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qtdBebida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qtdAcomp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdicionar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbLanche As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCpfFunc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNomeCli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEnviar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecoFinal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbBebida As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbAcomp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RealizarPedido As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarPedido As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarPedidos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents qtdAcomp As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents qtdBebida As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents qtdLanche As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents ListaProdutos As ListView
    Friend WithEvents Lanche As ColumnHeader
    Friend WithEvents listQtdLanche As ColumnHeader
    Friend WithEvents Acomp As ColumnHeader
    Friend WithEvents listQtdAcomp As ColumnHeader
    Friend WithEvents Bebida As ColumnHeader
    Friend WithEvents listQtdBebida As ColumnHeader
    Friend WithEvents ArredondaBorda As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As Label
    Friend WithEvents limparCarrinho As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
End Class
