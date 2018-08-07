Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports System.Reflection
Imports System.IO
Imports Newtonsoft.Json

Public Class PantallaGuardarResultado
    Dim resultadosGuardar As New Dictionary(Of String, Integer)()
    Private Sub BtnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        Dim documento As XmlDocument = New XmlDocument()
        documento.LoadXml("<resultados></resultados>")
        For Each keyvalue As KeyValuePair(Of String, Integer) In resultadosGuardar
            Dim nuevoElemento As XmlElement = documento.CreateElement(keyvalue.Key.ToString)
            nuevoElemento.InnerText = keyvalue.Value.ToString
            documento.DocumentElement.AppendChild(nuevoElemento)
        Next
        documento.PreserveWhitespace = True
        documento.Save("data.xml")
        MessageBox.Show("Se ha guardado el XML correctamente ",
                              "Guardar XML",
                              MessageBoxButtons.OK)
        If DialogResult.OK Then
            Dim resultado As Integer = MessageBox.Show("¿Desea clasificar las palabras no identificadas? ",
                            "Clasificar",
                            MessageBoxButtons.YesNo)
            ' MessageBoxButtons.YesNo.GetName(1,"Sí")

            If (resultado = DialogResult.Yes) Then
                PantallaClasificarPalabras.Show()
            End If
            If (resultado = DialogResult.No) Then
                Me.Close()
                PantallaPrincipal.BringToFront()
            End If
        End If

    End Sub

    Public Function RecibeResultados(ByVal resultadosRecibidos As Dictionary(Of String, Integer))
        resultadosGuardar = resultadosRecibidos
        Show()
        Return resultadosGuardar
    End Function

    Private Sub btnJason_Click(sender As Object, e As EventArgs) Handles btnJason.Click
        File.WriteAllText("...\json\resultado.json", JsonConvert.SerializeObject(resultadosGuardar))
        MessageBox.Show("Se ha guardado el JSON correctamente ",
                             "Guardar JSON",
                             MessageBoxButtons.OK)
        If DialogResult.OK Then
            Dim resultado As Integer = MessageBox.Show("¿Desea clasificar las palabras no identificadas? ",
                            "Clasificar",
                            MessageBoxButtons.YesNo)
            ' MessageBoxButtons.YesNo.GetName(1,"Sí")

            If (resultado = DialogResult.Yes) Then
                PantallaClasificarPalabras.Show()
            End If
            If (resultado = DialogResult.No) Then
                Me.Close()
                PantallaPrincipal.BringToFront()
            End If
        End If
    End Sub
End Class