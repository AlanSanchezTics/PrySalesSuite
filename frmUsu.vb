Public Class frmUsu

    Private Sub frmUsu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblUsuarios' table. You can move, or remove it, as needed.
        Me.TblUsuariosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblUsuarios)

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtSearch.TextChanged
        TblUsuariosBindingSource.Filter = "usuNombre LIKE '*" & TxtSearch.Text & "*'"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Dim u As New frmUsers
        idbusqueda = 0
        If u.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblUsuariosTableAdapter.Connection = conexion
            Me.TblUsuariosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblUsuarios)
        End If

    End Sub

    Private Sub cmdExit_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdChg_Click(sender As System.Object, e As System.EventArgs) Handles cmdChg.Click
        Dim u As New frmUsers
        idbusqueda = dgtUsu.CurrentRow.Cells("usuID").Value
        u.TxtName.Text = dgtUsu.CurrentRow.Cells("usuNombre").Value
        u.TxtLogin.Text = dgtUsu.CurrentRow.Cells("usuLogin").Value
        u.TxtPass.Text = dgtUsu.CurrentRow.Cells("usuClave").Value
        If dgtUsu.CurrentRow.Cells("usuTipo").Value = "Encargado" Then
            u.CmbType.SelectedIndex = 1
        Else
            u.CmbType.SelectedIndex = 0
        End If

        If u.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TblUsuariosTableAdapter.Connection = conexion
            Me.TblUsuariosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblUsuarios)
        End If
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        If dgtUsu.RowCount > 0 Then
            Dim res As Integer = MsgBox("¿Estas seguro que deseas eliminar al usuario con el nombre de " & dgtUsu.CurrentRow.Cells("usuNombre").Value & "?", MsgBoxStyle.YesNoCancel, "")
            If res = 6 Then
                strSQL = "proDelUsuario"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@usuID", SqlDbType.BigInt).Value = dgtUsu.CurrentRow.Cells("usuID").Value
                conectar()
                MsgBox("Usuario Eliminado con exito", MsgBoxStyle.Information, "")
                Me.TblUsuariosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblUsuarios)
            Else
                MsgBox("Operacion Cancelada", MsgBoxStyle.Exclamation, "")
            End If
        Else
            MsgBox("No hay elementos para eliminar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

End Class