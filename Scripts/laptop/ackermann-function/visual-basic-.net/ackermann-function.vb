Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)

            For value As Integer = 0 To 1000000
                For m As Integer = 0 To 3                 
                    For n As Integer = 0 To 3
                         ackermann(m,n)
                    Next
                Next
            Next
        End Sub

	
	Public Function ackermann(m As Integer, n As Integer) As Integer
        If m = 0 Then
            return n + 1
        End If

        If n = 0 Then
            return ackermann(m - 1, 1)
        End If

        return ackermann(m - 1, ackermann(m, n -1 ))

	End Function

    End Module
End Namespace
