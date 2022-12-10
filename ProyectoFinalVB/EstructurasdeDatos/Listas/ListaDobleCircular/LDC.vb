Public Class LDC
    Private head As NodoListas

    Public Property myHead As NodoListas
        Get
            Return head
        End Get
        Set(ByVal value As NodoListas)
            head = value
        End Set
    End Property

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub New(ByVal n As NodoListas)
        head = n
        n.myAnterior = head
        n.mySiguiente = head
    End Sub

    Public Function Agregar(ByVal n As NodoListas) As Boolean
        Dim h As NodoListas = head

        If head Is Nothing Then
            n.myAnterior = n
            n.mySiguiente = n
            head = n
            Return True
        End If

        If BuscarDato(n.myDato) Then
            Return False
        End If

        If n.myDato < head.myDato Then
            head.myAnterior.mySiguiente = n
            n.myAnterior = head.myAnterior
            n.mySiguiente = head
            head.myAnterior = n
            head = n
            Return True
        End If

        Do

            If n.myDato < h.mySiguiente.myDato Then
                Exit Do
            End If

            h = h.mySiguiente
        Loop While h IsNot head

        If n.myDato < h.mySiguiente.myDato Then
            h.mySiguiente.myAnterior = n
            n.myAnterior = h
            n.mySiguiente = h.mySiguiente
            h.mySiguiente = n
        Else
            n.mySiguiente = h
            n.myAnterior = h.myAnterior
            h.myAnterior.mySiguiente = n
            h.myAnterior = n
        End If

        Return True
    End Function

    Public Function Eliminar(ByVal dato As Integer) As Boolean
        If BuscarDato(dato) Then
            Dim h As NodoListas = head

            While h.mySiguiente IsNot head

                If h.myDato = dato Then
                    Exit While
                End If

                h = h.mySiguiente
            End While

            h.myAnterior.mySiguiente = h.mySiguiente
            h.mySiguiente.myAnterior = h.mySiguiente

            If h Is head Then
                head = head.mySiguiente
            End If

            Return True
        End If

        Return False
    End Function

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim h As NodoListas = head

        If h IsNot Nothing Then

            Do
                lista += h.myDato & ", "
                h = h.mySiguiente
            Loop While h IsNot head

            lista += "."
            lista = lista.Replace(", .", "")
            Return lista
        Else
            Return "La lista está vacía"
        End If
    End Function

    Public Function BuscarDato(ByVal a As Integer) As Boolean
        Dim h As NodoListas = head

        If h IsNot Nothing Then
            Do
                If h.myDato = a Then
                    Return True
                End If
                h = h.mySiguiente
            Loop While h IsNot head
        End If
        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        Dim h As NodoListas = head

        Do
            contador += 1
            h = h.mySiguiente
        Loop While h IsNot head

        Return contador
    End Function
End Class
