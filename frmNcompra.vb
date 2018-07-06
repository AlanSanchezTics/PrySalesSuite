Public Class frmNcompra

    Private Sub frmNcompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblProveedores' table. You can move, or remove it, as needed.
        Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblArticulos' table. You can move, or remove it, as needed.
        Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If nudcantidad.Value > 0 Then
            strSQL = "proAltaCompra"
            Dim max As Integer = dtgListCompras.RowCount
            For x As Integer = 0 To max - 1 Step 1
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@artNombre", SqlDbType.VarChar, 50).Value = dtgListCompras(0, x).Value
                comando.Parameters.Add("@cantidad", SqlDbType.Int).Value = dtgListCompras(1, x).Value
                comando.Parameters.Add("@provNombre", SqlDbType.VarChar, 50).Value = dtgListCompras(2, x).Value
                comando.Parameters.Add("@costo", SqlDbType.Money).Value = dtgListCompras(3, x).Value
                comando.Parameters.Add("@compTotal", SqlDbType.Money).Value = dtgListCompras(4, x).Value
                comando.Parameters.Add("@compFecha", SqlDbType.DateTime).Value = Format(Date.Now, "yyyy-MM-dd")
                conectar()
            Next
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
                MsgBox("Compra Registrada con exito", MsgBoxStyle.Information, "")
            End If
    End Sub

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        If Not (nudcantidad.Value = 0 Or txtCosto.Text.Trim = "") Then
            dtgListCompras.Rows.Add(cbArticulo.Text, nudcantidad.Value, cbProveedores.Text, txtCosto.Text, (CDbl(txtCosto.Text) * CInt(nudcantidad.Value)))
            lbltotal.Text = (lbltotal.Text + (txtCosto.Text * nudcantidad.Value))
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

End Class