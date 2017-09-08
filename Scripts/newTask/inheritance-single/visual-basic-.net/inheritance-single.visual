Imports System
Imports System.Web
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Rextester
    Public Module Program
        Public Sub Main(args() As string)
            'Your code goes here
            
            For value As Integer = 0 To 1000000 
             Dim obj As New Dog
             obj.speak()
             obj.walk()
             Next
        End Sub

Class Animal
  ' ...
   Public Function speak() 
      Console.WriteLine("Animal speaking\n")
   End Function

   Public Function walk() 
      Console.WriteLine("Animal walking\n")
   End Function

End Class

Class Dog
  Inherits Animal
  ' ...
   Public Function speak() 
      Console.WriteLine("Dog barking\n")
   End Function
End Class

Class Lab
  Inherits Dog
  ' ...
   Public Function speak() 
      Console.WriteLine("Lab barking\n")
   End Function
End Class

Class Collie
  Inherits Dog
  ' ...
   Public Function speak() 
      Console.WriteLine("Collie barking\n")
   End Function
End Class

Class Cat
  Inherits Animal
  ' ...
   Public Function speak() 
      Console.WriteLine("Cat meawing\n")
   End Function
End Class

End Module
End Namespace
