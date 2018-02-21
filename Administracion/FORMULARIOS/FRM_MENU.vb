

Public Class FRM_MENU
    Public QUIENLLAMOMODIFICARCLIENTE As Form
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
        Me.Dispose()

    End Sub

    Private Sub CargarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarClienteToolStripMenuItem.Click
        FRM_CLIENTES_A_M.BTN_CLIE_ACTUALIZAR.Visible = False
        FRM_CLIENTES_A_M.Show()

    End Sub

    Private Sub EliminarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarClienteToolStripMenuItem.Click
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_EDITAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.Show()

    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_ELIMINAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.Show()
    End Sub

    Private Sub FRM_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        FRM_GESTION_USUARIOS.BTN_USU_ACTUALIZAR.Visible = False
        FRM_GESTION_USUARIOS.Show()

    End Sub

    'CIERRE DE SESION
    Public formularios As New List(Of Form)
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        'LISTA DE FORMULARIOS ABIERTOS
        Dim fr As Form
        For Each fr In Application.OpenForms
            formularios.Add(fr)
        Next
        'ABRE FORMULARIO DE INICIO DE SESION
        Dim frinicio As New FRM_INGRESO
        frinicio.Show()
        'CIERRRA TODOS LOS FORMS ABIERTOS
        For Each frm As Form In formularios
            frm.Close()
        Next

    End Sub

    Private Sub ConsultarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarUsuariosToolStripMenuItem.Click
        FRM_GESTION_USUARIOS_B.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarClientesToolStripMenuItem.Click
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_EDITAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.BTN_CLIE_BUS_ELIMINAR.Visible = False
        FRM_CLIENTES_BUSCAR_B_M.Show()

    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click

    End Sub
End Class

