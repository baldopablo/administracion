Public Class FRM_PRODUCTOS
    Dim datacontext As New DC_AdminDataContext

    Private Sub BTN_PROD_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_PROD_GUARDAR.Click
        Dim BUSCARPRODUCTO = (From PROD In datacontext.PRODUCTOS Select PROD.PROD_CODIGO Where PROD_CODIGO = TB_PROD_CODIGO.Text).Any
        If BUSCARPRODUCTO = True Then
            MsgBox("El código de producto ingresado ya existe")
            Exit Sub
        End If
        Try
            If TB_PROD_CODIGO.Text.Length = 0 Or TB_PROD_DESCRIPCION.Text.Length = 0 Or TB_PROD_PRECIO_COSTO.Text.Length = 0 Or TB_PROD_PRECIO_VENTA.Text.Length = 0 Or TB_PROD_STOCK.Text.Length = 0 Or CB_PROD_DEPOSITO.Text.Length = 0 Or CB_PROD_PROVEEDOR.Text.Length = 0 Or CB_PROD_TIPO_PROD.Text.Length = 0 Then
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click

        If TB_PROD_ID.Text.Length = 0 Or TB_PROD_CODIGO.Text.Length = 0 Or TB_PROD_DESCRIPCION.Text.Length = 0 Or TB_PROD_PRECIO_COSTO.Text.Length = 0 Or TB_PROD_PRECIO_VENTA.Text.Length = 0 Or TB_PROD_STOCK.Text.Length = 0 Or CB_PROD_DEPOSITO.Text.Length = 0 Or CB_PROD_PROVEEDOR.Text.Length = 0 Or CB_PROD_TIPO_PROD.Text.Length = 0 Then
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
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            'FRM_CLIENTES_BUSCAR_B_M.cargargrilla()
            Me.Close()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar producto")
        End Try
    End Sub
End Class