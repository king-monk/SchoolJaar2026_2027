
Imports System

Public Class Voetballer
    Public strNaam As String
    Public dblAccuratie As Double

    Private intAantalGeleKaarten As Integer

    Public Sub New(strNaam As String, dblAccuratie As Double)
        Me.strNaam = strNaam
        Me.dblAccuratie = dblAccuratie
        Me.intAantalGeleKaarten = 0
    End Sub

    Public Function NaarKleedkamer() As String
        If intAantalGeleKaarten >= 2 Then
            Return "Rode kaart"
        Else
            Return "Spelen"
        End If
    End Function

    Public Sub GeefKaart()
        If intAantalGeleKaarten < 2 Then
            intAantalGeleKaarten += 1
        End If
    End Sub
End Class

Public Class Trapper
    Inherits Voetballer

    Public Sub New(strNaam As String, dblAccuratie As Double)
        MyBase.New(strNaam, dblAccuratie)
    End Sub

    Public Function DoeStrafschop() As Double
        Dim dblKans As Double =
            ((dblAccuratie - 0.3) + Rnd() * 0.4)

        Return dblKans
    End Function
End Class

Public Class Keeper
    Inherits Voetballer

    Public Sub New(strNaam As String, dblAccuratie As Double)
        MyBase.New(strNaam, dblAccuratie)
    End Sub

    Public Function DoeStrafschop() As Double
        Dim dblKans As Double =
            ((dblAccuratie - 0.2) + Rnd() * 0.3)

        Return dblKans
    End Function
End Class

Module Program
    Public Sub Main()
        Randomize()

        Dim objMbappe As New Trapper("Kylian Mbappe", 0.8)
        Dim objMartinez As New Keeper("Martinez", 0.6)

        Dim dblTrapper As Double = objMbappe.DoeStrafschop()
        Dim dblKeeper As Double = objMartinez.DoeStrafschop()

        Console.WriteLine("Trapper: " & objMbappe.strNaam)
        Console.WriteLine("Keeper: " & objMartinez.strNaam)

        If dblKeeper > dblTrapper Then
            Console.WriteLine("Gepakt door keeper!")
        Else
            Console.WriteLine("Goal!")
        End If

        Console.ReadLine()
    End Sub
End Module
