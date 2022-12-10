Public Class MenuPrincipal
    Private Sub btnAlgoritmo_Click(sender As Object, e As EventArgs) Handles btnAlgoritmo.Click
        Dim abrir As New MenuAlgoritmos()
        abrir.Show()
        Hide()
    End Sub

    Private Sub btnEstructura_Click(sender As Object, e As EventArgs) Handles btnEstructura.Click
        Dim aperto As New MenuEstructuras()
        aperto.Show()
        Hide()
    End Sub

    Private Sub MenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
