Imports System.IO
Imports AnalizadorEstructurasEspanol.AdministradorEstructuras
Public Class PantallaAdministrar
    Dim estructuras As New ArrayList()
    Dim verbos As ArrayList = AdministradorEstructuras.EnviaVerbos()
    Dim articulos As ArrayList = AdministradorEstructuras.EnviaArticulos()
    Dim vocales As ArrayList = AdministradorEstructuras.EnviaVocales()
    Dim preposiciones As ArrayList = AdministradorEstructuras.EnviaPreposiciones()
    Dim otros As ArrayList = AdministradorEstructuras.EnviaOtros()

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

    Private Sub PantallaAdministrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RellenaCampos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaPalabra(cbxEstructuras.SelectedItem, txtPalabra.Text)
        MessageBox.Show("Se ha eliminado corrrectamente",
                            "Añadir",
                            MessageBoxButtons.OK)
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        lbxEstructuras.Items.Clear()
        If cbxEstructuras.SelectedItem = "Verbos" Then
            For Each item In verbos
                lbxEstructuras.Items.Add(item)
            Next
        End If
        If cbxEstructuras.SelectedItem = "Articulos" Then
            For Each item In articulos
                lbxEstructuras.Items.Add(item)
            Next
        End If
        If cbxEstructuras.SelectedItem = "Vocales" Then
            For Each item In vocales
                lbxEstructuras.Items.Add(item)
            Next
        End If
        If cbxEstructuras.SelectedItem = "Preposiciones" Then
            For Each item In preposiciones
                lbxEstructuras.Items.Add(item)
            Next
        End If
        If cbxEstructuras.SelectedItem = "Otros" Then
            For Each item In otros
                lbxEstructuras.Items.Add(item)
            Next
        End If

    End Sub

End Class