<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShellSort
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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.gbTiempo = New System.Windows.Forms.GroupBox()
        Me.lblIntercambios = New System.Windows.Forms.Label()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblOrdenar = New System.Windows.Forms.Label()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lbNum = New System.Windows.Forms.ListBox()
        Me.lbOrd = New System.Windows.Forms.ListBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblComparaciones = New System.Windows.Forms.Label()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.gbTiempo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTitulo.Location = New System.Drawing.Point(292, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(212, 49)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Shell Sort"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Snow
        Me.lblNum.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblNum.ForeColor = System.Drawing.Color.Firebrick
        Me.lblNum.Location = New System.Drawing.Point(62, 130)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(113, 27)
        Me.lblNum.TabIndex = 1
        Me.lblNum.Text = "Numeros:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Snow
        Me.lblMin.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblMin.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMin.Location = New System.Drawing.Point(62, 176)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(171, 27)
        Me.lblMin.TabIndex = 2
        Me.lblMin.Text = "Limite Minimo:"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.BackColor = System.Drawing.Color.Snow
        Me.lblMax.Font = New System.Drawing.Font("Britannic Bold", 13.8!)
        Me.lblMax.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMax.Location = New System.Drawing.Point(62, 223)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(174, 27)
        Me.lblMax.TabIndex = 3
        Me.lblMax.Text = "Limite Maximo:"
        '
        'gbTiempo
        '
        Me.gbTiempo.BackColor = System.Drawing.Color.Snow
        Me.gbTiempo.Controls.Add(Me.lblCom)
        Me.gbTiempo.Controls.Add(Me.lblComparaciones)
        Me.gbTiempo.Controls.Add(Me.lblIntercambios)
        Me.gbTiempo.Controls.Add(Me.lblInt)
        Me.gbTiempo.Controls.Add(Me.lblOrdenar)
        Me.gbTiempo.Controls.Add(Me.lblOrd)
        Me.gbTiempo.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.gbTiempo.ForeColor = System.Drawing.Color.Firebrick
        Me.gbTiempo.Location = New System.Drawing.Point(41, 407)
        Me.gbTiempo.Name = "gbTiempo"
        Me.gbTiempo.Size = New System.Drawing.Size(406, 143)
        Me.gbTiempo.TabIndex = 4
        Me.gbTiempo.TabStop = False
        '
        'lblIntercambios
        '
        Me.lblIntercambios.AutoSize = True
        Me.lblIntercambios.Location = New System.Drawing.Point(161, 18)
        Me.lblIntercambios.Name = "lblIntercambios"
        Me.lblIntercambios.Size = New System.Drawing.Size(22, 22)
        Me.lblIntercambios.TabIndex = 3
        Me.lblIntercambios.Text = "0"
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.Location = New System.Drawing.Point(14, 18)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(133, 22)
        Me.lblInt.TabIndex = 2
        Me.lblInt.Text = "Intercambios:"
        '
        'lblOrdenar
        '
        Me.lblOrdenar.AutoSize = True
        Me.lblOrdenar.Location = New System.Drawing.Point(129, 110)
        Me.lblOrdenar.Name = "lblOrdenar"
        Me.lblOrdenar.Size = New System.Drawing.Size(40, 22)
        Me.lblOrdenar.TabIndex = 1
        Me.lblOrdenar.Text = "0:0"
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.Location = New System.Drawing.Point(14, 110)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(90, 22)
        Me.lblOrd.TabIndex = 0
        Me.lblOrd.Text = "Ordenar:"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Snow
        Me.btnGenerar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnGenerar.ForeColor = System.Drawing.Color.Firebrick
        Me.btnGenerar.Location = New System.Drawing.Point(66, 280)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(136, 69)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.Snow
        Me.btnOrdenar.Enabled = False
        Me.btnOrdenar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnOrdenar.ForeColor = System.Drawing.Color.Firebrick
        Me.btnOrdenar.Location = New System.Drawing.Point(242, 280)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(136, 69)
        Me.btnOrdenar.TabIndex = 5
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.Firebrick
        Me.btnMenu.Location = New System.Drawing.Point(718, 521)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(107, 53)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lbNum
        '
        Me.lbNum.BackColor = System.Drawing.Color.Snow
        Me.lbNum.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.lbNum.ForeColor = System.Drawing.Color.Firebrick
        Me.lbNum.FormattingEnabled = True
        Me.lbNum.ItemHeight = 19
        Me.lbNum.Location = New System.Drawing.Point(494, 130)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(110, 365)
        Me.lbNum.TabIndex = 7
        '
        'lbOrd
        '
        Me.lbOrd.BackColor = System.Drawing.Color.Snow
        Me.lbOrd.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.lbOrd.ForeColor = System.Drawing.Color.Firebrick
        Me.lbOrd.FormattingEnabled = True
        Me.lbOrd.ItemHeight = 19
        Me.lbOrd.Location = New System.Drawing.Point(647, 130)
        Me.lbOrd.Name = "lbOrd"
        Me.lbOrd.Size = New System.Drawing.Size(110, 365)
        Me.lbOrd.TabIndex = 8
        '
        'txtNum
        '
        Me.txtNum.BackColor = System.Drawing.Color.Snow
        Me.txtNum.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtNum.ForeColor = System.Drawing.Color.Firebrick
        Me.txtNum.Location = New System.Drawing.Point(197, 135)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(181, 26)
        Me.txtNum.TabIndex = 9
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.Snow
        Me.txtMin.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtMin.ForeColor = System.Drawing.Color.Firebrick
        Me.txtMin.Location = New System.Drawing.Point(262, 181)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(116, 26)
        Me.txtMin.TabIndex = 10
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.Snow
        Me.txtMax.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtMax.ForeColor = System.Drawing.Color.Firebrick
        Me.txtMax.Location = New System.Drawing.Point(262, 228)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(116, 26)
        Me.txtMax.TabIndex = 11
        '
        'lblComparaciones
        '
        Me.lblComparaciones.AutoSize = True
        Me.lblComparaciones.Location = New System.Drawing.Point(188, 64)
        Me.lblComparaciones.Name = "lblComparaciones"
        Me.lblComparaciones.Size = New System.Drawing.Size(22, 22)
        Me.lblComparaciones.TabIndex = 4
        Me.lblComparaciones.Text = "0"
        '
        'lblCom
        '
        Me.lblCom.AutoSize = True
        Me.lblCom.Location = New System.Drawing.Point(14, 64)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(155, 22)
        Me.lblCom.TabIndex = 5
        Me.lblCom.Text = "Comparaciones:"
        '
        'ShellSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.ShellSort
        Me.ClientSize = New System.Drawing.Size(851, 601)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lbOrd)
        Me.Controls.Add(Me.lbNum)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.gbTiempo)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "ShellSort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shell Sort"
        Me.gbTiempo.ResumeLayout(False)
        Me.gbTiempo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents gbTiempo As GroupBox
    Friend WithEvents lblOrdenar As Label
    Friend WithEvents lblOrd As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lbNum As ListBox
    Friend WithEvents lbOrd As ListBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents lblIntercambios As Label
    Friend WithEvents lblInt As Label
    Friend WithEvents lblCom As Label
    Friend WithEvents lblComparaciones As Label
End Class
