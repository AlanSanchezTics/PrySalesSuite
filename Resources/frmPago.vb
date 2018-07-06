Public Class frmPago

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "3"
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "5"
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "6"
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "8"
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Not (lblcant.Text.Length = 10) Then
            lblcant.Text = lblcant.Text & "0"
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Not (lblcant.Text.Length = 10) Then
            If Not (lblcant.Text.Contains(".")) Then
                lblcant.Text = lblcant.Text & "."
            End If
        End If
    End Sub
    Private Sub btnback_Click(sender As System.Object, e As System.EventArgs) Handles btnback.Click
        If Not (lblcant.Text = "") Then
            lblcant.Text = Mid(lblcant.Text, 1, Len(lblcant.Text) - 1)
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnPagar_Click(sender As System.Object, e As System.EventArgs) Handles btnPagar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        pago = CDbl(lblcant.Text)
        Me.Close()
    End Sub
End Class