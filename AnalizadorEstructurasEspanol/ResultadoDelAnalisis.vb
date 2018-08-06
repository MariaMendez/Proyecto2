Imports AnalizadorEstructurasEspanol.AdministradorEstructuras
Imports AnalizadorEstructurasEspanol.ObtieneTextoArchivo
Public Class ResultadoDelAnalisis

    Public Sub ObtieneElementos(ByVal textoArchivo As String)
        Dim pantallaClasificar = New PantallaClasificarPalabras
        Dim verbos As ArrayList = AdministradorEstructuras.EnviaVerbos()
        Dim articulos As ArrayList = AdministradorEstructuras.EnviaArticulos()
        Dim vocales As ArrayList = AdministradorEstructuras.EnviaVocales()
        Dim preposiciones As ArrayList = AdministradorEstructuras.EnviaPreposiciones()
        Dim otros As ArrayList = AdministradorEstructuras.EnviaOtros()
        Dim palabrasIdentificadas As New List(Of String)
        Dim cantidadVerbos As Integer = 0
        Dim cantidadArticulos As Integer = 0
        Dim cantidadVocales As Integer = 0
        Dim cantidadPreposiciones As Integer = 0
        Dim cantidadOtros As Integer = 0
        Dim tamañoTexto As Integer = Len(textoArchivo)
        Dim palabra As String = Nothing
        Dim arrayPalabras() As String, i As Integer
        arrayPalabras = Strings.Split(textoArchivo, " ")

        For index = 0 To verbos.Count - 1
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i).ToLower
                If palabra = (verbos.Item(index).ToString) Then
                    'Console.WriteLine(verbos.Item(1))
                    cantidadVerbos = cantidadVerbos + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i
            ' If textoArchivo.Contains(verbos.GetValue(index).ToString) Then
            'cantidadVerbos = cantidadVerbos + 1
            ' End If
        Next
        txbVerbos.Text = cantidadVerbos
        For index = 0 To articulos.Count - 1
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i).ToLower
                If palabra = (articulos.Item(index).ToString) Then
                    cantidadArticulos = cantidadArticulos + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i
        Next
        txbArticulos.Text = cantidadArticulos
        For index = 0 To vocales.Count - 1
            For i = 1 To tamañoTexto
                If Mid(textoArchivo, i, 1).Contains(vocales.Item(index).ToString) Then
                    cantidadVocales = cantidadVocales + 1
                End If
            Next
        Next
        txbVocales.Text = cantidadVocales
        For index = 0 To preposiciones.Count - 1
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i).ToLower
                If palabra = (preposiciones.Item(index).ToString) Then
                    cantidadPreposiciones = cantidadPreposiciones + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i

        Next
        txbPreposiciones.Text = cantidadPreposiciones
        For index = 0 To otros.Count - 1
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i).ToLower
                If palabra = (otros.Item(index).ToString) Then
                    cantidadOtros = cantidadOtros + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i

        Next
        txbOtros.Text = cantidadOtros
        Dim arrayPalabras2() As String
        Dim palabrasSinIdentificar As String = String.Join(" ", arrayPalabras.Except(palabrasIdentificadas))
        arrayPalabras2 = Strings.Split(palabrasSinIdentificar, " ")
        PantallaClasificarPalabras.RecibePalabras(arrayPalabras2)
        Show()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim result As Integer = MessageBox.Show("¿Desea clasificar las palabras no identificadas? ",
                              "Clasificar",
                              MessageBoxButtons.YesNo)
        ' MessageBoxButtons.YesNo.GetName(1,"Sí")

        If (result = DialogResult.Yes) Then
            PantallaClasificarPalabras.Show()
        End If
        If (result = DialogResult.No) Then
            Me.Close()
            PantallaPrincipal.BringToFront()
        End If
    End Sub

    Private Sub ResultadoDelAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class