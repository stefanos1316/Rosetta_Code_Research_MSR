Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        ' Match ignoring case of letters.

        For value As Integer = 0 To 10000000

        Dim input As String = "this is a matching string" + value.ToString()
        Dim pattern As String = "string"
        Dim replacement As String = "istyfied"

        Dim match As Match = Regex.Match(input,
                                         "string",
                                         RegexOptions.IgnoreCase)

            If match.Success Then
            End If

            Dim rgx As New Regex(pattern)
            Dim result As String = rgx.Replace(input, replacement)
        Next
    End Sub

End Module
