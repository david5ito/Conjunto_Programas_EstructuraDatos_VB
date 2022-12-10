<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pilas
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
        Me.lblThis = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblPila = New System.Windows.Forms.Label()
        Me.lblDato = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnBorrarP = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblThis
        '
        Me.lblThis.AutoSize = True
        Me.lblThis.BackColor = System.Drawing.Color.Snow
        Me.lblThis.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblThis.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblThis.Location = New System.Drawing.Point(253, 153)
        Me.lblThis.Name = "lblThis"
        Me.lblThis.Size = New System.Drawing.Size(70, 31)
        Me.lblThis.TabIndex = 0
        Me.lblThis.Text = "Pila:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblTitulo.Location = New System.Drawing.Point(379, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(119, 49)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Pilas"
        '
        'lblPila
        '
        Me.lblPila.AutoSize = True
        Me.lblPila.BackColor = System.Drawing.Color.Snow
        Me.lblPila.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblPila.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblPila.Location = New System.Drawing.Point(358, 153)
        Me.lblPila.Name = "lblPila"
        Me.lblPila.Size = New System.Drawing.Size(42, 31)
        Me.lblPila.TabIndex = 2
        Me.lblPila.Text = "----"
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.BackColor = System.Drawing.Color.Snow
        Me.lblDato.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblDato.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblDato.Location = New System.Drawing.Point(253, 271)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(79, 31)
        Me.lblDato.TabIndex = 3
        Me.lblDato.Text = "Dato:"
        '
        'txtNodo
        '
        Me.txtNodo.BackColor = System.Drawing.Color.Snow
        Me.txtNodo.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtNodo.Location = New System.Drawing.Point(364, 277)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(134, 22)
        Me.txtNodo.TabIndex = 4
        '
        'btnPush
        '
        Me.btnPush.BackColor = System.Drawing.Color.Snow
        Me.btnPush.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPush.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnPush.Location = New System.Drawing.Point(96, 118)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(129, 58)
        Me.btnPush.TabIndex = 5
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = False
        '
        'btnPop
        '
        Me.btnPop.BackColor = System.Drawing.Color.Snow
        Me.btnPop.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPop.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnPop.Location = New System.Drawing.Point(96, 209)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(129, 58)
        Me.btnPop.TabIndex = 6
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = False
        '
        'btnBorrarP
        '
        Me.btnBorrarP.BackColor = System.Drawing.Color.Snow
        Me.btnBorrarP.Enabled = False
        Me.btnBorrarP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrarP.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnBorrarP.Location = New System.Drawing.Point(96, 300)
        Me.btnBorrarP.Name = "btnBorrarP"
        Me.btnBorrarP.Size = New System.Drawing.Size(129, 58)
        Me.btnBorrarP.TabIndex = 7
        Me.btnBorrarP.Text = "Borrar Pila"
        Me.btnBorrarP.UseVisualStyleBackColor = False
        '
        'btnContar
        '
        Me.btnContar.BackColor = System.Drawing.Color.Snow
        Me.btnContar.Enabled = False
        Me.btnContar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnContar.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnContar.Location = New System.Drawing.Point(640, 118)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(129, 58)
        Me.btnContar.TabIndex = 8
        Me.btnContar.Text = "Contar"
        Me.btnContar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Snow
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnGuardar.Location = New System.Drawing.Point(640, 209)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 58)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar Pila"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Snow
        Me.btnCargar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCargar.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnCargar.Location = New System.Drawing.Point(640, 300)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(129, 58)
        Me.btnCargar.TabIndex = 10
        Me.btnCargar.Text = "Cargar Pila"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnMenu.Location = New System.Drawing.Point(766, 405)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 43)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Pilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.Pilas
        Me.ClientSize = New System.Drawing.Size(951, 481)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.btnBorrarP)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.lblDato)
        Me.Controls.Add(Me.lblPila)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblThis)
        Me.Name = "Pilas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblThis As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPila As Label
    Friend WithEvents lblDato As Label
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents btnPush As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnBorrarP As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnMenu As Button
End Class
