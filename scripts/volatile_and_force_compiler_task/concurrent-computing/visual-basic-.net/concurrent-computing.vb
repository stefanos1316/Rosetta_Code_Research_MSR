Imports System.Threading

Module Module1
   Public rnd As New Random

   Sub Main()
       

    For value As Integer = 0 To 1000000

       Dim t1 As New Thread(AddressOf Foo)
       Dim t2 As New Thread(AddressOf Foo)
       Dim t3 As New Thread(AddressOf Foo)

       t1.Start(value.ToString() + "Enjoy")
       t2.Start(value.ToString() + "Rosetta")
       t3.Start(value.ToString() + "Code")

       t1.Join()
       t2.Join()
       t3.Join()
    Next

   End Sub

   Sub Foo(ByVal state As Object)
       Thread.Sleep(rnd.Next(1))
       Console.WriteLine(state)
   End Sub

End Module
