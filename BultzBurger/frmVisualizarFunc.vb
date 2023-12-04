Imports MySql.Data.MySqlClient

Public Class frmVisualizarFunc

    Public tipo As String
    Public cargoId As Int16
    Public dirFotoFunc As String

    Private Sub frmVisualizarFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If

        Modulo.carregarFunc()

        cmbParametro.SelectedItem = "CPF"
    End Sub

    Private Sub btnSangria_Click(sender As Object, e As EventArgs) Handles btnRealizarSangria.Click
        Me.Close()
        conn.Close()
        frmRealizarSangria.Show()
    End Sub

    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click
        Me.Close()
        conn.Close()
        frmCadastrarItem.Show()
    End Sub

    Private Sub btnCadastrarFunc_Click(sender As Object, e As EventArgs) Handles btnCadastrarFunc.Click
        Me.Close()
        conn.Close()
        frmCadastrarFunc.Show()
    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmMenuGerente.Show()
    End Sub

    Private Sub tabEditarFunc_Enter(sender As Object, e As EventArgs) Handles tabEditarFunc.Enter
        lblPesquisa.Visible = False
        lblParametro.Visible = False
        txtPesquisa.Visible = False
        cmbParametro.Visible = False
    End Sub

    Private Sub tabVisualizar_Enter(sender As Object, e As EventArgs) Handles tabVisualizar.Enter
        lblPesquisa.Visible = True
        lblParametro.Visible = True
        txtPesquisa.Visible = True
        cmbParametro.Visible = True
    End Sub

    'Trazer diretório da foto
    Private Sub imgFotoFunc_Click(sender As Object, e As EventArgs) Handles imgFotoFunc.Click
        Try
            With ofdImgFunc
                .Title = "Procure a foto do funcionário"
                .InitialDirectory = Application.StartupPath & "\Assets\funcionarios"
                .ShowDialog()
                dirFotoFunc = .FileName

                imgFotoFunc.Load(dirFotoFunc)

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    'Limpar caso o usuário clique duas vezes no campo de CPF
    Private Sub txtCpf_DoubleClick(sender As Object, e As EventArgs) Handles txtCpf.DoubleClick
        Modulo.limpaEditarFunc()
    End Sub

    'Buscar informações no banco de dados se baseando no CPF
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        reader.Close()

        'Verificando se o CPF existe no Banco de Dados

        If (txtCpf.Text = "000.000.000-00") Then
            MsgBox("Você não pode editar o usuário administrador")
            Modulo.limpaEditarFunc()
            Exit Sub
        Else

            query = "SELECT * FROM funcionarios WHERE cpf = '" & txtCpf.Text & "';"

            Modulo.cmd = New MySqlCommand(query, conn)
            Modulo.reader = cmd.ExecuteReader()

            If (reader.HasRows = False) Then
                MsgBox("O CPF informado não existe no banco de dados. Verifique o CPF digitado!", vbOKOnly + vbExclamation, "Aviso")
            Else
                Try
                    Dim cargo, operador, gerente

                    operador = "Operador de Caixa"
                    gerente = "Gerente"

                    While (reader.Read)
                        If (reader("cargoId") = 1) Then
                            cargo = "Gerente"
                        ElseIf (reader("cargoId") = 2) Then
                            cargo = "Operador de Caixa"
                        End If

                        txtNome.Text = reader("nomeFunc")
                        txtEmail.Text = reader("email")
                        txtSenha.Text = reader("senha")

                        With cmbCargo.Items
                            .Add(operador)
                            .Add(gerente)
                        End With

                        cmbCargo.SelectedItem = cargo

                        If (reader("fotoFunc") <> "semFoto") Then
                            imgFotoFunc.Load(reader("fotoFunc"))
                        Else
                            imgFotoFunc.Load(Application.StartupPath & "\Assets\funcionarios\semFoto.png")
                        End If

                    End While

                Catch ex As Exception
                    MsgBox("Erro ao carregar dados. Informações do erro: " & ex.Message, vbOKOnly + vbCritical, "Erro")
                    Exit Sub
                End Try

                btnAlterar.Visible = True
                btnDeletar.Visible = True

                reader.Close()
            End If
        End If
    End Sub

    'Alterar informações do funcionário
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If (cmbCargo.Text = "Gerente") Then
            cargoId = 1
        ElseIf (cmbCargo.Text = "Operador de Caixa") Then
            cargoId = 2
        End If

        Try
            query = "UPDATE funcionarios SET nomeFunc = @nomeFunc, email = @email, senha = @senha, cargoId = @cargoId, fotoFunc = @fotoFunc WHERE cpf = '" & txtCpf.Text & "';"

            Modulo.cmd = New MySqlCommand(query, conn)

            With cmd.Parameters
                .AddWithValue("@nomeFunc", txtNome.Text)
                .AddWithValue("@email", txtEmail.Text)
                .AddWithValue("@senha", txtSenha.Text)
                .AddWithValue("@cargoId", cargoId)

                If (dirFotoFunc <> "") Then
                    .AddWithValue("@fotoFunc", dirFotoFunc)
                Else
                    .AddWithValue("@fotoFunc", "semFoto")
                End If

            End With

            Dim alterar = cmd.ExecuteNonQuery()

            If (alterar > 0) Then
                MsgBox("Informações alteradas com sucesso!", vbOKOnly + vbInformation, "Pedido Alterado")
                tcFunc.SelectedTab = tabVisualizar
                Modulo.carregarFunc()
                Modulo.limpaEditarFunc()
            Else
                MsgBox("Houve um erro ao alterar as credenciais, falha no banco de dados", vbOKOnly + vbCritical, "Erro")
            End If

        Catch ex As Exception
            MsgBox("Informações de erro: " & ex.Message)
        End Try
    End Sub

    'Deletar informações do funcionário
    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try

            Modulo.resp = MsgBox("Deseja mesmo deletar esse funcionário da lista?", vbYesNo + vbQuestion, "Atenção")

            If (resp = vbYes) Then

                query = "DELETE FROM funcionarios WHERE cpf = '" & txtCpf.Text & "';"
                Modulo.cmd = New MySqlCommand(query, conn)

                Dim deletar = cmd.ExecuteNonQuery()

                If (deletar > 0) Then
                    MsgBox("Informações deletadas com sucesso!", vbOKOnly + vbInformation, "Informações deletadas")
                    tcFunc.SelectedTab = tabVisualizar
                    Modulo.carregarFunc()
                    Modulo.limpaEditarFunc()
                Else
                    MsgBox("Houve um erro ao deletar as credenciais, falha no banco de dados", vbOKOnly + vbCritical, "Erro")
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Informações de erro: " & ex.Message)
        End Try
    End Sub

    Private Sub txtPesquisa_Click(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged
        If (cmbParametro.Text = "NOME") Then
            tipo = "nomeFunc"
        ElseIf (cmbParametro.Text = "CPF") Then
            tipo = "CPF"
        End If

        If (conn.State <> ConnectionState.Closed) Then
            Try
                query = "SELECT * FROM funcionarios WHERE " & tipo & " LIKE '" & txtPesquisa.Text & "%'"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader()

                With dgvFunc
                    .Rows.Clear() 'Limpa os dados do DataGridView antes de carregar novos dados

                    Dim cargo As String

                    Do While (reader.Read)
                        If (reader("cargoId") = 1) Then
                            cargo = "Gerente"
                        ElseIf (reader("cargoId") = 2) Then
                            cargo = "Operador de Caixa"
                        End If
                        .Rows.Add(reader("cpf"), reader("nomeFunc"), reader("email"), reader("senha"), cargo)
                    Loop

                    reader.Close()
                End With

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Erro") 'Confirmação de erro
            End Try
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
    Private Sub btnVisualizarCredenciais_MouseEnter(sender As Object, e As EventArgs) Handles btnVisualizarCredenciais.MouseEnter
        btnVisualizarCredenciais.Image = Image.FromFile(icnVisualizarFuncAtivo)
    End Sub

    Private Sub btnVisualizarCredenciais_MouseLeave(sender As Object, e As EventArgs) Handles btnVisualizarCredenciais.MouseLeave
        btnVisualizarCredenciais.Image = Image.FromFile(icnVisualizarFuncAtivo)
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