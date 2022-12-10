Public Class NodoGrafo
    Public aristas As List(Of Arista) = New List(Of Arista)()
    Private posx As Integer
    Private posy As Integer
    Private nombre As Integer

    Public Sub llenaNodo(ByVal x As Integer, ByVal y As Integer)
        posx = x
        posy = y
    End Sub

    Public Sub llenanombre(ByVal nomb As Integer)
        nombre = nomb
    End Sub

    Public Function getnombre() As Integer
        Return nombre
    End Function

    Public Function getX() As Integer
        Return posx
    End Function

    Public Function getY() As Integer
        Return posy
    End Function

    Public Sub llenararista(ByVal ar As Arista)
        aristas.Add(ar)
    End Sub
End Class
