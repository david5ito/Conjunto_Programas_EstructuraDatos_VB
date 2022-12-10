Public Class LS
    Private head As NodoListas

    Public Property myHead As NodoListas
        Get
            Return head
        End Get
        Set(ByVal Value As NodoListas)
            head = Value
        End Set
    End Property

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub New(ByVal n As NodoListas)
        head = n
    End Sub

    Public Sub Agregar(ByVal n As NodoListas)
        If head Is Nothing Then
            head = n
            Return
        End If

        If n.myDato < head.myDato Then
            n.mySiguiente = head
            head = n
            Return
        End If

        Dim h As NodoListas = head

        While h.mySiguiente IsNot Nothing

            If h.mySiguiente.myDato > n.myDato Then
                Exit While
            End If

            h = h.mySiguiente
        End While

        If h.mySiguiente IsNot Nothing Then
            n.mySiguiente = h.mySiguiente
            h.mySiguiente = n
            Return
        End If

        h.mySiguiente = n
    End Sub

    Public Sub Eliminar(ByVal dato As Integer)
        If head IsNot Nothing Then

            If head.myDato = dato Then
                head = head.mySiguiente
                Return
            End If

            Dim h As NodoListas = head

            While h.mySiguiente IsNot Nothing

                If h.mySiguiente.myDato = dato Then
                    h.mySiguiente = h.mySiguiente.mySiguiente
                    Return
                End If

                h = h.mySiguiente
            End While
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim h As NodoListas = head

        If h IsNot Nothing Then
            lista += h.ToString()
            h = h.mySiguiente

            While h IsNot Nothing
                lista += "," & h.ToString()
                h = h.mySiguiente
            End While

            Return lista
        Else
            Return "La lista esta vacia"
        End If
    End Function

    Public Function BuscarDato(ByVal a As Integer) As Boolean
        Dim h As NodoListas = head

        If h IsNot Nothing Then

            While h IsNot Nothing

                If h.myDato = a Then
                    Return True
                End If

                h = h.mySiguiente
            End While
        End If
        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        Dim h As NodoListas = head

        While h IsNot Nothing
            contador += 1
            h = h.mySiguiente
        End While

        Return contador
    End Function
End Class
