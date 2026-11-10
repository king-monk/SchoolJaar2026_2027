Imports System

Public Class Koppel
    Private dblLengteVrouw As Double
    Private dblLengteMan As Double

    Public Sub New(dblLengteVrouw As Double, dblLengteMan As Double)
        Me.dblLengteVrouw = dblLengteVrouw
        Me.dblLengteMan = dblLengteMan
    End Sub

    Public Function BerekenLengteverschil(strGeslacht As String) As Double
        If strGeslacht.ToLower() = "jongen" Then
            Return (dblLengteVrouw + dblLengteMan) / 2 + 6.5
        ElseIf strGeslacht.ToLower() = "meisje" Then
            Return (dblLengteVrouw + dblLengteMan) / 2 - 6.5
        Else
            Return 0
        End If
    End Function
End Class

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module





































