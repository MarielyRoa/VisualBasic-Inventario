Imports System.Data.SqlClient
Public Class Menu
    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click

    End Sub

    Private Sub MercanciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercanciaToolStripMenuItem.Click
        Dim MercanciasForm As New Mercancias1()
        MercanciasForm.Show()
        Me.Hide() '
    End Sub
End Class