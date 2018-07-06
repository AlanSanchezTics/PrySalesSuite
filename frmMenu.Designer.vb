<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tsStatus = New System.Windows.Forms.ToolStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripLabel()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsmVenta = New System.Windows.Forms.ToolStripButton()
        Me.tsmsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmArticulos = New System.Windows.Forms.ToolStripButton()
        Me.tsmProveedores = New System.Windows.Forms.ToolStripButton()
        Me.tsmCategorias = New System.Windows.Forms.ToolStripButton()
        Me.tsmCompras = New System.Windows.Forms.ToolStripButton()
        Me.tsmClientes = New System.Windows.Forms.ToolStripButton()
        Me.tsmUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.tsmReportes = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsStatus.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsStatus
        '
        Me.tsStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.lblDate})
        Me.tsStatus.Location = New System.Drawing.Point(0, 236)
        Me.tsStatus.Name = "tsStatus"
        Me.tsStatus.Size = New System.Drawing.Size(551, 25)
        Me.tsStatus.TabIndex = 3
        Me.tsStatus.Text = "ToolStrip2"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(145, 22)
        Me.lblUser.Text = "ToolStripLabel1"
        '
        'lblDate
        '
        Me.lblDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(145, 22)
        Me.lblDate.Text = "ToolStripLabel2"
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmVenta, Me.tsmsalir, Me.ToolStripSeparator1, Me.tsmArticulos, Me.tsmProveedores, Me.tsmCategorias, Me.tsmCompras, Me.tsmClientes, Me.tsmUsuarios, Me.tsmReportes})
        Me.tsMenu.Location = New System.Drawing.Point(0, 24)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(551, 39)
        Me.tsMenu.TabIndex = 5
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsmVenta
        '
        Me.tsmVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmVenta.Image = Global.PrySalesSuite.My.Resources.Resources.Sales_by_Payment_Method_rep
        Me.tsmVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmVenta.Name = "tsmVenta"
        Me.tsmVenta.Size = New System.Drawing.Size(36, 36)
        Me.tsmVenta.Text = "Nueva Venta"
        '
        'tsmsalir
        '
        Me.tsmsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmsalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit
        Me.tsmsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmsalir.Name = "tsmsalir"
        Me.tsmsalir.Size = New System.Drawing.Size(36, 36)
        Me.tsmsalir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsmArticulos
        '
        Me.tsmArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmArticulos.Image = Global.PrySalesSuite.My.Resources.Resources.file_roller
        Me.tsmArticulos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmArticulos.Name = "tsmArticulos"
        Me.tsmArticulos.Size = New System.Drawing.Size(36, 36)
        Me.tsmArticulos.Text = "Administracion de productos"
        '
        'tsmProveedores
        '
        Me.tsmProveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmProveedores.Image = Global.PrySalesSuite.My.Resources.Resources.supplier
        Me.tsmProveedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmProveedores.Name = "tsmProveedores"
        Me.tsmProveedores.Size = New System.Drawing.Size(36, 36)
        Me.tsmProveedores.Text = "Proveedores"
        '
        'tsmCategorias
        '
        Me.tsmCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmCategorias.Image = Global.PrySalesSuite.My.Resources.Resources.inventory_categories
        Me.tsmCategorias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmCategorias.Name = "tsmCategorias"
        Me.tsmCategorias.Size = New System.Drawing.Size(36, 36)
        Me.tsmCategorias.Text = "Gestion de Categorias"
        '
        'tsmCompras
        '
        Me.tsmCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmCompras.Image = Global.PrySalesSuite.My.Resources.Resources.shopping_cart
        Me.tsmCompras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmCompras.Name = "tsmCompras"
        Me.tsmCompras.Size = New System.Drawing.Size(36, 36)
        Me.tsmCompras.Text = "Registro de Compras"
        '
        'tsmClientes
        '
        Me.tsmClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmClientes.Image = Global.PrySalesSuite.My.Resources.Resources.clients
        Me.tsmClientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmClientes.Name = "tsmClientes"
        Me.tsmClientes.Size = New System.Drawing.Size(36, 36)
        Me.tsmClientes.Text = "Gestion de clientes"
        '
        'tsmUsuarios
        '
        Me.tsmUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmUsuarios.Image = Global.PrySalesSuite.My.Resources.Resources.users
        Me.tsmUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmUsuarios.Name = "tsmUsuarios"
        Me.tsmUsuarios.Size = New System.Drawing.Size(36, 36)
        Me.tsmUsuarios.Text = "Gestion de usuarios en sistema"
        '
        'tsmReportes
        '
        Me.tsmReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmReportes.Image = Global.PrySalesSuite.My.Resources.Resources.custom_reports
        Me.tsmReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmReportes.Name = "tsmReportes"
        Me.tsmReportes.Size = New System.Drawing.Size(36, 36)
        Me.tsmReportes.Text = "Administracion de reportes"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ModulosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaDeProductoToolStripMenuItem, Me.CatalogoDeProductosToolStripMenuItem, Me.CatalogoDeProveedoresToolStripMenuItem, Me.CatalogoDeClientesToolStripMenuItem, Me.CatalogoUsuariosToolStripMenuItem, Me.CatalogoDeCategoriasToolStripMenuItem, Me.CompraDeProductosToolStripMenuItem, Me.GenerarReportesToolStripMenuItem})
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ModulosToolStripMenuItem.Text = "Modulos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentaDeProductoToolStripMenuItem
        '
        Me.VentaDeProductoToolStripMenuItem.Name = "VentaDeProductoToolStripMenuItem"
        Me.VentaDeProductoToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.VentaDeProductoToolStripMenuItem.Text = "Venta de producto"
        '
        'CatalogoDeProductosToolStripMenuItem
        '
        Me.CatalogoDeProductosToolStripMenuItem.Name = "CatalogoDeProductosToolStripMenuItem"
        Me.CatalogoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CatalogoDeProductosToolStripMenuItem.Text = "Catalogo de productos"
        '
        'CatalogoDeProveedoresToolStripMenuItem
        '
        Me.CatalogoDeProveedoresToolStripMenuItem.Name = "CatalogoDeProveedoresToolStripMenuItem"
        Me.CatalogoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CatalogoDeProveedoresToolStripMenuItem.Text = "Catalogo de proveedores"
        '
        'CatalogoDeClientesToolStripMenuItem
        '
        Me.CatalogoDeClientesToolStripMenuItem.Name = "CatalogoDeClientesToolStripMenuItem"
        Me.CatalogoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CatalogoDeClientesToolStripMenuItem.Text = "Catalogo de Clientes"
        '
        'CatalogoUsuariosToolStripMenuItem
        '
        Me.CatalogoUsuariosToolStripMenuItem.Name = "CatalogoUsuariosToolStripMenuItem"
        Me.CatalogoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CatalogoUsuariosToolStripMenuItem.Text = "Catalogo Usuarios"
        '
        'CatalogoDeCategoriasToolStripMenuItem
        '
        Me.CatalogoDeCategoriasToolStripMenuItem.Name = "CatalogoDeCategoriasToolStripMenuItem"
        Me.CatalogoDeCategoriasToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CatalogoDeCategoriasToolStripMenuItem.Text = "Catalogo de Categorias"
        '
        'CompraDeProductosToolStripMenuItem
        '
        Me.CompraDeProductosToolStripMenuItem.Name = "CompraDeProductosToolStripMenuItem"
        Me.CompraDeProductosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CompraDeProductosToolStripMenuItem.Text = "Compra de productos"
        '
        'GenerarReportesToolStripMenuItem
        '
        Me.GenerarReportesToolStripMenuItem.Name = "GenerarReportesToolStripMenuItem"
        Me.GenerarReportesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.GenerarReportesToolStripMenuItem.Text = "Generar reportes"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 261)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.tsStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menu Principal"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsStatus.ResumeLayout(False)
        Me.tsStatus.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsStatus As System.Windows.Forms.ToolStrip
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsmVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmsalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmArticulos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsmClientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmCompras As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmUsuarios As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmProveedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmReportes As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmCategorias As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
