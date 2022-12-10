Public Class MenuAlgoritmos
    Private Sub btnBubble_Click(sender As Object, e As EventArgs) Handles btnBubble.Click
        Dim il As New BubbleSort()
        il.Show()
        Hide()
    End Sub

    Private Sub btnCocktail_Click(sender As Object, e As EventArgs) Handles btnCocktail.Click
        Dim i As New CocktailSort()
        i.Show()
        Hide()
    End Sub

    Private Sub btnInsertion_Click(sender As Object, e As EventArgs)
        Dim sam As New InsertionSort()
        sam.Show()
        Hide()
    End Sub

    Private Sub btnCounting_Click(sender As Object, e As EventArgs) Handles btnCounting.Click
        Dim sa As New CountingSort()
        sa.Show()
        Hide()
    End Sub

    Private Sub btnRadix_Click(sender As Object, e As EventArgs) Handles btnRadix.Click
        Dim o As New RadixSort()
        o.Show()
        Hide()
    End Sub

    Private Sub btnShell_Click(sender As Object, e As EventArgs) Handles btnShell.Click
        Dim yuk As New ShellSort()
        yuk.Show()
        Hide()
    End Sub

    Private Sub MenuAlgoritmos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnMergeSort_Click(sender As Object, e As EventArgs) Handles btnMergeSort.Click
        Dim yuk As New MergeSort()
        yuk.Show()
        Hide()
    End Sub

    Private Sub btnQuickSort_Click(sender As Object, e As EventArgs) Handles btnQuickSort.Click
        Dim yuk As New QuickSort()
        yuk.Show()
        Hide()
    End Sub
End Class