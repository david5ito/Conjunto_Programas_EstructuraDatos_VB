<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAlgoritmos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblIns = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnBubble = New System.Windows.Forms.Button()
        Me.btnCocktail = New System.Windows.Forms.Button()
        Me.btnCounting = New System.Windows.Forms.Button()
        Me.btnRadix = New System.Windows.Forms.Button()
        Me.btnShell = New System.Windows.Forms.Button()
        Me.btnMergeSort = New System.Windows.Forms.Button()
        Me.btnQuickSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIns
        '
        Me.lblIns.AutoSize = True
        Me.lblIns.BackColor = System.Drawing.Color.Snow
        Me.lblIns.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblIns.ForeColor = System.Drawing.Color.Crimson
        Me.lblIns.Location = New System.Drawing.Point(124, 60)
        Me.lblIns.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIns.Name = "lblIns"
        Me.lblIns.Size = New System.Drawing.Size(325, 24)
        Me.lblIns.TabIndex = 0
        Me.lblIns.Text = "Selecciona un tipo de Algoritmo"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Crimson
        Me.lblTitulo.Location = New System.Drawing.Point(28, 15)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(525, 45)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Algoritmos de Ordenamiento"
        '
        'btnBubble
        '
        Me.btnBubble.BackColor = System.Drawing.Color.Snow
        Me.btnBubble.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBubble.ForeColor = System.Drawing.Color.Crimson
        Me.btnBubble.Location = New System.Drawing.Point(42, 143)
        Me.btnBubble.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBubble.Name = "btnBubble"
        Me.btnBubble.Size = New System.Drawing.Size(125, 54)
        Me.btnBubble.TabIndex = 2
        Me.btnBubble.Text = "Bubble Sort"
        Me.btnBubble.UseVisualStyleBackColor = False
        '
        'btnCocktail
        '
        Me.btnCocktail.BackColor = System.Drawing.Color.Snow
        Me.btnCocktail.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCocktail.ForeColor = System.Drawing.Color.Crimson
        Me.btnCocktail.Location = New System.Drawing.Point(220, 143)
        Me.btnCocktail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCocktail.Name = "btnCocktail"
        Me.btnCocktail.Size = New System.Drawing.Size(125, 54)
        Me.btnCocktail.TabIndex = 3
        Me.btnCocktail.Text = "Cocktail Sort"
        Me.btnCocktail.UseVisualStyleBackColor = False
        '
        'btnCounting
        '
        Me.btnCounting.BackColor = System.Drawing.Color.Snow
        Me.btnCounting.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCounting.ForeColor = System.Drawing.Color.Crimson
        Me.btnCounting.Location = New System.Drawing.Point(400, 143)
        Me.btnCounting.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCounting.Name = "btnCounting"
        Me.btnCounting.Size = New System.Drawing.Size(125, 54)
        Me.btnCounting.TabIndex = 5
        Me.btnCounting.Text = "Counting Sort"
        Me.btnCounting.UseVisualStyleBackColor = False
        '
        'btnRadix
        '
        Me.btnRadix.BackColor = System.Drawing.Color.Snow
        Me.btnRadix.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRadix.ForeColor = System.Drawing.Color.Crimson
        Me.btnRadix.Location = New System.Drawing.Point(42, 211)
        Me.btnRadix.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRadix.Name = "btnRadix"
        Me.btnRadix.Size = New System.Drawing.Size(125, 54)
        Me.btnRadix.TabIndex = 6
        Me.btnRadix.Text = "Radix Sort"
        Me.btnRadix.UseVisualStyleBackColor = False
        '
        'btnShell
        '
        Me.btnShell.BackColor = System.Drawing.Color.Snow
        Me.btnShell.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShell.ForeColor = System.Drawing.Color.Crimson
        Me.btnShell.Location = New System.Drawing.Point(220, 211)
        Me.btnShell.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnShell.Name = "btnShell"
        Me.btnShell.Size = New System.Drawing.Size(125, 54)
        Me.btnShell.TabIndex = 7
        Me.btnShell.Text = "Shell Sort"
        Me.btnShell.UseVisualStyleBackColor = False
        '
        'btnMergeSort
        '
        Me.btnMergeSort.BackColor = System.Drawing.Color.Snow
        Me.btnMergeSort.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMergeSort.ForeColor = System.Drawing.Color.Crimson
        Me.btnMergeSort.Location = New System.Drawing.Point(400, 211)
        Me.btnMergeSort.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMergeSort.Name = "btnMergeSort"
        Me.btnMergeSort.Size = New System.Drawing.Size(125, 54)
        Me.btnMergeSort.TabIndex = 8
        Me.btnMergeSort.Text = "Merge Sort"
        Me.btnMergeSort.UseVisualStyleBackColor = False
        '
        'btnQuickSort
        '
        Me.btnQuickSort.BackColor = System.Drawing.Color.Snow
        Me.btnQuickSort.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnQuickSort.ForeColor = System.Drawing.Color.Crimson
        Me.btnQuickSort.Location = New System.Drawing.Point(42, 283)
        Me.btnQuickSort.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickSort.Name = "btnQuickSort"
        Me.btnQuickSort.Size = New System.Drawing.Size(125, 54)
        Me.btnQuickSort.TabIndex = 9
        Me.btnQuickSort.Text = "Quick Sort"
        Me.btnQuickSort.UseVisualStyleBackColor = False
        '
        'MenuAlgoritmos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.MenuAlgoritmos
        Me.ClientSize = New System.Drawing.Size(588, 394)
        Me.Controls.Add(Me.btnQuickSort)
        Me.Controls.Add(Me.btnMergeSort)
        Me.Controls.Add(Me.btnShell)
        Me.Controls.Add(Me.btnRadix)
        Me.Controls.Add(Me.btnCounting)
        Me.Controls.Add(Me.btnCocktail)
        Me.Controls.Add(Me.btnBubble)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblIns)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MenuAlgoritmos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmos de Ordenamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIns As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnBubble As Button
    Friend WithEvents btnCocktail As Button
    Friend WithEvents btnCounting As Button
    Friend WithEvents btnRadix As Button
    Friend WithEvents btnShell As Button
    Friend WithEvents btnMergeSort As Button
    Friend WithEvents btnQuickSort As Button
End Class
