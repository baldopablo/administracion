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
            Subtotal() 'ACTUALIZA SUB TOTAL DEL DATAGRIDVIEW AL QUITAR UN PRODUCTO DE LA VENTA
            CantidadProductos() 'ACTUALIZA LA CANTIDAD DE PRODUCTOS AL QUITAR UN PRODUCTO DE LA VENTA
            Exit Sub
        End If
    End Sub

    'CALCULO DEL SUBTOTAL 
    Private Sub Subtotal()
        Dim suma As Double = 0
        Dim ATot As Integer = DGV_VENTAS_BUSCAR.Rows.Count
        Dim Aa As Integer
        For Aa = 0 To ATot - 1
            suma = suma + DGV_VENTAS_BUSCAR.Rows(Aa).Cells(4).Value
        Next
        If Not String.IsNullOrEmpty(TB_SUBTOTAL_VENTA.Text) Then
            TB_SUBTOTAL_VENTA.Text = Format(suma)
        End If
    End Sub

    'SUMA LA CANTIDAD DE PRODUCTOS DE LA VENTA
    Private Sub CantidadProductos()
        Dim Cantidad_venta As Integer = 0
        Dim iCantidad_Venta As Integer = DGV_VENTAS_BUSCAR.Rows.Count
        Dim c As Integer
        For c = 0 To iCantidad_Venta - 1
            Cantidad_venta = Cantidad_venta + Integer.Parse(DGV_VENTAS_BUSCAR(1, c).Value)
        Next
        lblCantidadProductos.Text = Format(Cantidad_venta)
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    Private Sub BTN_PROD_GUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_GUARDAR.Click
        If DGV_VENTAS_BUSCAR.Rows.Count = 0 Then
            MsgBox("Debe ingresar productos a la venta")
            BTN_VENT_AGREGAR_PROD.Focus()
            Exit Sub
        End If

        'Dim BUSCARVENTA = (From v In datacontext.VENTAS Select v.ID_VENTA Where ID_VENTA = TB_VENTA_ID.Text).Any
        'If BUSCARVENTA = True Then
        '    MsgBox("El código de la venta ingresada ya existe")
        '    Exit Sub
        'End If
        ' Try
        'If TB_VENTA_ID.Text.Length = 0 Or CB_VENTA_FORMAPAGO.Text.Length = 0 Then
        '    MsgBox("Debe completar todos los campos requeridos")
        '    Exit Sub
        'End If
        ' Try

        Dim VEN = New VENTAS


        'GUARDA EN LA TABLA VENTAS
        VEN.VENT_FECHA = DTP_FECHA_VENTA.Text
        VEN.VENT_SUBTOTAL = TB_SUBTOTAL_VENTA.Text
        VEN.VENT_TOTAL = TB_VENTA_TOTAL.Text
        VEN.VENT_CANTIDAD = lblCantidadProductos.Text
        VEN.ID_FORM_DE_PAGO = CB_VENTA_FORMAPAGO.SelectedValue

        datacontext.VENTAS.InsertOnSubmit(VEN)
        datacontext.SubmitChanges()

       
        For Each rows As DataGridViewRow In Me.DGV_VENTAS_BUSCAR.Rows
            Dim P_X_V = New PROD_X_VTA
            'GUARDA EN LA TABLA PROD_X_VTA

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
      
        'Catch ex As Exception
        '    MsgBox("La venta no fue cargada, pongase en contacto con el administrador")
        '    Exit Sub
        'End Try
    End Sub

    Public Sub DisminuirStock()

    End Sub

    Private Sub BTN_VENTA_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_SALIR.Click
        Me.Close()
    End Sub
End Class