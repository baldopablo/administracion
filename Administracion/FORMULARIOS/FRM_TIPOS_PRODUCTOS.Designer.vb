﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TIPOS_PRODUCTOS
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
        Me.TB_PROD_TIPO_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_PROD_TIPO_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_PROD_TIPO_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_TIPO_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_PROD_TIPO_SALIR = New System.Windows.Forms.Button()
        Me.TB_PROD_TIPO_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código*"
        '
        'TB_PROD_TIPO_CODIGO
        '
        Me.TB_PROD_TIPO_CODIGO.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_TIPO_CODIGO.Location = New System.Drawing.Point(107, 18)
        Me.TB_PROD_TIPO_CODIGO.Name = "TB_PROD_TIPO_CODIGO"
        Me.TB_PROD_TIPO_CODIGO.Size = New System.Drawing.Size(163, 26)
        Me.TB_PROD_TIPO_CODIGO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*Datos obligatorios"
        '
        'TB_PROD_TIPO_ID
        '
        Me.TB_PROD_TIPO_ID.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_TIPO_ID.Location = New System.Drawing.Point(285, 31)
        Me.TB_PROD_TIPO_ID.Name = "TB_PROD_TIPO_ID"
        Me.TB_PROD_TIPO_ID.Size = New System.Drawing.Size(48, 26)
        Me.TB_PROD_TIPO_ID.TabIndex = 8
        Me.TB_PROD_TIPO_ID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Id"
        Me.Label4.Visible = False
        '
        'BTN_PROD_TIPO_ACTUALIZAR
        '
        Me.BTN_PROD_TIPO_ACTUALIZAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_TIPO_ACTUALIZAR.Location = New System.Drawing.Point(168, 134)
        Me.BTN_PROD_TIPO_ACTUALIZAR.Name = "BTN_PROD_TIPO_ACTUALIZAR"
        Me.BTN_PROD_TIPO_ACTUALIZAR.Size = New System.Drawing.Size(85, 32)
        Me.BTN_PROD_TIPO_ACTUALIZAR.TabIndex = 9
        Me.BTN_PROD_TIPO_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_PROD_TIPO_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_TIPO_GUARDAR
        '
        Me.BTN_PROD_TIPO_GUARDAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_TIPO_GUARDAR.Location = New System.Drawing.Point(77, 134)
        Me.BTN_PROD_TIPO_GUARDAR.Name = "BTN_PROD_TIPO_GUARDAR"
        Me.BTN_PROD_TIPO_GUARDAR.Size = New System.Drawing.Size(85, 32)
        Me.BTN_PROD_TIPO_GUARDAR.TabIndex = 10
        Me.BTN_PROD_TIPO_GUARDAR.Text = "Guardar"
        Me.BTN_PROD_TIPO_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_PROD_TIPO_SALIR
        '
        Me.BTN_PROD_TIPO_SALIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROD_TIPO_SALIR.Location = New System.Drawing.Point(263, 134)
        Me.BTN_PROD_TIPO_SALIR.Name = "BTN_PROD_TIPO_SALIR"
        Me.BTN_PROD_TIPO_SALIR.Size = New System.Drawing.Size(75, 32)
        Me.BTN_PROD_TIPO_SALIR.TabIndex = 11
        Me.BTN_PROD_TIPO_SALIR.Text = "Salir"
        Me.BTN_PROD_TIPO_SALIR.UseVisualStyleBackColor = True
        '
        'TB_PROD_TIPO_DESCRIPCION
        '
        Me.TB_PROD_TIPO_DESCRIPCION.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PROD_TIPO_DESCRIPCION.Location = New System.Drawing.Point(107, 72)
        Me.TB_PROD_TIPO_DESCRIPCION.Name = "TB_PROD_TIPO_DESCRIPCION"
        Me.TB_PROD_TIPO_DESCRIPCION.Size = New System.Drawing.Size(231, 26)
        Me.TB_PROD_TIPO_DESCRIPCION.TabIndex = 12
        '
        'FRM_TIPOS_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 178)
        Me.Controls.Add(Me.TB_PROD_TIPO_DESCRIPCION)
        Me.Controls.Add(Me.BTN_PROD_TIPO_SALIR)
        Me.Controls.Add(Me.BTN_PROD_TIPO_GUARDAR)
        Me.Controls.Add(Me.BTN_PROD_TIPO_ACTUALIZAR)
        Me.Controls.Add(Me.TB_PROD_TIPO_ID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_PROD_TIPO_CODIGO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_TIPOS_PRODUCTOS"
        Me.Text = "TIPOS DE PRODUCTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_PROD_TIPO_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_PROD_TIPO_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_PROD_TIPO_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_TIPO_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROD_TIPO_SALIR As System.Windows.Forms.Button
    Friend WithEvents TB_PROD_TIPO_DESCRIPCION As System.Windows.Forms.TextBox
End Class
