Imports System
'Imports System.Web
'Imports System.Collections.Generic
'Imports System.Linq
'Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
            'Your code goes here
            
             Dim obj As New Line
            For value As Integer = 0 To 2000000000 
             obj.someMethod(1, value)
            Next
        End Sub
                
Class Line
   Private variable As Integer    
   Public Sub New()   'parameterised constructor
     variable = 190909
   End Sub
   Protected Overrides Sub Finalize()  ' destructor   
   End Sub
   Public Function someMethod(ByVal n As Integer, value As Integer) As Integer
      variable = n + i
   End Function
   
End Class
        
    End Module
End Namespace
