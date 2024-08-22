Imports System.Data.SqlClient
Imports Almacen.AlmacenesDBDataSetTableAdapters


Public Class Mercancias1
    Private Sub Mercancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Structure Productos

        Dim ID_producto As Integer
        Dim Nombre As String
        Dim Descripcion As String
        Dim precio As Integer
        Dim cantidad As Integer
    End Structure

    Private mercancias As New List(Of Mercancias1)

    Private Const connectionString As String = "Server=DESKTOP-I90EIJK;Database=Almacenes;Integrated Security=True;"


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim nuevoRegistro As New Mercancias1

        nuevoRegistro.ID_producto = Integer.Parse(txtID_producto.Text)
        nuevoRegistro.Nombre = txtnombre.Text
        nuevoRegistro.Descripcion = txtdescripcion.Text
        nuevoRegistro.precio = txtprecio.Text
        nuevoRegistro.cantidad = txtcantidad.Text

        Using connection As New SqlConnection(connectionString)

            Dim query As String "INSERT INTO Productos (ID_producto, Nombre, Descripcion, precio, cantidad) VALUES (@ID_producto, @Nombre, @Descripcion, @Precio, @Cantidad)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID_producto", nuevoRegistro.ID_producto)
                command.Parameters.AddWithValue("@Nombre", nuevoRegistro.Nombre)
                command.Parameters.AddWithValue("@Descripcion", nuevoRegistro.Descripcion)
                command.Parameters.AddWithValue("@precio", nuevoRegistro.precio)
                command.Parameters.AddWithValue("@cantidad", nuevoRegistro.cantidad)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Producto agregado exitosamente.")
                    ' Volver a cargar los datos en el DataGridView
                    CargarDatos()
                Catch ex As Exception
                    MessageBox.Show("Error al agregar el Producto. Asegúrese de que todos los campos están correctos.")
                End Try
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class