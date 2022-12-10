Public Class Cola
    Public head As NodoCola

    Public Property myHead As NodoCola
        Get
            Return head
        End Get
        Set(ByVal value As NodoCola)
            head = value
        End Set
    End Property

    Public tail As NodoCola

    Public Property myTail As NodoCola
        Get
            Return head
        End Get
        Set(ByVal value As NodoCola)
            head = value
        End Set
    End Property

    Public Sub New()
        head = Nothing
        tail = Nothing
    End Sub

    Public Sub Encolar(n As NodoCola)
        If head Is Nothing Then
            head = n
            tail = n
        Else
            tail.siguiente = n
            tail = n
        End If
    End Sub

    Public Sub Desencolar()
        If head Is tail Then
            head = Nothing
            tail = Nothing
            Return
        End If

        head = head.siguiente
    End Sub

    Public Function Front() As Integer
        Return head.dato
    End Function

    Public Overrides Function ToString() As String
        Dim stringCola As String = ""
        Dim h As NodoCola = head

        If h IsNot Nothing Then
            stringCola += h.ToString()
            h = h.siguiente

            While h IsNot Nothing
                stringCola += "," & h.ToString()
                h = h.siguiente
            End While

            Return stringCola
        Else
            Return "La lista esta vacia"
        End If
    End Function
End Class
