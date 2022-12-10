<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDoble
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
        Me.lblLista = New System.Windows.Forms.Label()
        Me.lblThis = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBorrarL = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.BackColor = System.Drawing.Color.Snow
        Me.lblDato.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblDato.ForeColor = System.Drawing.Color.LightCoral
        Me.lblDato.Location = New System.Drawing.Point(253, 271)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(79, 31)
        Me.lblDato.TabIndex = 0
        Me.lblDato.Text = "Dato:"
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.BackColor = System.Drawing.Color.Snow
        Me.lblLista.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblLista.ForeColor = System.Drawing.Color.LightCoral
        Me.lblLista.Location = New System.Drawing.Point(358, 153)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(42, 31)
        Me.lblLista.TabIndex = 1
        Me.lblLista.Text = "----"
        '
        'lblThis
        '
        Me.lblThis.AutoSize = True
        Me.lblThis.BackColor = System.Drawing.Color.Snow
        Me.lblThis.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblThis.ForeColor = System.Drawing.Color.LightCoral
        Me.lblThis.Location = New System.Drawing.Point(253, 153)
        Me.lblThis.Name = "lblThis"
        Me.lblThis.Size = New System.Drawing.Size(81, 31)
        Me.lblThis.TabIndex = 2
        Me.lblThis.Text = "Lista:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.LightCoral
        Me.lblTitulo.Location = New System.Drawing.Point(310, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(244, 49)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Lista Doble"
        '
        'txtNodo
        '
        Me.txtNodo.BackColor = System.Drawing.Color.Snow
        Me.txtNodo.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtNodo.ForeColor = System.Drawing.Color.LightCoral
        Me.txtNodo.Location = New System.Drawing.Point(364, 277)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(134, 26)
        Me.txtNodo.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Snow
        Me.btnAgregar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.LightCoral
        Me.btnAgregar.Location = New System.Drawing.Point(96, 118)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(129, 58)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Snow
        Me.btnEliminar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.LightCoral
        Me.btnEliminar.Location = New System.Drawing.Point(96, 209)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(129, 58)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBorrarL
        '
        Me.btnBorrarL.BackColor = System.Drawing.Color.Snow
        Me.btnBorrarL.Enabled = False
        Me.btnBorrarL.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrarL.ForeColor = System.Drawing.Color.LightCoral
        Me.btnBorrarL.Location = New System.Drawing.Point(96, 300)
        Me.btnBorrarL.Name = "btnBorrarL"
        Me.btnBorrarL.Size = New System.Drawing.Size(129, 58)
        Me.btnBorrarL.TabIndex = 7
        Me.btnBorrarL.Text = "Borrar Lista"
        Me.btnBorrarL.UseVisualStyleBackColor = False
        '
        'btnContar
        '
        Me.btnContar.BackColor = System.Drawing.Color.Snow
        Me.btnContar.Enabled = False
        Me.btnContar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnContar.ForeColor = System.Drawing.Color.LightCoral
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
        Me.btnGuardar.ForeColor = System.Drawing.Color.LightCoral
        Me.btnGuardar.Location = New System.Drawing.Point(640, 209)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 58)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar Lista"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Snow
        Me.btnCargar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCargar.ForeColor = System.Drawing.Color.LightCoral
        Me.btnCargar.Location = New System.Drawing.Point(640, 300)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(129, 58)
        Me.btnCargar.TabIndex = 10
        Me.btnCargar.Text = "Cargar Lista"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.LightCoral
        Me.btnMenu.Location = New System.Drawing.Point(766, 405)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 43)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'ListaDoble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.ListaDoble
        Me.ClientSize = New System.Drawing.Size(951, 481)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.btnBorrarL)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblThis)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.lblDato)
        Me.Name = "ListaDoble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Doble"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDato As Label
    Friend WithEvents lblLista As Label
    Friend WithEvents lblThis As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBorrarL As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnMenu As Button
End Class
