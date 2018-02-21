<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_GESTION_USUARIOS
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
        Me.BTN_USU_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_USU_CANCELAR = New System.Windows.Forms.Button()
        Me.TB_USU_USUARIO = New System.Windows.Forms.TextBox()
        Me.TB_USU_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.CB_USU_PERFIL = New System.Windows.Forms.ComboBox()
        Me.BTN_USU_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.TB_USU_REPETIR_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_USU_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña nueva"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Perfil"
        '
        'BTN_USU_GUARDAR
        '
        Me.BTN_USU_GUARDAR.Location = New System.Drawing.Point(12, 153)
        Me.BTN_USU_GUARDAR.Name = "BTN_USU_GUARDAR"
        Me.BTN_USU_GUARDAR.Size = New System.Drawing.Size(79, 29)
        Me.BTN_USU_GUARDAR.TabIndex = 5
        Me.BTN_USU_GUARDAR.Text = "Guardar"
        Me.BTN_USU_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_USU_CANCELAR
        '
        Me.BTN_USU_CANCELAR.Location = New System.Drawing.Point(182, 152)
        Me.BTN_USU_CANCELAR.Name = "BTN_USU_CANCELAR"
        Me.BTN_USU_CANCELAR.Size = New System.Drawing.Size(79, 29)
        Me.BTN_USU_CANCELAR.TabIndex = 7
        Me.BTN_USU_CANCELAR.Text = "Cancelar"
        Me.BTN_USU_CANCELAR.UseVisualStyleBackColor = True
        '
        'TB_USU_USUARIO
        '
        Me.TB_USU_USUARIO.Location = New System.Drawing.Point(15, 35)
        Me.TB_USU_USUARIO.Name = "TB_USU_USUARIO"
        Me.TB_USU_USUARIO.Size = New System.Drawing.Size(137, 20)
        Me.TB_USU_USUARIO.TabIndex = 1
        '
        'TB_USU_CONTRASEÑA
        '
        Me.TB_USU_CONTRASEÑA.Location = New System.Drawing.Point(15, 75)
        Me.TB_USU_CONTRASEÑA.Name = "TB_USU_CONTRASEÑA"
        Me.TB_USU_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_USU_CONTRASEÑA.Size = New System.Drawing.Size(137, 20)
        Me.TB_USU_CONTRASEÑA.TabIndex = 2
        '
        'CB_USU_PERFIL
        '
        Me.CB_USU_PERFIL.FormattingEnabled = True
        Me.CB_USU_PERFIL.Items.AddRange(New Object() {"ADMINISTRADOR", "LIMITADO", "CONSULTA"})
        Me.CB_USU_PERFIL.Location = New System.Drawing.Point(12, 117)
        Me.CB_USU_PERFIL.Name = "CB_USU_PERFIL"
        Me.CB_USU_PERFIL.Size = New System.Drawing.Size(140, 21)
        Me.CB_USU_PERFIL.TabIndex = 4
        '
        'BTN_USU_ACTUALIZAR
        '
        Me.BTN_USU_ACTUALIZAR.Location = New System.Drawing.Point(97, 153)
        Me.BTN_USU_ACTUALIZAR.Name = "BTN_USU_ACTUALIZAR"
        Me.BTN_USU_ACTUALIZAR.Size = New System.Drawing.Size(79, 29)
        Me.BTN_USU_ACTUALIZAR.TabIndex = 6
        Me.BTN_USU_ACTUALIZAR.Text = "Actualizar"
        Me.BTN_USU_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'TB_USU_REPETIR_CONTRASEÑA
        '
        Me.TB_USU_REPETIR_CONTRASEÑA.Location = New System.Drawing.Point(161, 75)
        Me.TB_USU_REPETIR_CONTRASEÑA.Name = "TB_USU_REPETIR_CONTRASEÑA"
        Me.TB_USU_REPETIR_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_USU_REPETIR_CONTRASEÑA.Size = New System.Drawing.Size(137, 20)
        Me.TB_USU_REPETIR_CONTRASEÑA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Repetir contraseña nueva"
        '
        'TB_USU_ID
        '
        Me.TB_USU_ID.Location = New System.Drawing.Point(164, 35)
        Me.TB_USU_ID.Name = "TB_USU_ID"
        Me.TB_USU_ID.Size = New System.Drawing.Size(137, 20)
        Me.TB_USU_ID.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID"
        '
        'FRM_GESTION_USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 193)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_USU_ID)
        Me.Controls.Add(Me.TB_USU_REPETIR_CONTRASEÑA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_USU_ACTUALIZAR)
        Me.Controls.Add(Me.CB_USU_PERFIL)
        Me.Controls.Add(Me.TB_USU_CONTRASEÑA)
        Me.Controls.Add(Me.TB_USU_USUARIO)
        Me.Controls.Add(Me.BTN_USU_CANCELAR)
        Me.Controls.Add(Me.BTN_USU_GUARDAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_GESTION_USUARIOS"
        Me.Text = "Gestión de usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_USU_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_USU_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents TB_USU_USUARIO As System.Windows.Forms.TextBox
    Friend WithEvents TB_USU_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents CB_USU_PERFIL As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_USU_ACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents TB_USU_REPETIR_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_USU_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
