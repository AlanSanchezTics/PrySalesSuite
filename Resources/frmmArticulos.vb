Public Class frmmArticulos
    Private Sub ButCom_Click(sender As System.Object, e As System.EventArgs) Handles ButCom.Click
        If Not (TxtNom.Text = "" Or TxtPreu.Text = "" Or CbxUni.Text = "") Then
            If idbusqueda = 0 Then
                strSQL = "proAltaArticulo"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                strSQL = "proModArticulo"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@artCodigo", SqlDbType.BigInt).Value = idbusqueda
            End If
            comando.Parameters.Add("@artNombre", SqlDbType.VarChar, 50).Value = Me.TxtNom.Text
            comando.Parameters.Add("@artUnidad", SqlDbType.VarChar, 10).Value = Me.CbxUni.Text
            comando.Parameters.Add("@artPrecio", SqlDbType.Money).Value = CDbl(Me.TxtPreu.Text)
            comando.Parameters.Add("@catNombre", SqlDbType.VarChar, 50).Value = Me.CbxCat.Text
            'comando.Parameters.Add("@provNombre", SqlDbType.VarChar, 50).Value = Me.CbxPro.Text
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
            If conectar() = True Then
                If comando.Parameters("@retorno").Value = 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                    MsgBox("Articulo Actualizado", MsgBoxStyle.Exclamation, "")
                Else
                    MsgBox("El articulo ya esta registrado", MsgBoxStyle.Critical, "Datos existentes")
                End If
            Else
                MsgBox("Error al realizar la operacion", MsgBoxStyle.Critical, "")
            End If
        End If
    End Sub

    Private Sub BtnSal_Click(sender As System.Object, e As System.EventArgs) Handles BtnSal.Click
        Me.Close()

    End Sub

    Private Sub frmmArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblProveedores' table. You can move, or remove it, as needed.
        Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblCategorias' table. You can move, or remove it, as needed.
        Me.TblCategoriasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCategorias)

    End Sub

    Private Sub TxtPreu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPreu.KeyPress
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