Imports System.Diagnostics
Public Class BubbleSort
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
        Dim aux As Integer
        Dim comparaciones As Integer = 0
        Dim intercambios As Integer = 0
        For i = 1 To vector.Length - 1
            For j As Integer = 0 To vector.Length - 1 - 1
                comparaciones += 1
                If vector(j) > vector(j + 1) Then
                    aux = vector(j)
                    vector(j) = vector(j + 1)
                    vector(j + 1) = aux
                    intercambios += 1
                End If
            Next
        Next
        lblComparaciones.Text = comparaciones.ToString() & " Comparaciones"
        lblIntercambios.Text = intercambios.ToString() & " Intercambios"
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

    Private Sub BubbleSort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class