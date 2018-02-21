<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROVEEDORES
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
        Me.BTN_PROV_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_PROV_SALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PROV_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TB_PROV_DIRECCION = New System.Windows.Forms.TextBox()
        Me.TB_PROV_TEL_1 = New System.Windows.Forms.TextBox()
        Me.TB_PROV_TEL_2 = New System.Windows.Forms.TextBox()
        Me.TB_PROV_MAIL = New System.Windows.Forms.TextBox()
        Me.TB_PROV_URL = New System.Windows.Forms.TextBox()
        Me.TB_PROV_LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.TB_PROV_CODIGO = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTN_PROV_GUARDAR
        '
        Me.BTN_PROV_GUARDAR.Location = New System.Drawing.Point(14, 196)
        Me.BTN_PROV_GUARDAR.Name = "BTN_PROV_GUARDAR"
        Me.BTN_PROV_GUARDAR.Size = New System.Drawing.Size(82, 28)
        Me.BTN_PROV_GUARDAR.TabIndex = 0
        Me.BTN_PROV_GUARDAR.Text = "Guardar"
        Me.BTN_PROV_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_PROV_SALIR
        '
        Me.BTN_PROV_SALIR.Location = New System.Drawing.Point(149, 196)
        Me.BTN_PROV_SALIR.Name = "BTN_PROV_SALIR"
        Me.BTN_PROV_SALIR.Size = New System.Drawing.Size(82, 28)
        Me.BTN_PROV_SALIR.TabIndex = 1
        Me.BTN_PROV_SALIR.Text = "Salir"
        Me.BTN_PROV_SALIR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Teléfono 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Teléfono 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Página web"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Localidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(146, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Código"
        '
        'TB_PROV_NOMBRE
        '
        Me.TB_PROV_NOMBRE.Location = New System.Drawing.Point(14, 24)
        Me.TB_PROV_NOMBRE.Name = "TB_PROV_NOMBRE"
        Me.TB_PROV_NOMBRE.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_NOMBRE.TabIndex = 10
        '
        'TB_PROV_DIRECCION
        '
        Me.TB_PROV_DIRECCION.Location = New System.Drawing.Point(149, 25)
        Me.TB_PROV_DIRECCION.Name = "TB_PROV_DIRECCION"
        Me.TB_PROV_DIRECCION.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_DIRECCION.TabIndex = 11
        '
        'TB_PROV_TEL_1
        '
        Me.TB_PROV_TEL_1.Location = New System.Drawing.Point(14, 60)
        Me.TB_PROV_TEL_1.Name = "TB_PROV_TEL_1"
        Me.TB_PROV_TEL_1.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_TEL_1.TabIndex = 12
        '
        'TB_PROV_TEL_2
        '
        Me.TB_PROV_TEL_2.Location = New System.Drawing.Point(149, 64)
        Me.TB_PROV_TEL_2.Name = "TB_PROV_TEL_2"
        Me.TB_PROV_TEL_2.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_TEL_2.TabIndex = 13
        '
        'TB_PROV_MAIL
        '
        Me.TB_PROV_MAIL.Location = New System.Drawing.Point(15, 99)
        Me.TB_PROV_MAIL.Name = "TB_PROV_MAIL"
        Me.TB_PROV_MAIL.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_MAIL.TabIndex = 14
        '
        'TB_PROV_URL
        '
        Me.TB_PROV_URL.Location = New System.Drawing.Point(149, 99)
        Me.TB_PROV_URL.Name = "TB_PROV_URL"
        Me.TB_PROV_URL.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_URL.TabIndex = 15
        '
        'TB_PROV_LOCALIDAD
        '
        Me.TB_PROV_LOCALIDAD.Location = New System.Drawing.Point(16, 146)
        Me.TB_PROV_LOCALIDAD.Name = "TB_PROV_LOCALIDAD"
        Me.TB_PROV_LOCALIDAD.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_LOCALIDAD.TabIndex = 16
        '
        'TB_PROV_CODIGO
        '
        Me.TB_PROV_CODIGO.Location = New System.Drawing.Point(149, 146)
        Me.TB_PROV_CODIGO.Name = "TB_PROV_CODIGO"
        Me.TB_PROV_CODIGO.Size = New System.Drawing.Size(83, 20)
        Me.TB_PROV_CODIGO.TabIndex = 17
        '
        'FRM_PROVEEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TB_PROV_CODIGO)
        Me.Controls.Add(Me.TB_PROV_LOCALIDAD)
        Me.Controls.Add(Me.TB_PROV_URL)
        Me.Controls.Add(Me.TB_PROV_MAIL)
        Me.Controls.Add(Me.TB_PROV_TEL_2)
        Me.Controls.Add(Me.TB_PROV_TEL_1)
        Me.Controls.Add(Me.TB_PROV_DIRECCION)
        Me.Controls.Add(Me.TB_PROV_NOMBRE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_PROV_SALIR)
        Me.Controls.Add(Me.BTN_PROV_GUARDAR)
        Me.Name = "FRM_PROVEEDORES"
        Me.Text = "PROVEEDORES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_PROV_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_PROV_SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_PROV_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_TEL_1 As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_TEL_2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_MAIL As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_URL As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_LOCALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TB_PROV_CODIGO As System.Windows.Forms.TextBox
End Class
