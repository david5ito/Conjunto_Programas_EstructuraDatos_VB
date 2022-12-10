Public Class Pila
    Public top As NodoPila

    Public Property myTop As NodoPila
        Get
            Return top
        End Get
        Set(value As NodoPila)
            top = value
        End Set
    End Property

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        Dim h As NodoPila = top

        While h IsNot Nothing
            contador += 1
            h = h.mySiguiente
        End While

        Return contador
    End Function

    Public Sub Pila()
        top = Nothing
    End Sub

    Public Sub Push(n As NodoPila)
        n.mySiguiente = top
        top = n
    End Sub

    Public Function Pop() As NodoPila
        Dim regreso As NodoPila = Nothing

        If top IsNot Nothing Then
            top = top.mySiguiente
        End If

        Return regreso
    End Function

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim t As NodoPila = top

        If t IsNot Nothing Then
            lista += t.ToString()
            t = t.mySiguiente

            While t IsNot Nothing
                lista += "," & t.ToString()
                t = t.mySiguiente
            End While

            lista += "."
            lista = lista.Replace(".", "")
            Return lista
        Else
            Return "La lista esta vacia"
        End If
    End Function
End Class
