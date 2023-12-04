Imports MySql.Data.MySqlClient
Module Modulo

    Public host As String = "127.0.0.1" 'Endereço do banco de dados
    Public db As String = "dbBultz" 'Nome do banco
    Public user As String = "root" 'Usuário do banco
    Public passwd As String = "" 'Senha para acessar o banco

    Public query As String 'Variável para receber os comandos SQL

    Public connectionString As String = String.Format("Server={0};Database={1};User={2};Password={3}", host, db, user, passwd) 'Conectando com o banco de dados
    Public conn As MySqlConnection = New MySqlConnection(connectionString) 'Objeto do banco de dados (abre e fecha conexão)

    Public cmd As MySqlCommand 'Executa comandos SQL Standard
    Public reader As MySqlDataReader 'Lê o banco de dados

    Public resp 'Variável para receber respostas do usuários

    'Variáveis de Ícones
    Public icnRealizarPedidoInativo As String = Application.StartupPath & "\Assets\icones\realizar pedido preto.png"
    Public icnRealizarPedidoAtivo As String = Application.StartupPath & "\Assets\icones\realizar pedido branco.png"

    'Botão CadastrarFuncionário
    Public icnCadastrarFuncInativo As String = Application.StartupPath & "\Assets\icones\cadastrar funcionario preto.png"
    Public icnCadastrarFuncAtivo As String = Application.StartupPath & "\Assets\icones\cadastrar funcionario branco.png"

    'Botão VizualizarCredenciais
    Public icnVisualizarFuncInativo As String = Application.StartupPath & "\Assets\icones\vizualizar credenciais preto.png"
    Public icnVisualizarFuncAtivo As String = Application.StartupPath & "\Assets\icones\vizualizar credenciais branco.png"

    'Botão RealizarSangria
    Public icnRealizarSangriaInativo As String = Application.StartupPath & "\Assets\icones\sangria preto.png"
    Public icnRealizarSangriaAtivo As String = Application.StartupPath & "\Assets\icones\sangria branco.png"

    'Botão VizualizarPedidos
    Public icnVisualizarPedidoInativo As String = Application.StartupPath & "\Assets\icones\vizualizar pedidos preto.png"
    Public icnVisualizarPedidoAtivo As String = Application.StartupPath & "\Assets\icones\vizualizar pedidos branco.png"

    'Botão CadastrarItem
    Public icnCadastrarItemInativo As String = Application.StartupPath & "\Assets\icones\cadastrar preto.png"
    Public icnCadastrarItemAtivo As String = Application.StartupPath & "\Assets\icones\cadastrar branco.png"

    'Botão Home
    Public icnSairInativo As String = Application.StartupPath & "\Assets\icones\sair preto.png"
    Public icnSairAtivo As String = Application.StartupPath & "\Assets\icones\sair branco.png"

    'Botão de Deslogar
    Public icnDeslogarInativo As String = Application.StartupPath & "\Assets\icones\deslogar preto.png"
    Public icnDeslogarAtivo As String = Application.StartupPath & "\Assets\icones\deslogar branco.png"

    'Função que conecta com o banco
    Sub conectarBanco()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Erro ao abrir banco: " & ex.Message)
        End Try
    End Sub

    'Função para limpar o formulário de login
    Sub limpaLogin()
        With frmLogin
            .txtCpf.Text = ""
            .txtSenha.Text = ""
            .txtCpf.Focus()
        End With
    End Sub

    Sub limpaPedido()
        With frmRealizarPed
            .txtNomeCli.Text = ""
            .cmbLanche.SelectedItem = ""
            .cmbAcomp.SelectedItem = ""
            .cmbBebida.SelectedItem = ""
            .qtdLanche.Value = 0
            .qtdAcomp.Value = 0
            .qtdBebida.Value = 0
            .txtNomeCli.Focus()
        End With
    End Sub

    Sub limpaFunc()
        With frmCadastrarFunc
            .txtCpf.Text = ""
            .txtNome.Text = ""
            .txtEmail.Text = ""
            .txtSenha.Text = ""
            .cmbCargo.SelectedItem = ""
            .imgFotoFunc.Load(Application.StartupPath & "\Assets\fotos\adicionarFunc.png")
        End With
    End Sub

    Sub carregarPed()
        Try
            query = "SELECT * FROM pedidos ORDER BY idPedido ASC"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            With frmVisualizarPed.dgvPedidos
                .Rows.Clear() 'Limpa os dados do DataGridView antes de carregar novos dados

                Do While (reader.Read)
                    .Rows.Add(reader("idPedido"), reader("dataPed"), reader("nomeCli"), reader("cpfFunc"), "R$" & reader("precoFinal"))
                Loop
            End With

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Erro") 'Confirmação de erro
        End Try
    End Sub

    Sub carregarVenda()
        Try
            query = "SELECT * FROM venda ORDER BY idPedido ASC"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            With frmVisualizarPed.dgvVenda
                .Rows.Clear() 'Limpa os dados do DataGridView antes de carregar novos dados

                Do While (reader.Read)
                    .Rows.Add(reader("nomeLanche"), reader("qtdLanche"), reader("nomeAcomp"), reader("qtdAcomp"), reader("nomeBebida"), reader("qtdBebida"))
                Loop
            End With

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Erro") 'Confirmação de erro
        End Try
    End Sub

    'Carrega as informações do funcionário no DGV
    Sub carregarFunc()
        Try
            query = "SELECT * FROM funcionarios ORDER BY nomeFunc ASC"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            With frmVisualizarFunc.dgvFunc
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
    End Sub

    'Carrega as informações do cardápio no DGV
    Sub carregarCardapio()

        reader.Close()

        Try
            query = "SELECT * FROM cardapio ORDER BY idItem ASC"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            With frmCadastrarItem.dgvCardapio
                .Rows.Clear() 'Limpa os dados do DataGridView antes de carregar novos dados

                Dim tipoItem As String

                Do While (reader.Read)
                    If (reader("tipoItem") = 1) Then
                        tipoItem = "Lanche"
                    ElseIf (reader("tipoItem") = 2) Then
                        tipoItem = "Acompanhamento"
                    ElseIf (reader("tipoItem") = 3) Then
                        tipoItem = "Bebidas"
                    End If

                    .Rows.Add(reader("idItem"), reader("nomeItem"), reader("descItem"), reader("precoItem"), tipoItem)
                Loop

            End With

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Erro") 'Confirmação de erro
        End Try
    End Sub

    Sub carregarIdsCardapio()
        query = "SELECT * FROM cardapio"
        Modulo.cmd = New MySqlCommand(query, conn)
        Modulo.reader = cmd.ExecuteReader()

        While (reader.Read)
            frmCadastrarItem.cmbIdItem.Items.Add(reader("idItem"))
        End While

        reader.Close()
    End Sub


    'Limpa campos do funcionário
    Sub limpaEditarFunc()
        With frmVisualizarFunc
            .txtCpf.Text = ""
            .txtNome.Text = ""
            .txtEmail.Text = ""
            .txtSenha.Text = ""
            .cmbCargo.Items.Clear()
            .imgFotoFunc.Load(Application.StartupPath & "\Assets\fotos\adicionarFunc.png")
        End With
    End Sub

    Sub limpaSangria()
        With frmRealizarSangria
            .dgvSangria.Rows.Clear()
            .txtValorFinal.Visible = False
            .lblValor.Visible = False
            .btnRegistrarSangria.Visible = False
        End With
    End Sub

    Sub limpaCadastroItem()
        With frmCadastrarItem
            .txtNomeItem.Text = ""
            .txtDesc.Text = ""
            .txtPreco.Text = ""
            .cmbTipo.Text = ""
            .txtNomeItem.Focus()
        End With
    End Sub

End Module
