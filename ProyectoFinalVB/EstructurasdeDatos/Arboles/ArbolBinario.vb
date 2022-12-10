Imports System.Threading

Public Class ArbolBinario
    Private valor As String = ""

    Public Property myValor As String
        Get
            Return valor
        End Get
        Set(ByVal value As String)
            valor = value
        End Set
    End Property

    Public Raiz As NodoArbol
    Public aux As NodoArbol

    Public Sub New()
        aux = New NodoArbol()
    End Sub

    Public Sub New(ByVal nueva_raiz As NodoArbol)
        Raiz = nueva_raiz
    End Sub

    Public altura As Integer = 0

    Public Sub Insertar(ByVal x As Integer)
        If Raiz Is Nothing Then
            Raiz = New NodoArbol(x, Nothing, Nothing, Nothing)
            Raiz.nivel = 0
        Else
            Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel)
            altura = Raiz.nivel
        End If
    End Sub

    Public Sub Eliminar(ByVal x As Integer)
        If Raiz Is Nothing Then
            Raiz = New NodoArbol(x, Nothing, Nothing, Nothing)
        Else
            Raiz.Eliminar(x, Raiz)
        End If
    End Sub

    Public Function RaizArbol() As NodoArbol
        Dim t As NodoArbol = New NodoArbol()
        Return Raiz
    End Function

    Public Function Buscar(ByVal x As Integer) As NodoArbol
        Dim n As NodoArbol = New NodoArbol()

        If Raiz Is Nothing Then
            Raiz = New NodoArbol(x, Nothing, Nothing, Nothing)
        Else
            n = Raiz.buscar(x, Raiz)
        End If

        Return n
    End Function

    Public Sub DibujarArbol(ByVal grafo As Graphics, ByVal fuente As Font, ByVal Relleno As Brush, ByVal RellenoFuente As Brush, ByVal Lapiz As Pen, ByVal encuentro As Brush, ByVal i As Integer, ByVal m As Integer, ByVal max As Integer, ByVal min As Integer)
        Dim x As Integer = 400
        Dim y As Integer = 75
        If Raiz Is Nothing Then Return
        Raiz.PosicionNodo(x, y)
        Raiz.DibujarRamas(grafo, Lapiz)
        Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro, i, m, max, min)
    End Sub

    Public x1 As Integer = 400
    Public y2 As Integer = 75

    Public Sub Colorear(ByVal grafo As Graphics, ByVal fuente As Font, ByVal Relleno As Brush, ByVal RellenoFuente As Brush, ByVal Lapiz As Pen, ByVal Raiz As NodoArbol, ByVal post As Boolean, ByVal inor As Boolean, ByVal preor As Boolean)
        Dim entorno As Brush = Brushes.Blue

        If inor = True Then

            If Raiz IsNot Nothing Then
                Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nIzquierdo, post, inor, preor)
                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz)
                Thread.Sleep(1000)
                Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz)
                Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nDerecho, post, inor, preor)
            End If
        ElseIf preor = True Then

            If Raiz IsNot Nothing Then
                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz)
                Thread.Sleep(1000)
                Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz)
                Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nIzquierdo, post, inor, preor)
                Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nDerecho, post, inor, preor)
            End If
        ElseIf post = True Then

            If Raiz IsNot Nothing Then
                Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nIzquierdo, post, inor, preor)
                Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.nDerecho, post, inor, preor)
                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz)
                Thread.Sleep(1000)
                Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz)
            End If
        Else
            Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz)
            valor += Raiz.myInfo & ""
            Thread.Sleep(1000)
            Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz)
        End If
    End Sub
End Class
