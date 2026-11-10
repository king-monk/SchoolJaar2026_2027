Imports System

Class Dier
    Protected strKleur As String

    Public Sub New(strKleur As String)
        Me.strKleur = strKleur
    End Sub

    Public Function Eet() As String
        Return "Het dier eet."
    End Function
    Public Function Slaap() As String
        Return "Het dier slaapt."
    End Function
End Class

Class Hond
    Inherits Dier
    Private strBaas As String

    Public Sub New(strKleur As String)
        MyBase.New(strKleur)
    End Sub
    Public Function Blaf() As String
        Return "De hond blaft."
    End Function

    Public Function GeefBaasje() As String
        Return strBaas
    End Function

    Public Function ZetEigenaar(strBaas As String) As String
        Me.strBaas = strBaas
        Return "Het baasje van de hond is " & strBaas
    End Function

    Public Sub PrintInformatie()
        Console.WriteLine("Dier: hond")
        Console.WriteLine("Kleur: " & strKleur)
        Console.WriteLine("Baasje: " & strBaas)
    End Sub

End Class

Class Leeuw
    Inherits Dier
    Private strJungleNaam As String

    Public Sub New(strKleur As String, strJungleNaam As String)
        MyBase.New(strKleur)
        Me.strJungleNaam = strJungleNaam
    End Sub

    Public Function Brul() As String
        Return "De leeuw brult."
    End Function

    Public Function GeefJungleNaam() As String
        Return strJunglenaam
    End Function

    Public Function ZetJungleNaam(strJunglenaam As String) As String
        Me.strJunglenaam = strJunglenaam
        Return "De naam van de leeuw in de jungle is " & strJunglenaam
    End Function

    Public Sub PrintInformatie()
        Console.WriteLine("Dier: leeuw")
        Console.WriteLine("Kleur: " & strKleur)
        Console.WriteLine("Junglenaam: " & strJunglenaam)
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim objHond As New Hond("wit")
        Dim objLeeuw As New Leeuw("gert", "Gert")

    End Sub
End Module
