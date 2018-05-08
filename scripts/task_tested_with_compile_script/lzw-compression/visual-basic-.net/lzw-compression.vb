Imports System.Collections.Generic
Imports System.Text
'Imports Microsoft.VisualBasic.ChrW
			
'Public Module Module1
	

	Public Class Program
		Public Shared Sub Main(args As String())
			For i As Integer = 0 To 1000000
				Dim compressed As List(Of Integer) = Compress("TOBEORNOTTOBEORTOBEORNOT")
				'Console.WriteLine(string.Join(", ", compressed));
					'Console.WriteLine(decompressed);
				Dim decompressed As String = Decompress(compressed)
			Next
		End Sub

		Public Shared Function Compress(uncompressed As String) As List(Of Integer)
			' build the dictionary
			Dim dictionary As New Dictionary(Of String, Integer)()
			For i As Integer = 0 To 255
				dictionary.Add(Microsoft.VisualBasic.ChrW(i).ToString(), i)
			Next

			Dim w As String = String.Empty
			Dim compressed As New List(Of Integer)()

			For Each c As Char In uncompressed
				Dim wc As String = w & c
				If dictionary.ContainsKey(wc) Then
					w = wc
				Else
					' write w to output
					compressed.Add(dictionary(w))
					' wc is a new sequence; add it to the dictionary
					dictionary.Add(wc, dictionary.Count)
					w = c.ToString()
				End If
			Next

			' write remaining output if necessary
			If Not String.IsNullOrEmpty(w) Then
				compressed.Add(dictionary(w))
			End If

			Return compressed
		End Function

		Public Shared Function Decompress(compressed As List(Of Integer)) As String
			' build the dictionary
			Dim dictionary As New Dictionary(Of Integer, String)()
			For i As Integer = 0 To 255
				dictionary.Add(i, Microsoft.VisualBasic.ChrW(i).ToString())
			Next

			Dim w As String = dictionary(compressed(0))
			compressed.RemoveAt(0)
			Dim decompressed As New StringBuilder(w)

			For Each k As Integer In compressed
				Dim entry As String = Nothing
				If dictionary.ContainsKey(k) Then
					entry = dictionary(k)
				ElseIf k = dictionary.Count Then
					entry = w + w(0)
				End If

				decompressed.Append(entry)

				' new sequence; add it to the dictionary
				dictionary.Add(dictionary.Count, w + entry(0))

				w = entry
			Next

			Return decompressed.ToString()
		End Function
	End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================

'End Module
