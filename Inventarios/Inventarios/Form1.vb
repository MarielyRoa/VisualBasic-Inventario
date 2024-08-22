Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Dim connectionstring As String = "Server=DESKTOP-I90EIJK;Database=Almacenes;User Id=admin;Password=1234;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Dim usuario As String = txtusuario.Text
        Dim contraseña As String = txtcontraseña.Text

        If usuario = "admin" And contraseña = "1234" Then
            ' Credenciales válidas, puedes abrir el formulario principal o hacer otras acciones.
            MessageBox.Show("Inicio de sesión exitoso.")
            ' Ejemplo de apertura de otro formulario:
            Dim menuForm As New Menu()
            menuForm.Show()
            Me.Hide() ' Oculta el formulario actual si es necesario.
        Else
            ' Credenciales inválidas, muestra un mensaje de error.
            MessageBox.Show("Nombre de usuario o contraseña incorrectos.")
        End If
    End Sub
End Class
