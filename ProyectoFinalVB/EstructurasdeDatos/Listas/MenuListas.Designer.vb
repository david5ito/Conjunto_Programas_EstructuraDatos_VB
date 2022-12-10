<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuListas
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
        Me.btnSimple = New System.Windows.Forms.Button()
        Me.btnDoble = New System.Windows.Forms.Button()
        Me.btnSCircular = New System.Windows.Forms.Button()
        Me.btnDCircular = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIns
        '
        Me.lblIns.AutoSize = True
        Me.lblIns.BackColor = System.Drawing.Color.Snow
        Me.lblIns.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblIns.ForeColor = System.Drawing.Color.Firebrick
        Me.lblIns.Location = New System.Drawing.Point(153, 99)
        Me.lblIns.Name = "lblIns"
        Me.lblIns.Size = New System.Drawing.Size(346, 30)
        Me.lblIns.TabIndex = 0
        Me.lblIns.Text = "Selecciona un tipo de Lista"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 25.8!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTitulo.Location = New System.Drawing.Point(246, 44)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(164, 55)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Listas"
        '
        'btnSimple
        '
        Me.btnSimple.BackColor = System.Drawing.Color.Snow
        Me.btnSimple.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimple.ForeColor = System.Drawing.Color.Firebrick
        Me.btnSimple.Location = New System.Drawing.Point(133, 181)
        Me.btnSimple.Name = "btnSimple"
        Me.btnSimple.Size = New System.Drawing.Size(154, 66)
        Me.btnSimple.TabIndex = 2
        Me.btnSimple.Text = "Lista Simple"
        Me.btnSimple.UseVisualStyleBackColor = False
        '
        'btnDoble
        '
        Me.btnDoble.BackColor = System.Drawing.Color.Snow
        Me.btnDoble.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDoble.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDoble.Location = New System.Drawing.Point(133, 286)
        Me.btnDoble.Name = "btnDoble"
        Me.btnDoble.Size = New System.Drawing.Size(154, 66)
        Me.btnDoble.TabIndex = 3
        Me.btnDoble.Text = "Lista Doble"
        Me.btnDoble.UseVisualStyleBackColor = False
        '
        'btnSCircular
        '
        Me.btnSCircular.BackColor = System.Drawing.Color.Snow
        Me.btnSCircular.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSCircular.ForeColor = System.Drawing.Color.Firebrick
        Me.btnSCircular.Location = New System.Drawing.Point(369, 181)
        Me.btnSCircular.Name = "btnSCircular"
        Me.btnSCircular.Size = New System.Drawing.Size(154, 66)
        Me.btnSCircular.TabIndex = 4
        Me.btnSCircular.Text = "Lista Simple Circular"
        Me.btnSCircular.UseVisualStyleBackColor = False
        '
        'btnDCircular
        '
        Me.btnDCircular.BackColor = System.Drawing.Color.Snow
        Me.btnDCircular.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDCircular.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDCircular.Location = New System.Drawing.Point(369, 286)
        Me.btnDCircular.Name = "btnDCircular"
        Me.btnDCircular.Size = New System.Drawing.Size(154, 66)
        Me.btnDCircular.TabIndex = 5
        Me.btnDCircular.Text = "Lista Doble Circular"
        Me.btnDCircular.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.Firebrick
        Me.btnMenu.Location = New System.Drawing.Point(534, 392)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(107, 53)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'MenuListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.MenuListas
        Me.ClientSize = New System.Drawing.Size(730, 464)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnDCircular)
        Me.Controls.Add(Me.btnSCircular)
        Me.Controls.Add(Me.btnDoble)
        Me.Controls.Add(Me.btnSimple)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblIns)
        Me.Name = "MenuListas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIns As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnSimple As Button
    Friend WithEvents btnDoble As Button
    Friend WithEvents btnSCircular As Button
    Friend WithEvents btnDCircular As Button
    Friend WithEvents btnMenu As Button
End Class
