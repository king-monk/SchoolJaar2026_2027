Imports System

Public Class Wielrenner
    Public strNaam As String
    Public intLeeftijd As Integer
    Public strPloeg As String

    Public Sub ToonNaam()
        Console.WriteLine($"Naam: {strNaam}")
    End Sub

    Public Sub ToonLeeftijd()
        Console.WriteLine($"Leeftijd: {intLeeftijd}")
    End Sub

    Public Sub ToonPloeg()
        Console.WriteLine($"Ploeg: {strPloeg}")
    End Sub
End Class

Public Class ProfWielrenner
    Inherits Wielrenner

    Public strAantalOverwinningen As String
    Public dblSalaris As Double

    Public Sub ToonAantalOverwinningen()
        Console.WriteLine($"Aantal overwinningen: {strAantalOverwinningen}")
    End Sub

    Public Sub ToonSalaris()
        Console.WriteLine($"Salaris: {dblSalaris:C}")
    End Sub
End Class

Public Class AmateurWielrenner
    Inherits Wielrenner

    Public intAantalDeelnames As Integer
    Public intAantalOverwinningen As Integer

    Public Sub ToonAantalOverwinningen()
        Console.WriteLine($"Aantal overwinningen: {intAantalOverwinningen}")
    End Sub

    Public Sub ToonAantalDeelnames()
        Console.WriteLine($"Aantal deelnames: {intAantalDeelnames}")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim objProfWielrenner1 As New ProfWielrenner With {
            .strNaam = "idk",
            .intLeeftijd = 69,
            .strPloeg = "Team idk",
            .strAantalOverwinningen = "100",
            .dblSalaris = 2
        }

        Dim objProfWielrenner2 As New ProfWielrenner With {
            .strNaam = "Gert",
            .intLeeftijd = 67,
            .strPloeg = "Yo Gert",
            .strAantalOverwinningen = "420",
            .dblSalaris = 1734701.684
        }

        Dim objAmateurWielrenner1 As New AmateurWielrenner With {
            .strNaam = "Bert",
            .intLeeftijd = 2,
            .strPloeg = "Yo Bert",
            .intAantalDeelnames = 23,
            .intAantalOverwinningen = 6
        }

        Dim objAmateurWielrenner2 As New AmateurWielrenner With {
            .strNaam = "Erm",
            .intLeeftijd = 40,
            .strPloeg = "Erm Team",
            .intAantalDeelnames = 293,
            .intAantalOverwinningen = 0
        }

        ToonProfWielrenner(objProfWielrenner1)
        ToonProfWielrenner(objProfWielrenner2)
        ToonAmateurwielrenner(objAmateurWielrenner1)
        ToonAmateurwielrenner(objAmateurWielrenner2)
    End Sub

    Private Sub ToonProfWielrenner(profWielrenner As ProfWielrenner)
        Console.WriteLine("--- Prof Wielrenner ---")
        profWielrenner.ToonNaam()
        profWielrenner.ToonLeeftijd()
        profWielrenner.ToonAantalOverwinningen()
        Console.WriteLine()
    End Sub

    Private Sub ToonAmateurwielrenner(amateurWielrenner As AmateurWielrenner)
        Console.WriteLine("--- Amateur Wielrenner ---")
        amateurWielrenner.ToonNaam()
        amateurWielrenner.ToonLeeftijd()
        amateurWielrenner.ToonAantalOverwinningen()
        Console.WriteLine()
    End Sub
End Module
