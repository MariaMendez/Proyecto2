Public Class PantallaClasificarPalabras
    Dim palabrasAñadir As New List(Of String)
    Public Sub RellenaCampos()
        cbxEstructuras.Items.Add("Verbos")
        cbxEstructuras.Items.Add("Articulos")
        cbxEstructuras.Items.Add("Preposiciones")
        cbxEstructuras.Items.Add("Vocales")
        cbxEstructuras.Items.Add("Otros")
    End Sub
    Public Sub RecibePalabras(ByVal palabrasSinClasificar As String())
        Dim palabrasAIdentificar As String() = Nothing
        Dim palabra As String = Nothing
        palabrasAIdentificar = palabrasSinClasificar
        For i = 0 To UBound(palabrasAIdentificar)
            lvbPalabras.Items.Add(palabrasAIdentificar(i))
        Next i
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        AdministradorEstructuras.GuardarArraylistVerbos()
        AdministradorEstructuras.GuardarArraylistArticulos()
        AdministradorEstructuras.GuardarArraylistPreposiciones()
        AdministradorEstructuras.GuardarArraylistVocales()
        AdministradorEstructuras.GuardarArraylistOtros()
        Close()
        PantallaPrincipal.BringToFront()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        For index = 0 To lvbPalabras.SelectedItems.Count - 1
            palabrasAñadir.Add(lvbPalabras.SelectedItems.Item(index).Text)
            lvbPalabras.Items.Remove(lvbPalabras.SelectedItems.Item(index))
        Next
        AdministradorEstructuras.AgregaEstructura(palabrasAñadir, cbxEstructuras.SelectedItem)
        MessageBox.Show("La estructura se ha añadido correctamente")
    End Sub

    Private Sub PantallaClasificarPalabras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenaCampos()
    End Sub
End Class