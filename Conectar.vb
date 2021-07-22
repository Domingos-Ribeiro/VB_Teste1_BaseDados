Imports System.Data.SqlClient

Public Class Conectar

    Private StringConection As String =
        "Data Source = DOMINGOS\SQLEXPRESS;" +
        "Initial Catalog = adamastor2;" +
        "user id= sa;" +
        "password=123.Abc.@;"


    Public SSQL As String = "select * from Produtos;"




    Public Function BuscarDados() As DataTable
        Dim conexao As SqlConnection = New SqlConnection(StringConection)
        conexao.Open()
        Dim comando As SqlCommand = New SqlCommand(SSQL, conexao)
        Dim adpt As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        adpt.fill(dt)
        conexao.Close()
        Return dt

    End Function

End Class