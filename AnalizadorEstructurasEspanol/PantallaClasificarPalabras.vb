Public Class PantallaClasificarPalabras

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
            lbxPalabras.Items.Add(palabrasAIdentificar(i))
        Next i
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        AdministradorEstructuras.GuardarArraylistVerbos()
        AdministradorEstructuras.GuardarArraylistArticulos()
        AdministradorEstructuras.GuardarArraylistVocales()
        AdministradorEstructuras.GuardarArraylistPreposiciones()
        AdministradorEstructuras.GuardarArraylistOtros()
        Close()
        PantallaPrincipal.BringToFront()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim palabrasAñadir As New List(Of String)
        Dim i As Integer = 0
        Do While i <= lbxPalabras.SelectedItems.Count - 1
            If lbxPalabras.SelectedItems.Item(i) IsNot Nothing Then
                palabrasAñadir.Add(lbxPalabras.SelectedItems.Item(i))
                i = i + 1
            End If
        Loop
        lbxPalabras.SelectedItems.Clear()
        AdministradorEstructuras.AgregaEstructura(palabrasAñadir, cbxEstructuras.SelectedItem)
        MessageBox.Show("La estructura se ha añadido correctamente")
    End Sub

    Private Sub PantallaClasificarPalabras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenaCampos()
    End Sub
End Class