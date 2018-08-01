Public Class PantallaPrincipal
    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        PantallaBuscarArchivo.Show()
    End Sub

    Private Sub BtnAdministrar_Click(sender As Object, e As EventArgs) Handles btnAdministrar.Click
        PantallaAdministrar.Show()
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdministradorEstructuras.AsignaArraylistVerbos()
        AdministradorEstructuras.AsignaArraylistArticulos()
        AdministradorEstructuras.AsignaArraylistVocales()
        AdministradorEstructuras.AsignaArraylistPreposiciones()
    End Sub
End Class