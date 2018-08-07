Imports System.IO
Imports AnalizadorEstructurasEspanol.ObtieneTextoArchivo
Imports AnalizadorEstructurasEspanol.AdministradorEstructuras

Public Class PantallaBuscarArchivo

    Private Sub BtnBuscarFolder_Click(sender As Object, e As EventArgs) Handles btnBuscarFolder.Click
        ' Process.Start("explorer.exe", "c:\temp")
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txbRuta.Text = OpenFileDialog1.FileName
        End If

    End Sub


    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        If txbRuta.Text Is Nothing Then
            MessageBox.Show("Por favor seleccione un archivo")
            Exit Sub
        End If
        Dim filePath = txbRuta.Text
        ' Pasar filePath a la clase controladora
        Dim analizador As New ObtieneTextoArchivo
        ' Comprueba si el archivo aún existe 
        If My.Computer.FileSystem.FileExists(filePath) = False Then
            MessageBox.Show("Archivo no encontrado: " & filePath)
            Exit Sub
        End If
        analizador.ConvierteArchivoTexto(filePath)
        Me.Close()
    End Sub

    Private Sub PantallaBuscarArchivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
