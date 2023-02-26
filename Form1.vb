Public Class Form1
    Dim cantidadpersonas As Int32 = 0
    Dim registrados As Int32 = 0
    Dim registro() As Contacto
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCantPersonas_TextChanged(sender As Object, e As EventArgs) Handles txtCantPersonas.TextChanged
        cantidadpersonas = txtCantPersonas.Text
        registrados = 0
        ReDim registro(cantidadpersonas)
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        If (registrados < cantidadpersonas) Then
            Dim contactonew = New Contacto()
            contactonew.nombre_ = txtNombre.Text
            contactonew.fechadenacimiento_ = dtpFecha.Text
            contactonew.telefono_ = txtTelefono.Text
            contactonew.correo_ = txtCorreo.Text
            registro(registrados) = contactonew
            registrados = registrados + 1
            Dim lineanueva As String = contactonew.nombre_ + ", " + contactonew.edad.ToString() + ", " + contactonew.telefono_.ToString() + ", " + contactonew.correo_.ToString() + Environment.NewLine
            lblRespuesta.Text = lblRespuesta.Text + lineanueva
        Else
            MsgBox("Se terminó el registro")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCorreo.Click

    End Sub

    Private Sub lblFechaNacimiento_Click(sender As Object, e As EventArgs) Handles lblFechaNacimiento.Click

    End Sub
End Class
