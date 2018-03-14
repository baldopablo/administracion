Public Class FRM_PRODUCTOS
    Dim datacontext As New DC_AdminDataContext

    Private Sub BTN_PROD_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROD_GUARDAR.Click
        Dim BUSCARPRODUCTO = (From PROD In datacontext.PRODUCTOS Select PROD.PROD_CODIGO Where PROD_CODIGO = TB_PROD_CODIGO.Text).Any
        If BUSCARPRODUCTO = True Then
            MsgBox("El código de producto ingresado ya existe")
            Exit Sub
        End If
        Try
            If TB_PROD_CODIGO.Text.Length = 0 Or TB_PROD_DESCRIPCION.Text.Length = 0 Or TB_PROD_PRECIO_COSTO.Text.Length = 0 Or TB_PROD_PRECIO_VENTA.Text.Length = 0 Or TB_PROD_STOCK.Text.Length = 0 Or CB_PROD_DEPOSITO.Text.Length = 0 Or CB_PROD_PROVEEDOR.Text.Length = 0 Or CB_PROD_TIPO_PROD.Text.Length = 0 Or TB_PROD_CANTIDAD.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim PRODUCTO = New PRODUCTOS

                PRODUCTO.PROD_CODIGO = TB_PROD_CODIGO.Text
                PRODUCTO.PROD_DESCRIPCION = TB_PROD_DESCRIPCION.Text
                PRODUCTO.PROD_PRECIO_COSTO = TB_PROD_PRECIO_COSTO.Text
                PRODUCTO.PROD_PRECIO_VTA = TB_PROD_PRECIO_VENTA.Text
                PRODUCTO.PROD_STOCK = TB_PROD_STOCK.Text
                PRODUCTO.ID_PROVEEDOR = CB_PROD_PROVEEDOR.SelectedValue
                PRODUCTO.ID_DEPOSITO = CB_PROD_DEPOSITO.SelectedValue
                PRODUCTO.ID_PROD_TIPO = CB_PROD_TIPO_PROD.SelectedValue
                PRODUCTO.PROD_CANTIDAD = TB_PROD_CANTIDAD.Text
                I = PRODUCTO.ID_PRODUCTO

                datacontext.PRODUCTOS.InsertOnSubmit(PRODUCTO)
                datacontext.SubmitChanges()
                MsgBox("El producto se ha creado correctamente", vbInformation)

            End If
        Catch ex As Exception
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End Try
    End Sub

    Private Sub FRM_PRODUCTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'CARGA COMBO DEPOSITO
        Dim COMBODEPOSITO = (From DEP In datacontext.DEPOSITOS Select DEP.ID_DEPOSITO, DEP.DEPO_NOMBRE)
        CB_PROD_DEPOSITO.DataSource = COMBODEPOSITO
        CB_PROD_DEPOSITO.DisplayMember = "DEPO_NOMBRE"
        CB_PROD_DEPOSITO.ValueMember = "ID_DEPOSITO"

        'CARGA COMBO PROVEEDOR
        Dim COMBOPROVEEDOR = (From PROV In datacontext.PROVEEDORES Select PROV.ID_PROVEEDOR, PROV.PROV_NOMBRE)
        CB_PROD_PROVEEDOR.DataSource = COMBOPROVEEDOR
        CB_PROD_PROVEEDOR.DisplayMember = "PROV_NOMBRE"
        CB_PROD_PROVEEDOR.ValueMember = "ID_PROVEEDOR"

        'CARGA COMBO TIPO_PRODUCTO
        Dim COMBOTIPO_PRODUCTO = (From TIPO_PROD In datacontext.PRODUCTOS_TIPOS Select TIPO_PROD.ID_PROD_TIPO, TIPO_PROD.PROD_TIPO_DESC)
        CB_PROD_TIPO_PROD.DataSource = COMBOTIPO_PRODUCTO
        CB_PROD_TIPO_PROD.DisplayMember = "PROD_TIPO_DESC"
        CB_PROD_TIPO_PROD.ValueMember = "ID_PROD_TIPO"
    End Sub

    Private Sub BTN_PROD_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_SALIR.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROD_ACTUALIZAR.Click

        If TB_PROD_ID.Text.Length = 0 Or TB_PROD_CODIGO.Text.Length = 0 Or TB_PROD_DESCRIPCION.Text.Length = 0 Or TB_PROD_PRECIO_COSTO.Text.Length = 0 Or TB_PROD_PRECIO_VENTA.Text.Length = 0 Or TB_PROD_STOCK.Text.Length = 0 Or CB_PROD_DEPOSITO.Text.Length = 0 Or CB_PROD_PROVEEDOR.Text.Length = 0 Or CB_PROD_TIPO_PROD.Text.Length = 0 Or TB_PROD_CANTIDAD.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarProducto = (From P In datacontext.PRODUCTOS Where P.ID_PRODUCTO = (TB_PROD_ID.Text)).ToList()(0)

            ActualizarProducto.ID_PRODUCTO = TB_PROD_ID.Text
            ActualizarProducto.PROD_CODIGO = TB_PROD_CODIGO.Text
            ActualizarProducto.PROD_DESCRIPCION = TB_PROD_DESCRIPCION.Text
            ActualizarProducto.PROD_PRECIO_COSTO = TB_PROD_PRECIO_COSTO.Text
            ActualizarProducto.PROD_PRECIO_VTA = TB_PROD_PRECIO_VENTA.Text
            ActualizarProducto.PROD_STOCK = TB_PROD_STOCK.Text
            ActualizarProducto.ID_PROVEEDOR = CB_PROD_PROVEEDOR.SelectedValue
            ActualizarProducto.ID_DEPOSITO = CB_PROD_DEPOSITO.SelectedValue
            ActualizarProducto.ID_PROD_TIPO = CB_PROD_TIPO_PROD.SelectedValue
            ActualizarProducto.PROD_CANTIDAD = TB_PROD_CANTIDAD.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            FRM_PRODUCTOS_BUSCAR_B_M.CargarGrillaProducto()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
        End Try
    End Sub

    Private Sub BTN_PROD_CONFIRMAR_PRODUCTO_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PROD_CONFIRMAR_PRODUCTO.Click
        'CARGA EL DGV DE VENTAS
        Dim id_producto, id_tipo_producto, cantidad As Integer
        Dim codigo_producto, descripcion_producto As String
        Dim precio_costo, precio_venta As Double

        id_producto = TB_PROD_ID.Text
        codigo_producto = TB_PROD_CODIGO.Text
        descripcion_producto = TB_PROD_DESCRIPCION.Text
        precio_costo = TB_PROD_PRECIO_COSTO.Text
        precio_venta = TB_PROD_PRECIO_VENTA.Text
        id_tipo_producto = CB_PROD_TIPO_PROD.SelectedValue
        cantidad = TB_PROD_CANTIDAD.Text
        FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Add(id_producto, codigo_producto, descripcion_producto, precio_costo, precio_venta, id_tipo_producto, cantidad)

         PrecioCantidad()
        FRM_PROVEEDORES_BUSCAR_B_M.Close()
        Me.Close()
    End Sub

    Private Sub PrecioCantidad()

        'SUMA LA CANTIDAD DE PRODUCTOS DE LA VENTA
        Dim Cantidad_venta As Integer = 0
        Dim iCantidad_Venta As Integer = FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Count
        Dim c As Integer
        For c = 0 To iCantidad_Venta - 1
            Cantidad_venta = Cantidad_venta + Integer.Parse(FRM_VENTAS.DGV_VENTAS_BUSCAR(6, c).Value)
        Next
        FRM_VENTAS.lblCantidadProductos.Text = Format(Cantidad_venta)

        'CALCULA PRECIO DE VENTA * LA CANTIDAD DE PRODUCTOS
        Dim total As Double = 0
        Dim ATotal As Integer = FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Count
        Dim A As Integer
        For A = 0 To ATotal - 1
            total = FRM_VENTAS.DGV_VENTAS_BUSCAR("PROD_PRECIO_VTA", A).Value * Double.Parse(FRM_VENTAS.DGV_VENTAS_BUSCAR("PROD_CANTIDAD", A).Value)
            FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows(A).Cells("PRECIO_CANTIDAD").Value = Format(total, "$ #,##0.00")
        Next
        FRM_VENTAS.TXT_SUBTOTAL_VENTA.Text = Format(total, "$ #,##0.00")

    End Sub

End Class