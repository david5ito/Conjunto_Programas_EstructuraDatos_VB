Public Class MenuListas
    Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
        Dim wolyoil As New ListaSimple()
        wolyoil.Show()
        Hide()
    End Sub

    Private Sub btnSCircular_Click(sender As Object, e As EventArgs) Handles btnSCircular.Click
        Dim hwayoil As New ListaSimpleCircular()
        hwayoil.Show()
        Hide()
    End Sub

    Private Sub btnDoble_Click(sender As Object, e As EventArgs) Handles btnDoble.Click
        Dim suyoil As New ListaDoble()
        suyoil.Show()
        Hide()
    End Sub

    Private Sub btnDCircular_Click(sender As Object, e As EventArgs) Handles btnDCircular.Click
        Dim mokyoil As New ListaDobleCircular()
        mokyoil.Show()
        Hide()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub MenuListas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class