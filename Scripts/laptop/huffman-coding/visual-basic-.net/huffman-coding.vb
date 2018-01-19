Module VBModule

    Sub Main()
       ' Console.WriteLine("Stefanos would like to have huffman's coding in VB.NET")
       
        For value As Integer = 0 To 1000000
            Dim convertThisThing As String = " this is an example for huffman encoding" + value.ToString()
            Dim CMP() As Byte = HuffmanCoding.CompressByteArray(System.Text.Encoding.Unicode.GetBytes(convertThisThing))
        Next
    End Sub
    
End Module


Module HuffmanCoding
    ' first define the BitsArray, which is used to perform bitstoring and reading.
    Private Class bitsarray
        Public BytesUsed As Integer         ' the number of bytes used from the array or the progress
        Public BytesArray() As Byte         ' the bytes array
        Public ByteBuffer As Integer        ' a single buffer used to store bits until they form a byte
        Public ByteBufferUsed As Integer    ' a counter showing how many bits you are using from this array

        ' the constructer
        Public Sub New()
            BytesUsed = 0
            ByteBufferUsed = 0
            ReDim BytesArray(0 To 1023)
        End Sub

        ' SET BYTE ARRAY
        Public Sub SetArray(ByVal A() As Byte)
            BytesArray = A
            BytesUsed = 0
            ByteBufferUsed = -1
        End Sub

        ' add single bit to the buffer
        Public Sub AddBit(ByVal BitValue As Integer)
            ByteBufferUsed = ByteBufferUsed + 1
            BitValue = BitValue Mod 2                                               ' extract the first bit
            ByteBuffer = ByteBuffer Or (BitValue * Math.Pow(2, ByteBufferUsed - 1)) ' add the bit to the buffer
            If ByteBufferUsed = 8 Then
                BytesArray(BytesUsed) = ByteBuffer
                BytesUsed = BytesUsed + 1
                ByteBuffer = 0
                ByteBufferUsed = 0
                If BytesUsed = BytesArray.Length Then
                    ReDim Preserve BytesArray(0 To BytesUsed + 1023)
                End If
            End If
        End Sub


        ' read single bit from the buffer
        Public Function ReadBit() As Integer
            If ByteBufferUsed = -1 Then
                ByteBuffer = BytesArray(0)
                BytesUsed = 0
                ByteBufferUsed = 0
            End If
            If ByteBufferUsed = 8 Then
                BytesUsed = BytesUsed + 1
                ByteBuffer = BytesArray(BytesUsed)
                ByteBufferUsed = 0
            End If
            Dim Bit As Integer
            Bit = ByteBuffer Mod 2
            ByteBuffer = ByteBuffer \ 2
            ByteBufferUsed = ByteBufferUsed + 1
            Return Bit
        End Function

        Public Function ReadBits(ByVal Bits As Integer) As Integer
            Dim V As Integer
            Dim K As Integer
            V = 0
            For K = 0 To Bits - 1
                V = V + (Math.Pow(2, K) * ReadBit())
            Next
            Return V
        End Function



        ' add a number of bits to the array
        Public Sub AddBits(ByVal Value As Integer, ByVal Bits As Integer)
            Dim I As Integer
            For I = 1 To Bits
                AddBit(Value Mod 2)
                Value = Value \ 2
            Next
        End Sub

        ' save the rest of the byte
        Public Sub FlushBuffer()
            Do While ByteBufferUsed <> 0
                AddBit(0)
            Loop
        End Sub

        ' get the bits array
        Public Function GetBitsArray() As Byte()
            Dim B() As Byte
            Dim I As Integer
            ReDim B(0 To BytesUsed - 1)
            For I = 0 To BytesUsed - 1
                B(I) = BytesArray(I)
            Next
            Return B
        End Function

    End Class

    ' next define the tree nodes data struction
    Private Class BinaryTreeNode
        Public Probability As Long
        Public RightNode As BinaryTreeNode
        Public LeftNode As BinaryTreeNode
        Public Symbol As Integer
    End Class

    ' find the probabilities for a set of symbols
    Private Function FindProbabilitiesForSymbols(ByVal Data() As Byte) As Long()
        Dim B(0 To 255) As Long
        Dim I As Integer

        ' set probabilities to zero
        For I = 0 To 255
            B(I) = 0
        Next

        ' compute the probabilities
        For I = 0 To Data.Length - 1
            B(Data(I)) += 1
        Next

        Return B
    End Function


    Private Function GetSymbolCodes(ByVal N As BinaryTreeNode, ByVal Prefix As String) As Collection

        If N.LeftNode Is Nothing And N.RightNode Is Nothing Then
            Dim C As New Collection
            C.Add(N.Symbol)
            C.Add(Prefix)
            Return C
        End If

        Dim C1 As Collection
        Dim C2 As Collection
        Dim C3 As New Collection

        If Not N.LeftNode Is Nothing Then
            C1 = GetSymbolCodes(N.LeftNode, Prefix & "0")
        Else
            C1 = New Collection
        End If

        If Not N.RightNode Is Nothing Then
            C2 = GetSymbolCodes(N.RightNode, Prefix & "1")
        Else
            C2 = New Collection
        End If

        Dim I As Integer
        For I = 1 To C1.Count
            C3.Add(C1(I))
        Next
        For I = 1 To C2.Count
            C3.Add(C2(I))
        Next
        Return C3
    End Function


    Private Sub StoreTree(ByVal Node As BinaryTreeNode, ByRef BA As bitsarray)
        If Node Is Nothing Then
            Exit Sub
        End If

        If Node.Symbol <> -1 Then
            BA.AddBits(3, 2)
            BA.AddBits(Node.Symbol, 8)
            Exit Sub
        End If

        If Not Node.LeftNode Is Nothing Then
            BA.AddBits(0, 2)
            StoreTree(Node.LeftNode, BA)
        Else
            BA.AddBits(2, 2)
        End If

        If Not Node.RightNode Is Nothing Then
            BA.AddBits(1, 2)
            StoreTree(Node.RightNode, BA)
        Else
            BA.AddBits(2, 2)
        End If

    End Sub

    ' load tree from bits array
    Private Sub LoadTree(ByRef Node As BinaryTreeNode, ByVal BA As bitsarray)
        ' get two bits for the command
        Dim CMD As Integer
        Dim K1 As Integer
        Dim K2 As Integer
        CMD = BA.ReadBits(2)

        If CMD = 3 Then
            Node.Symbol = BA.ReadBits(8)
            Return
        End If

        If CMD = 0 Then
            Node.LeftNode = New BinaryTreeNode
            LoadTree(Node.LeftNode, BA)
        Else
            K1 = 0
        End If

        CMD = BA.ReadBits(2)
        If CMD = 1 Then
            Node.RightNode = New BinaryTreeNode
            LoadTree(Node.RightNode, BA)
        Else
            K2 = 0
        End If
    End Sub


    ' compress the data
    Public Function CompressByteArray(ByVal Data() As Byte) As Byte()
        ' first get the probabilities
        Dim P() As Long = FindProbabilitiesForSymbols(Data)

        ' next start creating the tree
        Dim NodeList(0 To 255) As BinaryTreeNode
        Dim NodeListUsed As Integer = 0
        Dim Node As BinaryTreeNode
        Dim I As Integer
        For I = 0 To 255
            If P(I) > 0 Then
                ' create a node
                Node = New BinaryTreeNode
                Node.Symbol = I                 ' the symbol the node is representing
                Node.Probability = P(I)         ' copy the probability
                Node.RightNode = Nothing        ' the default is nothing, but it is okay to assign a value
                Node.LeftNode = Nothing         ' same here
                NodeList(NodeListUsed) = Node   ' add the new node
                NodeListUsed += 1               ' update the number of nodes.
            End If
        Next

        ' next build the tree structure from the leaves
        Do While NodeListUsed > 1

            ' find the two nodes with the minimum probabilities
            Dim MinLoc1 As Integer
            Dim MinLoc2 As Integer
            Dim N1 As BinaryTreeNode
            Dim N2 As BinaryTreeNode

            ' find location of first min probability
            MinLoc1 = 0
            For I = 1 To NodeListUsed - 1
                If NodeList(I).Probability < NodeList(MinLoc1).Probability Then
                    MinLoc1 = I
                End If
            Next

            ' remove the item
            N1 = NodeList(MinLoc1)
            For I = MinLoc1 To NodeListUsed - 2
                NodeList(I) = NodeList(I + 1)
            Next
            NodeListUsed -= 1

            ' find the location of the second min probability
            MinLoc2 = 0
            For I = 1 To NodeListUsed - 1
                If NodeList(I).Probability < NodeList(MinLoc2).Probability Then
                    MinLoc2 = I
                End If
            Next

            ' remove the item
            N2 = NodeList(MinLoc2)
            For I = MinLoc2 To NodeListUsed - 2
                NodeList(I) = NodeList(I + 1)
            Next
            NodeListUsed -= 1


            ' set parent node
            Node = New BinaryTreeNode
            Node.Probability = N1.Probability + N2.Probability
            Node.LeftNode = N1
            Node.RightNode = N2
            Node.Symbol = -1

            ' add this node to the liost
            NodeList(NodeListUsed) = Node
            NodeListUsed += 1
        Loop

        ' now we got the tree, create the look up table for the symbols with code 
        Dim SymbolCodes As Collection = GetSymbolCodes(NodeList(0), "")
        Dim SYM(0 To 255) As String
        Dim I2 As Integer
        For I = 0 To 255
            For I2 = 1 To SymbolCodes.Count Step 2
                If SymbolCodes(I2) = I Then
                    SYM(I) = SymbolCodes(I2 + 1)
                End If
            Next
        Next

        ' define the bit array
        Dim BA As New bitsarray

        ' save tree structure
        Node = NodeList(0)
        I = 0
        BA.AddBits(Data.Length, 32)             ' length of data
        BA.AddBits(SymbolCodes.Count \ 2, 8)    ' number of symbols
        StoreTree(Node, BA)                     ' store the tree

        ' now store the symbols
        For I = 0 To Data.Length - 1
            For I2 = 0 To SYM(Data(I)).Length - 1
                BA.AddBit(SYM(Data(I)).Substring(I2, 1))
            Next
        Next

        BA.FlushBuffer()
        Return BA.GetBitsArray
    End Function

    Public Function DecompressByteArray(ByVal Data() As Byte) As Byte()
        Dim BA As New bitsarray
        BA.SetArray(Data)
        Dim Length As Long = BA.ReadBits(32)    ' get the length of data
        Dim NoOfSymbols = BA.ReadBits(8)        ' get howmany symbols in the tree
        Dim Node As New BinaryTreeNode
        Node.Symbol = -1
        LoadTree(Node, BA)                      ' generate the tree

        ' now we got the tree, create the look up table for the symbols with code 
        Dim SymbolCodes As Collection = GetSymbolCodes(Node, "")
        Dim SYM(0 To 255) As String
        Dim I2 As Integer
        For I As Integer = 0 To 255
            For I2 = 1 To SymbolCodes.Count Step 2
                If SymbolCodes(I2) = I Then
                    SYM(I) = SymbolCodes(I2 + 1)
                End If
            Next
        Next

        ' the last part is to extract the data from the stream
        Dim Result(0 To Length - 1) As Byte
        Dim Bt As String = ""
        Dim RC As Long = 0
        Dim FLG As Boolean
        Do While RC < Length
            FLG = False
            ' check if the bit is in the table
            For i As Integer = 0 To 255
                If SYM(i) = Bt And bt <> "" Then
                    Result(RC) = i
                    RC = RC + 1
                    Bt = ""
                    FLG = True
                    Exit For
                End If
            Next

            If Not FLG Then
                ' add a bit
                Bt = Bt & BA.ReadBit
            End If
        Loop
        Return Result
    End Function
End Module
