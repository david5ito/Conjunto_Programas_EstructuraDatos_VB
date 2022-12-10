Public Class MenuEstructuras
    Private Sub btnListas_Click(sender As Object, e As EventArgs) Handles btnListas.Click
        Dim hana As New MenuListas()
        hana.Show()
        Hide()
    End Sub

    Private Sub btnPila_Click(sender As Object, e As EventArgs) Handles btnPila.Click
        Dim dul As New Pilas()
        dul.Show()
        Hide()
    End Sub

    Private Sub Cola_Click(sender As Object, e As EventArgs) Handles Cola.Click
        Dim tres = New Colas()
        tres.Show()
        Hide()
    End Sub

    Private Sub btnGrafo_Click(sender As Object, e As EventArgs) Handles btnGrafo.Click
        Dim Net As New Grafos()
        Net.Show()
        Hide()
    End Sub

    Private Sub btnArbol_Click(sender As Object, e As EventArgs) Handles btnArbol.Click
        Dim daseot As New Arbol()
        daseot.Show()
        Hide()
    End Sub

    Private Sub MenuEstructuras_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class