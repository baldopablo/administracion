Public Class FRM_PROVEEDORES
    Dim datacontext As New DC_AdminDataContext
   
    Private Sub BTN_PROV_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROV_GUARDAR.Click
        Dim BUSCARPORVEEDOR = (From PROV In datacontext.PROVEEDORES Select PROV.PROV_CODIGO Where PROV_CODIGO = TB_PROV_CODIGO.Text).Any
        If BUSCARPORVEEDOR = True Then
            MsgBox("El código ingresado ya pertence a un porveedor")
            Exit Sub
        End If
        Try
            If TB_PROV_CODIGO.Text.Length = 0 Or TB_PROV_DIRECCION.Text.Length = 0 Or TB_PROV_LOCALIDAD.Text.Length = 0 Or TB_PROV_NOMBRE.Text.Length = 0 Or TB_PROV_TEL_1.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim PORVEEDOR = New PROVEEDORES

                PORVEEDOR.PROV_NOMBRE = TB_PROV_NOMBRE.Text
                PORVEEDOR.PROV_DIRECCION = TB_PROV_DIRECCION.Text
                PORVEEDOR.PROV_TEL_1 = TB_PROV_TEL_1.Text
                PORVEEDOR.PROV_TEL_2 = TB_PROV_TEL_2.Text
                PORVEEDOR.PROV_CODIGO = TB_PROV_CODIGO.Text
                PORVEEDOR.PROV_MAIL = TB_PROV_MAIL.Text
                PORVEEDOR.PROV_URL = TB_PROV_URL.Text
                PORVEEDOR.PROV_LOCALIDAD = TB_PROV_LOCALIDAD.Text
                I = PORVEEDOR.ID_PROVEEDOR


                datacontext.PROVEEDORES.InsertOnSubmit(PORVEEDOR)
                datacontext.SubmitChanges()
                MsgBox("El proveedor se ha creado correctamente", vbInformation)

            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_PROV_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROV_SALIR.Click
        Me.Close()
    End Sub
End Class