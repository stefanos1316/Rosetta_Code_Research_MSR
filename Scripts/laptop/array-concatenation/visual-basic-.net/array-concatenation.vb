Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
            'Your code goes here
          Dim array1() As Integer = {1, 2, 3, 4, 5}
            Dim array2() As Integer = {6, 7, 8, 9, 10}


            For value As Integer = 0 To 100000000                 
                
                Dim array3(array1.Length + array2.Length - 1) As Integer
 
                Array.Copy(array1, array3, array1.Length)
                Array.Copy(array2, 0, array3, array1.Length, array2.Length)
                
            Next
        End Sub
    End Module
End Namespace
