Public Class FRM_VENTAS_BUSCAR_M_B

    Dim datacontext As New DC_AdminDataContext

    Private Sub FRM_VENTAS_BUSCAR_M_B_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub BTN_PROD_TIPO_BUS_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_BUS_SALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TB_PROD_TIPO_BUSCAR_CODIGO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_VENTA_BUSCAR_DNI_CLI.TextChanged
        Dim buscar As String
        If RB_PROD_TIPO_BUSCAR_CODIGO.Checked = True Then
            armargrilla()
            buscar = Me.TB_VENTA_BUSCAR_DNI_CLI.Text & "*"
            Dim ConsultaCodigo = From U In datacontext.PRODUCTOS_TIPOS Select U.ID_PROD_TIPO, U.PROD_TIPO_DESC, U.PROD_TIPO_CODIGO Where PROD_TIPO_CODIGO Like buscar.ToString
            DGV_VENTA_BUSCAR.DataSource = ConsultaCodigo
        End If
    End Sub

    Private Sub TB_PROD_TIPO_BUSCAR_DESCRIPCION_TextChanged(sender As System.Object, e As System.EventArgs)
        'Dim buscar As String
        'If RB_PROD_TIPO_BUSCAR_DESCRIPCION.Checked = True Then
        '    armargrilla()
        '    buscar = "*" & Me.TB_PROD_TIPO_BUSCAR_DESCRIPCION.Text & "*"
        '    Dim ConsultaDescripcion = From U In datacontext.PRODUCTOS_TIPOS Select U.ID_PROD_TIPO, U.PROD_TIPO_DESC, U.PROD_TIPO_CODIGO Where PROD_TIPO_DESC Like buscar.ToString
        '    DGV_VENTA_BUSCAR.DataSource = ConsultaDescripcion
        'End If
    End Sub

    Private Sub armargrilla()
        DGV_VENTA_BUSCAR.Enabled = True
        DGV_VENTA_BUSCAR.AutoGenerateColumns = False
        DGV_VENTA_BUSCAR.Columns.Clear()

        DGV_VENTA_BUSCAR.Columns.Add("ID_PROD_TIPO", "ID_PROD_TIPO")
        DGV_VENTA_BUSCAR.Columns.Add("PROD_TIPO_DESC", "DESCRIPCIÓN")
        DGV_VENTA_BUSCAR.Columns.Add("PROD_TIPO_CODIGO", "CÓDIGO")

        DGV_VENTA_BUSCAR.Columns(0).DataPropertyName = "ID_PROD_TIPO"
        DGV_VENTA_BUSCAR.Columns(1).DataPropertyName = "PROD_TIPO_DESC"
        DGV_VENTA_BUSCAR.Columns(2).DataPropertyName = "PROD_TIPO_CODIGO"

        DGV_VENTA_BUSCAR.ClearSelection()

    End Sub

    Public Sub cargargrilla()
        Dim ConsultaTipoProducto = From U In datacontext.PRODUCTOS_TIPOS Select U.ID_PROD_TIPO, U.PROD_TIPO_DESC, U.PROD_TIPO_CODIGO
        DGV_VENTA_BUSCAR.DataSource = ConsultaTipoProducto
    End Sub

    Private Sub RB_PROD_TIPO_BUSCAR_CODIGO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PROD_TIPO_BUSCAR_CODIGO.CheckedChanged
        'TB_PROD_TIPO_BUSCAR_DESCRIPCION.Enabled = False
        'TB_PROD_TIPO_BUSCAR_DESCRIPCION.Clear()
        'TB_VENTA_BUSCAR_DNI_CLI.Enabled = True
    End Sub

    Private Sub RB_PROD_TIPO_BUSCAR_DESCRIPCION_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_PROD_TIPO_BUSCAR_DESCRIPCION.CheckedChanged
        'TB_VENTA_BUSCAR_DNI_CLI.Enabled = False
        'TB_VENTA_BUSCAR_DNI_CLI.Clear()
        'TB_PROD_TIPO_BUSCAR_DESCRIPCION.Enabled = True
    End Sub

    Private Sub BTN_PROD_TIPO_BUS_EDITAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_BUS_EDITAR.Click
        If DGV_VENTA_BUSCAR.SelectedRows.Count > 0 Then
            FRM_TIPOS_PRODUCTOS.TB_PROD_TIPO_ID.Text = DGV_VENTA_BUSCAR.Item("ID_PROD_TIPO", DGV_VENTA_BUSCAR.SelectedRows(0).Index).Value
            FRM_TIPOS_PRODUCTOS.TB_PROD_TIPO_DESCRIPCION.Text = DGV_VENTA_BUSCAR.Item("PROD_TIPO_DESC", DGV_VENTA_BUSCAR.SelectedRows(0).Index).Value
            FRM_TIPOS_PRODUCTOS.TB_PROD_TIPO_CODIGO = DGV_VENTA_BUSCAR.Item("PROD_TIPO_CODIGO", DGV_VENTA_BUSCAR.SelectedRows(0).Index).Value

        End If
        FRM_TIPOS_PRODUCTOS.BTN_PROD_TIPO_GUARDAR.Visible = False
        FRM_TIPOS_PRODUCTOS.Show()
    End Sub

    Private Sub BTN_PROD_TIPO_BUS_ELIMINAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_VENTA_BUS_ELIMINAR.Click
        Dim eliminar = (From C In datacontext.PRODUCTOS_TIPOS Where C.ID_PROD_TIPO = CInt(DGV_VENTA_BUSCAR.Item("ID_PROD_TIPO", DGV_VENTA_BUSCAR.SelectedRows(0).Index).Value)).ToList()(0)

        Select Case MsgBox("Se eliminará el Tipo de Producto seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar el Tipo de Producto")
            Case MsgBoxResult.Yes
                datacontext.PRODUCTOS_TIPOS.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("El Tipo de Producto ha sido eliminado")
                Me.cargargrilla()
        End Select
    End Sub
End Class