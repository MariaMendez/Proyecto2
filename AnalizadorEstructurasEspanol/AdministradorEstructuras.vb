Public Class AdministradorEstructuras
    Public Function AdministradorVerbos() As String()
        Dim verbos = {"abrir", "amar", "aprender", "asesinar", "beber", "bailar", "buscar", "callar", "conocer", "conseguir", "decir", "dejar", "doler", "encontrar", "entender", "escribir", "faltar", "forzar", "funcionar", "ganar", "gritar", "gustar", "intentar", "ir", "lanzar", "leer", "limpiar", "mentir", "mirar", "mover", "necesitar", "negociar", "ocurrir", "parar", "parecer", "partir", "quedar", "quemar", "querer", "recibir", "reconocer", "saber", "salir", "ser", "tardar", "tener", "usar", "vender", "ver", "venir"}
        Return verbos
    End Function
    Public Function AdministradorArticulos() As String()
        Dim articulos = {"el", "la", "los", "las", "un", "una", "unos", "unas", "lo"}
        Return articulos
    End Function
    Public Function AdministradorVocales() As String()
        Dim vocales = {"a", "e", "i", "o", "u"}
        Return vocales
    End Function
    Public Function AdministradorPreposiones() As String()
        Dim preposiciones = {"a", "ante", "bajo", "cabe", "con", "contra", "de", "desde", "en", "entre", "hacia", "hasta", "para", "por", "según", "sin", "so", "sobre", "tras"}
        Return preposiciones
    End Function
End Class
