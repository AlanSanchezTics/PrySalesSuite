Public Class Categorias

    Private Sub Categorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblCategorias' table. You can move, or remove it, as needed.
        Me.TblCategoriasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCategorias)

    End Sub
    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        TblCategoriasBindingSource.Filter = "catNombre LIKE '*" & txtNombre.Text & "*'"
    End Sub
    Private Sub btnNCategoria_Click(sender As System.Object, e As System.EventArgs) Handles btnNCategoria.Click
        idbusqueda = 0
        Dim ven As New FrmAgrModCategoria
        If ven.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblCategoriasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCategorias)
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As System.Object, e As System.EventArgs) Handles btnmodificar.Click
        Dim ven As New FrmAgrModCategoria
        idbusqueda = dtgCategorias.CurrentRow.Cells("catID").Value
        ven.txtNombre.Text = dtgCategorias.CurrentRow.Cells("catNombre").Value
        ven.txtdes.Text = dtgCategorias.CurrentRow.Cells("CatDescripcion").Value
        If ven.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblCategoriasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCategorias)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If dtgCategorias.RowCount > 0 Then
            Dim res As Integer = MsgBox("Realmente deseas eliminar la categoria " & dtgCategorias.CurrentRow.Cells("catNombre").Value & "?", MsgBoxStyle.YesNo, "")
            If res = 6 Then
                strSQL = "proDelCat"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@catID", SqlDbType.BigInt).Value = dtgCategorias.CurrentRow.Cells("catID").Value
                conectar()
                MsgBox("Categoria eliminada con exito", MsgBoxStyle.Information, "")
                Me.TblCategoriasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCategorias)
            Else
                MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "")
            End If
        Else
            MsgBox("No hay elementos para eliminar", MsgBoxStyle.Critical, "")
        End If
    End Sub
End Class