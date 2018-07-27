Imports AnalizadorEstructurasEspanol.ResultadoDelAnalisis
Public Class ObtieneTextoArchivo
    Public Sub ConvierteArchivoTexto(ByVal nombreArchivo As String)
        If String.IsNullOrEmpty(nombreArchivo) Then
            Throw New ArgumentException("El archivo", NameOf(nombreArchivo) + "se encuentra vacío")
            MessageBox.Show("El archivo está vacío")
        End If
        Dim textoArchivo As String = ConvierteTextoParaAnalizar(nombreArchivo)
        Dim resultados = New ResultadoDelAnalisis
        resultados.ObtieneElementos(textoArchivo)
        'MessageBox.Show(textoArchivo)
    End Sub
    Public Function ConvierteTextoParaAnalizar(ByVal filePath As String) As String

        If My.Computer.FileSystem.FileExists(filePath) = False Then
            Throw New Exception("Archivo no encontrado: " & filePath)
        End If

        Dim stringBuilder As New Text.StringBuilder()
        Dim archivo As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(filePath)
        Dim streamReader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(filePath)
        Dim lineaArchivo As String = ""
        Dim textoFinal As String = ""
        Dim textoArchivo As New ArrayList()

        If streamReader.Peek() >= 0 Then
            Do
                lineaArchivo = streamReader.ReadLine()
                If Not lineaArchivo Is Nothing Then
                    textoArchivo.Add(lineaArchivo)
                End If
            Loop Until lineaArchivo Is Nothing
            streamReader.Close()
            For Each lineaArchivo In textoArchivo
                'Console.WriteLine(lineaArchivo)
                textoFinal += " " + lineaArchivo + " "
                Console.WriteLine(textoFinal)
            Next
        End If

        Return textoFinal
    End Function
End Class
