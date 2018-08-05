Public Class PantallaClasificarPalabras
    Public Sub RecibePalabras(ByVal palabrasSinClasificar As String())
        Dim palabrasAIdentificar As String() = Nothing
        Dim palabra As String = Nothing
        palabrasAIdentificar = palabrasSinClasificar
        For i = 0 To UBound(palabrasAIdentificar)
            lvbPalabras.Items.Add(palabrasAIdentificar(i))
        Next i
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Close()
        PantallaPrincipal.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdministradorEstructuras.AgregaEstructura(txbPreclasificar.Text)
        MessageBox.Show("La estructura se ha añadido correctamente")
    End Sub
End Class