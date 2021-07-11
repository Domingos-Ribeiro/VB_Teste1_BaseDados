Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ligacao As New Conectar
        dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarProdutos.Click
        Dim ligacao As New Conectar
        ligacao.SSQL = "Select * from Produtos"
        dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        'MessageBox.Show(dgvTeste1.Rows.Count() - 1)
        txtContar.Text = (dgvTeste1.Rows.Count() - 1)
    End Sub

    Private Sub btnLimparGrid_Click(sender As Object, e As EventArgs) Handles btnLimparGrid.Click
        dgvTeste1.Columns.Clear()
    End Sub

    Private Sub RemoverSelecionado_Click(sender As Object, e As EventArgs) Handles RemoverSelecionado.Click

        Dim nomeProduto As String = txtRemoverSelecionado.Text '.ToUpper() 
        Dim dadosDaGrid As Integer = dgvTeste1.Rows.Count - 1

        If txtRemoverSelecionado.Text = "" Then
            MessageBox.Show("Por favor introduza o nome de um produto na Caixa de Texto")
            Return
        End If

        Try

            For i = 0 To dadosDaGrid
                'If dgvTeste1(1, i).Value.ToString().ToUpper() = nomeProduto Then
                If dgvTeste1(1, i).Value.ToString() = nomeProduto Then
                        dgvTeste1.Rows.RemoveAt(i)
                    End If
            Next

        Catch ex As Exception
            MessageBox.Show("Removeu com Sucesso o produto " + "(" + nomeProduto + ")")
        End Try


    End Sub

    Private Sub btnNomesGridToList_Click(sender As Object, e As EventArgs) Handles btnNomesGridToList.Click

        Dim nomeProduto As String = ""
        Dim dadosDaGrid As Integer = dgvTeste1.Rows.Count - 1


        Try

            For i = 0 To dadosDaGrid
                nomeProduto = dgvTeste1(1, i).Value.ToString
                ListBox1.Items.Add(nomeProduto)
            Next

        Catch ex As Exception
            ' Poderia colocar aqui uma menssagem qualquer.
        End Try

        'Dim ligacao As New Conectar
        'ligacao.SSQL = "Select * from Produtos; "
        'ListBox1.DataSource = ligacao.BuscarDados()

        'ListBox1.ValueMember = "NomeDoProduto"

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        dgvTeste1.Columns("NomeDoProduto").Width = 159
        dgvTeste1.Columns("Existências").Width = 81
        Dim ligacao As New Conectar
        ligacao.SSQL = "Select * from Produtos; Select * from Fornecedores; Select * from Categorias;"
        dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        dgvTeste1.Columns("NomeDoProduto").Width = 159
        Dim ligacao As New Conectar
        ligacao.SSQL = "Select * from Produtos where Existências = '0'"
            dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        dgvTeste1.Columns("NomeDoProduto").Width = 200
        Dim ligacao As New Conectar
        ligacao.SSQL = "Select NomeDoProduto from Produtos; "
        dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub btnContaNomesList_Click(sender As Object, e As EventArgs) Handles btnContaNomesList.Click
        txtContaNomesList.Text = (ListBox1.Items.Count())
    End Sub

    Private Sub btnLimpaList_Click(sender As Object, e As EventArgs) Handles btnLimpaList.Click

        ListBox1.Items.Clear()

    End Sub

    Private Sub btnEliminaProdutoLista_Click(sender As Object, e As EventArgs) Handles btnEliminaProdutoLista.Click

        Dim nomeP As String = txtEliminaProdutoLista.Text.ToUpper()
        Dim listagem As Integer = ListBox1.Items.Count

        Try
            For i = 0 To listagem
                If ListBox1.Items(i).ToString().ToUpper() = nomeP Then

                    ListBox1.Items.RemoveAt(i)

                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvTeste1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeste1.CellContentClick

    End Sub

    Private Sub btnAtualizaLinha_Click(sender As Object, e As EventArgs) Handles btnAtualizaLinha.Click

        Dim index As Integer = dgvTeste1.CurrentRow.Cells(0).RowIndex
        Dim ChavePrimaria As Integer = dgvTeste1(0, index).Value
        Dim obj As New Conectar

        obj.SSQL = "Update Produtos SET NomeDoProduto =" + "'" + dgvTeste1(1, index).Value.ToString() + "'" +
                  ", CódigoDoFornecedor =" + "'" + dgvTeste1(2, index).Value.ToString() + "'" +
                  ", CódigoDaCategoria = " + " '" + dgvTeste1(3, index).Value.ToString() + "'" +
                  ", Existências = " + " '" + dgvTeste1(5, index).Value.ToString() + "'" +
                  ", UnidadesEncomendadas = " + " '" + dgvTeste1(6, index).Value.ToString() + "'" +
                  ", ExistênciaMínima = " + " '" + dgvTeste1(7, index).Value.ToString() + "'" +
                  ", Descontinuado = " + " '" + "true" + "'" + " WHERE CódigoDoProduto =" + ChavePrimaria.ToString() + ";"


        obj.BuscarDados()
        dgvTeste1.DataSource = Nothing
        dgvTeste1.Rows.Clear()
        obj.SSQL = "Select * from Produtos"
        dgvTeste1.DataSource = obj.BuscarDados()




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        dgvTeste1.DataSource = Nothing
        dgvTeste1.Rows.Clear()

        Dim obj As New Conectar

        obj.SSQL = "Select distinct count(*) 
                    From Produtos;"

        dgvTeste1.DataSource = obj.BuscarDados()

        txtContaProdutos.Text = dgvTeste1(0, 0).Value.ToString()

        obj.SSQL = "Select * from Produtos"

        dgvTeste1.DataSource = obj.BuscarDados()
    End Sub

    Private Sub btnInserirDados_Click(sender As Object, e As EventArgs) Handles btnInserirDados.Click
        Dim Descontinuado As Boolean = 1
        Dim obj As New Conectar
        obj.SSQL = "Insert into Produtos (NomeDoProduto, CódigoDoFornecedor, CódigoDaCategoria, PreçoUnitário, Descontinuado)
                        values ('" + txtNomeProduto.Text.ToString() +
                             "','" + txtNomeFornecedor.Text.ToString() +
                             "','" + txtCategoria.Text.ToString() +
                             "','" + txtPreco.Text.ToString() +
                             "','" + Descontinuado.ToString() + "')"


        obj.BuscarDados()
        dgvTeste1.DataSource = Nothing
        dgvTeste1.Rows.Clear()
        obj.SSQL = "Select * from Produtos;"
        dgvTeste1.DataSource = obj.BuscarDados()

        MessageBox.Show("Dados Inseridos com Sucesso")

    End Sub


End Class
