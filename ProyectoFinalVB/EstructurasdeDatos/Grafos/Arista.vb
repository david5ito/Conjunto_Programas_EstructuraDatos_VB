Imports InputKey
Public Class Arista
    Private origen As Integer
    Private destino As Integer
    Private peso As Integer
    Private tipo As Integer

    Public Sub llenaArista(ByVal ori As Integer, ByVal des As Integer, ByVal pes As Integer, ByVal tip As Integer)
        origen = ori
        destino = des
        peso = Convert.ToInt32(InputDialog.mostrar("Cual es el peso de la Arista?"))
        tipo = tip
    End Sub

    Public Function getOrigen() As Integer
        Return origen
    End Function

    Public Function getDestino() As Integer
        Return destino
    End Function

    Public Function getPeso() As Integer
        Return peso
    End Function

    Public Function getTipo() As Integer
        Return tipo
    End Function
End Class
