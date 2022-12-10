<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colas
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
        Me.lblDato = New System.Windows.Forms.Label()
        Me.lblThis = New System.Windows.Forms.Label()
        Me.lblCola = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnDesencolar = New System.Windows.Forms.Button()
        Me.btnEncolar = New System.Windows.Forms.Button()
        Me.btnBorrarC = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.BackColor = System.Drawing.Color.Snow
        Me.lblDato.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblDato.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblDato.Location = New System.Drawing.Point(253, 271)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(79, 31)
        Me.lblDato.TabIndex = 0
        Me.lblDato.Text = "Dato:"
        '
        'lblThis
        '
        Me.lblThis.AutoSize = True
        Me.lblThis.BackColor = System.Drawing.Color.Snow
        Me.lblThis.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblThis.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblThis.Location = New System.Drawing.Point(253, 153)
        Me.lblThis.Name = "lblThis"
        Me.lblThis.Size = New System.Drawing.Size(77, 31)
        Me.lblThis.TabIndex = 1
        Me.lblThis.Text = "Cola:"
        '
        'lblCola
        '
        Me.lblCola.AutoSize = True
        Me.lblCola.BackColor = System.Drawing.Color.Snow
        Me.lblCola.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblCola.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCola.Location = New System.Drawing.Point(358, 153)
        Me.lblCola.Name = "lblCola"
        Me.lblCola.Size = New System.Drawing.Size(42, 31)
        Me.lblCola.TabIndex = 2
        Me.lblCola.Text = "----"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Location = New System.Drawing.Point(379, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(127, 49)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Colas"
        '
        'txtNodo
        '
        Me.txtNodo.BackColor = System.Drawing.Color.Snow
        Me.txtNodo.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNodo.Location = New System.Drawing.Point(364, 277)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(134, 22)
        Me.txtNodo.TabIndex = 4
        '
        'btnDesencolar
        '
        Me.btnDesencolar.BackColor = System.Drawing.Color.Snow
        Me.btnDesencolar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDesencolar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDesencolar.Location = New System.Drawing.Point(96, 209)
        Me.btnDesencolar.Name = "btnDesencolar"
        Me.btnDesencolar.Size = New System.Drawing.Size(129, 58)
        Me.btnDesencolar.TabIndex = 5
        Me.btnDesencolar.Text = "Desencolar"
        Me.btnDesencolar.UseVisualStyleBackColor = False
        '
        'btnEncolar
        '
        Me.btnEncolar.BackColor = System.Drawing.Color.Snow
        Me.btnEncolar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEncolar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEncolar.Location = New System.Drawing.Point(96, 118)
        Me.btnEncolar.Name = "btnEncolar"
        Me.btnEncolar.Size = New System.Drawing.Size(129, 58)
        Me.btnEncolar.TabIndex = 6
        Me.btnEncolar.Text = "Encolar"
        Me.btnEncolar.UseVisualStyleBackColor = False
        '
        'btnBorrarC
        '
        Me.btnBorrarC.BackColor = System.Drawing.Color.Snow
        Me.btnBorrarC.Enabled = False
        Me.btnBorrarC.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrarC.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBorrarC.Location = New System.Drawing.Point(96, 300)
        Me.btnBorrarC.Name = "btnBorrarC"
        Me.btnBorrarC.Size = New System.Drawing.Size(129, 58)
        Me.btnBorrarC.TabIndex = 7
        Me.btnBorrarC.Text = "Borrar Cola"
        Me.btnBorrarC.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Snow
        Me.btnCargar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCargar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCargar.Location = New System.Drawing.Point(640, 300)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(129, 58)
        Me.btnCargar.TabIndex = 8
        Me.btnCargar.Text = "Cargar Cola"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Snow
        Me.btnConsultar.Enabled = False
        Me.btnConsultar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsultar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnConsultar.Location = New System.Drawing.Point(640, 118)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(129, 58)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Snow
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnGuardar.Location = New System.Drawing.Point(640, 209)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 58)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar Cola"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnMenu.Location = New System.Drawing.Point(766, 405)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 43)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Colas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.Colas
        Me.ClientSize = New System.Drawing.Size(951, 481)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnBorrarC)
        Me.Controls.Add(Me.btnEncolar)
        Me.Controls.Add(Me.btnDesencolar)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCola)
        Me.Controls.Add(Me.lblThis)
        Me.Controls.Add(Me.lblDato)
        Me.Name = "Colas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDato As Label
    Friend WithEvents lblThis As Label
    Friend WithEvents lblCola As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents btnDesencolar As Button
    Friend WithEvents btnEncolar As Button
    Friend WithEvents btnBorrarC As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnMenu As Button
End Class
