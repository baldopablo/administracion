Public Class FRM_FORMAS_DE_PAGO
    Dim datacontext As New DC_AdminDataContext
    Private Sub BTN_FDP_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FDP_GUARDAR.Click
        Dim BUSCARFDP = (From FDP In datacontext.FORMAS_DE_PAGO Select FDP.FDP_DESCRIPCION Where FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text).Any
        If BUSCARFDP = True Then
            MsgBox("La forma de pago ingresada ya existe")
            Exit Sub
        End If
        Try
            If TB_FDP_DESCRIPCION.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim FDEPAGO = New FORMAS_DE_PAGO

                FDEPAGO.FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text

                I = FDEPAGO.ID_FORM_DE_PAGO

                datacontext.FORMAS_DE_PAGO.InsertOnSubmit(FDEPAGO)
                datacontext.SubmitChanges()
                MsgBox("La forma de pago se ha creado correctamente", vbInformation)

            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

End Class