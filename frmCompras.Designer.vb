﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgCompras = New System.Windows.Forms.DataGridView()
        Me.TblComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNCompra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblComprasTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblComprasTableAdapter()
        Me.CompID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompExiste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(645, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 69)
        Me.Panel1.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy-MM-dd"
        Me.dtpFecha.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(114, 15)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(546, 32)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Value = New Date(2017, 6, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        '
        'dtgCompras
        '
        Me.dtgCompras.AllowUserToAddRows = False
        Me.dtgCompras.AllowUserToDeleteRows = False
        Me.dtgCompras.AllowUserToOrderColumns = True
        Me.dtgCompras.AllowUserToResizeColumns = False
        Me.dtgCompras.AllowUserToResizeRows = False
        Me.dtgCompras.AutoGenerateColumns = False
        Me.dtgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCompras.BackgroundColor = System.Drawing.Color.White
        Me.dtgCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompID, Me.ArtNombre, Me.ArtCodigo, Me.CompCantidad, Me.ProvNombre, Me.ProvID, Me.CompFecha, Me.compCosto, Me.CompTotal, Me.CompExiste})
        Me.dtgCompras.DataSource = Me.TblComprasBindingSource
        Me.dtgCompras.Location = New System.Drawing.Point(12, 116)
        Me.dtgCompras.Name = "dtgCompras"
        Me.dtgCompras.ReadOnly = True
        Me.dtgCompras.RowHeadersVisible = False
        Me.dtgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCompras.Size = New System.Drawing.Size(1310, 353)
        Me.dtgCompras.TabIndex = 1
        '
        'TblComprasBindingSource
        '
        Me.TblComprasBindingSource.DataMember = "tblCompras"
        Me.TblComprasBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'BdSaleSuitDataSet
        '
        Me.BdSaleSuitDataSet.DataSetName = "bdSaleSuitDataSet"
        Me.BdSaleSuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit__1_
        Me.BtnSalir.Location = New System.Drawing.Point(1236, 491)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(86, 105)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.PrySalesSuite.My.Resources.Resources.preferences_system_time
        Me.btnBuscar.Location = New System.Drawing.Point(1144, 491)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 105)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar Fecha"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnNCompra
        '
        Me.btnNCompra.Image = Global.PrySalesSuite.My.Resources.Resources.shopping_basket_add
        Me.btnNCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNCompra.Location = New System.Drawing.Point(1052, 491)
        Me.btnNCompra.Name = "btnNCompra"
        Me.btnNCompra.Size = New System.Drawing.Size(86, 105)
        Me.btnNCompra.TabIndex = 2
        Me.btnNCompra.Text = "Registrar nueva compra"
        Me.btnNCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNCompra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Image = Global.PrySalesSuite.My.Resources.Resources.images
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 130)
        Me.Label1.TabIndex = 0
        '
        'TblComprasTableAdapter
        '
        Me.TblComprasTableAdapter.ClearBeforeFill = True
        '
        'CompID
        '
        Me.CompID.DataPropertyName = "compID"
        Me.CompID.HeaderText = "compID"
        Me.CompID.Name = "CompID"
        Me.CompID.ReadOnly = True
        '
        'ArtNombre
        '
        Me.ArtNombre.DataPropertyName = "artNombre"
        Me.ArtNombre.HeaderText = "Articulo"
        Me.ArtNombre.Name = "ArtNombre"
        Me.ArtNombre.ReadOnly = True
        '
        'ArtCodigo
        '
        Me.ArtCodigo.DataPropertyName = "artCodigo"
        Me.ArtCodigo.HeaderText = "artCodigo"
        Me.ArtCodigo.Name = "ArtCodigo"
        Me.ArtCodigo.ReadOnly = True
        Me.ArtCodigo.Visible = False
        '
        'CompCantidad
        '
        Me.CompCantidad.DataPropertyName = "compCantidad"
        Me.CompCantidad.HeaderText = "Cantidad(lts)"
        Me.CompCantidad.Name = "CompCantidad"
        Me.CompCantidad.ReadOnly = True
        '
        'ProvNombre
        '
        Me.ProvNombre.DataPropertyName = "provNombre"
        Me.ProvNombre.HeaderText = "Proveedor"
        Me.ProvNombre.Name = "ProvNombre"
        Me.ProvNombre.ReadOnly = True
        '
        'ProvID
        '
        Me.ProvID.DataPropertyName = "provID"
        Me.ProvID.HeaderText = "provID"
        Me.ProvID.Name = "ProvID"
        Me.ProvID.ReadOnly = True
        Me.ProvID.Visible = False
        '
        'CompFecha
        '
        Me.CompFecha.DataPropertyName = "compFecha"
        Me.CompFecha.HeaderText = "Fecha de Compra"
        Me.CompFecha.Name = "CompFecha"
        Me.CompFecha.ReadOnly = True
        '
        'compCosto
        '
        Me.compCosto.DataPropertyName = "compCosto"
        Me.compCosto.HeaderText = "Costo por unidad"
        Me.compCosto.Name = "compCosto"
        Me.compCosto.ReadOnly = True
        '
        'CompTotal
        '
        Me.CompTotal.DataPropertyName = "compTotal"
        Me.CompTotal.HeaderText = "Total"
        Me.CompTotal.Name = "CompTotal"
        Me.CompTotal.ReadOnly = True
        '
        'CompExiste
        '
        Me.CompExiste.DataPropertyName = "compExiste"
        Me.CompExiste.HeaderText = "compExiste"
        Me.CompExiste.Name = "CompExiste"
        Me.CompExiste.ReadOnly = True
        Me.CompExiste.Visible = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNCompra)
        Me.Controls.Add(Me.dtgCompras)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompras"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgCompras As System.Windows.Forms.DataGridView
    Friend WithEvents btnNCompra As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblComprasTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblComprasTableAdapter
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TblComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents compCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompExiste As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
