Public Class PantallaClasificarPalabras
    Public Sub RecibePalabras(ByVal palabrasSinClasificar As String())
        Dim palabrasAIdentificar As String() = Nothing
        Dim palabra As String = Nothing
        palabrasAIdentificar = palabrasSinClasificar
        For i = 0 To UBound(palabrasAIdentificar)
            cbxPalabras.Items.Add(palabrasAIdentificar(i))
        Next i
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

     
    End Sub
End Class