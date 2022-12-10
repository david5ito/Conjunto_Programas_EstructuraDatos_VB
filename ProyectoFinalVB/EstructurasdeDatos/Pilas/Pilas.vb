Imports System.IO
Public Class Pilas

    Dim MiPila As Pila = New Pila()
    Dim n As NodoPila = New NodoPila()

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim n As NodoPila = New NodoPila(Integer.Parse(txtNodo.Text))
        MiPila.Push(n)
        lblPila.Text = MiPila.ToString()
        txtNodo.Clear()
        btnBorrarP.Enabled = True
        btnContar.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        MiPila.Pop()
        lblPila.Text = MiPila.ToString()
    End Sub

    Private Sub btnBorrarP_Click(sender As Object, e As EventArgs) Handles btnBorrarP.Click
        MiPila.top = Nothing
        lblPila.Text = MiPila.ToString()
        btnBorrarP.Enabled = False
        btnContar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Número de nodos en la Pila: " & MiPila.ContarNodos())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

            If Dialogo.ShowDialog() = DialogResult.OK Then
                Dim dato As String = lblPila.Text
                Dim ruta As String = Dialogo.SelectedPath & "\Pila.txt"

                Using writer = New StreamWriter(ruta)
                    writer.Close()
                End Using

                File.WriteAllText(ruta, dato)
                MessageBox.Show("Datos guardados en el archivo : " & "Pila.txt")
            End If

        Catch
            MessageBox.Show("Error al guardar")
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim Seleccionar As OpenFileDialog = New OpenFileDialog()

            If Seleccionar.ShowDialog() = DialogResult.OK Then
                MiPila.myTop = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = File.ReadAllText(ruta)
                Dim Pila As String() = linea.Split(", ")
                Dim contador As Integer = Pila.Length - 1

                For Each i As String In Pila
                    n = New NodoPila()
                    n.myDato = Integer.Parse(Pila(contador))
                    MiPila.Push(n)
                    contador -= 1
                Next

                lblPila.Text = MiPila.ToString()
            End If

        Catch
            MessageBox.Show("Error al cargar")
            MiPila.myTop = Nothing
            lblPila.Text = MiPila.ToString()
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub Pilas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class