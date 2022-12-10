Imports System.Diagnostics
Public Class RadixSort
    Dim vector As Integer()
    Dim n As Integer
    Dim max As Integer
    Dim min As Integer
    Dim i As Integer
    Dim contador As Stopwatch = New Stopwatch()

    Public Sub GenerarDatos(ByVal n As Integer, ByVal min As Integer, ByVal max As Integer)
        vector = New Integer(n - 1) {}
        Dim aleatorio As Random = New Random()
        For i = 0 To vector.Length - 1
            vector(i) = aleatorio.[Next](min, max)
        Next
    End Sub

    Public Sub Ordenar(ByVal n As Integer)
        Dim aux As Integer() = New Integer(vector.Length - 1) {}
        Dim count As Integer() = New Integer(1 << min) {}
        Dim pref As Integer() = New Integer(1 << min) {}
        Dim groups As Integer = CInt(Math.Ceiling(CDbl(max) / CDbl(min)))
        Dim mask As Integer = (1 << min) - 1

        Dim c As Integer = 0, shift As Integer = 0

        While c < groups
            For j As Integer = 0 To count.Length - 1
                count(j) = 0
            Next

            For i As Integer = 0 To vector.Length - 1
                count(vector(i) >> shift And mask) += 1
            Next

            pref(0) = 0

            For i As Integer = 1 To count.Length - 1
                pref(i) = pref(i - 1) + count(i - 1)
            Next

            For i As Integer = 0 To vector.Length - 1
                aux(Math.Min(Threading.Interlocked.Increment(pref(vector(i) >> shift And mask)), pref(vector(i) >> shift And mask) - 1)) = vector(i)
            Next

            aux.CopyTo(vector, 0)
            c += 1
            shift += min
        End While


    End Sub

    Public Sub Mostrar(ByVal l As ListBox)
        For i = 0 To vector.Length - 1
            l.Items.Add(vector(i))
        Next
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            lbNum.Items.Clear()
            lbOrd.Items.Clear()
            n = Integer.Parse(txtNum.Text)
            min = Integer.Parse(txtMin.Text)
            max = Integer.Parse(txtMax.Text)
            GenerarDatos(n, min, max)
            Mostrar(lbNum)
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
        lblOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        Mostrar(lbOrd)
        btnGenerar.Enabled = True
        btnOrdenar.Enabled = False
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub RadixSort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class