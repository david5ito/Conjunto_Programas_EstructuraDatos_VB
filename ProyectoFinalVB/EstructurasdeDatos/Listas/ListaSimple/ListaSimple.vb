Imports System.IO
Public Class ListaSimple
    Public n As NodoListas
    Public MiLista As LS = New LS()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If Not MiLista.BuscarDato(Integer.Parse(txtNodo.Text)) Then
                n = New NodoListas()
                n.myDato = Integer.Parse(txtNodo.Text)
                MiLista.Agregar(n)
                lblLista.Text = MiLista.ToString()
                txtNodo.Clear()
                btnBorrarL.Enabled = True
                btnContar.Enabled = True
                btnGuardar.Enabled = True
                Return
            End If

            MessageBox.Show("El dato ya existe en la lista")
            txtNodo.Clear()
        Catch
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim dato As Integer = Integer.Parse(txtNodo.Text)

            If Not MiLista.BuscarDato(dato) Then
                MessageBox.Show("No se encontró el dato")
                lblLista.Text = MiLista.ToString()
                Return
            End If

            MiLista.Eliminar(dato)
            lblLista.Text = MiLista.ToString()
            txtNodo.Clear()
        Catch
            MessageBox.Show("Introduzca un número válido.")
        End Try
    End Sub

    Private Sub btnBorrarL_Click(sender As Object, e As EventArgs) Handles btnBorrarL.Click
        MiLista.myHead = Nothing
        lblLista.Text = MiLista.ToString()
        btnBorrarL.Enabled = False
        btnContar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de nodos en la lista: " & MiLista.ContarNodos())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Dialogo As FolderBrowserDialog = New FolderBrowserDialog()

        If Dialogo.ShowDialog() = DialogResult.OK Then
            Dim dato As String = lblLista.Text
            Dim ruta As String = Dialogo.SelectedPath & "\Lista.txt"

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
            MiLista.myHead = Nothing
            Dim contador As Integer = 0
            Dim ruta As String = Seleccionar.FileName
            Dim linea As String = File.ReadAllText(ruta)
            Dim Lista As String() = linea.Split(", ")

            For Each i As String In Lista
                n = New NodoListas()
                n.myDato = Integer.Parse(Lista(contador))
                MiLista.Agregar(n)
                contador += 1
            Next

            lblLista.Text = MiLista.ToString()
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub ListaSimple_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class