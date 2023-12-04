Imports MySql.Data.MySqlClient

Public Class frmCadastrarItem

    Public tipoItem As Integer

    Private Sub frmCadastrarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If

        'Trazer informações dos tipos dos itens
        query = "SELECT tipoComida from comidas"
        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        While (reader.Read)
            If (reader("tipoComida") = 1) Then
                cmbTipo.Items.Add("Lanche")

            ElseIf (reader("tipoComida") = 2) Then
                cmbTipo.Items.Add("Acompanhamento")

            ElseIf (reader("tipoComida") = 3) Then
                cmbTipo.Items.Add("Bebida")
            End If
        End While

        reader.Close()

        Modulo.carregarIdsCardapio()
        Modulo.carregarCardapio()

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If (txtNomeItem.Text = "" Or txtDesc.Text = "" Or txtPreco.Text = "" Or cmbTipo.Text = "") Then
            MsgBox("Preencha todos os campos!", vbOKOnly + vbExclamation, "Atenção")
            Exit Sub
        Else

            query = "INSERT INTO cardapio (nomeItem, descItem, precoItem, tipoItem) VALUES (@nomeItem, @descItem, @precoItem, @tipoItem)"
            Modulo.cmd = New MySqlCommand(query, conn)

            With cmd.Parameters
                .AddWithValue("@nomeItem", txtNomeItem.Text)
                .AddWithValue("@descItem", txtDesc.Text)
                .AddWithValue("@precoItem", txtPreco.Text)
            End With

            If (cmbTipo.Text = "Lanche") Then
                cmd.Parameters.AddWithValue("@tipoItem", 1)
            ElseIf (cmbTipo.Text = "Acompanhamento") Then
                cmd.Parameters.AddWithValue("@tipoItem", 2)
            ElseIf (cmbTipo.Text = "Bebida") Then
                cmd.Parameters.AddWithValue("@tipoItem", 3)
            End If

            Dim adicionar = cmd.ExecuteNonQuery()

            If (adicionar > 0) Then
                Modulo.resp = MsgBox("Item inserido no cardápio com sucesso! Deseja adicionar mais um?", vbInformation + vbYesNo, "Item Adicionado")

                If (Modulo.resp = vbYes) Then
                    Modulo.limpaCadastroItem()
                    Modulo.carregarCardapio()
                    cmbIdItem.Items.Clear()
                    Modulo.carregarIdsCardapio()
                Else
                    Modulo.limpaCadastroItem()
                    Me.Close()
                    conn.Close()
                    frmMenuGerente.Show()
                End If
            End If
        End If
    End Sub

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs) Handles btnEditarItem.Click
        tcItens.SelectedTab = tabCadastrarItem

        query = "SELECT * FROM cardapio WHERE idItem = '" & cmbIdItem.Text & "';"
        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        Dim itemAtual As String

        cmbTipo.Items.Clear()

        cmbTipo.Items.Add("Lanche")
        cmbTipo.Items.Add("Acompanhamento")
        cmbTipo.Items.Add("Bebida")

        While (reader.Read)
            txtNomeItem.Text = reader("nomeItem")
            txtDesc.Text = reader("descItem")
            txtPreco.Text = reader("precoItem")

            If (reader("tipoItem") = 1) Then
                itemAtual = "Lanche"
            ElseIf (reader("tipoItem") = 2) Then
                itemAtual = "Acompanhamento"
            ElseIf (reader("tipoItem") = 3) Then
                itemAtual = "Bebida"
            End If

            cmbTipo.Text = itemAtual

            btnAdicionar.Visible = False
            btnAlterar.Visible = True
            btnDeletar.Visible = True

        End While

        reader.Close()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If (txtNomeItem.Text = "" Or txtDesc.Text = "" Or txtPreco.Text = "" Or cmbTipo.Text = "") Then
            MsgBox("Preencha todos os campos!", vbOKOnly + vbExclamation, "Atenção")
            Exit Sub
        Else
            query = "UPDATE cardapio SET nomeItem = @nomeItem, descItem = @descItem, precoItem = @precoItem, tipoItem = @tipoItem WHERE idItem = '" & cmbIdItem.Text & "';"
            Modulo.cmd = New MySqlCommand(query, conn)

            If (cmbTipo.Text = "Lanche") Then
                tipoItem = 1
            ElseIf (cmbTipo.Text = "Acompanhamento") Then
                tipoItem = 2
            ElseIf (cmbTipo.Text = "Bebida") Then
                tipoItem = 3
            End If

            With cmd.Parameters
                .AddWithValue("@nomeItem", txtNomeItem.Text)
                .AddWithValue("@descItem", txtDesc.Text)
                .AddWithValue("@precoItem", txtPreco.Text)
                .AddWithValue("@tipoItem", tipoItem)
            End With

            Dim alterarCardapio = cmd.ExecuteNonQuery()

            If (alterarCardapio > 0) Then
                MsgBox("Item alterado com sucesso!", vbInformation + vbOKOnly, "Item Alterado")
                Modulo.limpaCadastroItem()
                btnAlterar.Visible = False
                btnDeletar.Visible = False
                btnAdicionar.Visible = True

                tcItens.SelectedTab = tabVisualizarItem
                Modulo.carregarCardapio()
            Else
                MsgBox("Houve um erro ao alterar o item do cardápio", vbOKOnly + vbCritical, "Erro")
            End If

        End If
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

        Modulo.resp = MsgBox("Deseja mesmo deletar esse item do cardápio?", vbYesNo + vbQuestion, "Atenção")

        If (resp = vbYes) Then
            query = "DELETE FROM cardapio WHERE idItem = '" & cmbIdItem.Text & "';"
            Modulo.cmd = New MySqlCommand(query, conn)
            Dim deletarItem = cmd.ExecuteNonQuery()

            If (deletarItem > 0) Then
                MsgBox("Item deletado com sucesso!", vbInformation + vbOKOnly, "Item Alterado")
                Modulo.limpaCadastroItem()
                btnAlterar.Visible = False
                btnDeletar.Visible = False
                btnAdicionar.Visible = True

                tcItens.SelectedTab = tabVisualizarItem
                Modulo.carregarCardapio()
                cmbIdItem.Items.Clear()
                Modulo.carregarIdsCardapio()
            Else
                MsgBox("Houve um erro ao deletar o item do cardápio", vbOKOnly + vbCritical, "Erro")
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnCadastrarFunc_Click(sender As Object, e As EventArgs) Handles btnCadastrarFunc.Click
        Me.Close()
        conn.Close()
        frmCadastrarFunc.Show()
    End Sub

    Private Sub btnVisualizarCredenciais_Click(sender As Object, e As EventArgs) Handles btnVisualizarCredenciais.Click
        Me.Close()
        conn.Close()
        frmVisualizarFunc.Show()
    End Sub

    Private Sub btnRealizarSangria_Click(sender As Object, e As EventArgs) Handles btnRealizarSangria.Click
        Me.Close()
        conn.Close()
        frmRealizarSangria.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmMenuGerente.Show()
    End Sub

    'Eventos Cadastrar Funcionário
    Private Sub btnCadastrarFuncionario_MouseEnter(sender As Object, e As EventArgs) Handles btnCadastrarFunc.MouseEnter
        btnCadastrarFunc.Image = Image.FromFile(icnCadastrarFuncAtivo)
    End Sub

    Private Sub btnCadastrarFuncionario_MouseLeave(sender As Object, e As EventArgs) Handles btnCadastrarFunc.MouseLeave
        btnCadastrarFunc.Image = Image.FromFile(icnCadastrarFuncInativo)
    End Sub

    'Eventos Visualizar Funcionário
    Private Sub btnVisualizarCredenciais_MouseEnter(sender As Object, e As EventArgs) Handles btnVisualizarCredenciais.MouseEnter
        btnVisualizarCredenciais.Image = Image.FromFile(icnVisualizarFuncAtivo)
    End Sub

    Private Sub btnVisualizarCredenciais_MouseLeave(sender As Object, e As EventArgs) Handles btnVisualizarCredenciais.MouseLeave
        btnVisualizarCredenciais.Image = Image.FromFile(icnVisualizarFuncInativo)
    End Sub

    'Eventos Sangria
    Private Sub btnRealizarSangria_MouseEnter(sender As Object, e As EventArgs) Handles btnRealizarSangria.MouseEnter
        btnRealizarSangria.Image = Image.FromFile(icnRealizarSangriaAtivo)
    End Sub

    Private Sub btnRealizarSangria_MouseLeave(sender As Object, e As EventArgs) Handles btnRealizarSangria.MouseLeave
        btnRealizarSangria.Image = Image.FromFile(icnRealizarSangriaInativo)
    End Sub

    'Eventos Cadstrar Item
    Private Sub btnAdicionarItem_Enter(sender As Object, e As EventArgs) Handles btnAdicionarItem.MouseEnter
        btnAdicionarItem.Image = Image.FromFile(icnCadastrarItemAtivo)
    End Sub

    Private Sub btnAdicionarItem_Leave(sender As Object, e As EventArgs) Handles btnAdicionarItem.MouseLeave
        btnAdicionarItem.Image = Image.FromFile(icnCadastrarItemAtivo)
    End Sub

    'Eventos Sair
    Private Sub btnSair_MouseEnter(sender As Object, e As EventArgs) Handles btnSair.MouseEnter
        btnSair.Image = Image.FromFile(icnSairAtivo)
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = Image.FromFile(icnSairInativo)
    End Sub


End Class