Public Class NodoListas
    Private dato As Integer
    Private siguiente As NodoListas
    Private anterior As NodoListas

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Public Property mySiguiente As NodoListas
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoListas)
            siguiente = value
        End Set
    End Property

    Public Property myAnterior As NodoListas
        Get
            Return anterior
        End Get
        Set(ByVal value As NodoListas)
            anterior = value
        End Set
    End Property

    Public Sub New(ByVal dato As Integer, ByVal siguiente As NodoListas, ByVal anterior As NodoListas)
        Me.dato = dato
        Me.siguiente = siguiente
        Me.anterior = anterior
    End Sub

    Public Sub New()
        dato = 0
        siguiente = Nothing
        anterior = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
