Imports System.Diagnostics
Public Class ShellSort
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

    Public Function Ordenar(ByVal n As Integer)
        Dim aux As Integer
        Dim comparaciones As Integer = 0
        Dim intercambios As Integer = 0
        Dim j As Integer = vector.Length / 2
        Dim x As Integer

        While j > 0
            x = 1
            While x <> 0
                x = 0
                i = 1
                While i <= (vector.Length - j)
                    comparaciones += 1

                    If vector(i - 1) > vector((i - 1) + j) Then
                        aux = vector((i - 1) + j)
                        vector((i - 1) + j) = vector(i - 1)
                        vector(i - 1) = aux
                        x = 1
                        intercambios += 1
                    End If
                    i += 1
                End While
            End While

            j = j / 2 'salto /2... 5/2 = 2
            lblComparaciones.Text = comparaciones.ToString() & " Comparaciones"
            lblIntercambios.Text = intercambios.ToString() & " Intercambios"
        End While

        Return intercambios
    End Function

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

    Private Sub ShellSort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class