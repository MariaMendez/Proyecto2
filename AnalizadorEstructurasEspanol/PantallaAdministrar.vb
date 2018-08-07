Imports System.IO
Imports AnalizadorEstructurasEspanol.AdministradorEstructuras
Public Class PantallaAdministrar
    Dim estructuras As New ArrayList()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        AñadeEstructura(cbxEstructuras.SelectedItem, txtPalabra.Text)
        MessageBox.Show("Se ha añadido corrrectamente",
                             "Añadir",
                             MessageBoxButtons.OK)
    End Sub

    Public Sub RellenaCampos()
        cbxEstructuras.Items.Add("Verbos")
        cbxEstructuras.Items.Add("Articulos")
        cbxEstructuras.Items.Add("Preposiciones")
        cbxEstructuras.Items.Add("Vocales")
        cbxEstructuras.Items.Add("Otros")
    End Sub
    Private Sub Cabezera()
        dgvEstructuras.Columns.Add(1, "Estructura")
        dgvEstructuras.Columns.Add(2, "Palabras")
    End Sub

    Private Sub PantallaAdministrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RellenaCampos()
        Call Cabezera()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaPalabra(cbxEstructuras.SelectedItem, txtPalabra.Text)
        MessageBox.Show("Se ha eliminado corrrectamente",
                            "Añadir",
                            MessageBoxButtons.OK)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        GuardarArraylistVerbos()
        GuardarArraylistArticulos()
        GuardarArraylistVocales()
        GuardarArraylistPreposiciones()
        GuardarArraylistOtros()
        Close()
        PantallaPrincipal.BringToFront()
    End Sub
    Public Sub RecibeEstructuras(ByVal estructuraAnadir As ArrayList)
        estructuras = estructuraAnadir
    End Sub
End Class