Public Class FRM_FORMAS_DE_PAGO
    Dim datacontext As New DC_AdminDataContext

    'GUARDAR
    Private Sub BTN_FDP_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FDP_GUARDAR.Click
        Dim BUSCARFORMAPAGO = (From FDP In datacontext.FORMAS_DE_PAGO Select FDP.FDP_DESCRIPCION Where FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text).Any
        If BUSCARFORMAPAGO = True Then
            MsgBox("El DNI ingresado ya pertence a un cliente")
            Exit Sub
        End If

        If TB_FDP_DESCRIPCION.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim i As Integer
            Dim FORMA_PAGO = New FORMAS_DE_PAGO

            '  FORMA_PAGO.ID_FORM_DE_PAGO = TB_FDP_ID.Text
            FORMA_PAGO.FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text

            i = FORMA_PAGO.ID_FORM_DE_PAGO

            datacontext.FORMAS_DE_PAGO.InsertOnSubmit(FORMA_PAGO)
            datacontext.SubmitChanges()

               Select MsgBox("El Cliente fue creado, cargar otro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo cliente")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    TB_FDP_DESCRIPCION.Clear()
            End Select

        Catch ex As Exception
            MsgBox("La forma de pago no fue cargada, pongase en contacto con el administrador")
            Exit Sub
        End Try

    End Sub

    Private Sub FRM_FORMAS_DE_PAGO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TB_FDP_DESCRIPCION.Focus()
    End Sub

    Private Sub BTN_FDP_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_FDP_SALIR.Click
        Me.Close()
    End Sub

    Private Sub BTN_FDP_ACTUALIZAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_FDP_ACTUALIZAR.Click
        If TB_FDP_DESCRIPCION.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarFormaPago = (From P In datacontext.FORMAS_DE_PAGO Where P.ID_FORM_DE_PAGO = (TB_FDP_ID.Text)).ToList()(0)

            ActualizarFormaPago.ID_FORM_DE_PAGO = TB_FDP_ID.Text
            ActualizarFormaPago.FDP_DESCRIPCION = TB_FDP_DESCRIPCION.Text
           
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            FRM_CLIENTES_BUSCAR_B_M.cargargrilla()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar alumno")
        End Try
    End Sub
End Class