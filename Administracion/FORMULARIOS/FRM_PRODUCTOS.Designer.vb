<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTOS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PROD_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_PROD_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TB_PROD_PRECIO_COSTO = New System.Windows.Forms.TextBox()
        Me.TB_PROD_PRECIO_VENTA = New System.Windows.Forms.TextBox()
        Me.TB_PROD_STOCK = New System.Windows.Forms.TextBox()
        Me.CB_PROD_PROVEEDOR = New System.Windows.Forms.ComboBox()
        Me.CB_PROD_DEPOSITO = New System.Windows.Forms.ComboBox()
        Me.CB_PROD_TIPO_PROD = New System.Windows.Forms.ComboBox()
        Me.BTN_PROD_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_SALIR = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TB_PROD_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio de costo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio de venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad en stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Proveedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Depósito"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de producto"
        '
        'TB_PROD_CODIGO
        '
        Me.TB_PROD_CODIGO.Location = New System.Drawing.Point(18, 40)
        Me.TB_PROD_CODIGO.Name = "TB_PROD_CODIGO"
        Me.TB_PROD_CODIGO.Size = New System.Drawing.Size(98, 20)
        Me.TB_PROD_CODIGO.TabIndex = 8
        '
        'TB_PROD_DESCRIPCION
        '
        Me.TB_PROD_DESCRIPCION.Location = New System.Drawing.Point(134, 40)
        Me.TB_PROD_DESCRIPCION.Name = "TB_PROD_DESCRIPCION"
        Me.TB_PROD_DESCRIPCION.Size = New System.Drawing.Size(98, 20)
        Me.TB_PROD_DESCRIPCION.TabIndex = 9
        '
        'TB_PROD_PRECIO_COSTO
        '
        Me.TB_PROD_PRECIO_COSTO.Location = New System.Drawing.Point(18, 93)
        Me.TB_PROD_PRECIO_COSTO.Name = "TB_PROD_PRECIO_COSTO"
        Me.TB_PROD_PRECIO_COSTO.Size = New System.Drawing.Size(98, 20)
        Me.TB_PROD_PRECIO_COSTO.TabIndex = 10
        '
        'TB_PROD_PRECIO_VENTA
        '
        Me.TB_PROD_PRECIO_VENTA.Location = New System.Drawing.Point(134, 93)
        Me.TB_PROD_PRECIO_VENTA.Name = "TB_PROD_PRECIO_VENTA"
        Me.TB_PROD_PRECIO_VENTA.Size = New System.Drawing.Size(98, 20)
        Me.TB_PROD_PRECIO_VENTA.TabIndex = 11
        '
        'TB_PROD_STOCK
        '
        Me.TB_PROD_STOCK.Location = New System.Drawing.Point(18, 148)
        Me.TB_PROD_STOCK.Name = "TB_PROD_STOCK"
        Me.TB_PROD_STOCK.Size = New System.Drawing.Size(98, 20)
        Me.TB_PROD_STOCK.TabIndex = 12
        '
        'CB_PROD_PROVEEDOR
        '
        Me.CB_PROD_PROVEEDOR.FormattingEnabled = True
        Me.CB_PROD_PROVEEDOR.Items.AddRange(New Object() {"LOPEZ S.R.L", "GIMENEZ S.A", "1"})
        Me.CB_PROD_PROVEEDOR.Location = New System.Drawing.Point(134, 147)
        Me.CB_PROD_PROVEEDOR.Name = "CB_PROD_PROVEEDOR"
        Me.CB_PROD_PROVEEDOR.Size = New System.Drawing.Size(94, 21)
        Me.CB_PROD_PROVEEDOR.TabIndex = 13
        '
        'CB_PROD_DEPOSITO
        '
        Me.CB_PROD_DEPOSITO.FormattingEnabled = True
        Me.CB_PROD_DEPOSITO.Location = New System.Drawing.Point(18, 204)
        Me.CB_PROD_DEPOSITO.Name = "CB_PROD_DEPOSITO"
        Me.CB_PROD_DEPOSITO.Size = New System.Drawing.Size(94, 21)
        Me.CB_PROD_DEPOSITO.TabIndex = 14
        '
        'CB_PROD_TIPO_PROD
        '
        Me.CB_PROD_TIPO_PROD.FormattingEnabled = True
        Me.CB_PROD_TIPO_PROD.Items.AddRange(New Object() {"ENLATADOS", "1"})
        Me.CB_PROD_TIPO_PROD.Location = New System.Drawing.Point(134, 204)
        Me.CB_PROD_TIPO_PROD.Name = "CB_PROD_TIPO_PROD"
        Me.CB_PROD_TIPO_PROD.Size = New System.Drawing.Size(94, 21)
        Me.CB_PROD_TIPO_PROD.TabIndex = 15
        '
        'BTN_PROD_GUARDAR
        '
        Me.BTN_PROD_GUARDAR.Location = New System.Drawing.Point(22, 244)
        Me.BTN_PROD_GUARDAR.Name = "BTN_PROD_GUARDAR"
        Me.BTN_PROD_GUARDAR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_PROD_GUARDAR.TabIndex = 16
        Me.BTN_PROD_GUARDAR.Text = "Guardar"
        Me.BTN_PROD_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_SALIR
        '
        Me.BTN_PROD_SALIR.Location = New System.Drawing.Point(148, 244)
        Me.BTN_PROD_SALIR.Name = "BTN_PROD_SALIR"
        Me.BTN_PROD_SALIR.Size = New System.Drawing.Size(89, 31)
        Me.BTN_PROD_SALIR.TabIndex = 17
        Me.BTN_PROD_SALIR.Text = "Salir"
        Me.BTN_PROD_SALIR.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(53, 244)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(89, 31)
        Me.btnActualizar.TabIndex = 18
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'TB_PROD_ID
        '
        Me.TB_PROD_ID.Location = New System.Drawing.Point(168, 309)
        Me.TB_PROD_ID.Name = "TB_PROD_ID"
        Me.TB_PROD_ID.Size = New System.Drawing.Size(98, 20)
        Me.TB_PROD_ID.TabIndex = 20
        Me.TB_PROD_ID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID"
        Me.Label9.Visible = False
        '
        'FRM_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 341)
        Me.Controls.Add(Me.TB_PROD_ID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.BTN_PROD_SALIR)
        Me.Controls.Add(Me.BTN_PROD_GUARDAR)
        Me.Controls.Add(Me.CB_PROD_TIPO_PROD)
        Me.Controls.Add(Me.CB_PROD_DEPOSITO)
        Me.Controls.Add(Me.CB_PROD_PROVEEDOR)
        Me.Controls.Add(Me.TB_PROD_STOCK)
        Me.Controls.Add(Me.TB_PROD_PRECIO_VENTA)
        Me.Controls.Add(Me.TB_PROD_PRECIO_COSTO)
        Me.Controls.Add(Me.TB_PROD_DESCRIPCION)
        Me.Controls.Add(Me.TB_PROD_CODIGO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_PRODUCTOS"
        Me.Text = "PRODUCTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_PROD_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_PRECIO_COSTO As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_PRECIO_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_STOCK As System.Windows.Forms.TextBox
    Friend WithEvents CB_PROD_PROVEEDOR As System.Windows.Forms.ComboBox
    Friend WithEvents CB_PROD_DEPOSITO As System.Windows.Forms.ComboBox
    Friend WithEvents CB_PROD_TIPO_PROD As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_PROD_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_SALIR As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents TB_PROD_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
