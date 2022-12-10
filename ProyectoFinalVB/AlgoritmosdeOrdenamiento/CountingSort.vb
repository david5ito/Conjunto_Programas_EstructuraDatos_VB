Imports System.Diagnostics

Public Class CountingSort
    Dim vector As Integer()
    Dim Ordenado As Integer()
    Dim n As Integer
    Dim max As Integer
    Dim min As Integer
    Dim i As Integer
    Dim contador As Stopwatch = New Stopwatch()

    Public Sub GenerarDatos(ByVal n As Integer, ByVal min As Integer, ByVal max As Integer)
        vector = New Integer(n - 1) {}
        Dim aleatorio As Random = New Random()

        For j = 0 To vector.Length - 1
            vector(j) = aleatorio.[Next](min, max)
        Next
    End Sub

    Public Sub Ordenar(ByVal n As Integer)
        Dim aux As Integer() = New Integer(vector.Length - 1) {}
        Dim valorMayor As Integer = 0

        For h As Integer = 0 To vector.Length - 1
            If vector(h) > valorMayor Then
                valorMayor = vector(h)
            End If
        Next

        aux = New Integer(valorMayor + 1 - 1) {}

        For o As Integer = 0 To vector.Length - 1
            Dim posicion As Integer = vector(o)
            aux(posicion) += 1
        Next

        For l As Integer = 1 To aux.Length - 1
            aux(l) = aux(l - 1) + aux(l)
        Next

        Dim i As Integer = aux.Length - 1

        While i <> 0
            aux(i) = aux(i - 1)
            i -= 1
        End While

        aux(0) = 0
        Ordenado = New Integer(vector.Length - 1) {}

        For s As Integer = 0 To vector.Length - 1
            Dim valor As Integer = vector(s)
            Dim posicion As Integer = aux(valor)
            Ordenado(posicion) = valor
            aux(valor) += 1
        Next
    End Sub

    Public Function Mostrar(ByVal arreglo As Integer()) As String
        Dim colaString As String
        colaString = arreglo(0)
        For z As Integer = 0 To arreglo.Length - 1 - 1
            colaString += "," & arreglo(z + 1)
        Next
        Return colaString
    End Function

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            lblGenerado.Text = "0"
            lblOrdenado.Text = "0"
            lblTiempo.Text = "0:0"
            n = Integer.Parse(txtNum.Text)
            min = Integer.Parse(txtMin.Text)
            max = Integer.Parse(txtMax.Text)
            GenerarDatos(n, min, max)
            lblGenerado.Text = Mostrar(vector)
            btnGenerar.Enabled = False
            btnOrdenar.Enabled = True
            txtNum.Clear()
            txtMin.Clear()
            txtMax.Clear()
        Catch
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        contador.Restart()
        Ordenar(n)
        contador.Stop()
        lblTiempo.Text = contador.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        lblOrdenado.Text = Mostrar(Ordenado)
        btnGenerar.Enabled = True
        btnOrdenar.Enabled = False
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub CountingSort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class