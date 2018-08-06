Imports System.IO
Imports System.Reflection
Imports System.Text

Public Class AdministradorEstructuras
    Shared verbos As New ArrayList()
    Shared articulos As New ArrayList()
    Shared vocales As New ArrayList()
    Shared preposiciones As New ArrayList()
    Shared otros As New ArrayList()
    Shared verbos2 As New ArrayList
    Shared articulos2 As ArrayList
    Shared vocales2 As ArrayList
    Shared preposiciones2 As ArrayList
    Shared otros2 As ArrayList
    Shared estructura As New ArrayList()
    Shared nuevaEstructura As New Dictionary(Of String, List(Of String))()

    Public Shared Sub AsignaArraylistVerbos()

        Using Reader As New StreamReader(".\Arraylist\verbos.txt")
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

        Using Reader As New StreamReader(".\Arraylist\articulos.txt")
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

        Using Reader As New StreamReader(".\Arraylist\vocales.txt")
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

        Using Reader As New StreamReader(".\Arraylist\preposiciones.txt")
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

    Public Shared Sub AsignaArraylistOtros()

        Using Reader As New StreamReader(".\Arraylist\otros.txt")
            While Reader.EndOfStream = False
                Dim palabra As String = Nothing
                Dim arrayPalabras As String(), i As Integer
                arrayPalabras = Strings.Split(Reader.ReadLine().TrimEnd, " ")
                For i = 0 To UBound(arrayPalabras)
                    palabra = arrayPalabras(i)
                    otros.Add(palabra)
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
            Case "Otros"
                AdministraOtros(palabra)
            Case Else
                MessageBox.Show("Elija una estructura valida")
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
    Public Shared Sub AdministraOtros(ByVal otro)
        otros.Add(otro)
        EnviaOtros()
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
    Public Shared Function EnviaOtros() As ArrayList
        otros2 = otros
        For Each obj In otros2
            Console.Write("   {0}", obj)
        Next obj
        Console.WriteLine()
        Return otros2
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