Imports System

Public Class Veelhoek
    Private intAantalzijden As Integer

    Public Sub New(intAantalzijden As Integer)
        Me.intAantalzijden = intAantalzijden
    End Sub
End Class

Public Class Vierkant
    Inherits Veelhoek

    Public Sub New()
        MyBase.New(4)
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim objVierkant As New Vierkant()
        Console.WriteLine("Aantal zijden van het vierkant: {0}", objVierkant.intAantalzijden)
    End Sub
End Module
