Imports MySql.Data.MySqlClient

Public Class frmRealizarPed

    Public valorLanche As Decimal
    Public valorAcomp As Decimal
    Public valorBebida As Decimal
    Public valorFinal As Decimal

    Public idPedido As Integer

    'Valor máximo de itens do cardápio
    Public lancheArr(12)
    Public acompArr(12)
    Public bebidaArr(12)

    Public nomeLanche As String
    Public nomeAcomp As String
    Public nomeBebida As String

    Public dataPed As Date

    'Ao iniciar formulário
    Private Sub FazerPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Funcionário logado que realizará o pedido
        txtCpfFunc.Text = frmLogin.funcionarioLogado

        'Conectando banco de dados
        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If

        txtPrecoFinal.Text = "R$ 0,00"
        qtdLanche.Value = 0
        qtdAcomp.Value = 0
        qtdBebida.Value = 0

        query = "SELECT * FROM cardapio"

        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        'Adicionando itens na ComboBox
        Do While (reader.Read)
            Dim item As String = reader.GetString("nomeItem")

            If (reader.GetString("tipoItem") = 1) Then
                cmbLanche.Items.Add(item)
            ElseIf (reader.GetString("tipoItem") = 2) Then
                cmbAcomp.Items.Add(item)
            ElseIf (reader.GetString("tipoItem") = 3) Then
                cmbBebida.Items.Add(item)
            End If

        Loop

        reader.Close()

        query = "SELECT * FROM cardapio WHERE tipoItem = 1"

        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        Dim linha As Integer = 0

        While (reader.Read)
            lancheArr(linha) = reader("nomeItem")
            linha = linha + 1

        End While

        reader.Close()
        linha = 0

        query = "SELECT * FROM cardapio WHERE tipoItem = 2"

        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        While (reader.Read)
            acompArr(linha) = reader("nomeItem")
            linha = linha + 1

        End While

        reader.Close()
        linha = 0

        query = "SELECT * FROM cardapio WHERE tipoItem = 3"

        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        While (reader.Read)
            bebidaArr(linha) = reader("nomeItem")
            linha = linha + 1

        End While

        reader.Close()
        linha = 0

    End Sub

    Private Sub btnVisualizarPedidos_Click(sender As Object, e As EventArgs) Handles btnVisualizarPedidos.Click
        Me.Close()
        conn.Close()
        frmVisualizarPed.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmMenuOperador.Show()
    End Sub

    'Trocando quantidade de lanches
    Private Sub qtdLanche_ValueChanged(sender As Object, e As EventArgs) Handles qtdLanche.ValueChanged
        If (cmbLanche.Text = "") Then
            qtdLanche.Value = 0
        End If
    End Sub

    'Trocando quantidade de acompanhamentos
    Private Sub qtdAcomp_ValueChanged(sender As Object, e As EventArgs) Handles qtdAcomp.ValueChanged
        If (cmbAcomp.Text = "") Then
            qtdAcomp.Value = 0
        End If
    End Sub

    'Trocando quantidade de bebidas
    Private Sub qtdBebida_ValueChanged(sender As Object, e As EventArgs) Handles qtdBebida.ValueChanged
        If (cmbBebida.Text = "") Then
            qtdBebida.Value = 0
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If (qtdLanche.Value <> 0) Then
            query = "SELECT * FROM cardapio WHERE nomeItem = '" & cmbLanche.Text & "';"

            Modulo.cmd = New MySqlCommand(query, conn)
            Modulo.reader = cmd.ExecuteReader()

            While (reader.Read)
                valorLanche = reader.GetDecimal("precoItem")
            End While

            reader.Close()
        Else
            valorLanche = 0
        End If

        If (qtdAcomp.Value <> 0) Then
            query = "SELECT * FROM cardapio WHERE nomeItem = '" & cmbAcomp.Text & "';"

            Modulo.cmd = New MySqlCommand(query, conn)
            Modulo.reader = cmd.ExecuteReader()

            While (reader.Read)
                valorAcomp = reader.GetDecimal("precoItem")
            End While

            reader.Close()
        Else
            valorAcomp = 0
        End If

        If (qtdBebida.Value <> 0) Then
            query = "SELECT * FROM cardapio WHERE nomeItem = '" & cmbBebida.Text & "';"

            Modulo.cmd = New MySqlCommand(query, conn)
            Modulo.reader = cmd.ExecuteReader()

            While (reader.Read)
                valorBebida = reader.GetDecimal("precoItem")
            End While

            reader.Close()
        Else
            valorBebida = 0
        End If

        reader.Close()

        'Calculando valor final
        valorFinal = (valorLanche * qtdLanche.Value) + (valorAcomp * qtdAcomp.Value) + (valorBebida * qtdBebida.Value) + FormatNumber(txtPrecoFinal.Text)
        txtPrecoFinal.Text = "R$ " & valorFinal

        ' Adicionando itens no carrinho
        If (qtdLanche.Value = 0 And qtdAcomp.Value = 0 And qtdBebida.Value = 0) Then
            MsgBox("Selecione pelo menos um item!", vbExclamation + vbOKOnly, "Atenção")
            Exit Sub
        Else

            ListaProdutos.Items.Add(New ListViewItem({cmbLanche.Text, qtdLanche.Value, cmbAcomp.Text, qtdAcomp.Value, cmbBebida.Text, qtdBebida.Value}))

            'Mostrando botão de enviar pedido
            If (ListaProdutos.Items.Count > 0) Then
                btnEnviar.Visible = True
            End If

            cmbLanche.SelectedItem = ""
            cmbAcomp.SelectedItem = ""
            cmbBebida.SelectedItem = ""
            qtdLanche.Value = 0
            qtdAcomp.Value = 0
            qtdBebida.Value = 0

        End If

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If (ListaProdutos.Items.Count = 0) Then
            MsgBox("Adicione o pedido ao carrinho!", vbInformation)
            Exit Sub

        ElseIf (txtNomeCli.Text = "") Then
            MsgBox("Preencha o nome do cliente primeiro", vbInformation)
            txtNomeCli.Focus()
            Exit Sub
        End If

        Modulo.resp = MsgBox("O pedido será enviado à cozinha.", vbOKCancel + vbExclamation, "Pedido Realizado!")

        If (resp = vbOK) Then

            dataPed = Date.Now.ToShortDateString

            Try

                query = "INSERT INTO pedidos (dataPed, nomeCli, cpfFunc, precoFinal)" & "VALUES (@dataPed, @nomeCli, @cpfFunc, @precoFinal);"

                Modulo.cmd = New MySqlCommand(query, conn)

                With cmd.Parameters
                    .AddWithValue("@dataPed", dataPed)
                    .AddWithValue("@nomeCli", txtNomeCli.Text)
                    .AddWithValue("@cpfFunc", txtCpfFunc.Text)
                    .AddWithValue("@precoFinal", valorFinal)
                End With

                ' Execute the query
                Dim inserirPed = cmd.ExecuteNonQuery()

                If (inserirPed > 0) Then

                    query = "SELECT * FROM pedidos"
                    Modulo.cmd = New MySqlCommand(query, conn)
                    Modulo.reader = cmd.ExecuteReader()

                    While (reader.Read)
                        If (reader.HasRows) Then
                            idPedido = reader("idPedido")
                        Else
                            idPedido = 0
                        End If

                    End While

                    reader.Close()

                    For Each item In ListaProdutos.Items

                        For i As Integer = 0 To 11

                            If (lancheArr(i) = item.SubItems(0).text) Then
                                nomeLanche = lancheArr(i)
                                Exit For
                            End If

                        Next

                        For i As Integer = 0 To 11

                            If (acompArr(i) = item.SubItems(2).text) Then
                                nomeAcomp = acompArr(i)
                                Exit For
                            End If
                        Next

                        For i As Integer = 0 To 11

                            If (bebidaArr(i) = item.SubItems(4).text) Then
                                nomeBebida = bebidaArr(i)
                                Exit For
                            End If
                        Next

                        query = "INSERT INTO venda (idPedido, nomeLanche, qtdLanche, nomeAcomp, qtdAcomp, nomeBebida, qtdBebida)" & "VALUES (@idPedido, @nomeLanche, @qtdLanche, @nomeAcomp, @qtdAcomp, @nomeBebida, @qtdBebida);"

                        Modulo.cmd = New MySqlCommand(query, conn)

                        With cmd.Parameters
                            .AddWithValue("@idPedido", idPedido)

                            If (item.SubItems(0).Text <> "") Then
                                .AddWithValue("@nomeLanche", nomeLanche)
                            Else
                                .AddWithValue("@nomeLanche", "Nenhum Item")
                            End If


                            .AddWithValue("@qtdLanche", Convert.ToInt16(item.SubItems(1).Text))

                            If (item.SubItems(2).Text <> "") Then
                                .AddWithValue("@nomeAcomp", nomeAcomp)
                            Else
                                .AddWithValue("@nomeAcomp", "Nenhum Item")
                            End If

                            .AddWithValue("@qtdAcomp", Convert.ToInt16(item.SubItems(3).Text))

                            If (item.SubItems(4).Text <> "") Then
                                .AddWithValue("@nomeBebida", nomeBebida)
                            Else
                                .AddWithValue("@nomeBebida", "Nenhum Item")
                            End If

                            .AddWithValue("@qtdBebida", Convert.ToInt16(item.SubItems(5).Text))
                        End With

                        Dim inserirVenda = cmd.ExecuteNonQuery()

                    Next

                    'Limpando informações na conclusão do pedido
                    ListaProdutos.Items.Clear()
                    txtPrecoFinal.Text = "R$ 0,00"
                    txtNomeCli.Text = ""
                    btnEnviar.Visible = False

                Else
                    MsgBox("Houve um erro ao realizar o pedido, falha no banco de dados", vbOKOnly + vbCritical, "Erro")
                End If
            Catch ex As Exception
                MsgBox("Informações de erro: ", ex.Message)
            End Try
        End If

    End Sub


    Private Sub limparCarrinho_Click(sender As Object, e As EventArgs) Handles limparCarrinho.Click
        ListaProdutos.Items.Clear()
        txtPrecoFinal.Text = "R$ 0,00"
        btnEnviar.Visible = False
    End Sub

    Private Sub btnRealizarPedido_MouseEnter(sender As Object, e As EventArgs) Handles btnRealizarPedido.MouseEnter
        btnRealizarPedido.Image = Image.FromFile(icnRealizarPedidoAtivo)
    End Sub

    Private Sub btnRealizarPedido_MouseLeave(sender As Object, e As EventArgs) Handles btnRealizarPedido.MouseLeave
        btnRealizarPedido.Image = Image.FromFile(icnRealizarPedidoAtivo)
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
        btnSair.Image = Image.FromFile(icnSairAtivo)
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = Image.FromFile(icnSairInativo)
    End Sub

    Private Sub ListaProdutos_MouseClick(sender As Object, e As MouseEventArgs) Handles ListaProdutos.MouseClick

        Dim selectedItem As ListViewItem = ListaProdutos.SelectedItems(0)
        Dim item As ListViewItem = ListaProdutos.SelectedItems(0)

        If (e.Button = MouseButtons.Right) Then

            If (ListaProdutos.SelectedItems.Count > 0) Then

                Modulo.resp = MsgBox("Deseja excluir o pedido do carrinho?", vbExclamation + vbYesNo, "Atenção!")

                If (Modulo.resp = vbYes) Then
                    ListaProdutos.Items.Remove(selectedItem)

                End If

            End If
        ElseIf (e.Button = MouseButtons.Left) Then
            If (ListaProdutos.SelectedItems.Count > 0) Then

                cmbLanche.Text = item.SubItems(0).Text
                qtdLanche.Text = item.SubItems(1).Text
                cmbAcomp.Text = item.SubItems(2).Text
                qtdAcomp.Text = item.SubItems(3).Text
                cmbBebida.Text = item.SubItems(4).Text
                qtdBebida.Text = item.SubItems(5).Text

                ListaProdutos.Items.Remove(selectedItem)
            End If
        End If
    End Sub

    Private Sub cmbLanche_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cmbLanche.MouseDoubleClick
        cmbLanche.Text = ""
    End Sub

    Private Sub cmbAcomp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cmbAcomp.MouseDoubleClick
        cmbAcomp.Text = ""
    End Sub

    Private Sub cmbBebida_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles cmbBebida.MouseDoubleClick
        cmbBebida.Text = ""
    End Sub
End Class