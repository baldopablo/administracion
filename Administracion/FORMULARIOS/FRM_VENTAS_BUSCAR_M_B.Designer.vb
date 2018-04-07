<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_VENTAS_BUSCAR_M_B
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
        Me.BTN_VENTA_BUS_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_VENTA_BUS_EDITAR = New System.Windows.Forms.Button()
        Me.DGV_VENTA_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_VENTA_BUSCAR_DNI_CLI = New System.Windows.Forms.TextBox()
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RB_PROD_TIPO_BUSCAR_CODIGO = New System.Windows.Forms.RadioButton()
        Me.BTN_VENTA_BUS_SALIR = New System.Windows.Forms.Button()
        Me.DTP_FECHA_VENTA_BUSCAR = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV_VENTA_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_VENTA_BUS_ELIMINAR
        '
        Me.BTN_VENTA_BUS_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_BUS_ELIMINAR.Location = New System.Drawing.Point(81, 365)
        Me.BTN_VENTA_BUS_ELIMINAR.Name = "BTN_VENTA_BUS_ELIMINAR"
        Me.BTN_VENTA_BUS_ELIMINAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_VENTA_BUS_ELIMINAR.TabIndex = 13
        Me.BTN_VENTA_BUS_ELIMINAR.Text = "Eliminar"
        Me.BTN_VENTA_BUS_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_VENTA_BUS_EDITAR
        '
        Me.BTN_VENTA_BUS_EDITAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_BUS_EDITAR.Location = New System.Drawing.Point(35, 365)
        Me.BTN_VENTA_BUS_EDITAR.Name = "BTN_VENTA_BUS_EDITAR"
        Me.BTN_VENTA_BUS_EDITAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_VENTA_BUS_EDITAR.TabIndex = 12
        Me.BTN_VENTA_BUS_EDITAR.Text = "Modificar"
        Me.BTN_VENTA_BUS_EDITAR.UseVisualStyleBackColor = True
        '
        'DGV_VENTA_BUSCAR
        '
        Me.DGV_VENTA_BUSCAR.AllowUserToAddRows = False
        Me.DGV_VENTA_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VENTA_BUSCAR.Location = New System.Drawing.Point(35, 103)
        Me.DGV_VENTA_BUSCAR.MultiSelect = False
        Me.DGV_VENTA_BUSCAR.Name = "DGV_VENTA_BUSCAR"
        Me.DGV_VENTA_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_VENTA_BUSCAR.Size = New System.Drawing.Size(656, 252)
        Me.DGV_VENTA_BUSCAR.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP_FECHA_VENTA_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.TB_VENTA_BUSCAR_DNI_CLI)
        Me.GroupBox1.Controls.Add(Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.RB_PROD_TIPO_BUSCAR_CODIGO)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 76)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Venta"
        '
        'TB_VENTA_BUSCAR_DNI_CLI
        '
        Me.TB_VENTA_BUSCAR_DNI_CLI.Location = New System.Drawing.Point(109, 22)
        Me.TB_VENTA_BUSCAR_DNI_CLI.Name = "TB_VENTA_BUSCAR_DNI_CLI"
        Me.TB_VENTA_BUSCAR_DNI_CLI.Size = New System.Drawing.Size(129, 26)
        Me.TB_VENTA_BUSCAR_DNI_CLI.TabIndex = 2
        '
        'RB_PROD_TIPO_BUSCAR_DESCRIPCION
        '
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.AutoSize = True
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.Location = New System.Drawing.Point(11, 49)
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.Name = "RB_PROD_TIPO_BUSCAR_DESCRIPCION"
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.Size = New System.Drawing.Size(62, 22)
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.TabIndex = 1
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.TabStop = True
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.Text = "Fecha"
        Me.RB_PROD_TIPO_BUSCAR_DESCRIPCION.UseVisualStyleBackColor = True
        '
        'RB_PROD_TIPO_BUSCAR_CODIGO
        '
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.AutoSize = True
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.Location = New System.Drawing.Point(11, 26)
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.Name = "RB_PROD_TIPO_BUSCAR_CODIGO"
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.Size = New System.Drawing.Size(92, 22)
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.TabIndex = 0
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.TabStop = True
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.Text = "Dni Cliente"
        Me.RB_PROD_TIPO_BUSCAR_CODIGO.UseVisualStyleBackColor = True
        '
        'BTN_VENTA_BUS_SALIR
        '
        Me.BTN_VENTA_BUS_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VENTA_BUS_SALIR.Location = New System.Drawing.Point(606, 365)
        Me.BTN_VENTA_BUS_SALIR.Name = "BTN_VENTA_BUS_SALIR"
        Me.BTN_VENTA_BUS_SALIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_VENTA_BUS_SALIR.TabIndex = 10
        Me.BTN_VENTA_BUS_SALIR.Text = "Salir"
        Me.BTN_VENTA_BUS_SALIR.UseVisualStyleBackColor = True
        '
        'DTP_FECHA_VENTA_BUSCAR
        '
        Me.DTP_FECHA_VENTA_BUSCAR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FECHA_VENTA_BUSCAR.Location = New System.Drawing.Point(109, 48)
        Me.DTP_FECHA_VENTA_BUSCAR.Name = "DTP_FECHA_VENTA_BUSCAR"
        Me.DTP_FECHA_VENTA_BUSCAR.Size = New System.Drawing.Size(129, 26)
        Me.DTP_FECHA_VENTA_BUSCAR.TabIndex = 14
        '
        'FRM_VENTAS_BUSCAR_M_B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 407)
        Me.Controls.Add(Me.BTN_VENTA_BUS_ELIMINAR)
        Me.Controls.Add(Me.BTN_VENTA_BUS_EDITAR)
        Me.Controls.Add(Me.DGV_VENTA_BUSCAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_VENTA_BUS_SALIR)
        Me.Name = "FRM_VENTAS_BUSCAR_M_B"
        Me.Text = "FRM_VENTAS_BUSCAR_M_B"
        CType(Me.DGV_VENTA_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_VENTA_BUS_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTN_VENTA_BUS_EDITAR As System.Windows.Forms.Button
    Friend WithEvents DGV_VENTA_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_VENTA_BUSCAR_DNI_CLI As System.Windows.Forms.TextBox
    Friend WithEvents RB_PROD_TIPO_BUSCAR_DESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PROD_TIPO_BUSCAR_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_VENTA_BUS_SALIR As System.Windows.Forms.Button
    Friend WithEvents DTP_FECHA_VENTA_BUSCAR As System.Windows.Forms.DateTimePicker
End Class
