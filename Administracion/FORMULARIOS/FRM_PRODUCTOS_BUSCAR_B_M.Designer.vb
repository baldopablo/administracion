﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTOS_BUSCAR_B_M
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
        Me.BTN_PROD_BUS_ELIMINAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_BUS_EDITAR = New System.Windows.Forms.Button()
        Me.DGV_PROD_BUSCAR = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_PROD_BUSCAR_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_PROD_BUSCAR_NOMBRE = New System.Windows.Forms.TextBox()
        Me.RB_PROD_BUSCAR_CODIGO = New System.Windows.Forms.RadioButton()
        Me.RB_PROD_BUSCAR_NOMBRE = New System.Windows.Forms.RadioButton()
        Me.BTN_PROD_BUS_SALIR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV_PROD_BUSCAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_PROD_BUS_ELIMINAR
        '
        Me.BTN_PROD_BUS_ELIMINAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_BUS_ELIMINAR.Location = New System.Drawing.Point(77, 356)
        Me.BTN_PROD_BUS_ELIMINAR.Name = "BTN_PROD_BUS_ELIMINAR"
        Me.BTN_PROD_BUS_ELIMINAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_PROD_BUS_ELIMINAR.TabIndex = 8
        Me.BTN_PROD_BUS_ELIMINAR.Text = "Eliminar"
        Me.BTN_PROD_BUS_ELIMINAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_BUS_EDITAR
        '
        Me.BTN_PROD_BUS_EDITAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_BUS_EDITAR.Location = New System.Drawing.Point(31, 356)
        Me.BTN_PROD_BUS_EDITAR.Name = "BTN_PROD_BUS_EDITAR"
        Me.BTN_PROD_BUS_EDITAR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_PROD_BUS_EDITAR.TabIndex = 7
        Me.BTN_PROD_BUS_EDITAR.Text = "Modificar"
        Me.BTN_PROD_BUS_EDITAR.UseVisualStyleBackColor = True
        '
        'DGV_PROD_BUSCAR
        '
        Me.DGV_PROD_BUSCAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PROD_BUSCAR.Location = New System.Drawing.Point(31, 94)
        Me.DGV_PROD_BUSCAR.Name = "DGV_PROD_BUSCAR"
        Me.DGV_PROD_BUSCAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PROD_BUSCAR.Size = New System.Drawing.Size(739, 252)
        Me.DGV_PROD_BUSCAR.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_PROD_BUSCAR_CODIGO)
        Me.GroupBox1.Controls.Add(Me.TB_PROD_BUSCAR_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.RB_PROD_BUSCAR_CODIGO)
        Me.GroupBox1.Controls.Add(Me.RB_PROD_BUSCAR_NOMBRE)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 76)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'TB_PROD_BUSCAR_CODIGO
        '
        Me.TB_PROD_BUSCAR_CODIGO.Location = New System.Drawing.Point(98, 46)
        Me.TB_PROD_BUSCAR_CODIGO.Name = "TB_PROD_BUSCAR_CODIGO"
        Me.TB_PROD_BUSCAR_CODIGO.Size = New System.Drawing.Size(129, 26)
        Me.TB_PROD_BUSCAR_CODIGO.TabIndex = 3
        '
        'TB_PROD_BUSCAR_NOMBRE
        '
        Me.TB_PROD_BUSCAR_NOMBRE.Location = New System.Drawing.Point(98, 22)
        Me.TB_PROD_BUSCAR_NOMBRE.Name = "TB_PROD_BUSCAR_NOMBRE"
        Me.TB_PROD_BUSCAR_NOMBRE.Size = New System.Drawing.Size(129, 26)
        Me.TB_PROD_BUSCAR_NOMBRE.TabIndex = 2
        '
        'RB_PROD_BUSCAR_CODIGO
        '
        Me.RB_PROD_BUSCAR_CODIGO.AutoSize = True
        Me.RB_PROD_BUSCAR_CODIGO.Location = New System.Drawing.Point(11, 49)
        Me.RB_PROD_BUSCAR_CODIGO.Name = "RB_PROD_BUSCAR_CODIGO"
        Me.RB_PROD_BUSCAR_CODIGO.Size = New System.Drawing.Size(79, 22)
        Me.RB_PROD_BUSCAR_CODIGO.TabIndex = 1
        Me.RB_PROD_BUSCAR_CODIGO.TabStop = True
        Me.RB_PROD_BUSCAR_CODIGO.Text = "CODIGO"
        Me.RB_PROD_BUSCAR_CODIGO.UseVisualStyleBackColor = True
        '
        'RB_PROD_BUSCAR_NOMBRE
        '
        Me.RB_PROD_BUSCAR_NOMBRE.AutoSize = True
        Me.RB_PROD_BUSCAR_NOMBRE.Location = New System.Drawing.Point(11, 26)
        Me.RB_PROD_BUSCAR_NOMBRE.Name = "RB_PROD_BUSCAR_NOMBRE"
        Me.RB_PROD_BUSCAR_NOMBRE.Size = New System.Drawing.Size(81, 22)
        Me.RB_PROD_BUSCAR_NOMBRE.TabIndex = 0
        Me.RB_PROD_BUSCAR_NOMBRE.TabStop = True
        Me.RB_PROD_BUSCAR_NOMBRE.Text = "NOMBRE"
        Me.RB_PROD_BUSCAR_NOMBRE.UseVisualStyleBackColor = True
        '
        'BTN_PROD_BUS_SALIR
        '
        Me.BTN_PROD_BUS_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_BUS_SALIR.Location = New System.Drawing.Point(685, 356)
        Me.BTN_PROD_BUS_SALIR.Name = "BTN_PROD_BUS_SALIR"
        Me.BTN_PROD_BUS_SALIR.Size = New System.Drawing.Size(85, 27)
        Me.BTN_PROD_BUS_SALIR.TabIndex = 5
        Me.BTN_PROD_BUS_SALIR.Text = "Salir"
        Me.BTN_PROD_BUS_SALIR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(519, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Agregar a la Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_PRODUCTOS_BUSCAR_B_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 399)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_PROD_BUS_ELIMINAR)
        Me.Controls.Add(Me.BTN_PROD_BUS_EDITAR)
        Me.Controls.Add(Me.DGV_PROD_BUSCAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_PROD_BUS_SALIR)
        Me.Name = "FRM_PRODUCTOS_BUSCAR_B_M"
        Me.Text = "MODIFICAR Y ELIMINAR PRODUCTOS"
        CType(Me.DGV_PROD_BUSCAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_PROD_BUS_ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_BUS_EDITAR As System.Windows.Forms.Button
    Friend WithEvents DGV_PROD_BUSCAR As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_PROD_BUSCAR_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROD_BUSCAR_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents RB_PROD_BUSCAR_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents RB_PROD_BUSCAR_NOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents BTN_PROD_BUS_SALIR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
