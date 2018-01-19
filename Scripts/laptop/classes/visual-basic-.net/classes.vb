
Imports System
Imports System.Web
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
            'Your code goes here
            
            For value As Integer = 0 To 2100000000 
             Dim obj As New Line
             	obj.someMethod(value)
             Next
       End Sub
                
Class Line
   Private variable As Integer    
   Public Sub New()   'parameterised constructor
     variable = 190909
   End Sub
   Protected Overrides Sub Finalize()  ' destructor   
   End Sub
   Public Function someMethod(value As Integer) As Integer
      Return variable + value
   End Function
   
End Class
        
    End Module
End Namespace
