<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arbol
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.gbRecorrer = New System.Windows.Forms.GroupBox()
        Me.rbtnOrden = New System.Windows.Forms.RadioButton()
        Me.rbtnPreOrden = New System.Windows.Forms.RadioButton()
        Me.rbtnPostOrden = New System.Windows.Forms.RadioButton()
        Me.btnRecorrer = New System.Windows.Forms.Button()
        Me.lblThis = New System.Windows.Forms.Label()
        Me.btnIdentificar = New System.Windows.Forms.Button()
        Me.btnAltura = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.gbRecorrer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.BackColor = System.Drawing.Color.Snow
        Me.lblDato.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblDato.ForeColor = System.Drawing.Color.Plum
        Me.lblDato.Location = New System.Drawing.Point(218, 508)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(79, 31)
        Me.lblDato.TabIndex = 0
        Me.lblDato.Text = "Dato:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Snow
        Me.btnAgregar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.Plum
        Me.btnAgregar.Location = New System.Drawing.Point(55, 508)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(144, 43)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Snow
        Me.btnEliminar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.Plum
        Me.btnEliminar.Location = New System.Drawing.Point(55, 573)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(144, 43)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Snow
        Me.btnBuscar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Plum
        Me.btnBuscar.Location = New System.Drawing.Point(55, 636)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(144, 43)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNodo
        '
        Me.txtNodo.BackColor = System.Drawing.Color.Snow
        Me.txtNodo.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtNodo.ForeColor = System.Drawing.Color.Plum
        Me.txtNodo.Location = New System.Drawing.Point(316, 513)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(134, 26)
        Me.txtNodo.TabIndex = 5
        '
        'gbRecorrer
        '
        Me.gbRecorrer.BackColor = System.Drawing.Color.Snow
        Me.gbRecorrer.Controls.Add(Me.btnRecorrer)
        Me.gbRecorrer.Controls.Add(Me.rbtnPostOrden)
        Me.gbRecorrer.Controls.Add(Me.rbtnPreOrden)
        Me.gbRecorrer.Controls.Add(Me.rbtnOrden)
        Me.gbRecorrer.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.gbRecorrer.ForeColor = System.Drawing.Color.Plum
        Me.gbRecorrer.Location = New System.Drawing.Point(489, 494)
        Me.gbRecorrer.Name = "gbRecorrer"
        Me.gbRecorrer.Size = New System.Drawing.Size(252, 261)
        Me.gbRecorrer.TabIndex = 6
        Me.gbRecorrer.TabStop = False
        Me.gbRecorrer.Text = "Recorrer"
        '
        'rbtnOrden
        '
        Me.rbtnOrden.AutoSize = True
        Me.rbtnOrden.Location = New System.Drawing.Point(19, 44)
        Me.rbtnOrden.Name = "rbtnOrden"
        Me.rbtnOrden.Size = New System.Drawing.Size(85, 26)
        Me.rbtnOrden.TabIndex = 0
        Me.rbtnOrden.TabStop = True
        Me.rbtnOrden.Text = "Orden"
        Me.rbtnOrden.UseVisualStyleBackColor = True
        '
        'rbtnPreOrden
        '
        Me.rbtnPreOrden.AutoSize = True
        Me.rbtnPreOrden.Location = New System.Drawing.Point(19, 89)
        Me.rbtnPreOrden.Name = "rbtnPreOrden"
        Me.rbtnPreOrden.Size = New System.Drawing.Size(122, 26)
        Me.rbtnPreOrden.TabIndex = 1
        Me.rbtnPreOrden.TabStop = True
        Me.rbtnPreOrden.Text = "Pre Orden"
        Me.rbtnPreOrden.UseVisualStyleBackColor = True
        '
        'rbtnPostOrden
        '
        Me.rbtnPostOrden.AutoSize = True
        Me.rbtnPostOrden.Location = New System.Drawing.Point(19, 135)
        Me.rbtnPostOrden.Name = "rbtnPostOrden"
        Me.rbtnPostOrden.Size = New System.Drawing.Size(130, 26)
        Me.rbtnPostOrden.TabIndex = 2
        Me.rbtnPostOrden.TabStop = True
        Me.rbtnPostOrden.Text = "Post Orden"
        Me.rbtnPostOrden.UseVisualStyleBackColor = True
        '
        'btnRecorrer
        '
        Me.btnRecorrer.BackColor = System.Drawing.Color.Snow
        Me.btnRecorrer.Location = New System.Drawing.Point(60, 175)
        Me.btnRecorrer.Name = "btnRecorrer"
        Me.btnRecorrer.Size = New System.Drawing.Size(144, 43)
        Me.btnRecorrer.TabIndex = 3
        Me.btnRecorrer.Text = "Recorrer"
        Me.btnRecorrer.UseVisualStyleBackColor = False
        '
        'lblThis
        '
        Me.lblThis.AutoSize = True
        Me.lblThis.BackColor = System.Drawing.Color.Snow
        Me.lblThis.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblThis.ForeColor = System.Drawing.Color.Plum
        Me.lblThis.Location = New System.Drawing.Point(771, 457)
        Me.lblThis.Name = "lblThis"
        Me.lblThis.Size = New System.Drawing.Size(395, 31)
        Me.lblThis.TabIndex = 4
        Me.lblThis.Text = "Encontrar el maximo y minimo"
        '
        'btnIdentificar
        '
        Me.btnIdentificar.BackColor = System.Drawing.Color.Snow
        Me.btnIdentificar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnIdentificar.ForeColor = System.Drawing.Color.Plum
        Me.btnIdentificar.Location = New System.Drawing.Point(777, 504)
        Me.btnIdentificar.Name = "btnIdentificar"
        Me.btnIdentificar.Size = New System.Drawing.Size(199, 43)
        Me.btnIdentificar.TabIndex = 7
        Me.btnIdentificar.Text = "Identificar"
        Me.btnIdentificar.UseVisualStyleBackColor = False
        '
        'btnAltura
        '
        Me.btnAltura.BackColor = System.Drawing.Color.Snow
        Me.btnAltura.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnAltura.ForeColor = System.Drawing.Color.Plum
        Me.btnAltura.Location = New System.Drawing.Point(777, 572)
        Me.btnAltura.Name = "btnAltura"
        Me.btnAltura.Size = New System.Drawing.Size(199, 43)
        Me.btnAltura.TabIndex = 8
        Me.btnAltura.Text = "Determinar Altura"
        Me.btnAltura.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Snow
        Me.btnCargar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnCargar.ForeColor = System.Drawing.Color.Plum
        Me.btnCargar.Location = New System.Drawing.Point(777, 640)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(199, 43)
        Me.btnCargar.TabIndex = 9
        Me.btnCargar.Text = "Cargar Arbol"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Snow
        Me.btnGuardar.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Plum
        Me.btnGuardar.Location = New System.Drawing.Point(777, 709)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(199, 43)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar Arbol"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.Plum
        Me.btnMenu.Location = New System.Drawing.Point(1112, 734)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 43)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Arbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1239, 800)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnAltura)
        Me.Controls.Add(Me.btnIdentificar)
        Me.Controls.Add(Me.lblThis)
        Me.Controls.Add(Me.gbRecorrer)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblDato)
        Me.Name = "Arbol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arbol"
        Me.gbRecorrer.ResumeLayout(False)
        Me.gbRecorrer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDato As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents gbRecorrer As GroupBox
    Friend WithEvents btnRecorrer As Button
    Friend WithEvents rbtnPostOrden As RadioButton
    Friend WithEvents rbtnPreOrden As RadioButton
    Friend WithEvents rbtnOrden As RadioButton
    Friend WithEvents lblThis As Label
    Friend WithEvents btnIdentificar As Button
    Friend WithEvents btnAltura As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnMenu As Button
End Class
