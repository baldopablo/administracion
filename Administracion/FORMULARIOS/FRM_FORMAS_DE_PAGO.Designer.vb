<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMAS_DE_PAGO
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
        Me.BTN_FDP_GUARDAR = New System.Windows.Forms.Button()
        Me.BTN_FDP_SALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_FDP_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTN_FDP_GUARDAR
        '
        Me.BTN_FDP_GUARDAR.Location = New System.Drawing.Point(10, 51)
        Me.BTN_FDP_GUARDAR.Name = "BTN_FDP_GUARDAR"
        Me.BTN_FDP_GUARDAR.Size = New System.Drawing.Size(100, 35)
        Me.BTN_FDP_GUARDAR.TabIndex = 0
        Me.BTN_FDP_GUARDAR.Text = "Guardar"
        Me.BTN_FDP_GUARDAR.UseVisualStyleBackColor = True
        '
        'BTN_FDP_SALIR
        '
        Me.BTN_FDP_SALIR.Location = New System.Drawing.Point(116, 51)
        Me.BTN_FDP_SALIR.Name = "BTN_FDP_SALIR"
        Me.BTN_FDP_SALIR.Size = New System.Drawing.Size(100, 35)
        Me.BTN_FDP_SALIR.TabIndex = 1
        Me.BTN_FDP_SALIR.Text = "Salir"
        Me.BTN_FDP_SALIR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Forma de pago"
        '
        'TB_FDP_DESCRIPCION
        '
        Me.TB_FDP_DESCRIPCION.Location = New System.Drawing.Point(12, 25)
        Me.TB_FDP_DESCRIPCION.Name = "TB_FDP_DESCRIPCION"
        Me.TB_FDP_DESCRIPCION.Size = New System.Drawing.Size(204, 20)
        Me.TB_FDP_DESCRIPCION.TabIndex = 3
        '
        'FRM_FORMAS_DE_PAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 96)
        Me.Controls.Add(Me.TB_FDP_DESCRIPCION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_FDP_SALIR)
        Me.Controls.Add(Me.BTN_FDP_GUARDAR)
        Me.Name = "FRM_FORMAS_DE_PAGO"
        Me.Text = "FORMAS DE PAGO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_FDP_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTN_FDP_SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_FDP_DESCRIPCION As System.Windows.Forms.TextBox
End Class
