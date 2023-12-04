<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuGerente))
        Me.MenuGerente = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnAdicionarItem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSangria = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCadastrarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVisualizarFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuGerente
        '
        Me.MenuGerente.AnimateWindow = True
        Me.MenuGerente.AnimationInterval = 200
        Me.MenuGerente.BorderRadius = 16
        Me.MenuGerente.ContainerControl = Me
        Me.MenuGerente.DockIndicatorTransparencyValue = 0.6R
        Me.MenuGerente.ResizeForm = False
        Me.MenuGerente.TransparentWhileDrag = True
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
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.Animated = True
        Me.btnAdicionarItem.BackColor = System.Drawing.Color.Transparent
        Me.btnAdicionarItem.BorderRadius = 10
        Me.btnAdicionarItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionarItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdicionarItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdicionarItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdicionarItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnAdicionarItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdicionarItem.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdicionarItem.Image = CType(resources.GetObject("btnAdicionarItem.Image"), System.Drawing.Image)
        Me.btnAdicionarItem.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnAdicionarItem.Location = New System.Drawing.Point(11, 325)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.PressedColor = System.Drawing.Color.Transparent
        Me.btnAdicionarItem.Size = New System.Drawing.Size(60, 54)
        Me.btnAdicionarItem.TabIndex = 3
        '
        'btnSair
        '
        Me.btnSair.Animated = True
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.BorderRadius = 10
        Me.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSair.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSair.ForeColor = System.Drawing.Color.Transparent
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSair.Location = New System.Drawing.Point(11, 500)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.PressedColor = System.Drawing.Color.Transparent
        Me.btnSair.Size = New System.Drawing.Size(60, 54)
        Me.btnSair.TabIndex = 4
        '
        'btnSangria
        '
        Me.btnSangria.Animated = True
        Me.btnSangria.BackColor = System.Drawing.Color.Transparent
        Me.btnSangria.BorderRadius = 10
        Me.btnSangria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSangria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSangria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSangria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSangria.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSangria.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSangria.ForeColor = System.Drawing.Color.Transparent
        Me.btnSangria.Image = CType(resources.GetObject("btnSangria.Image"), System.Drawing.Image)
        Me.btnSangria.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSangria.Location = New System.Drawing.Point(11, 216)
        Me.btnSangria.Name = "btnSangria"
        Me.btnSangria.PressedColor = System.Drawing.Color.Transparent
        Me.btnSangria.Size = New System.Drawing.Size(60, 54)
        Me.btnSangria.TabIndex = 2
        '
        'btnCadastrarFunc
        '
        Me.btnCadastrarFunc.Animated = True
        Me.btnCadastrarFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastrarFunc.BorderRadius = 10
        Me.btnCadastrarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCadastrarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCadastrarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCadastrarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCadastrarFunc.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCadastrarFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCadastrarFunc.ForeColor = System.Drawing.Color.Transparent
        Me.btnCadastrarFunc.Image = CType(resources.GetObject("btnCadastrarFunc.Image"), System.Drawing.Image)
        Me.btnCadastrarFunc.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCadastrarFunc.Location = New System.Drawing.Point(11, 18)
        Me.btnCadastrarFunc.Name = "btnCadastrarFunc"
        Me.btnCadastrarFunc.PressedColor = System.Drawing.Color.Transparent
        Me.btnCadastrarFunc.Size = New System.Drawing.Size(60, 54)
        Me.btnCadastrarFunc.TabIndex = 0
        '
        'btnVisualizarFunc
        '
        Me.btnVisualizarFunc.Animated = True
        Me.btnVisualizarFunc.BackColor = System.Drawing.Color.Transparent
        Me.btnVisualizarFunc.BorderRadius = 10
        Me.btnVisualizarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVisualizarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVisualizarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVisualizarFunc.FillColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnVisualizarFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVisualizarFunc.ForeColor = System.Drawing.Color.Transparent
        Me.btnVisualizarFunc.Image = CType(resources.GetObject("btnVisualizarFunc.Image"), System.Drawing.Image)
        Me.btnVisualizarFunc.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnVisualizarFunc.Location = New System.Drawing.Point(11, 114)
        Me.btnVisualizarFunc.Name = "btnVisualizarFunc"
        Me.btnVisualizarFunc.PressedColor = System.Drawing.Color.Transparent
        Me.btnVisualizarFunc.Size = New System.Drawing.Size(60, 54)
        Me.btnVisualizarFunc.TabIndex = 1
        '
        'frmMenuGerente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGerente"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuGerente As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSangria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCadastrarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVisualizarFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdicionarItem As Guna.UI2.WinForms.Guna2Button
End Class
