<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountingSort
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.gbTiempo = New System.Windows.Forms.GroupBox()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.lblGenerado = New System.Windows.Forms.Label()
        Me.lblOrdenado = New System.Windows.Forms.Label()
        Me.lblTOrd = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.gbTiempo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblTitulo.Location = New System.Drawing.Point(282, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(290, 49)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Counting Sort"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btnMenu.Location = New System.Drawing.Point(694, 296)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(107, 53)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'gbTiempo
        '
        Me.gbTiempo.BackColor = System.Drawing.Color.Snow
        Me.gbTiempo.Controls.Add(Me.lblGen)
        Me.gbTiempo.Controls.Add(Me.lblGenerado)
        Me.gbTiempo.Controls.Add(Me.lblOrdenado)
        Me.gbTiempo.Controls.Add(Me.lblTOrd)
        Me.gbTiempo.Controls.Add(Me.lblTiempo)
        Me.gbTiempo.Controls.Add(Me.lblOrd)
        Me.gbTiempo.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.gbTiempo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.gbTiempo.Location = New System.Drawing.Point(23, 401)
        Me.gbTiempo.Name = "gbTiempo"
        Me.gbTiempo.Size = New System.Drawing.Size(778, 173)
        Me.gbTiempo.TabIndex = 7
        Me.gbTiempo.TabStop = False
        '
        'lblGen
        '
        Me.lblGen.AutoSize = True
        Me.lblGen.Location = New System.Drawing.Point(19, 34)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(102, 22)
        Me.lblGen.TabIndex = 5
        Me.lblGen.Text = "Generado:"
        '
        'lblGenerado
        '
        Me.lblGenerado.AutoSize = True
        Me.lblGenerado.Location = New System.Drawing.Point(154, 34)
        Me.lblGenerado.Name = "lblGenerado"
        Me.lblGenerado.Size = New System.Drawing.Size(22, 22)
        Me.lblGenerado.TabIndex = 2
        Me.lblGenerado.Text = "0"
        '
        'lblOrdenado
        '
        Me.lblOrdenado.AutoSize = True
        Me.lblOrdenado.Location = New System.Drawing.Point(135, 77)
        Me.lblOrdenado.Name = "lblOrdenado"
        Me.lblOrdenado.Size = New System.Drawing.Size(22, 22)
        Me.lblOrdenado.TabIndex = 3
        Me.lblOrdenado.Text = "0"
        '
        'lblTOrd
        '
        Me.lblTOrd.AutoSize = True
        Me.lblTOrd.Location = New System.Drawing.Point(19, 122)
        Me.lblTOrd.Name = "lblTOrd"
        Me.lblTOrd.Size = New System.Drawing.Size(185, 22)
        Me.lblTOrd.TabIndex = 2
        Me.lblTOrd.Text = "Tiempo en ordenar:"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(226, 122)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(40, 22)
        Me.lblTiempo.TabIndex = 1
        Me.lblTiempo.Text = "0:0"
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.Location = New System.Drawing.Point(19, 77)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(103, 22)
        Me.lblOrd.TabIndex = 0
        Me.lblOrd.Text = "Ordenado:"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Snow
        Me.lblNum.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblNum.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblNum.Location = New System.Drawing.Point(270, 130)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(113, 27)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Numeros:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Snow
        Me.lblMin.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblMin.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMin.Location = New System.Drawing.Point(270, 176)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(171, 27)
        Me.lblMin.TabIndex = 1
        Me.lblMin.Text = "Limite Minimo:"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.Snow
        Me.lblMax.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblMax.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMax.Location = New System.Drawing.Point(270, 223)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(174, 27)
        Me.lblMax.TabIndex = 2
        Me.lblMax.Text = "Limite Maximo:"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Snow
        Me.btnGenerar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnGenerar.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btnGenerar.Location = New System.Drawing.Point(274, 280)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(136, 69)
        Me.btnGenerar.TabIndex = 8
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.Snow
        Me.btnOrdenar.Enabled = False
        Me.btnOrdenar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnOrdenar.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btnOrdenar.Location = New System.Drawing.Point(450, 280)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(136, 69)
        Me.btnOrdenar.TabIndex = 5
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'txtNum
        '
        Me.txtNum.BackColor = System.Drawing.Color.Snow
        Me.txtNum.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtNum.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.txtNum.Location = New System.Drawing.Point(405, 135)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(181, 26)
        Me.txtNum.TabIndex = 5
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.Snow
        Me.txtMin.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtMin.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.txtMin.Location = New System.Drawing.Point(470, 181)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(116, 26)
        Me.txtMin.TabIndex = 9
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.Snow
        Me.txtMax.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtMax.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.txtMax.Location = New System.Drawing.Point(470, 228)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(116, 26)
        Me.txtMax.TabIndex = 10
        '
        'CountingSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.CountingSort
        Me.ClientSize = New System.Drawing.Size(851, 601)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.gbTiempo)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "CountingSort"
        Me.Text = "Counting Sort"
        Me.gbTiempo.ResumeLayout(False)
        Me.gbTiempo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblOrd As Label
    Friend WithEvents lblGen As Label
    Friend WithEvents lblOrdenado As Label
    Friend WithEvents lblTOrd As Label
    Private WithEvents btnGenerar As Button
    Private WithEvents lblTitulo As Label
    Private WithEvents btnMenu As Button
    Private WithEvents gbTiempo As GroupBox
    Private WithEvents lblNum As Label
    Private WithEvents lblMin As Label
    Private WithEvents lblMax As Label
    Private WithEvents btnOrdenar As Button
    Private WithEvents txtNum As TextBox
    Private WithEvents txtMin As TextBox
    Private WithEvents txtMax As TextBox
    Private WithEvents lblGenerado As Label
End Class
