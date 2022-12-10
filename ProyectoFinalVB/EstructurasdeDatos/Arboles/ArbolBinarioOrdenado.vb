Public Class ArbolBinarioOrdenado
    Public pre_orden As String
    Public post_orden As String
    Public en_orden As String

    Class Nodo
        Public info As Integer
        Public izq, der As Nodo
    End Class

    Private raiz As Nodo

    Public Sub New()
        raiz = Nothing
    End Sub

    Public Sub Insertar(ByVal info As Integer)
        Dim nuevo As Nodo
        nuevo = New Nodo()
        nuevo.info = info
        nuevo.izq = Nothing
        nuevo.der = Nothing

        If raiz Is Nothing Then
            raiz = nuevo
        Else
            Dim reco As Nodo, anterior As Nodo = Nothing
            reco = raiz

            While reco IsNot Nothing
                anterior = reco

                If info < reco.info Then
                    reco = reco.izq
                Else
                    reco = reco.der
                End If
            End While

            If info < anterior.info Then
                anterior.izq = nuevo
            Else
                anterior.der = nuevo
            End If
        End If
    End Sub

    Private Sub PostOrden(ByVal reco As Nodo)
        If reco IsNot Nothing Then
            post_orden += reco.info & " "
            PostOrden(reco.izq)
            PostOrden(reco.der)
        End If
    End Sub

    Public Sub PostOrden()
        PostOrden(raiz)
    End Sub

    Private Sub PreOrden(ByVal reco As Nodo)
        If reco IsNot Nothing Then
            PreOrden(reco.izq)
            pre_orden += reco.info & " "
            PreOrden(reco.der)
        End If
    End Sub

    Public Sub PreOrden()
        PreOrden(raiz)
    End Sub

    Private Sub EnOrden(ByVal reco As Nodo)
        If reco IsNot Nothing Then
            EnOrden(reco.izq)
            EnOrden(reco.der)
            en_orden += reco.info & " "
        End If
    End Sub

    Public Sub EnOrden()
        EnOrden(raiz)
    End Sub
End Class
