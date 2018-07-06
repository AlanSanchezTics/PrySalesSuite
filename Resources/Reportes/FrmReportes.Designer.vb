<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbReporte = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.dtpFechaF = New System.Windows.Forms.DateTimePicker()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.dtpFechaI = New System.Windows.Forms.DateTimePicker()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de:"
        '
        'cbReporte
        '
        Me.cbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReporte.FormattingEnabled = True
        Me.cbReporte.Items.AddRange(New Object() {"Usuarios", "Clientes", "Ventas", "Compras", "Articulos", "Proveedores", "Categorias"})
        Me.cbReporte.Location = New System.Drawing.Point(172, 12)
        Me.cbReporte.Name = "cbReporte"
        Me.cbReporte.Size = New System.Drawing.Size(121, 21)
        Me.cbReporte.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(96, 72)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(217, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dtpFechaF
        '
        Me.dtpFechaF.CalendarFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaF.CustomFormat = "yyyy-MM-dd"
        Me.dtpFechaF.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaF.Location = New System.Drawing.Point(250, 39)
        Me.dtpFechaF.Name = "dtpFechaF"
        Me.dtpFechaF.Size = New System.Drawing.Size(143, 27)
        Me.dtpFechaF.TabIndex = 8
        Me.dtpFechaF.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(212, 45)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(18, 18)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "a"
        Me.lbl2.Visible = False
        '
        'dtpFechaI
        '
        Me.dtpFechaI.CalendarFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaI.CustomFormat = "yyyy-MM-dd"
        Me.dtpFechaI.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaI.Location = New System.Drawing.Point(46, 39)
        Me.dtpFechaI.Name = "dtpFechaI"
        Me.dtpFechaI.Size = New System.Drawing.Size(143, 27)
        Me.dtpFechaI.TabIndex = 6
        Me.dtpFechaI.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(10, 48)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(30, 18)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "De"
        Me.lbl1.Visible = False
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 109)
        Me.Controls.Add(Me.dtpFechaF)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.dtpFechaI)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cbReporte)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmReportes"
        Me.ShowIcon = False
        Me.Text = "Reporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbReporte As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl1 As System.Windows.Forms.Label
End Class
