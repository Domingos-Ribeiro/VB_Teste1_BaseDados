Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ligacao As New Conectar
        dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ligacao As New Conectar
        ligacao.SSQL = "Select * from Produtos"
        dgvTeste1.DataSource = ligacao.BuscarDados()
    End Sub
End Class
