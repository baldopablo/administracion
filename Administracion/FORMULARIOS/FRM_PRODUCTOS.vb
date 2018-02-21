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
                PRODUCTO.ID_PROVEEDOR = CB_PROD_PROVEEDOR.Text
                PRODUCTO.ID_DEPOSITO = CB_PROD_DEPOSITO.Text
                PRODUCTO.ID_PROD_TIPO = CB_PROD_TIPO_PROD.Text

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
End Class