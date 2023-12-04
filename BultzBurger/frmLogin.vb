Imports MySql.Data.MySqlClient
Public Class frmLogin

    Public funcionarioLogado As String
    Public nomeFunc As String
    Public logado As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (conn.State = ConnectionState.Closed) Then
            Modulo.conectarBanco()
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If (txtCpf.Text = "" Or txtSenha.Text = "") Then
            MsgBox("Preencha todos os campos", vbOKOnly + vbExclamation, "Atenção")
        Else
            Try
                Do While (logado = False)

                    'Verifica se a conexão está aberta
                    If (conn.State = ConnectionState.Closed) Then
                        conn.Open()
                    End If

                    'Procure no banco de dados um CPF e SENHA igual ao informado
                    query = "SELECT * FROM funcionarios WHERE cpf = '" & txtCpf.Text & "' AND senha = '" & txtSenha.Text & "'"

                    'Objeto de comando para executar uma query
                    Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                    'Leitor do banco de dados
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    'Se encontrar o CPF
                    If (reader.HasRows) Then

                        Try
                            reader.Read()
                            'Procura o cargo do respectivo CPF
                            Dim cargoId As Integer = reader.GetInt32("cargoId")
                            funcionarioLogado = reader.GetString("cpf")
                            nomeFunc = reader.GetString("nomeFunc")

                            'Fecha leitura e conexão após buscar o cargo
                            reader.Close()
                            conn.Close()

                            If (cargoId = 1) Then 'Se o cargo for igual a 1 (Gerente)
                                frmMenuGerente.Show()
                                Me.Hide()
                                logado = True

                            ElseIf (cargoId = 2) Then 'Se o cargo for igual a 2 (Operador) 
                                frmMenuOperador.Show()
                                Me.Hide()
                                logado = True
                            End If

                        Catch ex As Exception
                            MsgBox("Erro: " & ex.Message)
                        End Try

                    Else
                        MsgBox("Usuário ou senha incorretos!", vbOKOnly + vbCritical, "Erro")
                        reader.Close()
                        Modulo.limpaLogin()
                        Exit Sub
                    End If
                Loop

            Catch ex As Exception
                MsgBox("Não foi possível conectar ao banco de dados, Erro: " & ex.Message, vbCritical + vbOKOnly, "Erro")
            End Try
        End If
    End Sub

    Private Sub chkVisualizarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisualizarSenha.CheckedChanged
        If (chkVisualizarSenha.CheckState = CheckState.Checked) Then
            txtSenha.UseSystemPasswordChar = False
            txtSenha.PasswordChar = ""

        Else
            txtSenha.UseSystemPasswordChar = True
            txtSenha.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtSehna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then btnEntrar.PerformClick()
    End Sub
End Class