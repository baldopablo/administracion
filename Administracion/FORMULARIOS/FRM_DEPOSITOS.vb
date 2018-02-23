Public Class FRM_DEPOSITOS
    Dim datacontext As New DC_AdminDataContext

    Private Sub BTN_DEPO_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DEPO_GUARDAR.Click

        Dim BUSCARCODIGO = (From DEPO In datacontext.DEPOSITOS Select DEPO.DEPO_CODIGO Where DEPO_CODIGO = TB_DEPO_CODIGO.Text).Any
        If BUSCARCODIGO = True Then
            MsgBox("El código de deposito ingresado ya existe")
            Exit Sub
        End If
        Try
            'CONTROLAR LA VALIDACION!!!!!!!!

            'If TB_DEPO_CODIGO.Text.Length = 0 Or TB_DEPO_DIRECCION.Text.Length = 0 Or TB_DEPO_LOCALIDAD.Text.Length = 0 Or TB_DEPO_NOMBRE.Text.Length = 0 Then
            '    MsgBox("Debe completar todos los campos requeridos")
            '    Exit Sub
            ' Else
            Dim I As Integer
            Dim DEPOSITO = New DEPOSITOS

            DEPOSITO.DEPO_CODIGO = TB_DEPO_CODIGO.Text
            DEPOSITO.DEPO_DIRECCION = TB_DEPO_DIRECCION.Text
            DEPOSITO.DEPO_LOCALIDAD = TB_DEPO_LOCALIDAD.Text
            DEPOSITO.DEPO_NOMBRE = TB_DEPO_NOMBRE.Text

            I = DEPOSITO.ID_DEPOSITO

            datacontext.DEPOSITOS.InsertOnSubmit(DEPOSITO)
            datacontext.SubmitChanges()
            MsgBox("El depósito se ha creado correctamente", vbInformation)

            '   End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub


    Private Sub BTN_DEPO_ACTUALIZAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_DEPO_ACTUALIZAR.Click

        If TB_DEPO_CODIGO.Text.Length = 0 Or TB_DEPO_NOMBRE.Text.Length = 0 Or TB_DEPO_DIRECCION.Text.Length = 0 Or TB_DEPO_LOCALIDAD.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarDeposito = (From P In datacontext.DEPOSITOS Where P.ID_DEPOSITO = (TB_DEPO_ID.Text)).ToList()(0)

            ActualizarDeposito.ID_DEPOSITO = TB_DEPO_ID.Text
            ActualizarDeposito.DEPO_NOMBRE = TB_DEPO_NOMBRE.Text
            ActualizarDeposito.DEPO_DIRECCION = TB_DEPO_DIRECCION.Text
            ActualizarDeposito.DEPO_LOCALIDAD = TB_DEPO_LOCALIDAD.Text
            ActualizarDeposito.DEPO_CODIGO = TB_DEPO_CODIGO.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
        End Try
    End Sub
End Class