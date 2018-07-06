<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.dtgArticulos = New System.Windows.Forms.DataGridView()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.txtlitros = New System.Windows.Forms.TextBox()
        Me.lbllitros = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbArticulo = New System.Windows.Forms.ListBox()
        Me.TblArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.TblArticulosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter()
        Me.btnCorte = New System.Windows.Forms.Button()
        Me.CachedRptVentas1 = New PrySalesSuite.CachedRptVentas()
        Me.btnDel = New System.Windows.Forms.Button()
        CType(Me.dtgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCobrar
        '
        Me.btnCobrar.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Image = Global.PrySalesSuite.My.Resources.Resources.cobrar
        Me.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCobrar.Location = New System.Drawing.Point(285, 529)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(1057, 85)
        Me.btnCobrar.TabIndex = 38
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'dtgArticulos
        '
        Me.dtgArticulos.AllowUserToAddRows = False
        Me.dtgArticulos.AllowUserToDeleteRows = False
        Me.dtgArticulos.AllowUserToOrderColumns = True
        Me.dtgArticulos.AllowUserToResizeColumns = False
        Me.dtgArticulos.AllowUserToResizeRows = False
        Me.dtgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgArticulos.BackgroundColor = System.Drawing.Color.White
        Me.dtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cCantidad, Me.cPrecio, Me.cTotal})
        Me.dtgArticulos.Location = New System.Drawing.Point(284, 65)
        Me.dtgArticulos.Name = "dtgArticulos"
        Me.dtgArticulos.ReadOnly = True
        Me.dtgArticulos.RowHeadersVisible = False
        Me.dtgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgArticulos.Size = New System.Drawing.Size(1058, 415)
        Me.dtgArticulos.TabIndex = 37
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Articulos"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        '
        'cPrecio
        '
        Me.cPrecio.HeaderText = "Importe"
        Me.cPrecio.Name = "cPrecio"
        Me.cPrecio.ReadOnly = True
        '
        'cTotal
        '
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        '
        'btnsearch
        '
        Me.btnsearch.Enabled = False
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Image = Global.PrySalesSuite.My.Resources.Resources.searchIcon
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(817, 28)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(122, 36)
        Me.btnsearch.TabIndex = 36
        Me.btnsearch.Text = "Consultar"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Enabled = False
        Me.btnadd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.PrySalesSuite.My.Resources.Resources.add_to_cart_light
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(712, 28)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(101, 36)
        Me.btnadd.TabIndex = 35
        Me.btnadd.Text = "Añadir"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(148, 481)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(82, 32)
        Me.lbltotal.TabIndex = 34
        Me.lbltotal.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 32)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Total: $"
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(550, 37)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 27)
        Me.txtprecio.TabIndex = 32
        Me.txtprecio.Visible = False
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(547, 17)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(69, 18)
        Me.lblprecio.TabIndex = 31
        Me.lblprecio.Text = "Precio:"
        Me.lblprecio.Visible = False
        '
        'txtlitros
        '
        Me.txtlitros.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlitros.Location = New System.Drawing.Point(550, 37)
        Me.txtlitros.Name = "txtlitros"
        Me.txtlitros.Size = New System.Drawing.Size(100, 27)
        Me.txtlitros.TabIndex = 30
        Me.txtlitros.Visible = False
        '
        'lbllitros
        '
        Me.lbllitros.AutoSize = True
        Me.lbllitros.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllitros.Location = New System.Drawing.Point(547, 17)
        Me.lbllitros.Name = "lbllitros"
        Me.lbllitros.Size = New System.Drawing.Size(57, 18)
        Me.lbllitros.TabIndex = 29
        Me.lbllitros.Text = "Litros"
        Me.lbllitros.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Venta por:"
        '
        'cbtipo
        '
        Me.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipo.Enabled = False
        Me.cbtipo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Items.AddRange(New Object() {"Cantidad", "Monto"})
        Me.cbtipo.Location = New System.Drawing.Point(411, 36)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(121, 26)
        Me.cbtipo.TabIndex = 27
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(282, 33)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(66, 18)
        Me.lblProducto.TabIndex = 26
        Me.lblProducto.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Producto:"
        '
        'lbArticulo
        '
        Me.lbArticulo.DataSource = Me.TblArticulosBindingSource
        Me.lbArticulo.DisplayMember = "artNombre"
        Me.lbArticulo.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArticulo.FormattingEnabled = True
        Me.lbArticulo.ItemHeight = 23
        Me.lbArticulo.Location = New System.Drawing.Point(12, 14)
        Me.lbArticulo.Name = "lbArticulo"
        Me.lbArticulo.Size = New System.Drawing.Size(224, 464)
        Me.lbArticulo.TabIndex = 24
        Me.lbArticulo.ValueMember = "artNombre"
        '
        'TblArticulosBindingSource
        '
        Me.TblArticulosBindingSource.DataMember = "tblArticulos"
        Me.TblArticulosBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'BdSaleSuitDataSet
        '
        Me.BdSaleSuitDataSet.DataSetName = "bdSaleSuitDataSet"
        Me.BdSaleSuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblArticulosTableAdapter
        '
        Me.TblArticulosTableAdapter.ClearBeforeFill = True
        '
        'btnCorte
        '
        Me.btnCorte.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorte.Location = New System.Drawing.Point(12, 570)
        Me.btnCorte.Name = "btnCorte"
        Me.btnCorte.Size = New System.Drawing.Size(224, 42)
        Me.btnCorte.TabIndex = 40
        Me.btnCorte.Text = "Corte"
        Me.btnCorte.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(242, 219)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(36, 95)
        Me.btnDel.TabIndex = 41
        Me.btnDel.Text = "<<"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 624)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnCorte)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.dtgArticulos)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.lblprecio)
        Me.Controls.Add(Me.txtlitros)
        Me.Controls.Add(Me.lbllitros)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbtipo)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nueva venta"
        CType(Me.dtgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents dtgArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents lblprecio As System.Windows.Forms.Label
    Friend WithEvents txtlitros As System.Windows.Forms.TextBox
    Friend WithEvents lbllitros As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbArticulo As System.Windows.Forms.ListBox
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblArticulosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter
    Friend WithEvents btnCorte As System.Windows.Forms.Button
    Friend WithEvents CachedRptVentas1 As PrySalesSuite.CachedRptVentas
    Friend WithEvents btnDel As System.Windows.Forms.Button
End Class
