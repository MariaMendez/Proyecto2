Imports System.IO
Imports AnalizadorEstructurasEspanol.AdministradorEstructuras
Public Class PantallaAdministrar
    Dim estructuras As New ArrayList()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        AñadeEstructura(cbxEstructuras.SelectedItem, txtPalabra.Text)

    End Sub

    Public Sub RellenaCampos()
        AdministradorEstructuras.EnviaEstructura()
        cbxEstructuras.Items.Add("Verbos")
        cbxEstructuras.Items.Add("Articulos")
        cbxEstructuras.Items.Add("Preposiciones")
        cbxEstructuras.Items.Add("Vocales")
        For Each item In estructuras
            cbxEstructuras.Items.Add(item)
        Next

    End Sub
    Private Sub Cabezera()
        dgvEstructuras.Columns.Add(1, "Estructura")
        dgvEstructuras.Columns.Add(2, "Palabras")
    End Sub

    Private Sub PantallaAdministrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RellenaCampos()
        Call Cabezera()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EliminaPalabra(cbxEstructuras.SelectedItem, txtPalabra.Text)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        GuardarArraylistVerbos()
        GuardarArraylistArticulos()
        GuardarArraylistVocales()
        GuardarArraylistPreposiciones()
        Close()
        PantallaPrincipal.BringToFront()
    End Sub
    Public Sub RecibeEstructuras(ByVal estructuraAnadir As ArrayList)
        estructuras = estructuraAnadir
    End Sub
End Class