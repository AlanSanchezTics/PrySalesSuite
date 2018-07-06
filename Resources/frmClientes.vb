Public Class frmClientes

    Private Sub frmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TblClientesTableAdapter.Fill(Me.BdSaleSuitDataSet.tblClientes)
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim v As New frmmClientes
        idbusqueda = 0
        If v.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblClientesTableAdapter.Connection = conexion
            Me.TblClientesTableAdapter.Fill(Me.BdSaleSuitDataSet.tblClientes)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim v As New frmmClientes
        idbusqueda = dtgClientes.CurrentRow.Cells("cliID").Value
        v.txtnombre.Text = dtgClientes.CurrentRow.Cells("cliNombre").Value
        v.txtdireccion.Text = dtgClientes.CurrentRow.Cells("cliDireccion").Value
        v.txtrfc.Text = dtgClientes.CurrentRow.Cells("cliRFC").Value
        v.txtemail.Text = dtgClientes.CurrentRow.Cells("cliEmail").Value
        v.txttel.Text = dtgClientes.CurrentRow.Cells("cliTel").Value
        If v.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblClientesTableAdapter.Connection = conexion
            Me.TblClientesTableAdapter.Fill(Me.BdSaleSuitDataSet.tblClientes)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtrfc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtrfc.TextChanged
        Me.TblClientesBindingSource.Filter = "cliNombre LIKE '*" & Me.txtrfc.Text & "*'"
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If dtgClientes.RowCount > 0 Then
            Dim res As Integer = MsgBox("Estas seguro que deseas eliminar al usuario con el nombre de " & dtgClientes.CurrentRow.Cells("cliNombre").Value & "?", MsgBoxStyle.YesNoCancel, "")
            If res = 6 Then
                strSQL = "proDelCliente"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@cliID", SqlDbType.BigInt).Value = dtgClientes.CurrentRow.Cells("cliID").Value
                conectar()
                Me.TblClientesTableAdapter.Connection = conexion
                Me.TblClientesTableAdapter.Fill(Me.BdSaleSuitDataSet.tblClientes)
            Else
                MsgBox("Operacion Cancelada", MsgBoxStyle.Exclamation, "")
            End If
        Else
            MsgBox("No hay elementos para eliminar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class