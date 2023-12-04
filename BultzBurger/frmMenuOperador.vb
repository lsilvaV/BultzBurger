Public Class frmMenuOperador

    Private Sub btnVisualizarPedidos_Click(sender As Object, e As EventArgs) Handles btnVisualizarPedidos.Click
        Me.Close()
        conn.Close()
        frmVisualizarPed.Show()
    End Sub

    Private Sub btnRealizarPedido_Click(sender As Object, e As EventArgs) Handles btnRealizarPedido.Click
        Me.Close()
        conn.Close()
        frmRealizarPed.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmLogin.logado = False
        frmLogin.Show()
        limpaLogin()
    End Sub

    Private Sub btnRealizarPedido_MouseEnter(sender As Object, e As EventArgs) Handles btnRealizarPedido.MouseEnter
        btnRealizarPedido.Image = Image.FromFile(icnRealizarPedidoAtivo)
    End Sub

    Private Sub btnRealizarPedido_MouseLeave(sender As Object, e As EventArgs) Handles btnRealizarPedido.MouseLeave
        btnRealizarPedido.Image = Image.FromFile(icnRealizarPedidoInativo)
    End Sub

    'Eventos VizualizarPedidos
    Private Sub btnVisualizarPedidos_MouseEnter(sender As Object, e As EventArgs) Handles btnVisualizarPedidos.MouseEnter
        btnVisualizarPedidos.Image = Image.FromFile(icnVisualizarPedidoAtivo)
    End Sub

    Private Sub btnVisualizarPedidos_MouseLeave(sender As Object, e As EventArgs) Handles btnVisualizarPedidos.MouseLeave
        btnVisualizarPedidos.Image = Image.FromFile(icnVisualizarPedidoInativo)
    End Sub

    'Eventos Sair
    Private Sub btnSair_MouseEnter(sender As Object, e As EventArgs) Handles btnSair.MouseEnter
        btnSair.Image = Image.FromFile(icnDeslogarAtivo)
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = Image.FromFile(icnDeslogarInativo)
    End Sub

End Class
