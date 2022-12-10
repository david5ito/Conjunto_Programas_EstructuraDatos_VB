Imports System.IO
Public Class Colas

    Dim n As NodoCola
    Dim MiCola As Cola = New Cola()

    Private Sub btnEncolar_Click(sender As Object, e As EventArgs) Handles btnEncolar.Click
        Try
            n = New NodoCola()
            n.myDato = Integer.Parse(txtNodo.Text)
            MiCola.Encolar(n)
            lblCola.Text = MiCola.ToString()
            txtNodo.Clear()
            btnBorrarC.Enabled = True
            btnConsultar.Enabled = True
            btnGuardar.Enabled = True
        Catch
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnDesencolar_Click(sender As Object, e As EventArgs) Handles btnDesencolar.Click
        MiCola.Desencolar()
        lblCola.Text = MiCola.ToString()
    End Sub

    Private Sub btnBorrarC_Click(sender As Object, e As EventArgs) Handles btnBorrarC.Click
        MiCola.head = Nothing
        lblCola.Text = MiCola.ToString()
        btnBorrarC.Enabled = False
        btnConsultar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        MessageBox.Show("El dato frontal es : " & MiCola.Front())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

        If Dialogo.ShowDialog() = DialogResult.OK Then
            Dim dato As String = lblCola.Text
            Dim ruta As String = Dialogo.SelectedPath & "\Cola.txt"

            Using writer = New StreamWriter(ruta)
                writer.Close()
            End Using

            File.WriteAllText(ruta, dato)
            MessageBox.Show("Datos guardados")
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim Seleccionar As OpenFileDialog = New OpenFileDialog()

        If Seleccionar.ShowDialog() = DialogResult.OK Then
            MiCola.myHead = Nothing
            Dim contador As Integer = 0
            Dim ruta As String = Seleccionar.FileName
            Dim linea As String = File.ReadAllText(ruta)
            Dim Lista As String() = linea.Split(", ")

            For Each i As String In Lista
                n = New NodoCola()
                n.myDato = Integer.Parse(Lista(contador))
                MiCola.Encolar(n)
                contador += 1
            Next

            lblCola.Text = MiCola.ToString()
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub Colas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class