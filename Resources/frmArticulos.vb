Public Class frmArticulos

    Private Sub Txtalta_Click(sender As System.Object, e As System.EventArgs) Handles ButtAlta.Click
        Dim z As New frmmArticulos
        idbusqueda = 0
        If z.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)
        End If
    End Sub

    Private Sub TxtBaja_Click(sender As System.Object, e As System.EventArgs) Handles ButtBaja.Click
        If DtgArticulos.RowCount > 0 Then
            Dim res As Integer = MsgBox("Estas seguro que deseas eliminar al usuario con el nombre de " & DtgArticulos.CurrentRow.Cells("ArtNombre").Value & "?", MsgBoxStyle.YesNoCancel, "")
            If res = 6 Then
                strSQL = "proDelArticulo"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@artCodigo", SqlDbType.BigInt).Value = DtgArticulos.CurrentRow.Cells("artCodigo").Value
                conectar()
                Me.TblArticulosTableAdapter.Connection = conexion
                Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)
            Else
                MsgBox("Operacion Cancelada", MsgBoxStyle.Exclamation, "")
            End If
        Else
            MsgBox("No hay elementos para eliminar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub frmArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)
    End Sub
    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        TblArticulosBindingSource.Filter = "artNombre LIKE '*" & txtNombre.Text & "*'"
    End Sub

    Private Sub ButtMod_Click(sender As System.Object, e As System.EventArgs) Handles ButtMod.Click
        Dim z As New frmmArticulos
        idbusqueda = DtgArticulos.CurrentRow.Cells("ArtCodigo").Value
        z.TxtNom.Text = DtgArticulos.CurrentRow.Cells("ArtNombre").Value
        z.TxtPreu.Text = DtgArticulos.CurrentRow.Cells("ArtPrecio").Value
        z.CbxCat.Text = DtgArticulos.CurrentRow.Cells("CatNombre").Value
        'z.CbxPro.Text = DtgArticulos.CurrentRow.Cells("ProvNombre").Value
        z.CbxUni.Text = DtgArticulos.CurrentRow.Cells("ArtUnidad").Value
        If z.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)
        End If
    End Sub

    Private Sub ButtSalir_Click(sender As System.Object, e As System.EventArgs) Handles ButtSalir.Click
        Me.Close()

    End Sub
End Class
