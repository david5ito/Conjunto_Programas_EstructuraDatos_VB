Public Class NodoArbol
    Private info As Integer

    Public Property myInfo As Integer
        Get
            Return info
        End Get
        Set(ByVal value As Integer)
            info = value
        End Set
    End Property

    Public nIzquierdo As NodoArbol
    Public nDerecho As NodoArbol
    Public nPadre As NodoArbol
    Public altura As Integer
    Public nivel As Integer
    Public suma As Integer = 0
    Private arbol As ArbolBinario

    Public Sub New()
    End Sub

    Public Property myArbol As ArbolBinario
        Get
            Return arbol
        End Get
        Set(ByVal value As ArbolBinario)
            arbol = value
        End Set
    End Property

    Public Sub New(ByVal nueva_info As Integer, ByVal izquierdo As NodoArbol, ByVal derecho As NodoArbol, ByVal padre As NodoArbol)
        info = nueva_info
        nIzquierdo = izquierdo
        nDerecho = derecho
        nPadre = padre
        altura = 0
    End Sub

    Public Function Insertar(ByVal x As Integer, ByVal t As NodoArbol, ByRef Level As Integer) As NodoArbol
        If t Is Nothing Then
            t = New NodoArbol(x, Nothing, Nothing, Nothing)
            t.nivel = Level
            t.altura = Alturas(t)
        ElseIf x < t.info Then
            Level += 1
            t.nIzquierdo = Insertar(x, t.nIzquierdo, Level)
        ElseIf x > t.info Then
            Level += 1
            t.nDerecho = Insertar(x, t.nDerecho, Level)
        Else
            MessageBox.Show("Dato Existente en el Árbol", "Error de Ingreso")
        End If

        Return t
    End Function

    Private Shared Function Alturas(ByVal t As NodoArbol) As Integer
        Return If(t Is Nothing, -1, t.altura)
    End Function

    Public Sub Eliminar(ByVal x As Integer, ByRef t As NodoArbol)
        If t IsNot Nothing Then

            If x < t.info Then
                Eliminar(x, t.nIzquierdo)
            Else

                If x > t.info Then
                    Eliminar(x, t.nDerecho)
                Else
                    Dim NodoEliminar As NodoArbol = t

                    If NodoEliminar.nDerecho Is Nothing Then
                        t = NodoEliminar.nIzquierdo
                    Else

                        If NodoEliminar.nIzquierdo Is Nothing Then
                            t = NodoEliminar.nDerecho
                        Else

                            If (Alturas(t.nIzquierdo) - Alturas(t.nDerecho)) > 0 Then
                                Dim AuxiliarNodo As NodoArbol = Nothing
                                Dim Auxiliar As NodoArbol = t.nIzquierdo
                                Dim Bandera As Boolean = False

                                While Auxiliar.nDerecho IsNot Nothing
                                    AuxiliarNodo = Auxiliar
                                    Auxiliar = Auxiliar.nDerecho
                                    Bandera = True
                                End While

                                t.info = Auxiliar.info
                                NodoEliminar = Auxiliar

                                If Bandera = True Then
                                    AuxiliarNodo.nDerecho = Auxiliar.nIzquierdo
                                Else
                                    t.nIzquierdo = Auxiliar.nIzquierdo
                                End If
                            Else

                                If (Alturas(t.nDerecho) - Alturas(t.nIzquierdo)) > 0 Then
                                    Dim AuxiliarNodo As NodoArbol = Nothing
                                    Dim Auxiliar As NodoArbol = t.nDerecho
                                    Dim Bandera As Boolean = False

                                    While Auxiliar.nIzquierdo IsNot Nothing
                                        AuxiliarNodo = Auxiliar
                                        Auxiliar = Auxiliar.nIzquierdo
                                        Bandera = True
                                    End While

                                    t.info = Auxiliar.info
                                    NodoEliminar = Auxiliar

                                    If Bandera = True Then
                                        AuxiliarNodo.nIzquierdo = Auxiliar.nDerecho
                                    Else
                                        t.nDerecho = Auxiliar.nDerecho
                                    End If
                                Else

                                    If Alturas(t.nDerecho) - Alturas(t.nIzquierdo) = 0 Then
                                        Dim AuxiliarNodo As NodoArbol = Nothing
                                        Dim Auxiliar As NodoArbol = t.nIzquierdo
                                        Dim Bandera As Boolean = False

                                        While Auxiliar.nDerecho IsNot Nothing
                                            AuxiliarNodo = Auxiliar
                                            Auxiliar = Auxiliar.nDerecho
                                            Bandera = True
                                        End While

                                        t.info = Auxiliar.info
                                        NodoEliminar = Auxiliar

                                        If Bandera = True Then
                                            AuxiliarNodo.nDerecho = Auxiliar.nIzquierdo
                                        Else
                                            t.nIzquierdo = Auxiliar.nIzquierdo
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MessageBox.Show("Nodo NO Existente en el Árbol", "Error de Eliminación")
        End If
    End Sub

    Public Function buscar(ByVal x As Integer, ByRef t As NodoArbol) As NodoArbol
        If t IsNot Nothing Then

            If x < t.info Then
                buscar(x, t.nIzquierdo)
            Else

                If x > t.info Then
                    buscar(x, t.nDerecho)
                Else
                    Return t
                End If
            End If
        Else
            MessageBox.Show("Nodo NO Encontrado en el Árbol", " Error de Búsqueda")
        End If

        Return Nothing
    End Function

    Private Const Radio As Integer = 30
    Private Const DistanciaH As Integer = 80
    Private Const DistanciaV As Integer = 10
    Private CoordenadaX As Integer
    Private CoordenadaY As Integer

    Public Sub PosicionNodo(ByRef xmin As Integer, ByVal ymin As Integer)
        Dim aux1, aux2 As Integer
        CoordenadaY = CInt((ymin + Radio / 2))

        If nIzquierdo IsNot Nothing Then
            nIzquierdo.PosicionNodo(xmin, ymin + Radio + DistanciaV)
        End If

        If (nIzquierdo IsNot Nothing) AndAlso (nDerecho IsNot Nothing) Then
            xmin += DistanciaH
        End If

        If nDerecho IsNot Nothing Then
            nDerecho.PosicionNodo(xmin, ymin + Radio + DistanciaV)
        End If

        If nIzquierdo IsNot Nothing AndAlso nDerecho IsNot Nothing Then
            CoordenadaX = CInt(((nIzquierdo.CoordenadaX + nDerecho.CoordenadaX) / 2))
        ElseIf nIzquierdo IsNot Nothing Then
            aux1 = nIzquierdo.CoordenadaX
            nIzquierdo.CoordenadaX = CoordenadaX - 80
            CoordenadaX = aux1
        ElseIf nDerecho IsNot Nothing Then
            aux2 = nDerecho.CoordenadaX
            nDerecho.CoordenadaX = CoordenadaX + 80
            CoordenadaX = aux2
        Else
            CoordenadaX = CInt((xmin + Radio / 2))
            xmin += Radio
        End If
    End Sub

    Public Sub DibujarRamas(ByVal grafo As Graphics, ByVal Lapiz As Pen)
        If nIzquierdo IsNot Nothing Then
            grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, nIzquierdo.CoordenadaX, nIzquierdo.CoordenadaY)
            nIzquierdo.DibujarRamas(grafo, Lapiz)
        End If

        If nDerecho IsNot Nothing Then
            grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, nDerecho.CoordenadaX, nDerecho.CoordenadaY)
            nDerecho.DibujarRamas(grafo, Lapiz)
        End If
    End Sub

    Public Sub DibujarNodo(ByVal grafo As Graphics, ByVal fuente As Font, ByVal Relleno As Brush, ByVal RellenoFuente As Brush, ByVal Lapiz As Pen, ByVal encuentro As Brush, ByVal i As Integer, ByVal m As Integer, ByVal max As Integer, ByVal min As Integer)
        Dim rect As Rectangle = New Rectangle(CInt((CoordenadaX - Radio / 2)), CInt((CoordenadaY - Radio / 2)), Radio, Radio)

        If max = info Then
            grafo.FillEllipse(Brushes.Green, rect)
        ElseIf min = info Then
            grafo.FillEllipse(Brushes.Red, rect)
        ElseIf i = info Then
            grafo.FillEllipse(encuentro, rect)
        ElseIf m <> 0 Then

            If info Mod m = 0 Then
                grafo.FillEllipse(Brushes.Red, rect)
                suma = suma + info
            Else
                grafo.FillEllipse(Relleno, rect)
            End If
        Else
            grafo.FillEllipse(Relleno, rect)
        End If

        grafo.DrawEllipse(Lapiz, rect)
        Dim formato As StringFormat = New StringFormat()
        formato.Alignment = StringAlignment.Center
        formato.LineAlignment = StringAlignment.Center
        grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato)

        If nIzquierdo IsNot Nothing Then
            nIzquierdo.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro, i, m, max, min)
        End If

        If nDerecho IsNot Nothing Then
            nDerecho.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro, i, m, max, min)
        End If
    End Sub

    Public Sub colorear(ByVal grafo As Graphics, ByVal fuente As Font, ByVal Relleno As Brush, ByVal RellenoFuente As Brush, ByVal Lapiz As Pen)
        Dim rect As Rectangle = New Rectangle(CInt((CoordenadaX - Radio / 2)), CInt((CoordenadaY - Radio / 2)), Radio, Radio)
        Dim prueba As Rectangle = New Rectangle(CInt((CoordenadaX - Radio / 2)), CInt((CoordenadaY - Radio / 2)), Radio, Radio)
        grafo.FillEllipse(Relleno, rect)
        grafo.DrawEllipse(Lapiz, rect)
        Dim formato As StringFormat = New StringFormat()
        formato.Alignment = StringAlignment.Center
        formato.LineAlignment = StringAlignment.Center
        grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato)
    End Sub
End Class
