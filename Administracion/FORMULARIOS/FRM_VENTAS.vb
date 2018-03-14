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
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_CODIGO", "CODIGO")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_DESCRIPCION", "DESCRIPCION")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_PRECIO_COSTO", "PRECIO DE COSTO")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_PRECIO_VTA", "PRECIO DE VENTA")
        DGV_VENTAS_BUSCAR.Columns.Add("ID_PROD_TIPO", "ID_PROD_TIPO")
        DGV_VENTAS_BUSCAR.Columns.Add("PROD_CANTIDAD", "PROD_CANTIDAD")
        DGV_VENTAS_BUSCAR.Columns.Add("PRECIO_CANTIDAD", "PRECIO_CANTIDAD")

        DGV_VENTAS_BUSCAR.Columns(0).DataPropertyName = "ID_PRODUCTO"
        DGV_VENTAS_BUSCAR.Columns(1).DataPropertyName = "PROD_CODIGO"
        DGV_VENTAS_BUSCAR.Columns(2).DataPropertyName = "PROD_DESCRIPCION"
        DGV_VENTAS_BUSCAR.Columns(3).DataPropertyName = "PROD_PRECIO_COSTO"
        DGV_VENTAS_BUSCAR.Columns(4).DataPropertyName = "PROD_PRECIO_VTA"
        DGV_VENTAS_BUSCAR.Columns(5).DataPropertyName = "ID_PROD_TIPO"
        DGV_VENTAS_BUSCAR.Columns(6).DataPropertyName = "CANTIDAD"
        DGV_VENTAS_BUSCAR.Columns(7).DataPropertyName = "PRECIO_CANTIDAD"
        DGV_VENTAS_BUSCAR.ClearSelection()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENT_QUITAR_PROD.Click
        'CALCULO DEL SUBTOTAL 
        DGV_VENTAS_BUSCAR.Rows.RemoveAt(DGV_VENTAS_BUSCAR.CurrentRow.Index)

        Dim total As Double = 0
        Dim iTotal As Integer = Me.DGV_VENTAS_BUSCAR.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.DGV_VENTAS_BUSCAR(4, i).Value)
        Next
        TXT_SUBTOTAL_VENTA.Text = Format(total, "$ #,##0.00")

        'CUENTA CANTIDAD DE PRODUCTOS DE LA VENTA
        Dim Cantidad_venta As Integer = 0
        Dim iCantidad_Venta As Integer = Me.DGV_VENTAS_BUSCAR.Rows.Count
        Dim c As Integer
        For c = 0 To iCantidad_Venta - 1
            Cantidad_venta = Cantidad_venta + Integer.Parse(Me.DGV_VENTAS_BUSCAR(6, c).Value)
        Next
        Me.lblCantidadProductos.Text = Format(Cantidad_venta)
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    Private Sub BTN_PROD_GUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_GUARDAR.Click
        Dim BUSCARVENTA = (From v In datacontext.VENTAS Select v.ID_VENTA Where ID_VENTA = TB_VENTA_ID.Text).Any
        If BUSCARVENTA = True Then
            MsgBox("El código de la venta ingresada ya existe")
            Exit Sub
        End If
        'Try
        If TB_VENTA_ID.Text.Length = 0 Or TB_VENTA_DESCUENTO.Text.Length = 0 Or CB_VENTA_FORMAPAGO.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Dim VENTA = New VENTAS
        Try
            For Each rows As DataGridViewRow In Me.DGV_VENTAS_BUSCAR.Rows
                VENTA.ID_VENTA = TB_VENTA_ID.Text
                VENTA.ID_PRODUCTO = rows.Cells(0).Value
                VENTA.VENT_FECHA = DTP_FECHA_VENTA.Text
                VENTA.VENT_DESCUENTO = CDbl(TB_VENTA_DESCUENTO.Text)
                VENTA.ID_FORM_DE_PAGO = CB_VENTA_FORMAPAGO.SelectedValue
                VENTA.VENT_CANTIDAD = rows.Cells(6).Value

                datacontext.VENTAS.InsertOnSubmit(VENTA)
                datacontext.SubmitChanges()
            Next

            Select Case MsgBox("La venta fue guadada correctamente, cargar otra?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo cliente")
                Case MsgBoxResult.No
                    Me.Close()
                Case MsgBoxResult.Yes
                    ' limpiar_campos()
            End Select

        Catch ex As Exception
            MsgBox("La venta no fue cargada, pongase en contacto con el administrador")
            Exit Sub
        End Try

    End Sub
End Class