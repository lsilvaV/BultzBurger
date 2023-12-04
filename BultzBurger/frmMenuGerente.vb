Public Class frmMenuGerente

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmLogin.logado = False
        frmLogin.Show()
        limpaLogin()
    End Sub

    Private Sub btnCadastrarFunc_Click(sender As Object, e As EventArgs) Handles btnCadastrarFunc.Click
        Me.Close()
        conn.Close()
        frmCadastrarFunc.Show()
    End Sub

    Private Sub btnVisualizarFunc_Click(sender As Object, e As EventArgs) Handles btnVisualizarFunc.Click
        Me.Close()
        conn.Close()
        frmVisualizarFunc.Show()
    End Sub

    Private Sub btnSangria_Click(sender As Object, e As EventArgs) Handles btnSangria.Click
        Me.Close()
        conn.Close()
        frmRealizarSangria.Show()
    End Sub

    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click
        Me.Close()
        conn.Close()
        frmCadastrarItem.Show()
    End Sub

    'Eventos Cadastrar Funcionário
    Private Sub btnCadastrarFuncionario_MouseEnter(sender As Object, e As EventArgs) Handles btnCadastrarFunc.MouseEnter
        btnCadastrarFunc.Image = Image.FromFile(icnCadastrarFuncAtivo)
    End Sub

    Private Sub btnCadastrarFuncionario_MouseLeave(sender As Object, e As EventArgs) Handles btnCadastrarFunc.MouseLeave
        btnCadastrarFunc.Image = Image.FromFile(icnCadastrarFuncInativo)
    End Sub

    'Eventos Visualizar Funcionário
    Private Sub btnVisualizarCredenciais_MouseEnter(sender As Object, e As EventArgs) Handles btnVisualizarFunc.MouseEnter
        btnVisualizarFunc.Image = Image.FromFile(icnVisualizarFuncAtivo)
    End Sub

    Private Sub btnVisualizarCredenciais_MouseLeave(sender As Object, e As EventArgs) Handles btnVisualizarFunc.MouseLeave
        btnVisualizarFunc.Image = Image.FromFile(icnVisualizarFuncInativo)
    End Sub

    'Eventos Realizar Sangria
    Private Sub btnRealizarSangria_MouseEnter(sender As Object, e As EventArgs) Handles btnSangria.MouseEnter
        btnSangria.Image = Image.FromFile(icnRealizarSangriaAtivo)
    End Sub

    Private Sub btnRealizarSangria_MouseLeave(sender As Object, e As EventArgs) Handles btnSangria.MouseLeave
        btnSangria.Image = Image.FromFile(icnRealizarSangriaInativo)
    End Sub

    'Eventos Cadstrar Item
    Private Sub btnAdicionarItem_Enter(sender As Object, e As EventArgs) Handles btnAdicionarItem.MouseEnter
        btnAdicionarItem.Image = Image.FromFile(icnCadastrarItemAtivo)
    End Sub

    Private Sub btnAdicionarItem_Leave(sender As Object, e As EventArgs) Handles btnAdicionarItem.MouseLeave
        btnAdicionarItem.Image = Image.FromFile(icnCadastrarItemInativo)
    End Sub

    'Eventos Sair
    Private Sub btnSair_MouseEnter(sender As Object, e As EventArgs) Handles btnSair.MouseEnter
        btnSair.Image = Image.FromFile(icnDeslogarAtivo)
    End Sub

    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = Image.FromFile(icnDeslogarInativo)
    End Sub


End Class
