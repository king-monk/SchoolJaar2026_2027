Module 
    Public Class Bestelling
        'protected, voor overerving mogelijk te maken op een veilige manier
        Protected strKlantNaam As String
        Protected dblTotaalBedrag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub

        Public Overridable Function Print() 'overridable, zodat het kan geprint worden in de console
            Return Console.WriteLine(strKlantNaam + " Totaal bedrag: " + dblTotaalBedrag)
        End Function

        Public Function BerekenVerzendkosten()
            Return dblTotaalBedrag = dblTotaalBedrag + 5
        End Function
    End Class

    Public Class SnelleLevering
        Inherits Bestelling
        Private dblSpoedToeslag As Double

        Public Sub New(dblSpoedToeslag As Double)
            Me.dblSpoedToeslag = 10;
        End Sub

        Public Function BerekenVerzendkoste() '+= bestaat niet in VB? Het zou handig zijn.
            Return dblTotaalBedrag = dblTotaalBedrag + dblSpoedToeslag
        End Function

        Public Function BerekenDouaneKosten()
            Return dblTotaalBedrag = dblTotaalBedrag + dblTotaalBedrag * 0.1 'dblTotaalBedrag * 0.1 is de 10% van Douane
        End Function

        Public Function BerekenVerzendkosten()
            Return dblTotaalBedrag = BerekenDouaneKosten() + 5
        End Function

    End Class

    Public Class Verzending
        Inherits Bestelling
        Protected strVerzendType As String

        Public Sub New(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub

        Public Function BerekenVerzendKosten()
            Return dblTotaalBedrag = dblTotaalBedrag + 3
        End Function
    End Class

    Public Class PakketVerzending
        Inherits Verzending
        Protected strPakketgrootte As String 'er kunnen maar drie verschillende opties geschreven worden zo gezegd,
        'geen idee hoe ik dat in VB doe.

        Public Sub New(strPakketgrootte As String)
            Me.strPakketgrootte = strPakketgrootte
        End Sub

        Public Function BerekenVerzendKosten()
            'Vergeten hoedat ik Else en ElseIf doe..
            'want dit programma verwijderd iedere keer mijn tabs,
            'dus heb ik het maar op de slechte if spam manier gedaan
            'sorry!
            If strPakketgrootte == "klein" Then
                Return dblTotaalBedrag = dblTotaalBedrag + 3
            End If
            If strPakketgrootte == "middelgroot" Then
                Return dblTotaalBedrag = dblTotaalBedrag + 5
            End If
            If strPakketgrootte == "groot" Then
                Return dblTotaalBedrag = dblTotaalBedrag + 8
            End If
        End Function
    End Class

    Public Class Luchtpost
        Inherits Verzending
        Private dblLuchttarief As Double

        Public Sub New(dblLuchttarief As Double)
            Me.dblLuchttarief = 15
        End Sub

        'Ik denk dat ik gewoon het totaal bedrag kan gebruiken omdat dat toch aangepast wordt daar voren al.
        Public Function BerekenVerzendKosten()
            Return dblTotaalBedrag = dblTotaalBedrag + dblLuchttarief
        End Function

    End Class

    Public Sub Main() 'main sub, geen idee of ik er public bij moet zetten of niet
        Dim objBestellingJansen = New Bestelling("Jansen", 100)
        Dim objSnelleLeveringJansen = objBestellingJansen.BerekenVerzendkosten()

        Dim objBestellingMartinez = New Bestelling("Martinez", 200)
        Dim objSnelleLeveringMartinez = objBestellingMartinez.BerekenVerzendkosten()

        Dim objPakketVerzending = New Verzending("Pakket") 'vergeten te zorgen dat de child class ook in de parent class constructor komt
        Dim objLuchtpost = New Verzending("LuchtPost")

        objBestellingJansen.Print()
        objBestellingMartinez.Print()
        objPakketVerzending.Print()
        objLuchtpost.Print()
    End Sub
End Module
