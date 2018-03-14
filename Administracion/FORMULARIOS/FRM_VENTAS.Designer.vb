<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_VENTAS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_VENT_AGREGAR_PROD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_VENTAS_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_VENTA_SALIR = New System.Windows.Forms.Button()
        Me.BTN_VENTA_GUARDAR = New System.Windows.Forms.Button()
        Me.CB_VENTA_FORMAPAGO = New System.Windows.Forms.ComboBox()
        Me.TB_VENTA_DESCUENTO = New System.Windows.Forms.TextBox()
        Me.TB_VENTA_ID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTP_FECHA_VENTA = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCantidadProductos = New System.Windows.Forms.Label()
        Me.BTN_VENT_QUITAR_PROD = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_SUBTOTAL_VENTA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_CLIENTE_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_CLIENTE_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TB_CLIENTE_DNI = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_VENTA_GENERAR_COMPROBANTE = New System.Windows.Forms.Button()
        CType(Me.DGV_VENTAS_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_VENT_AGREGAR_PROD
        '
        Me.BTN_VENT_AGREGAR_PROD.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENT_AGREGAR_PROD.Location = New System.Drawing.Point(323, 19)
        Me.BTN_VENT_AGREGAR_PROD.Name = "BTN_VENT_AGREGAR_PROD"
        Me.BTN_VENT_AGREGAR_PROD.Size = New System.Drawing.Size(140, 28)
        Me.BTN_VENT_AGREGAR_PROD.TabIndex = 2
        Me.BTN_VENT_AGREGAR_PROD.Text = "Agregar producto"
        Me.BTN_VENT_AGREGAR_PROD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha de Venta"
        '
        'DGV_VENTAS_BUSCAR
        '
        Me.DGV_VENTAS_BUSCAR.AllowUserToAddRows = False
        Me.DGV_VENTAS_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VENTAS_BUSCAR.Location = New System.Drawing.Point(15, 63)
        Me.DGV_VENTAS_BUSCAR.Name = "DGV_VENTAS_BUSCAR"
        Me.DGV_VENTAS_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_VENTAS_BUSCAR.Size = New System.Drawing.Size(595, 193)
        Me.DGV_VENTAS_BUSCAR.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "*Datos obligatorios"
        '
        'BTN_VENTA_SALIR
        '
        Me.BTN_VENTA_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_SALIR.Location = New System.Drawing.Point(546, 468)
        Me.BTN_VENTA_SALIR.Name = "BTN_VENTA_SALIR"
        Me.BTN_VENTA_SALIR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_VENTA_SALIR.TabIndex = 39
        Me.BTN_VENTA_SALIR.Text = "Salir"
        Me.BTN_VENTA_SALIR.UseVisualStyleBackColor = True
        '
        'BTN_VENTA_GUARDAR
        '
        Me.BTN_VENTA_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_GUARDAR.Location = New System.Drawing.Point(451, 468)
        Me.BTN_VENTA_GUARDAR.Name = "BTN_VENTA_GUARDAR"
        Me.BTN_VENTA_GUARDAR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_VENTA_GUARDAR.TabIndex = 38
        Me.BTN_VENTA_GUARDAR.Text = "Guardar"
        Me.BTN_VENTA_GUARDAR.UseVisualStyleBackColor = True
        '
        'CB_VENTA_FORMAPAGO
        '
        Me.CB_VENTA_FORMAPAGO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_VENTA_FORMAPAGO.FormattingEnabled = True
        Me.CB_VENTA_FORMAPAGO.Location = New System.Drawing.Point(134, 74)
        Me.CB_VENTA_FORMAPAGO.Name = "CB_VENTA_FORMAPAGO"
        Me.CB_VENTA_FORMAPAGO.Size = New System.Drawing.Size(181, 26)
        Me.CB_VENTA_FORMAPAGO.TabIndex = 35
        '
        'TB_VENTA_DESCUENTO
        '
        Me.TB_VENTA_DESCUENTO.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VENTA_DESCUENTO.Location = New System.Drawing.Point(520, 286)
        Me.TB_VENTA_DESCUENTO.Name = "TB_VENTA_DESCUENTO"
        Me.TB_VENTA_DESCUENTO.Size = New System.Drawing.Size(90, 23)
        Me.TB_VENTA_DESCUENTO.TabIndex = 31
        '
        'TB_VENTA_ID
        '
        Me.TB_VENTA_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_VENTA_ID.Location = New System.Drawing.Point(152, 21)
        Me.TB_VENTA_ID.Name = "TB_VENTA_ID"
        Me.TB_VENTA_ID.Size = New System.Drawing.Size(98, 26)
        Me.TB_VENTA_ID.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Forma de Pago*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Cantidad de Productos*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(447, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Descuento*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Id Venta*"
        '
        'DTP_FECHA_VENTA
        '
        Me.DTP_FECHA_VENTA.CalendarFont = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FECHA_VENTA.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FECHA_VENTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FECHA_VENTA.Location = New System.Drawing.Point(440, 71)
        Me.DTP_FECHA_VENTA.Name = "DTP_FECHA_VENTA"
        Me.DTP_FECHA_VENTA.Size = New System.Drawing.Size(100, 26)
        Me.DTP_FECHA_VENTA.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCantidadProductos)
        Me.GroupBox1.Controls.Add(Me.BTN_VENT_QUITAR_PROD)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_SUBTOTAL_VENTA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DGV_VENTAS_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.BTN_VENT_AGREGAR_PROD)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_DESCUENTO)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_ID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 342)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Venta"
        '
        'lblCantidadProductos
        '
        Me.lblCantidadProductos.AutoSize = True
        Me.lblCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCantidadProductos.Location = New System.Drawing.Point(187, 273)
        Me.lblCantidadProductos.Name = "lblCantidadProductos"
        Me.lblCantidadProductos.Size = New System.Drawing.Size(2, 15)
        Me.lblCantidadProductos.TabIndex = 49
        '
        'BTN_VENT_QUITAR_PROD
        '
        Me.BTN_VENT_QUITAR_PROD.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENT_QUITAR_PROD.Location = New System.Drawing.Point(469, 19)
        Me.BTN_VENT_QUITAR_PROD.Name = "BTN_VENT_QUITAR_PROD"
        Me.BTN_VENT_QUITAR_PROD.Size = New System.Drawing.Size(140, 28)
        Me.BTN_VENT_QUITAR_PROD.TabIndex = 48
        Me.BTN_VENT_QUITAR_PROD.Text = "Quitar producto"
        Me.BTN_VENT_QUITAR_PROD.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(520, 310)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 23)
        Me.TextBox1.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Total"
        '
        'TXT_SUBTOTAL_VENTA
        '
        Me.TXT_SUBTOTAL_VENTA.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SUBTOTAL_VENTA.Location = New System.Drawing.Point(520, 262)
        Me.TXT_SUBTOTAL_VENTA.Name = "TXT_SUBTOTAL_VENTA"
        Me.TXT_SUBTOTAL_VENTA.Size = New System.Drawing.Size(90, 23)
        Me.TXT_SUBTOTAL_VENTA.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "SubTotal"
        '
        'TB_CLIENTE_ID
        '
        Me.TB_CLIENTE_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_ID.Location = New System.Drawing.Point(87, 23)
        Me.TB_CLIENTE_ID.Name = "TB_CLIENTE_ID"
        Me.TB_CLIENTE_ID.Size = New System.Drawing.Size(56, 26)
        Me.TB_CLIENTE_ID.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Cliente*"
        '
        'TB_CLIENTE_APELLIDO
        '
        Me.TB_CLIENTE_APELLIDO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_APELLIDO.Location = New System.Drawing.Point(144, 23)
        Me.TB_CLIENTE_APELLIDO.Name = "TB_CLIENTE_APELLIDO"
        Me.TB_CLIENTE_APELLIDO.Size = New System.Drawing.Size(192, 26)
        Me.TB_CLIENTE_APELLIDO.TabIndex = 48
        '
        'TB_CLIENTE_DNI
        '
        Me.TB_CLIENTE_DNI.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CLIENTE_DNI.Location = New System.Drawing.Point(337, 23)
        Me.TB_CLIENTE_DNI.Name = "TB_CLIENTE_DNI"
        Me.TB_CLIENTE_DNI.Size = New System.Drawing.Size(127, 26)
        Me.TB_CLIENTE_DNI.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(470, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 25)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_VENTA_GENERAR_COMPROBANTE
        '
        Me.BTN_VENTA_GENERAR_COMPROBANTE.Location = New System.Drawing.Point(370, 472)
        Me.BTN_VENTA_GENERAR_COMPROBANTE.Name = "BTN_VENTA_GENERAR_COMPROBANTE"
        Me.BTN_VENTA_GENERAR_COMPROBANTE.Size = New System.Drawing.Size(75, 23)
        Me.BTN_VENTA_GENERAR_COMPROBANTE.TabIndex = 51
        Me.BTN_VENTA_GENERAR_COMPROBANTE.Text = "Generar Comprobante"
        Me.BTN_VENTA_GENERAR_COMPROBANTE.UseVisualStyleBackColor = True
        '
        'FRM_VENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 508)
        Me.Controls.Add(Me.BTN_VENTA_GENERAR_COMPROBANTE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_CLIENTE_DNI)
        Me.Controls.Add(Me.TB_CLIENTE_APELLIDO)
        Me.Controls.Add(Me.TB_CLIENTE_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_VENTA_SALIR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTN_VENTA_GUARDAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DTP_FECHA_VENTA)
        Me.Controls.Add(Me.CB_VENTA_FORMAPAGO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_VENTAS"
        Me.Text = "VENTAS"
        CType(Me.DGV_VENTAS_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_VENT_AGREGAR_PROD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_VENTAS_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BTN_VENTA_SALIR As System.Windows.Forms.Button
    Friend WithEvents BTN_VENTA_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents CB_VENTA_FORMAPAGO As System.Windows.Forms.ComboBox
    Friend WithEvents TB_VENTA_DESCUENTO As System.Windows.Forms.TextBox
    Friend WithEvents TB_VENTA_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTP_FECHA_VENTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_CLIENTE_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_SUBTOTAL_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_VENT_QUITAR_PROD As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_CLIENTE_APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TB_CLIENTE_DNI As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblCantidadProductos As System.Windows.Forms.Label
    Friend WithEvents BTN_VENTA_GENERAR_COMPROBANTE As System.Windows.Forms.Button
End Class
