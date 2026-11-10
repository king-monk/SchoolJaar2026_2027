Imports System

Module Program
    Sub Main(args As String())
        Dim objVerdediger As New Verdediger("Jan")
        Dim objAanvaller As New Aanvaller("Pieter")

        objVerdediger.TrapBal()
        objAanvaller.TrapBal()
    End Sub
End Module

Public Class Speler
    Public ReadOnly strNaam As String

    Public Sub New(strNaam As String)
        Me.strNaam = strNaam
    End Sub

    Public Overridable Sub TrapBal()
        Console.WriteLine($"{strNaam} trapt de bal.")
    End Sub
End Class

Public Class Verdediger
    Inherits Speler

    Public Sub New(strNaam As String)
        MyBase.New(strNaam)
    End Sub

    Public Overrides Sub TrapBal()
        If Random.Shared.Next(2) = 0 Then
            Console.WriteLine($"{strNaam} verliest de bal.")
        Else
            Console.WriteLine($"{strNaam} geeft de bal goed af aan een ploeggenoot.")
        End If
    End Sub
End Class

Public Class Aanvaller
    Inherits Speler

    Public Sub New(strNaam As String)
        MyBase.New(strNaam)
    End Sub

    Public Overrides Sub TrapBal()
        If Random.Shared.Next(100) < 30 Then
            Console.WriteLine($"{strNaam} maakt een goal!")
        Else
            Console.WriteLine($"{strNaam} maakt geen goal.")
        End If
    End Sub
End Class
