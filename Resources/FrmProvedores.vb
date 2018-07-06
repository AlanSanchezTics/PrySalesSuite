Public Class FrmProvedores
    Private Sub FrmProvedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblProveedores' table. You can move, or remove it, as needed.
        Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblProveedores' table. You can move, or remove it, as needed.
        Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
    End Sub


    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        TblProveedoresBindingSource.Filter = "provNombre LIKE '*" & txtNombre.Text & "*'"
    End Sub

    Private Sub ButAgregar_Click(sender As System.Object, e As System.EventArgs) Handles ButAgregar.Click
        Dim p As New FrmmProveedores
        idbusqueda = 0
        If p.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblProveedoresTableAdapter.Connection = conexion
            Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
        End If
    End Sub

    Private Sub ButMod_Click(sender As System.Object, e As System.EventArgs) Handles ButMod.Click
        Dim p As New FrmmProveedores
        idbusqueda = DtgProveedores.CurrentRow.Cells("provID").Value
        p.TxapNombre.Text = DtgProveedores.CurrentRow.Cells("provNombre").Value
        p.txtRFC.Text = DtgProveedores.CurrentRow.Cells("provRFC").Value
        p.TxapDireccion.Text = DtgProveedores.CurrentRow.Cells("provDireccion").Value
        p.MtxapTel.Text = DtgProveedores.CurrentRow.Cells("provTel").Value
        If p.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblProveedoresTableAdapter.Connection = conexion
            Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
        End If
    End Sub

    Private Sub ButEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButEliminar.Click
        If DtgProveedores.RowCount > 0 Then
            Dim res As Integer = MsgBox("¿Estas seguro que deseas eliminar al proveedor de " & DtgProveedores.CurrentRow.Cells("provNombre").Value & "?", MsgBoxStyle.YesNoCancel, "")
            If res = 6 Then
                strSQL = "proDelProveedor"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@provID", SqlDbType.BigInt).Value = DtgProveedores.CurrentRow.Cells("provID").Value
                conectar()
                MsgBox("Proveedor Eliminado con exito", MsgBoxStyle.Information, "")
                Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
            Else
                MsgBox("Operacion Cancelada", MsgBoxStyle.Exclamation, "")
            End If
        Else
            MsgBox("No hay elementos para eliminar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub ButSalir_Click(sender As System.Object, e As System.EventArgs) Handles ButSalir.Click
        Me.Close()
    End Sub
End Class