Imports MySql.Data.MySqlClient

Public Class frmVisualizarPed

    'Variáveis Publicas
    Public valorLanche As Decimal
    Public valorAcomp As Decimal
    Public valorBebida As Decimal
    Public valorFinal As Decimal

    Public dataPedEdit As Date

    'Evento de inicialização
    Private Sub frmVisualizarPed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If

        Modulo.carregarPed()
        Modulo.carregarVenda()
    End Sub

    'Trocar de formulario para o de realizar pedido
    Private Sub btnRealizarPedido_Click(sender As Object, e As EventArgs) Handles btnRealizarPedido.Click
        Me.Close()
        conn.Close()
        frmRealizarPed.Show()
    End Sub

    'Deslogar
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmMenuOperador.Show()
    End Sub

    'Mostrar Detalhes da Venda Baseados no Pedido
    Private Sub dgvPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellContentClick
        Try

            If (e.ColumnIndex = 0) Then
                query = "SELECT * FROM venda WHERE idPedido = " & dgvPedidos.CurrentCell.Value & " ;"
                Modulo.cmd = New MySqlCommand(query, conn)
                Modulo.reader = cmd.ExecuteReader()

                dgvVenda.Rows.Clear()


                Do While (reader.Read)
                    With dgvVenda
                        .Rows.Add(reader("nomeLanche"), reader("qtdLanche"), reader("nomeAcomp"), reader("qtdAcomp"), reader("nomeBebida"), reader("qtdBebida"))
                    End With
                Loop

                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Erro") 'Confirmação de erro
        End Try

    End Sub

    'Eventos RealizarPedido
    Private Sub btnRealizarPedido_MouseEnter(sender As Object, e As EventArgs) Handles btnRealizarPedido.MouseEnter
        btnRealizarPedido.Image = Image.FromFile(icnRealizarPedidoAtivo)
    End Sub
    Private Sub btnRealizarPedido_MouseLeave(sender As Object, e As EventArgs) Handles btnRealizarPedido.MouseLeave
        btnRealizarPedido.Image = Image.FromFile(icnRealizarPedidoInativo)
    End Sub

    'Eventos VisualizarPedidos
    Private Sub btnVisualizarPedidos_MouseEnter(sender As Object, e As EventArgs) Handles btnVisualizarPedidos.MouseEnter
        btnVisualizarPedidos.Image = Image.FromFile(icnVisualizarPedidoAtivo)
    End Sub
    Private Sub btnVisualizarPedidos_MouseLeave(sender As Object, e As EventArgs) Handles btnVisualizarPedidos.MouseLeave
        btnVisualizarPedidos.Image = Image.FromFile(icnVisualizarPedidoAtivo)
    End Sub

    'Eventos Sair
    Private Sub btnSair_MouseEnter(sender As Object, e As EventArgs) Handles btnSair.MouseEnter
        btnSair.Image = Image.FromFile(icnSairAtivo)
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = Image.FromFile(icnSairInativo)
    End Sub


End Class
