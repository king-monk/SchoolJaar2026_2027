Imports System

Module Program
    Sub Main(args As String())
        Dim objTijger As New Tijger()
        Dim objSalamander As New Salamander()
        Dim objMens As New Mens()

        Console.WriteLine("De Salamander heeft " & objSalamander.GeefAantalPoten() & " poten.")
        Console.WriteLine("De Tijger heeft " & objTijger.GeefAantalPoten() & " poten.")
        Console.WriteLine("De Mens heeft " & objMens.GeefAantalPoten() & " poten.")
        Console.WriteLine("De Tijger is " & objTijger.GeefHaarKleur() & " harig.")
        Console.WriteLine("De mens is " & objMens.GeefHaarKleur() & " harig.")
        Console.WriteLine("De Salamander heeft een longcapaciteit van " & objSalamander.GeefLongCapaciteit() & " liter.")
        Console.WriteLine("De Tijger heeft een longcapaciteit van " & objTijger.GeefLongCapaciteit() & " liter.")
        Console.WriteLine("De Mens heeft een longcapaciteit van " & objMens.GeefLongCapaciteit() & " liter.")
    End Sub
End Module

Public Class Salamander
    Protected intAantalPoten As Integer
    Protected intStaartLengteInCm As Integer
    Protected dblLongCapaciteitInLiter As Double

    Public Sub New(intAantalPoten As Integer, intStaartLengteInCm As Integer, dblLongCapaciteitInLiter As Double)
        Me.intAantalPoten = 4
        Me.intStaartLengteInCm = 6
        Me.dblLongCapaciteitInLiter = 0.5
    End Sub

    Public Function GeefAantalPoten() As Integer
        Return intAantalPoten
    End Function

    Public Function GeefLongCapaciteit() As Double
        Return dblLongCapaciteitInLiter
    End Function
End Class

Public Class Tijger
    Inherits Salamander

    Protected strHaarKleur As String

    Public Sub New()
        MyBase.New()
        strHaarKleur = "Zwart"
        dblLongCapaciteitInLiter = 2
    End Sub

    Public Function GeefHaarKleur() As String
        Return strHaarKleur
    End Function
End Class

Public Class Mens
    Inherits Tijger

    Private intAantalBenen As Integer
    Private intAantalArmen As Integer

    Public Sub New(haarKleur As String)
        MyBase.New()
        intAantalPoten = 0
        intStaartLengteInCm = 0
        dblLongCapaciteitInLiter = 7
        strHaarKleur = haarKleur
        intAantalBenen = 2
        intAantalArmen = 2
    End Sub

    Public Function GeefAantalArmenEnBenen() As String
        Return intAantalArmen & " armen en " & intAantalBenen & " benen"
    End Function
End Class
