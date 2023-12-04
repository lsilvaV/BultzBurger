Imports MySql.Data.MySqlClient

Public Class frmRealizarSangria

    Public valorTotal As Decimal = 0

    Private Sub frmRealizarSangria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If

        Modulo.limpaSangria()
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

    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click
        Me.Close()
        conn.Close()
        frmCadastrarItem.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmMenuGerente.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        query = "SELECT * FROM pedidos WHERE dataPed = '" & dataPedido.Value.ToString("yyyy-MM-dd") & "';"
        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader

        With dgvSangria
            .Rows.Clear() 'Limpa os dados do DataGridView antes de carregar novos dados

            Do While (reader.Read)
                .Rows.Add(reader("dataPed"), reader("precoFinal"))
                valorTotal = valorTotal + reader("precoFinal")
            Loop
        End With

        If (reader.HasRows) Then
            txtValorFinal.Visible = True
            lblValor.Visible = True
            btnRegistrarSangria.Visible = True
            txtValorFinal.Text = "R$ " & valorTotal

        Else
            dgvSangria.Rows.Clear()
            txtValorFinal.Visible = False
            lblValor.Visible = False
            btnRegistrarSangria.Visible = False
        End If

        reader.Close()

    End Sub

    Private Sub btnRegistrarSangria_Click(sender As Object, e As EventArgs) Handles btnRegistrarSangria.Click

        query = "INSERT INTO sangria VALUES (@dataSangria, @valorTotal);"
        Modulo.cmd = New MySqlCommand(query, conn)

        With cmd.Parameters
            .AddWithValue("@dataSangria", dataPedido.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@valorTotal", valorTotal)
        End With

        Dim sangria = cmd.ExecuteNonQuery()

        If (sangria > 0) Then
            MsgBox("Sangria realizada com sucesso!", vbOKOnly + vbInformation, "Sangria Realizada")
            dgvSangria.Rows.Clear()
            valorTotal = 0
            txtValorFinal.Visible = False
            lblValor.Visible = False
            btnRegistrarSangria.Visible = False
        Else
            MsgBox("Houve um erro ao realizar a sangria", vbOKOnly + vbCritical, "Erro")
        End If

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

    'Eventos Sangria
    Private Sub btnRealizarSangria_MouseEnter(sender As Object, e As EventArgs) Handles btnSangria.MouseEnter
        btnSangria.Image = Image.FromFile(icnRealizarSangriaAtivo)
    End Sub

    Private Sub btnRealizarSangria_MouseLeave(sender As Object, e As EventArgs) Handles btnSangria.MouseLeave
        btnSangria.Image = Image.FromFile(icnRealizarSangriaAtivo)
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
        btnSair.Image = Image.FromFile(icnSairAtivo)
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = Image.FromFile(icnSairInativo)
    End Sub

End Class