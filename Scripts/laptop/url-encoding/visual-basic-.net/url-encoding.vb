Imports System
Imports System.Web

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
	   For value As Integer = 0 To 10000000
            Dim encodedUrl As String = HttpUtility.UrlEncode("http%3A%2F%2Ffoo%20bar%2F" + value.ToString())
   	   'Console.WriteLine(encodedUrl)
           Next
	End Sub
    End Module
End Namespace
