Public Class FRM_VENTAS
    Dim datacontext As New DC_AdminDataContext

    Private Sub FRM_VENTAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()

        'CARGA COMBO DEPOSITO
        Dim COMBOFORMAPAGO = (From FDP In datacontext.FORMAS_DE_PAGO Select FDP.ID_FORM_DE_PAGO, FDP.FDP_DESCRIPCION)
        CB_VENTA_FORMAPAGO.DataSource = COMBOFORMAPAGO
        CB_VENTA_FORMAPAGO.DisplayMember = "FDP_DESCRIPCION"
        CB_VENTA_FORMAPAGO.ValueMember = "ID_FORM_DE_PAGO"
    End Sub

    Private Sub BTN_VENT_AGREGAR_PROD_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_AGREGAR_PROD.Click
        FRM_PRODUCTOS_BUSCAR_B_M.ShowDialog()
    End Sub

    Private Sub armargrilla()
        DGV_VENTAS_BUSCAR.Enabled = True
        DGV_VENTAS_BUSCAR.AutoGenerateColumns = False
        DGV_VENTAS_BUSCAR.Columns.Clear()

        DGV_VENTAS_BUSCAR.Columns.Add("ID_PRODUCTO", "ID_PRODUCTO")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_CANTIDAD", "CANTIDAD")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_DESCRIPCION", "DESCRIPCION")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_PRECIO_COSTO", "PRECIO UNITARIO")
        DGV_VENTAS_BUSCAR.Columns.Add("PRECIO TOTAL", "PRECIO TOTAL")

        DGV_VENTAS_BUSCAR.Columns(0).DataPropertyName = "ID_PRODUCTO"
        DGV_VENTAS_BUSCAR.Columns(0).Visible = False
        DGV_VENTAS_BUSCAR.Columns(1).DataPropertyName = "PROD_CANTIDAD"
        DGV_VENTAS_BUSCAR.Columns(2).DataPropertyName = "PROD_DESCRIPCION"
        DGV_VENTAS_BUSCAR.Columns(2).Width = 200
        DGV_VENTAS_BUSCAR.Columns(3).DataPropertyName = "PROD_PRECIO_COSTO"
        DGV_VENTAS_BUSCAR.Columns(3).Width = 150
        DGV_VENTAS_BUSCAR.Columns(4).Width = 150
       
        DGV_VENTAS_BUSCAR.ClearSelection()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_QUITAR_PROD.Click

        If DGV_VENTAS_BUSCAR.Rows.Count = 0 Then
            MsgBox("No existen productos por quitar")
        Else
            DGV_VENTAS_BUSCAR.Rows.RemoveAt(DGV_VENTAS_BUSCAR.CurrentRow.Index)
            FRM_PRODUCTOS.Subtotal()                              'ACTUALIZA SUB TOTAL DEL DATAGRIDVIEW AL QUITAR UN PRODUCTO DE LA VENTA
            FRM_PRODUCTOS.CantidadProductos()                     'ACTUALIZA LA CANTIDAD DE PRODUCTOS AL QUITAR UN PRODUCTO DE LA VENTA

            TB_VENTA_DESCUENTO.Clear()
            TB_VENTA_TOTAL.Clear()
            TB_SUBTOTAL_VENTA.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_CARGAR_CLIENTE.Click
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    Private Sub BTN_PROD_GUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_GUARDAR.Click

        'VALIDA CARGA DE PRODUCTOS PARA LA VENTA
        If DGV_VENTAS_BUSCAR.Rows.Count = 0 Then
            MsgBox("Debe ingresar productos a la venta")
            BTN_VENT_AGREGAR_PROD.Focus()
            Exit Sub
        End If
        'VALIDA LA CARGA DE CLIENTE
        If TB_CLIENTE_APELLIDO.Text.Length = 0 Or TB_CLIENTE_NOMBRE.Text.Length = 0 Or TB_CLIENTE_DNI.Text.Length = 0 Or TB_CLIENTE_DIRECCION.Text.Length = 0 Or TB_CLIENTE_TELEFONO.Text.Length = 0 Then
            MsgBox("Debe seleccionar un cliente")
            BTN_VENT_CARGAR_CLIENTE.Focus()
            Exit Sub
        End If
        Try
            Dim VEN = New VENTAS

            'GUARDA EN LA TABLA VENTAS
            VEN.VENT_FECHA = DTP_FECHA_VENTA.Text
            VEN.VENT_SUBTOTAL = TB_SUBTOTAL_VENTA.Text
            VEN.VENT_TOTAL = TB_VENTA_TOTAL.Text
            VEN.VENT_CANTIDAD = LBL_VENTA_CANT_PROD.Text
            VEN.ID_FORM_DE_PAGO = CB_VENTA_FORMAPAGO.SelectedValue

            datacontext.VENTAS.InsertOnSubmit(VEN)
            datacontext.SubmitChanges()

            'GUARDA EN LA TABLA PROD_X_VTA
            For Each rows As DataGridViewRow In Me.DGV_VENTAS_BUSCAR.Rows
                Dim P_X_V = New PROD_X_VTA

                P_X_V.ID_PRODUCTO = rows.Cells(0).Value
                P_X_V.PXV_CANTIDAD = rows.Cells(1).Value
                P_X_V.PXV_PRECIO_X_PRODUCTO = rows.Cells(3).Value
                TB_VENTA_ID.Text = VEN.ID_VENTA
                P_X_V.ID_VENTA = TB_VENTA_ID.Text
                TB_PROD_X_VTA_ID.Text = P_X_V.ID_PROD_X_VTA
                datacontext.PROD_X_VTA.InsertOnSubmit(P_X_V)
                datacontext.SubmitChanges()
            Next
            MsgBox("La venta fue realizada correctamente", vbInformation)
        Catch ex As Exception
            MsgBox("La venta no fue cargada, pongase en contacto con el administrador")
            Exit Sub
        End Try
    End Sub

    Private Sub BTN_VENTA_ACTUALIZAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_ACTUALIZAR.Click

        If TB_SUBTOTAL_VENTA.Text.Length = 0 Or TB_VENTA_TOTAL.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim VEN = New VENTAS
            Dim ActualizarVenta = (From P In datacontext.VENTAS Where P.ID_VENTA = (TB_VENTA_ID.Text)).ToList()(0)

            'ACTUALIZA LA TABLA VENTAS
            ActualizarVenta.VENT_FECHA = DTP_FECHA_VENTA.Text
            ActualizarVenta.VENT_SUBTOTAL = TB_SUBTOTAL_VENTA.Text
            ActualizarVenta.VENT_TOTAL = TB_VENTA_TOTAL.Text
            ActualizarVenta.VENT_CANTIDAD = LBL_VENTA_CANT_PROD.Text
            ActualizarVenta.ID_FORM_DE_PAGO = CB_VENTA_FORMAPAGO.Text
            datacontext.SubmitChanges()


            'ACTUALIZA LA TABLA PROD_X_VENTA
            For Each rows As DataGridViewRow In Me.DGV_VENTAS_BUSCAR.Rows
                Dim PROD_X_VTA = New PROD_X_VTA

                PROD_X_VTA.ID_PRODUCTO = rows.Cells(0).Value
                PROD_X_VTA.PXV_CANTIDAD = rows.Cells(1).Value
                PROD_X_VTA.PXV_PRECIO_X_PRODUCTO = rows.Cells(3).Value
                TB_VENTA_ID.Text = VEN.ID_VENTA
                PROD_X_VTA.ID_VENTA = TB_VENTA_ID.Text
                TB_PROD_X_VTA_ID.Text = PROD_X_VTA.ID_PROD_X_VTA

                datacontext.SubmitChanges()
            Next
            MsgBox("Los datos se han modificado correctamente")
            FRM_VENTAS_BUSCAR_M_B.cargargrilla()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar venta")
        End Try
    End Sub

    Public Sub DisminuirStock()

    End Sub

    Private Sub BTN_VENTA_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_SALIR.Click
        Me.Close()
    End Sub

    Private Sub TB_VENTA_DESCUENTO_LostFocus(sender As Object, e As System.EventArgs) Handles TB_VENTA_DESCUENTO.LostFocus

        'CALCULO DEL TOTAL DE LA VENTA
        If TB_VENTA_DESCUENTO.Text = "" Then
            TB_VENTA_TOTAL.Text = TB_SUBTOTAL_VENTA.Text
        Else
            Dim vsubtotal As Double = TB_SUBTOTAL_VENTA.Text
            Dim vdescuento As Double = TB_VENTA_DESCUENTO.Text
            Dim vporcentaje As Double
            Dim vtotal As Double

            vporcentaje = vsubtotal * vdescuento / 100
            vtotal = vsubtotal - vporcentaje
            TB_VENTA_TOTAL.Text = vtotal
        End If
    End Sub

End Class