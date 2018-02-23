<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DEPOSITOS
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
        Me.BTN_DEPO_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_DEPO_SALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_DEPO_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TB_DEPO_DIRECCION = New System.Windows.Forms.TextBox()
        Me.TB_DEPO_LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_DEPO_CODIGO = New System.Windows.Forms.TextBox()
        Me.BTN_DEPO_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.TB_DEPO_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_DEPO_GUARDAR
        '
        Me.BTN_DEPO_GUARDAR.Location = New System.Drawing.Point(12, 219)
        Me.BTN_DEPO_GUARDAR.Name = "BTN_DEPO_GUARDAR"
        Me.BTN_DEPO_GUARDAR.Size = New System.Drawing.Size(93, 34)
        Me.BTN_DEPO_GUARDAR.TabIndex = 0
        Me.BTN_DEPO_GUARDAR.Text = "Guardar"
        Me.BTN_DEPO_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_DEPO_SALIR
        '
        Me.BTN_DEPO_SALIR.Location = New System.Drawing.Point(210, 219)
        Me.BTN_DEPO_SALIR.Name = "BTN_DEPO_SALIR"
        Me.BTN_DEPO_SALIR.Size = New System.Drawing.Size(97, 34)
        Me.BTN_DEPO_SALIR.TabIndex = 1
        Me.BTN_DEPO_SALIR.Text = "Salir"
        Me.BTN_DEPO_SALIR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre del Depósito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Localidad"
        '
        'TB_DEPO_NOMBRE
        '
        Me.TB_DEPO_NOMBRE.Location = New System.Drawing.Point(19, 80)
        Me.TB_DEPO_NOMBRE.Name = "TB_DEPO_NOMBRE"
        Me.TB_DEPO_NOMBRE.Size = New System.Drawing.Size(210, 20)
        Me.TB_DEPO_NOMBRE.TabIndex = 5
        '
        'TB_DEPO_DIRECCION
        '
        Me.TB_DEPO_DIRECCION.Location = New System.Drawing.Point(19, 130)
        Me.TB_DEPO_DIRECCION.Name = "TB_DEPO_DIRECCION"
        Me.TB_DEPO_DIRECCION.Size = New System.Drawing.Size(210, 20)
        Me.TB_DEPO_DIRECCION.TabIndex = 6
        '
        'TB_DEPO_LOCALIDAD
        '
        Me.TB_DEPO_LOCALIDAD.Location = New System.Drawing.Point(20, 180)
        Me.TB_DEPO_LOCALIDAD.Name = "TB_DEPO_LOCALIDAD"
        Me.TB_DEPO_LOCALIDAD.Size = New System.Drawing.Size(209, 20)
        Me.TB_DEPO_LOCALIDAD.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Código"
        '
        'TB_DEPO_CODIGO
        '
        Me.TB_DEPO_CODIGO.Location = New System.Drawing.Point(19, 33)
        Me.TB_DEPO_CODIGO.Name = "TB_DEPO_CODIGO"
        Me.TB_DEPO_CODIGO.Size = New System.Drawing.Size(210, 20)
        Me.TB_DEPO_CODIGO.TabIndex = 9
        '
        'BTN_DEPO_ACTUALIZAR
        '
        Me.BTN_DEPO_ACTUALIZAR.Location = New System.Drawing.Point(111, 219)
        Me.BTN_DEPO_ACTUALIZAR.Name = "BTN_DEPO_ACTUALIZAR"
        Me.BTN_DEPO_ACTUALIZAR.Size = New System.Drawing.Size(97, 34)
        Me.BTN_DEPO_ACTUALIZAR.TabIndex = 10
        Me.BTN_DEPO_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_DEPO_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'TB_DEPO_ID
        '
        Me.TB_DEPO_ID.Location = New System.Drawing.Point(253, 33)
        Me.TB_DEPO_ID.Name = "TB_DEPO_ID"
        Me.TB_DEPO_ID.Size = New System.Drawing.Size(69, 20)
        Me.TB_DEPO_ID.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID"
        '
        'FRM_DEPOSITOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 274)
        Me.Controls.Add(Me.TB_DEPO_ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_DEPO_ACTUALIZAR)
        Me.Controls.Add(Me.TB_DEPO_CODIGO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_DEPO_LOCALIDAD)
        Me.Controls.Add(Me.TB_DEPO_DIRECCION)
        Me.Controls.Add(Me.TB_DEPO_NOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_DEPO_SALIR)
        Me.Controls.Add(Me.BTN_DEPO_GUARDAR)
        Me.Name = "FRM_DEPOSITOS"
        Me.Text = "DEPOSITOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_DEPO_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_DEPO_SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_DEPO_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TB_DEPO_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_DEPO_LOCALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_DEPO_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents BTN_DEPO_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents TB_DEPO_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
