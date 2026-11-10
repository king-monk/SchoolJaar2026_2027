
Imports System

Module Program

    Class Radio

        Public Sub SpeelLied()
            SpeelRadio()
        End Sub

        Private Sub SpeelRadio()
            Dim random As New Random()
            Dim intGetal As Integer = random.Next(1, 4)

            Console.WriteLine("Speel lied: ")

            If intGetal = 1 Then
                Console.WriteLine("Cold little heart")
            ElseIf intGetal = 2 Then
                Console.WriteLine("Stickerbush Symphony")
            Else
                Console.WriteLine("Fear of the dark")
            End If
        End Sub
    End Class

    Sub Main(args As String())
        Dim newRadio As New Radio()
        newRadio.SpeelLied()

        Console.ReadLine()
    End Sub

End Module
