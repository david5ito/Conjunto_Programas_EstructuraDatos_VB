<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafos
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Grafo1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Grafo1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Grafo1ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverNodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AristaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirigidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoDirigidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdyacenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Grafo1ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Grafo1ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Snow
        Me.PictureBox1.Location = New System.Drawing.Point(16, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1035, 491)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Snow
        Me.MenuStrip1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.NodoToolStripMenuItem, Me.AristaToolStripMenuItem, Me.MatrizToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Grafo1ToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'Grafo1ToolStripMenuItem
        '
        Me.Grafo1ToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.Grafo1ToolStripMenuItem.Name = "Grafo1ToolStripMenuItem"
        Me.Grafo1ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Grafo1ToolStripMenuItem.Text = "Grafo 1"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.BorrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Grafo1ToolStripMenuItem1})
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'Grafo1ToolStripMenuItem1
        '
        Me.Grafo1ToolStripMenuItem1.BackColor = System.Drawing.Color.Snow
        Me.Grafo1ToolStripMenuItem1.Name = "Grafo1ToolStripMenuItem1"
        Me.Grafo1ToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.Grafo1ToolStripMenuItem1.Text = "Grafo 1"
        '
        'NodoToolStripMenuItem
        '
        Me.NodoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.MoverTodoToolStripMenuItem, Me.MoverNodoToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.NodoToolStripMenuItem.Name = "NodoToolStripMenuItem"
        Me.NodoToolStripMenuItem.Size = New System.Drawing.Size(69, 26)
        Me.NodoToolStripMenuItem.Text = "Nodo"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Grafo1ToolStripMenuItem2})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'Grafo1ToolStripMenuItem2
        '
        Me.Grafo1ToolStripMenuItem2.BackColor = System.Drawing.Color.Snow
        Me.Grafo1ToolStripMenuItem2.Name = "Grafo1ToolStripMenuItem2"
        Me.Grafo1ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.Grafo1ToolStripMenuItem2.Text = "Grafo 1"
        '
        'MoverTodoToolStripMenuItem
        '
        Me.MoverTodoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.MoverTodoToolStripMenuItem.Name = "MoverTodoToolStripMenuItem"
        Me.MoverTodoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MoverTodoToolStripMenuItem.Text = "Mover Todo"
        '
        'MoverNodoToolStripMenuItem
        '
        Me.MoverNodoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.MoverNodoToolStripMenuItem.Name = "MoverNodoToolStripMenuItem"
        Me.MoverNodoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MoverNodoToolStripMenuItem.Text = "Mover Nodo"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'AristaToolStripMenuItem
        '
        Me.AristaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.AristaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirigidaToolStripMenuItem, Me.NoDirigidaToolStripMenuItem, Me.EliminarToolStripMenuItem1})
        Me.AristaToolStripMenuItem.Name = "AristaToolStripMenuItem"
        Me.AristaToolStripMenuItem.Size = New System.Drawing.Size(77, 26)
        Me.AristaToolStripMenuItem.Text = "Arista"
        '
        'DirigidaToolStripMenuItem
        '
        Me.DirigidaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.DirigidaToolStripMenuItem.Name = "DirigidaToolStripMenuItem"
        Me.DirigidaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DirigidaToolStripMenuItem.Text = "Dirigida"
        '
        'NoDirigidaToolStripMenuItem
        '
        Me.NoDirigidaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.NoDirigidaToolStripMenuItem.Name = "NoDirigidaToolStripMenuItem"
        Me.NoDirigidaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NoDirigidaToolStripMenuItem.Text = "No Dirigida"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.BackColor = System.Drawing.Color.Snow
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'MatrizToolStripMenuItem
        '
        Me.MatrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdyacenciaToolStripMenuItem, Me.PesoToolStripMenuItem})
        Me.MatrizToolStripMenuItem.Name = "MatrizToolStripMenuItem"
        Me.MatrizToolStripMenuItem.Size = New System.Drawing.Size(80, 26)
        Me.MatrizToolStripMenuItem.Text = "Matriz"
        '
        'AdyacenciaToolStripMenuItem
        '
        Me.AdyacenciaToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.AdyacenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Grafo1ToolStripMenuItem3})
        Me.AdyacenciaToolStripMenuItem.Name = "AdyacenciaToolStripMenuItem"
        Me.AdyacenciaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AdyacenciaToolStripMenuItem.Text = "Adyacencia"
        '
        'Grafo1ToolStripMenuItem3
        '
        Me.Grafo1ToolStripMenuItem3.BackColor = System.Drawing.Color.Snow
        Me.Grafo1ToolStripMenuItem3.Name = "Grafo1ToolStripMenuItem3"
        Me.Grafo1ToolStripMenuItem3.Size = New System.Drawing.Size(224, 26)
        Me.Grafo1ToolStripMenuItem3.Text = "Grafo 1"
        '
        'PesoToolStripMenuItem
        '
        Me.PesoToolStripMenuItem.BackColor = System.Drawing.Color.Snow
        Me.PesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Grafo1ToolStripMenuItem4})
        Me.PesoToolStripMenuItem.Name = "PesoToolStripMenuItem"
        Me.PesoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PesoToolStripMenuItem.Text = "Peso"
        '
        'Grafo1ToolStripMenuItem4
        '
        Me.Grafo1ToolStripMenuItem4.BackColor = System.Drawing.Color.Snow
        Me.Grafo1ToolStripMenuItem4.Name = "Grafo1ToolStripMenuItem4"
        Me.Grafo1ToolStripMenuItem4.Size = New System.Drawing.Size(224, 26)
        Me.Grafo1ToolStripMenuItem4.Text = "Grafo 1"
        '
        'Grafos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Grafos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grafos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Grafo1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Grafo1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Grafo1ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MoverTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverNodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AristaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirigidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoDirigidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdyacenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Grafo1ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PesoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Grafo1ToolStripMenuItem4 As ToolStripMenuItem
End Class
