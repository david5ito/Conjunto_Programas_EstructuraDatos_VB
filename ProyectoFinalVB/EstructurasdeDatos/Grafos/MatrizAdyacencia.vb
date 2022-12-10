Public Class MatrizAdyacencia
    Private grafo As List(Of NodoGrafo) = New List(Of NodoGrafo)()

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal gr As List(Of NodoGrafo))
        InitializeComponent()
        grafo = gr
    End Sub
    Private Sub MatrizAdyacente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.ColumnCount = 0
        dgv.ColumnCount = grafo.Count
        dgv.RowCount = 1
        dgv.RowCount = grafo.Count

        For i As Integer = 0 To grafo.Count - 1
            dgv.Columns(i).Name = i.ToString()
        Next

        For i As Integer = 0 To grafo.Count - 1

            For j As Integer = 0 To grafo.Count - 1
                dgv.Rows(i).Cells(j).Value = 0
            Next
        Next

        For i As Integer = 0 To grafo.Count - 1

            For j As Integer = 0 To grafo(i).aristas.Count() - 1
                dgv.Rows(i).Cells(grafo(i).aristas(j).getDestino()).Value = 1
            Next
        Next
    End Sub
End Class