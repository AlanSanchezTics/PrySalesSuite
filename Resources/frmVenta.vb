Public Class frmVenta
    Private total As Double
    Private Sub btnCobrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCobrar.Click
        Dim folio As Integer
        Dim ven As New frmPago
        If ven.ShowDialog() = Windows.Forms.DialogResult.OK Then
        strSQL = "proAltaVenta"
            comando = New SqlClient.SqlCommand(strSQL, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@cliID", SqlDbType.BigInt).Value = 1
            comando.Parameters.Add("@usuNombre", SqlDbType.VarChar, 100).Value = usuNombre
            comando.Parameters.Add("@venTotal", SqlDbType.Money).Value = CDbl(lbltotal.Text)
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
            If conectar() = True Then
                folio = comando.Parameters("@retorno").Value
                strSQL = "proAltaDetVenta"
                Dim max As Integer = dtgArticulos.RowCount
                For x As Integer = 0 To max - 1 Step 1
                    comando = New SqlClient.SqlCommand(strSQL, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Add("@artNombre", SqlDbType.VarChar, 50).Value = dtgArticulos(0, x).Value
                    comando.Parameters.Add("@venID", SqlDbType.BigInt).Value = folio
                    comando.Parameters.Add("@detCantidad", SqlDbType.BigInt).Value = CInt(Me.dtgArticulos(1, x).Value)
                    comando.Parameters.Add("@detSubtotal", SqlDbType.Money).Value = CDbl(Me.dtgArticulos(3, x).Value)
                    conectar()
                Next
                MsgBox("Su cambio es de " & (pago - CDbl(lbltotal.Text)) & " Pesos")
                limpiar()
            End If
        End If
    End Sub

    Private Sub cbtipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbtipo.SelectedIndexChanged
        If cbtipo.Text = "Cantidad" Then
            lbllitros.Visible = True
            txtlitros.Visible = True
            txtlitros.Text = ""
            lblprecio.Visible = False
            txtprecio.Visible = False
            txtprecio.Text = ""
        ElseIf cbtipo.Text = "Monto" Then
            lbllitros.Visible = False
            txtlitros.Visible = False
            lblprecio.Visible = True
            txtprecio.Visible = True
            txtlitros.Text = ""
            txtprecio.Text = ""
        End If
        btnadd.Enabled = True
    End Sub

    Private Sub lbArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbArticulo.SelectedIndexChanged
        lblProducto.Text = lbArticulo.SelectedValue
        cbtipo.Enabled = True
        btnsearch.Enabled = True
    End Sub
    Private Sub limpiar()
        lblproducto.Text = ""
        lbltotal.Text = "0.00"
        dtgArticulos.Rows.Clear()
        btnadd.Enabled = False
        cbtipo.Enabled = False
        btnsearch.Enabled = False
        btnCobrar.Enabled = False
        lblprecio.Visible = False
        txtprecio.Visible = False
        lblLitros.Visible = False
        txtlitros.Visible = False
        lbArticulo.ClearSelected()
    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        If Not (txtlitros.Text = "" And txtprecio.Text = "") Then
            Dim max As Integer = dtgArticulos.RowCount
            Dim cantidad As String = ""
            Dim precio As Integer
            Dim Stock As Integer
            If cbtipo.Text = "Cantidad" Then
                cantidad = txtlitros.Text
            ElseIf cbtipo.Text = "Monto" Then
                cantidad = txtprecio.Text
            End If
            strSQL = "SELECT artPrecio, artStock FROM tblArticulos WHERE artNombre= '" & lblProducto.Text & "'"
            If leerArticulos("tblArticulos") = True Then
                precio = dts.Tables("tblArticulos").Rows(0).Item(0)
                Stock = dts.Tables("tblArticulos").Rows(0).Item(1)
            End If
            Dim cant As Double
            If max > 0 Then
                For x As Integer = 0 To max - 1 Step 1
                    If dtgArticulos(0, x).Value = lblProducto.Text Then
                        cant = dtgArticulos(1, x).Value
                        cant = cant + txtlitros.Text
                        If Stock >= cant Then
                            dtgArticulos(1, x).Value = cant
                            dtgArticulos(3, x).Value = (cant * dtgArticulos(2, x).Value)
                            total = total + CDbl(precio * CDbl(txtlitros.Text))
                            lbltotal.Text = total
                            Exit Sub
                        Else
                            MsgBox("No existe la cantidad suficiente del articulo a vender", MsgBoxStyle.Critical, "")
                            Exit Sub
                        End If
                    End If
                Next
                If (Stock >= txtlitros.Text) Then
                    If txtlitros.Visible = True Then
                        dtgArticulos.Rows.Add(lbArticulo.SelectedValue.ToString, cantidad, precio, CStr(precio * CDbl(txtlitros.Text)))
                        total = total + CDbl(precio * CDbl(txtlitros.Text))
                    ElseIf txtprecio.Visible = True Then
                        Dim x As Integer = CInt(txtprecio.Text)
                        dtgArticulos.Rows.Add(lbArticulo.SelectedValue.ToString, CStr(CInt(txtprecio.Text) / precio), precio, txtprecio.Text)
                        total = total + CDbl(txtprecio.Text)
                    End If
                    lbltotal.Text = total
                    btnCobrar.Enabled = True
                Else
                    MsgBox("No existe la cantidad suficiente del articulo a vender", MsgBoxStyle.Critical, "")
                End If
            Else
                If (Stock >= txtlitros.Text) Then
                    If txtlitros.Visible = True Then
                        dtgArticulos.Rows.Add(lbArticulo.SelectedValue.ToString, cantidad, precio, CStr(precio * CDbl(txtlitros.Text)))
                        total = total + CDbl(precio * CDbl(txtlitros.Text))
                    ElseIf txtprecio.Visible = True Then
                        Dim x As Integer = CInt(txtprecio.Text)
                        dtgArticulos.Rows.Add(lbArticulo.SelectedValue.ToString, CStr(CInt(txtprecio.Text) / precio), precio, txtprecio.Text)
                        total = total + CDbl(txtprecio.Text)
                    End If
                    lbltotal.Text = total
                    btnCobrar.Enabled = True
                Else
                    MsgBox("No existe la cantidad suficiente del articulo a vender", MsgBoxStyle.Critical, "")
                End If
            End If
        End If
    End Sub

    Private Sub frmVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblArticulos' table. You can move, or remove it, as needed.
        Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)
        limpiar()
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        strSQL = "SELECT artPrecio FROM tblArticulos WHERE artNombre= '" & lblProducto.Text & "'"
        If leerArticulos("tblArticulos") = True Then
            MsgBox("Articulo: " & lblProducto.Text & " | Precio por litro: $" & dts.Tables("tblArticulos").Rows(0).Item(0), MsgBoxStyle.Information, "Precio de producto")
        End If
    End Sub

    Private Sub BtnRetiro_Click(sender As System.Object, e As System.EventArgs) Handles btnCorte.Click
        Dim v As New frmPago
        If v.ShowDialog = Windows.Forms.DialogResult.OK Then
            strSQL = "proRetiro"
            comando = New SqlClient.SqlCommand(strSQL, conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@retCantidad", SqlDbType.Money).Value = pago
            comando.Parameters.Add("@usuNombre", SqlDbType.VarChar, 50).Value = usuNombre
            If conectar() = True Then
                MsgBox("Retiro Realizado")
            End If
        End If
    End Sub

    Private Sub txtlitros_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtlitros.KeyPress
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

    Private Sub txtprecio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
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

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        If dtgArticulos.RowCount > 0 Then
            lbltotal.Text = (lbltotal.Text - dtgArticulos.CurrentRow.Cells("cTotal").Value)
            dtgArticulos.Rows.RemoveAt(Me.dtgArticulos.CurrentRow.Index)
        End If
    End Sub
End Class