'Rextester.Program.Main is the entry point for your code. Don't change it.
'Compiler version 11.0.50709.17929 for Microsoft (R) .NET Framework 4.5

Imports System
Imports System.Web
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
            'Your code goes here
            For value As Integer = 0 To 1000000000  
            Dim i As Integer  
	           i = factorial(10)
          
            Next
       		Console.WriteLine("Done")
	 End Sub
       
        Function factorial(ByVal n As Integer) As Integer
            If n <= 1 Then
                Return 1
            Else
                Return factorial(n - 1) * n
            End If
        End Function
        
    End Module
End Namespace
