Imports System.IO
Public Class Arbol

    Private r As String = ""
    Private arreglo As String()
    Private Dato As Integer = 0
    Private massimo As Integer = 0
    Private minino As Integer = 0
    Private miArbol As ArbolBinario = New ArbolBinario(Nothing)
    Private g As Graphics
    Private enc As Integer = 0
    Private multiplo As Integer = 0
    Private iden As Boolean = False
    Private enor As Boolean = False
    Private preor As Boolean = False
    Private posor As Boolean = False
    Private alt As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNodo.Text = "" Then
            MessageBox.Show("Debe ingresar un valor ")
        Else
            Dato = Integer.Parse(txtNodo.Text)
            r += Dato.ToString() & " "

            If massimo = 0 Then
                massimo = Dato
                minino = Dato
            Else

                If massimo < Dato Then
                    massimo = Dato
                End If

                If minino > Dato Then
                    minino = Dato
                End If
            End If

            If Dato <= 0 OrElse Dato >= 100 Then
                MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso")
            Else
                miArbol.Insertar(Dato)
                txtNodo.Clear()
                txtNodo.Focus()
                enc = 0
                Refresh()
                Refresh()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtNodo.Text = "" Then
            MessageBox.Show("Debe ingresar un valor ")
        Else
            Dato = Integer.Parse(txtNodo.Text)
            miArbol.Eliminar(Dato)
            txtNodo.Clear()
            txtNodo.Focus()
            enc = 0
            Refresh()
            Refresh()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtNodo.Text = "" Then
            MessageBox.Show("Debe Ingresar un Valor")
        Else
            Dato = Integer.Parse(txtNodo.Text)
            enc = Dato
            miArbol.Buscar(Dato)
            txtNodo.Clear()
            txtNodo.Focus()
            Refresh()
            Refresh()
        End If
    End Sub

    Private Sub btnRecorrer_Click(sender As Object, e As EventArgs) Handles btnRecorrer.Click
        Dim tamano As Integer = (r.Length) / 2
        arreglo = r.Split(" "c)
        Dim abo As ArbolBinarioOrdenado = New ArbolBinarioOrdenado()

        For i As Integer = 0 To arreglo.Length - 1 - 1
            abo.Insertar(Int32.Parse(arreglo(i)))
        Next

        If rbtnOrden.Checked = True Then
            preor = True
            abo.PreOrden()
        ElseIf rbtnPreOrden.Checked = True Then
            posor = True
            abo.PostOrden()
        ElseIf rbtnPostOrden.Checked = True Then
            enor = True
            abo.EnOrden()
        End If

        Refresh()
        Refresh()
    End Sub

    Private Sub btnIdentificar_Click(sender As Object, e As EventArgs) Handles btnIdentificar.Click
        iden = True
        Refresh()
    End Sub

    Private Sub btnAltura_Click(sender As Object, e As EventArgs) Handles btnAltura.Click
        alt = True
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim DatosGuardados As String = File.ReadAllText(openFileDialog1.FileName)
            Dim arreglo As String() = DatosGuardados.Split()
            Dim arregloborrar As String() = r.Split()

            For i As Integer = 0 To arregloborrar.Length - 2
                miArbol.Eliminar(Convert.ToInt32(arregloborrar(i)))
                Refresh()
                Refresh()
            Next

            For i As Integer = 0 To arreglo.Length - 2
                r += arreglo(i).ToString()
                miArbol.Insertar(Convert.ToInt32(arreglo(i)))
                Refresh()
                Refresh()
            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveFileDialog1.FileName & ".txt", r)
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim annyeonghaseyo As New MenuPrincipal()
        annyeonghaseyo.Show()
        Hide()
    End Sub

    Private Sub Arbol_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Arbol_Paint(sender As Object, en As PaintEventArgs) Handles MyBase.Paint
        en.Graphics.Clear(Me.BackColor)
        en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        g = en.Graphics

        If enor = True OrElse posor = True OrElse preor = True Then
            miArbol.Colorear(g, Me.Font, Brushes.DarkBlue, Brushes.White, Pens.White, miArbol.RaizArbol(), enor, preor, posor)
        ElseIf iden = True Then
            miArbol.DibujarArbol(g, Me.Font, Brushes.DarkBlue, Brushes.White, Pens.Black, Brushes.Black, enc, multiplo, massimo, minino)
        ElseIf alt = True Then
            MessageBox.Show("Altura: " & (miArbol.altura))
        Else
            miArbol.DibujarArbol(g, Me.Font, Brushes.DarkBlue, Brushes.White, Pens.Black, Brushes.Black, enc, multiplo, 0, 0)
        End If

        preor = False
        enor = False
        posor = False
        iden = False
        alt = False
    End Sub
End Class