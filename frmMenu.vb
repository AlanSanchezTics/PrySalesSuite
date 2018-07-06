Public Class frmMenu

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Format(Date.Now().Date, "| yyyy-MM-dd |") & Format(Date.Now(), " hh:mm:ss |")
    End Sub

    Private Sub frmMenu_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim ven As New frmVenta
        ven.MdiParent = Me
        ven.Show()
        lblUser.Text = usuNombre
        If tipo = "A" Then
            tsmArticulos.Visible = True
            tsmCategorias.Visible = True
            tsmClientes.Visible = True
            tsmCompras.Visible = True
            tsmProveedores.Visible = True
            tsmReportes.Visible = True
            tsmUsuarios.Visible = True
        ElseIf tipo = "O" Then
            tsmArticulos.Visible = False
            tsmCategorias.Visible = False
            tsmClientes.Visible = False
            tsmCompras.Visible = False
            tsmProveedores.Visible = False
            tsmReportes.Visible = False
            tsmUsuarios.Visible = False
        End If
    End Sub

    Private Sub tsmVenta_Click(sender As System.Object, e As System.EventArgs) Handles tsmVenta.Click
        cerrarChildrens()
        Dim ventana As New frmVenta
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub tsmClientes_Click(sender As System.Object, e As System.EventArgs) Handles tsmClientes.Click
        cerrarChildrens()
        Dim ventana As New frmClientes
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
    Private Sub cerrarChildrens()
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub

    Private Sub tsmadmArt_Click(sender As System.Object, e As System.EventArgs) Handles tsmArticulos.Click
        cerrarChildrens()
        Dim ven As New frmArticulos
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub tsmCompras_Click(sender As System.Object, e As System.EventArgs) Handles tsmCompras.Click
        cerrarChildrens()
        Dim ven As New frmCompras
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub tsmUsuarios_Click(sender As System.Object, e As System.EventArgs) Handles tsmUsuarios.Click
        cerrarChildrens()
        Dim ven As New frmUsu
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub tsmProveedores_Click(sender As System.Object, e As System.EventArgs) Handles tsmProveedores.Click
        cerrarChildrens()
        Dim ven As New FrmProvedores
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub tsmCategorias_Click(sender As System.Object, e As System.EventArgs) Handles tsmCategorias.Click
        cerrarChildrens()
        Dim ven As New Categorias
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub tsmReportes_Click(sender As System.Object, e As System.EventArgs) Handles tsmReportes.Click
        Dim v As New FrmReportes
        v.ShowDialog()
    End Sub

    Private Sub tsmsalir_Click(sender As System.Object, e As System.EventArgs) Handles tsmsalir.Click
        Dim v As New frmLogin
        v.Show()
        Me.Dispose()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim v As New frmLogin
        v.Show()
        Me.Dispose()
    End Sub

    Private Sub VentaDeProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentaDeProductoToolStripMenuItem.Click
        cerrarChildrens()
        Dim ventana As New frmVenta
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub CatalogoDeProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeProductosToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New frmArticulos
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub CatalogoDeProveedoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeProveedoresToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New FrmProvedores
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub CatalogoDeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeClientesToolStripMenuItem.Click
        cerrarChildrens()
        Dim ventana As New frmClientes
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub CatalogoUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoUsuariosToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New frmUsu
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub CatalogoDeCategoriasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeCategoriasToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New Categorias
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub CompraDeProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompraDeProductosToolStripMenuItem.Click
        cerrarChildrens()
        Dim ven As New frmCompras
        ven.MdiParent = Me
        ven.Show()
    End Sub

    Private Sub GenerarReportesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarReportesToolStripMenuItem.Click
        Dim v As New FrmReportes
        v.ShowDialog()
    End Sub
End Class
