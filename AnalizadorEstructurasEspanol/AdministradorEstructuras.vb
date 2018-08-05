Imports System.IO
Imports System.Reflection
Imports System.Text

Public Class AdministradorEstructuras
    Shared verbos As New ArrayList()
    Shared articulos As New ArrayList()
    Shared vocales As New ArrayList()
    Shared preposiciones As New ArrayList()
    Shared verbos2 As New ArrayList
    Shared articulos2 As ArrayList
    Shared vocales2 As ArrayList
    Shared preposiciones2 As ArrayList
    Shared estructura As New ArrayList()
    Shared nuevaEstructura As New Dictionary(Of String, List(Of String))()

    Public Shared Sub AsignaArraylistVerbos()

        Using Reader As New StreamReader("C:\prueba\verbos.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i)
                    verbos.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistArticulos()

        Using Reader As New StreamReader("C:\prueba\articulos.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i)
                    articulos.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistVocales()

        Using Reader As New StreamReader("C:\prueba\vocales.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i)
                    vocales.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistPreposiciones()

        Using Reader As New StreamReader("C:\prueba\preposiciones.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i)
                    preposiciones.Add(palabra)
                Next i
            End While
        End Using
    End Sub
    Public Shared Sub AsignaArraylistNuevasEstructuras()

        Using Reader As New StreamReader("C:\prueba\estructuras.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i)
                    estructura.Add(palabra)
                Next i
            End While
        End Using
    End Sub

    Public Shared Sub AñadeEstructura(ByVal estructura As String, ByVal palabra As String)
        Select Case estructura
            Case "Verbos"
                AdministraVerbos(palabra)
            Case "Articulos"
                AdministraArticulos(palabra)
            Case "Vocales"
                AdministraVocales(palabra)
            Case "Preposiciones"
                AdministraPreposiones(palabra)
            Case Else
                AdministraNuevasEstructuras(estructura, palabra)
        End Select
    End Sub

    Public Shared Sub AdministraVerbos(ByVal verbo)
        verbos.Add(verbo)
        EnviaVerbos()
    End Sub
    Public Shared Sub AdministraArticulos(ByVal articulo)
        articulos.Add(articulo)
        EnviaArticulos()
    End Sub
    Public Shared Sub AdministraVocales(ByVal vocal)
        vocales.Add(vocal)
        EnviaVocales()
    End Sub
    Public Shared Sub AdministraPreposiones(ByVal preposicion)
        preposiciones.Add(preposicion)
        EnviaPreposiciones()
    End Sub
    Public Shared Sub AdministraNuevasEstructuras(ByVal estructura As String, ByVal palabra As String)
        If nuevaEstructura.ContainsKey(estructura) Then
            nuevaEstructura(estructura).Add(palabra)
        Else
            nuevaEstructura.Add(estructura, New List(Of String)(New String() {palabra}))
        End If
    End Sub
    Public Shared Function EnviaVerbos() As ArrayList
        verbos2 = verbos
        For Each obj In verbos2
            Console.Write("   {0}", obj)
        Next obj
        Console.WriteLine()
        Return verbos2
    End Function

    Public Shared Function EnviaArticulos() As ArrayList
        articulos2 = articulos
        For Each obj In articulos
            Console.WriteLine("   {0}", obj)
        Next
        Return articulos2
    End Function

    Public Shared Function EnviaVocales() As ArrayList
        Dim vocales2 As ArrayList
        vocales2 = vocales
        For Each obj In vocales
            Console.WriteLine("   {0}", obj)
        Next
        Return vocales2
    End Function

    Public Shared Function EnviaPreposiciones() As ArrayList
        Dim preposiciones2 As ArrayList
        preposiciones2 = preposiciones
        For Each obj In preposiciones
            Console.WriteLine("   {0}", obj)
        Next
        Return preposiciones2
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
        Dim obj As [Object]
        For Each obj In estructuraEliminada

            Console.Write("   {0}", obj)
        Next obj
        Console.WriteLine()
    End Sub
    Public Shared Sub GuardarArraylistVerbos()
        Dim append As Boolean = True
        Dim nombreArchivo As String = "c:\prueba\verbos.txt"
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
        Dim nombreArchivo As String = "c:\prueba\articulos.txt"
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
        Dim nombreArchivo As String = "c:\prueba\vocales.txt"
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
        Dim nombreArchivo As String = "c:\prueba\preposiciones.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In preposiciones
                writer.Write(obj + " ")
            Next obj
        End Using
    End Sub

    Public Shared Sub AgregaEstructura(ByVal nombreEstructura As String)
        estructura.Add(nombreEstructura)
        Dim append As Boolean = True
        Dim nombreArchivo As String = "c:\prueba\estructuras.txt"
        If (System.IO.File.Exists(nombreArchivo)) Then
            append = False
        End If
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(nombreArchivo, append)
            For Each obj In estructura
                writer.Write(obj + " ")
            Next obj
        End Using
    End Sub
    Public Shared Sub EnviaEstructura()
        PantallaAdministrar.RecibeEstructuras(estructura)
    End Sub

End Class