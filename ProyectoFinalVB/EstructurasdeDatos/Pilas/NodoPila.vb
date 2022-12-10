Public Class NodoPila
    Private dato As Integer

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Private siguiente As NodoPila

    Public Property mySiguiente As NodoPila
        Get
            Return siguiente
        End Get
        Set(ByVal value As NodoPila)
            siguiente = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal d As Integer)
        dato = d
        siguiente = Nothing
    End Sub

    Public Sub New(ByVal d As Integer, ByVal s As NodoPila)
        dato = d
        siguiente = s
    End Sub

    Public Sub New(ByVal n As NodoPila)
        dato = n.dato
        siguiente = n.siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
