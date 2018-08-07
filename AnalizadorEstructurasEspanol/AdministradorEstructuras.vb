Imports System.IO
Imports System.Reflection
Imports System.Text

Public Class AdministradorEstructuras
    Shared verbos As New ArrayList()
    Shared articulos As New ArrayList()
    Shared vocales As New ArrayList()
    Shared preposiciones As New ArrayList()
    Shared otros As New ArrayList()
    Shared verbosEnviar As New ArrayList
    Shared articulosEnviar As ArrayList
    Shared vocalesEnviar As ArrayList
    Shared preposicionesEnviar As ArrayList
    Shared otrosEnviar As ArrayList
    Shared estructura As New ArrayList()
    Shared nuevaEstructura As New Dictionary(Of String, List(Of String))()

    Public Shared Sub AsignaArraylistVerbos()

        Using Reader As New StreamReader(".\Arraylist\verbos.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i).ToLower
                    verbos.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistArticulos()

        Using Reader As New StreamReader(".\Arraylist\articulos.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i).ToLower
                    articulos.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistVocales()

        Using Reader As New StreamReader(".\Arraylist\vocales.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i).ToLower
                    vocales.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistPreposiciones()

        Using Reader As New StreamReader(".\Arraylist\preposiciones.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i).ToLower
                    preposiciones.Add(palabra)
                Next i
            End While
        End Using
    End Sub

    Public Shared Sub AsignaArraylistOtros()

        Using Reader As New StreamReader(".\Arraylist\otros.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i).ToLower
                    otros.Add(palabra)
                Next i
            End While
        End Using
    End Sub

    Public Shared Sub AñadeEstructura(ByVal estructura As String, ByVal palabra As String)
        Select Case estructura
            Case "Verbos"
                verbos.Add(palabra)
                EnviaVerbos()
            Case "Articulos"
                articulos.Add(palabra)
                EnviaArticulos()
            Case "Vocales"
                vocales.Add(palabra)
                EnviaVocales()
            Case "Preposiciones"
                preposiciones.Add(palabra)
                EnviaPreposiciones()
            Case "Otros"
                otros.Add(palabra)
                EnviaOtros()
            Case Else
                MessageBox.Show("Elija una estructura valida")
        End Select
    End Sub

    Public Shared Function EnviaVerbos() As ArrayList
        verbosEnviar = verbos
        Return verbosEnviar
    End Function

    Public Shared Function EnviaArticulos() As ArrayList
        articulosEnviar = articulos
        Return articulosEnviar
    End Function

    Public Shared Function EnviaVocales() As ArrayList
        Dim vocales2 As ArrayList
        vocales2 = vocales
        Return vocales2
    End Function

    Public Shared Function EnviaPreposiciones() As ArrayList
        Dim preposiciones2 As ArrayList
        preposiciones2 = preposiciones
        Return preposiciones2
    End Function
    Public Shared Function EnviaOtros() As ArrayList
        otrosEnviar = otros
        Return otrosEnviar
    End Function
    Public Shared Sub EliminaPalabra(ByVal estructuraEliminar, ByVal palabra)
        Dim estructura As New ArrayList()
        Select Case estructuraEliminar
            Case "Verbos"
                estructura = verbos
            Case "Articulos"
                estructura = articulos
            Case "Vocales"
                estructura = vocales
            Case "Preposiciones"
                estructura = preposiciones
        End Select
        Dim estructuraEliminada As New ArrayList()
        Dim i As Integer = 0
        Do While i <= estructura.Count - 1
            If estructura.Item(i).ToString = palabra Then
                estructura.RemoveAt(i)
                estructuraEliminada = estructura
            End If
            i = i + 1
        Loop
        If estructuraEliminar = "Verbos" Then
            verbos = estructuraEliminada
        End If
        If estructuraEliminar = "Articulos" Then
            articulos = estructuraEliminada
        End If
        If estructuraEliminar = "Vocales" Then
            vocales = estructuraEliminada
        End If
        If estructuraEliminar = "Preposiciones" Then
            preposiciones = estructuraEliminada
        End If
    End Sub
    Public Shared Sub GuardarArraylistVerbos()
        Dim append As Boolean = True
        Dim nombreArchivo As String = ".\Arraylist\verbos.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In verbos
                writer.Write(obj + " ")
            Next obj
        End Using
    End Sub
    Public Shared Sub GuardarArraylistArticulos()
        Dim append As Boolean = True
        Dim nombreArchivo As String = ".\Arraylist\articulos.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In articulos
                writer.Write(obj + " ")
            Next obj
        End Using
    End Sub
    Public Shared Sub GuardarArraylistVocales()
        Dim append As Boolean = True
        Dim nombreArchivo As String = ".\Arraylist\vocales.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In vocales
                writer.Write(obj + " ")
            Next obj
        End Using

    End Sub
    Public Shared Sub GuardarArraylistPreposiciones()
        Dim append As Boolean = True
        Dim nombreArchivo As String = ".\Arraylist\preposiciones.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In preposiciones
                writer.Write(obj + " ")
            Next obj
        End Using
    End Sub
    Public Shared Sub GuardarArraylistOtros()
        Dim append As Boolean = True
        Dim nombreArchivo As String = ".\Arraylist\otros.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In otros
                writer.Write(obj + " ")
            Next obj
        End Using
    End Sub

    Public Shared Sub AgregaEstructura(ByVal palabras As List(Of String), ByVal nombreEstructura As String)
        Select Case nombreEstructura
            Case "Verbos"
                For Each item In palabras
                    verbos.Add(item)
                Next
            Case "Articulos"
                For Each item In palabras
                    articulos.Add(item)
                Next
            Case "Preposiciones"
                For Each item In palabras
                    preposiciones.Add(item)
                Next
            Case "Vocales"
                For Each item In palabras
                    vocales.Add(item)
                Next
            Case "Otros"
                For Each item In palabras
                    otros.Add(item)
                Next
        End Select
    End Sub

End Class