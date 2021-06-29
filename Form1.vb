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
        Try

            For i = 0 To dadosDaGrid
                'If dgvTeste1(1, i).Value.ToString().ToUpper() = nomeProduto Then
                If dgvTeste1(1, i).Value.ToString() = nomeProduto Then
                        dgvTeste1.Rows.RemoveAt(i)
                    End If
            Next

        Catch ex As Exception
            MessageBox.Show("Removeu com Sucesso o produto --->  " + nomeProduto)
        End Try


    End Sub

    Private Sub btnNomesGridToList_Click(sender As Object, e As EventArgs) Handles btnNomesGridToList.Click

        Dim ligacao As New Conectar
        ligacao.SSQL = "Select NomeDoProduto from Produtos"
        ListBox1.DataSource = ligacao.BuscarDados()



        '**********************  Este código passa só o id dos Produtos  ********************************
        'Esta linha não faz falta ---> Dim colunaProduto As String = dgvTeste1.Columns(1).ToString
        'Dim dadosDaGrid As Integer = dgvTeste1.Rows.Count - 1

        'For index = 1 To dadosDaGrid

        '    ListBox1.Items.Add(index)

        'Next

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

End Class
