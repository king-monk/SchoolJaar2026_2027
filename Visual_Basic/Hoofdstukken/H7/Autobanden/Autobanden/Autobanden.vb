Imports System

Module Program
    Class Auto
        Public intBandenspanning As Integer


        Public Sub New()
            Me.intBandenspanning = 5
        End Sub

        Public Sub GaOpVakantie()
            Me.intBandenspanning -= 1
            End Function

        Public Sub PompBandenOp()
            Me.intBandenspanning = 5
        End Sub

        Public Function GeefStaatBandenWeer() As String
            If intBandenspanning >= 3 Then
                Return "Alles is oké"
            Else
                Return "Moet opgepompt worden"
            End If
        End Function
    End Class
    Sub Main(args As String())

        Dim objAuto As New Auto()
        Console.WriteLine(objAuto.GaOpVakantie())
    End Sub
End Module
