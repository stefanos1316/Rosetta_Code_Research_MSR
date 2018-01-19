Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
            'Your code goes here


            For value As Integer = 0 To 2000000000                 
          	Dim array1() As Integer = {1+value, 2-value, 3+value, 4-value, 5+value}
            	Dim array2() As Integer = {6+value, 7-value, 8+value, 9-value, 10-value}
                
                Dim array3(array1.Length + array2.Length - 1) As Integer
 
                Array.Copy(array1, array3, array1.Length)
                Array.Copy(array2, 0, array3, array1.Length, array2.Length)
                
            Next
        End Sub
    End Module
End Namespace
