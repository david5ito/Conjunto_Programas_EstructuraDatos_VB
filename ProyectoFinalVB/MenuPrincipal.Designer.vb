<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBi = New System.Windows.Forms.Label()
        Me.btnAlgoritmo = New System.Windows.Forms.Button()
        Me.btnEstructura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(131, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Que desea crear?"
        '
        'lblBi
        '
        Me.lblBi.AutoSize = True
        Me.lblBi.BackColor = System.Drawing.Color.Transparent
        Me.lblBi.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.lblBi.ForeColor = System.Drawing.Color.Snow
        Me.lblBi.Location = New System.Drawing.Point(171, 23)
        Me.lblBi.Name = "lblBi"
        Me.lblBi.Size = New System.Drawing.Size(285, 55)
        Me.lblBi.TabIndex = 1
        Me.lblBi.Text = "Bienvenid@"
        '
        'btnAlgoritmo
        '
        Me.btnAlgoritmo.BackColor = System.Drawing.Color.Snow
        Me.btnAlgoritmo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlgoritmo.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnAlgoritmo.Location = New System.Drawing.Point(374, 150)
        Me.btnAlgoritmo.Name = "btnAlgoritmo"
        Me.btnAlgoritmo.Size = New System.Drawing.Size(175, 73)
        Me.btnAlgoritmo.TabIndex = 2
        Me.btnAlgoritmo.Text = "Algoritmo de Ordenamiento"
        Me.btnAlgoritmo.UseVisualStyleBackColor = False
        '
        'btnEstructura
        '
        Me.btnEstructura.BackColor = System.Drawing.Color.Snow
        Me.btnEstructura.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEstructura.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnEstructura.Location = New System.Drawing.Point(75, 150)
        Me.btnEstructura.Name = "btnEstructura"
        Me.btnEstructura.Size = New System.Drawing.Size(175, 73)
        Me.btnEstructura.TabIndex = 3
        Me.btnEstructura.Text = "Estructura de Datos"
        Me.btnEstructura.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 272)
        Me.Controls.Add(Me.btnEstructura)
        Me.Controls.Add(Me.btnAlgoritmo)
        Me.Controls.Add(Me.lblBi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBi As Label
    Friend WithEvents btnAlgoritmo As Button
    Friend WithEvents btnEstructura As Button
End Class
