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

        Dim nomeProduto As String = txtRemoverSelecionado.Text.ToUpper()
        Dim dadosDaGrid As Integer = dgvTeste1.Rows.Count - 1
        Try

            For i = 0 To dadosDaGrid
                If dgvTeste1(1, i).Value.ToString().ToUpper() = nomeProduto Then
                    dgvTeste1.Rows.RemoveAt(i)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Removeu o produto" + nomeProduto)
        End Try


    End Sub
End Class
