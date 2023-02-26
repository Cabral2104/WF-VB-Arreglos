<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBLCantPersonas = New System.Windows.Forms.Label()
        Me.txtCantPersonas = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LBLCantPersonas
        '
        Me.LBLCantPersonas.AutoSize = True
        Me.LBLCantPersonas.Location = New System.Drawing.Point(105, 15)
        Me.LBLCantPersonas.Name = "LBLCantPersonas"
        Me.LBLCantPersonas.Size = New System.Drawing.Size(95, 13)
        Me.LBLCantPersonas.TabIndex = 0
        Me.LBLCantPersonas.Text = "Num de Contactos"
        '
        'txtCantPersonas
        '
        Me.txtCantPersonas.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtCantPersonas.Location = New System.Drawing.Point(206, 12)
        Me.txtCantPersonas.Name = "txtCantPersonas"
        Me.txtCantPersonas.Size = New System.Drawing.Size(100, 20)
        Me.txtCantPersonas.TabIndex = 1
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(151, 96)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 2
        Me.lblTelefono.Text = "Telefono"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(156, 58)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(90, 133)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaNacimiento.TabIndex = 4
        Me.lblFechaNacimiento.Text = "Fecha De Nacimiento"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtNombre.Location = New System.Drawing.Point(205, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(163, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTelefono.Location = New System.Drawing.Point(205, 93)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(163, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(205, 127)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Imprimir.Location = New System.Drawing.Point(474, 58)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(195, 88)
        Me.Imprimir.TabIndex = 8
        Me.Imprimir.Text = "Guardar Contacto"
        Me.Imprimir.UseVisualStyleBackColor = False
        '
        'lblRespuesta
        '
        Me.lblRespuesta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRespuesta.Location = New System.Drawing.Point(105, 191)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(548, 194)
        Me.lblRespuesta.TabIndex = 9
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(156, 165)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 10
        Me.lblCorreo.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtCorreo.Location = New System.Drawing.Point(205, 158)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(179, 20)
        Me.txtCorreo.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 450)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtCantPersonas)
        Me.Controls.Add(Me.LBLCantPersonas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLCantPersonas As Label
    Friend WithEvents txtCantPersonas As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Imprimir As Button
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
End Class
