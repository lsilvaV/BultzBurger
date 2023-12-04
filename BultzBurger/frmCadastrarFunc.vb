Imports MySql.Data.MySqlClient

Public Class frmCadastrarFunc

    Public nomeCargo As String 'Recebe os nomes dos cargos
    Public idCargo As Integer 'Recebe o ID dos cargos
    Public dirFotoFunc As String 'Recebe o diretório da foto do novo funcionário

    Private Sub frmCadastrarFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If

        query = "SELECT * FROM cargos"

        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        Do While (reader.Read)
            nomeCargo = reader.GetString("cargo")
            idCargo = reader.GetInt16("cargoId")
            cmbCargo.Items.Add(nomeCargo)
        Loop

        reader.Close()
    End Sub

    Private Sub btnVisualizarFunc_Click(sender As Object, e As EventArgs) Handles btnVisualizarCredenciais.Click
        Me.Close()
        conn.Close()
        frmVisualizarFunc.Show()
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

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        conn.Close()
        frmMenuGerente.Show()
    End Sub

    Private Sub imgFotoFunc_Click(sender As Object, e As EventArgs) Handles imgFotoFunc.Click
        Try
            With ofdImg
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

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        If (txtCpf.Text = "" Or txtNome.Text = "" Or txtEmail.Text = "" Or txtSenha.Text = "" Or cmbCargo.SelectedItem = "") Then
            MsgBox("Preencha todos os campos!", vbOKOnly + vbExclamation, "Atenção")
        Else
            Try
                query = "INSERT INTO funcionarios VALUES (@cpf, @nomeFunc, @email, @senha, @cargoId, @fotoFunc);"

                Modulo.cmd = New MySqlCommand(query, conn)

                With cmd.Parameters
                    .AddWithValue("@cpf", txtCpf.Text)
                    .AddWithValue("@nomeFunc", txtNome.Text)
                    .AddWithValue("@email", txtEmail.Text)
                    .AddWithValue("@senha", txtSenha.Text)
                    .AddWithValue("@cargoId", idCargo)

                    If (dirFotoFunc = "") Then
                        .AddWithValue("@fotoFunc", "semFoto")
                    Else
                        .AddWithValue("@fotoFunc", dirFotoFunc)
                    End If

                End With

                Dim cadastro = cmd.ExecuteNonQuery()

                If (cadastro > 0) Then
                    resp = MsgBox("Deseja cadastrar mais um funcionário?", vbYesNo + vbQuestion, "Cadastro Realizado")

                    If (resp = vbYes) Then
                        Modulo.limpaFunc()
                        conn.Close()
                    Else
                        Me.Close()
                        conn.Close()
                        frmMenuGerente.Show()
                    End If
                Else
                    MsgBox("Houve um erro ao cadastrar o funcionário, falha no banco de dados", vbOKOnly + vbCritical, "Erro")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Informações de erro: ", ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    'Eventos Cadastrar Funcionário
    Private Sub btnCadastrarFuncionario_MouseEnter(sender As Object, e As EventArgs) Handles btnCadastrarFunc.MouseEnter
        btnCadastrarFunc.Image = Image.FromFile(icnCadastrarFuncAtivo)
    End Sub

    Private Sub btnCadastrarFuncionario_MouseLeave(sender As Object, e As EventArgs) Handles btnCadastrarFunc.MouseLeave
        btnCadastrarFunc.Image = Image.FromFile(icnCadastrarFuncAtivo)
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

