<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuOperador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuOperador))
        Me.MenuOperador = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.barraLateral = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRealizarPedido = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarPedidos = New Guna.UI2.WinForms.Guna2Button()
        Me.barraLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOperador
        '
        Me.MenuOperador.AnimateWindow = True
        Me.MenuOperador.AnimationInterval = 200
        Me.MenuOperador.BorderRadius = 16
        Me.MenuOperador.ContainerControl = Me
        Me.MenuOperador.DockIndicatorTransparencyValue = 0.6R
        Me.MenuOperador.ResizeForm = False
        Me.MenuOperador.TransparentWhileDrag = True
        '
        'barraLateral
        '
        Me.barraLateral.BackColor = System.Drawing.Color.Transparent
        Me.barraLateral.Controls.Add(Me.btnSair)
        Me.barraLateral.Controls.Add(Me.btnRealizarPedido)
        Me.barraLateral.Controls.Add(Me.btnVisualizarPedidos)
        Me.barraLateral.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.barraLateral.Location = New System.Drawing.Point(12, 12)
        Me.barraLateral.Name = "barraLateral"
        Me.barraLateral.Radius = 7
        Me.barraLateral.ShadowColor = System.Drawing.Color.Black
        Me.barraLateral.ShadowDepth = 255
        Me.barraLateral.Size = New System.Drawing.Size(82, 576)
        Me.barraLateral.TabIndex = 45
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
        Me.btnSair.TabIndex = 3
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
        Me.btnRealizarPedido.TabIndex = 0
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
        Me.btnVisualizarPedidos.TabIndex = 1
        '
        'frmMenuOperador
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.barraLateral)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuOperador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALKSFJLKJFLSDKJFS"
        Me.barraLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuOperador As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents barraLateral As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRealizarPedido As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarPedidos As Guna.UI2.WinForms.Guna2Button
End Class
