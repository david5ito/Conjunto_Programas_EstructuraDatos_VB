Public Class NodoCola
    Public dato As Integer
    Public siguiente As NodoCola

    Public Property myDato As Integer
        Get
            Return dato
        End Get
        Set(value As Integer)
            dato = value
        End Set
    End Property

    Public Property mySiguiente As NodoCola
        Get
            Return siguiente
        End Get
        Set(value As NodoCola)
            siguiente = value
        End Set
    End Property

    Public Sub New()
        dato = 0
        siguiente = Nothing
    End Sub

    Public Sub New(dato As Integer, siguiente As NodoCola)
        Me.dato = dato
        Me.siguiente = siguiente
    End Sub

    Public Overrides Function ToString() As String
        Return dato & ""
    End Function
End Class
