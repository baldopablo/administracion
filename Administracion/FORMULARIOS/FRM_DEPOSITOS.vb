Public Class FRM_DEPOSITOS
    Dim datacontext As New DC_AdminDataContext
    Private Sub BTN_DEPO_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DEPO_GUARDAR.Click
        Dim BUSCARCODIGO = (From DEPO In datacontext.DEPOSITOS Select DEPO.DEPO_CODIGO Where DEPO_CODIGO = TB_DEPO_CODIGO.Text).Any
        If BUSCARCODIGO = True Then
            MsgBox("El código de deposito ingresado ya existe")
            Exit Sub
        End If
        Try
            If TB_DEPO_CODIGO.Text.Length = 0 Or TB_DEPO_DIRECCION.Text.Length = 0 Or TB_DEPO_LOCALIDAD.Text.Length = 0 Or TB_DEPO_NOMBRE.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
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

            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub
End Class