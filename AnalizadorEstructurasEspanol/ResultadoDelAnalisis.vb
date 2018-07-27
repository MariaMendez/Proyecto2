Imports AnalizadorEstructurasEspanol.AdministradorEstructuras
Imports AnalizadorEstructurasEspanol.ObtieneTextoArchivo
Public Class ResultadoDelAnalisis

    Public Sub ObtieneElementos(ByVal textoArchivo As String)
        Dim administrador = New AdministradorEstructuras
        Dim pantallaClasificar = New PantallaClasificarPalabras
        Dim verbos As String() = administrador.AdministradorVerbos()
        Dim articulos As String() = administrador.AdministradorArticulos()
        Dim vocales As String() = administrador.AdministradorVocales()
        Dim preposiciones As String() = administrador.AdministradorPreposiones()
        Dim palabrasIdentificadas As New List(Of String)
        Dim cantidadVerbos As Integer = 0
        Dim cantidadArticulos As Integer = 0
        Dim cantidadVocales As Integer = 0
        Dim cantidadPreposiciones As Integer = 0
        Dim tamañoTexto As Integer = Len(textoArchivo)
        Dim palabra As String = Nothing
        Dim arrayPalabras() As String, i As Integer
        arrayPalabras = Strings.Split(textoArchivo, " ")

        For index = 0 To verbos.GetUpperBound(0)
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i)
                If palabra = (verbos.GetValue(index).ToString) Then
                    cantidadVerbos = cantidadVerbos + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i
            ' If textoArchivo.Contains(verbos.GetValue(index).ToString) Then
            'cantidadVerbos = cantidadVerbos + 1
            ' End If
        Next
        txbVerbos.Text = cantidadVerbos
        For index = 0 To articulos.GetUpperBound(0)
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i)
                If palabra = (articulos.GetValue(index).ToString) Then
                    cantidadArticulos = cantidadArticulos + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i
        Next
        txbArticulos.Text = cantidadArticulos
        For index = 0 To vocales.GetUpperBound(0)
            For i = 1 To tamañoTexto
                If Mid(textoArchivo, i, 1).Contains(vocales.GetValue(index).ToString) Then
                    cantidadVocales = cantidadVocales + 1
                End If
            Next
        Next
        txbVocales.Text = cantidadVocales
        For index = 0 To preposiciones.GetUpperBound(0)
            For i = 0 To UBound(arrayPalabras)
                palabra = arrayPalabras(i)
                If palabra = (preposiciones.GetValue(index).ToString) Then
                    cantidadPreposiciones = cantidadPreposiciones + 1
                    palabrasIdentificadas.Add(palabra)
                End If
            Next i

        Next
        txbPreposiciones.Text = cantidadPreposiciones
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
            MessageBox.Show("adios")
        End If
    End Sub
End Class