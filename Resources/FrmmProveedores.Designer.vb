<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmmProveedores
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxapDireccion = New System.Windows.Forms.TextBox()
        Me.MtxapTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxapNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BapSalir = New System.Windows.Forms.Button()
        Me.BapApro = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtRFC)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxapDireccion)
        Me.Panel2.Controls.Add(Me.MtxapTel)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxapNombre)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 190)
        Me.Panel2.TabIndex = 8
        '
        'txtRFC
        '
        Me.txtRFC.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFC.Location = New System.Drawing.Point(108, 55)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(272, 27)
        Me.txtRFC.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "RFC:"
        '
        'TxapDireccion
        '
        Me.TxapDireccion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxapDireccion.Location = New System.Drawing.Point(108, 98)
        Me.TxapDireccion.MaxLength = 100
        Me.TxapDireccion.Name = "TxapDireccion"
        Me.TxapDireccion.Size = New System.Drawing.Size(272, 27)
        Me.TxapDireccion.TabIndex = 14
        '
        'MtxapTel
        '
        Me.MtxapTel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxapTel.Location = New System.Drawing.Point(108, 143)
        Me.MtxapTel.Mask = "000-000-0000"
        Me.MtxapTel.Name = "MtxapTel"
        Me.MtxapTel.Size = New System.Drawing.Size(148, 27)
        Me.MtxapTel.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Direccion:"
        '
        'TxapNombre
        '
        Me.TxapNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxapNombre.Location = New System.Drawing.Point(108, 11)
        Me.TxapNombre.MaxLength = 50
        Me.TxapNombre.Name = "TxapNombre"
        Me.TxapNombre.Size = New System.Drawing.Size(272, 27)
        Me.TxapNombre.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'BapSalir
        '
        Me.BapSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit
        Me.BapSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BapSalir.Location = New System.Drawing.Point(363, 208)
        Me.BapSalir.Name = "BapSalir"
        Me.BapSalir.Size = New System.Drawing.Size(64, 73)
        Me.BapSalir.TabIndex = 9
        Me.BapSalir.Text = "Salir"
        Me.BapSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BapSalir.UseVisualStyleBackColor = True
        '
        'BapApro
        '
        Me.BapApro.Image = Global.PrySalesSuite.My.Resources.Resources.save
        Me.BapApro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BapApro.Location = New System.Drawing.Point(284, 208)
        Me.BapApro.Name = "BapApro"
        Me.BapApro.Size = New System.Drawing.Size(64, 73)
        Me.BapApro.TabIndex = 0
        Me.BapApro.Text = "Guardar"
        Me.BapApro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BapApro.UseVisualStyleBackColor = True
        '
        'FrmmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(439, 293)
        Me.Controls.Add(Me.BapSalir)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BapApro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmmProveedores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proveedor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BapApro As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxapDireccion As System.Windows.Forms.TextBox
    Friend WithEvents MtxapTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxapNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BapSalir As System.Windows.Forms.Button
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
