Option Strict On
Option Explicit On 

Public Class clsLZW
    ' see http://marknelson.us/1989/10/01/lzw-data-compression/
    ' this is a VB.NET conversion port of mark's C program.
    ' Please refer to that program prior to modifying this one.

    Private BITS As Integer = 14
    Private HASHING_SHIFT As Integer = 4
    Private MAX_VALUE As Integer = (1 << BITS) - 1
    Private MAX_CODE As Integer = MAX_VALUE - 1
    'Private Const TABLE_SIZE As Integer = 5021 ' 12 bits
    'Private Const TABLE_SIZE As Integer = 9029 ' 13 bits
    Private Const TABLE_SIZE As Integer = 18041 ' 14 bits
    Private EOF As Integer = -1

    Public brInput As IO.BinaryReader = Nothing
    Public bwOutput As IO.BinaryWriter = Nothing

    Private iaCode_Value(TABLE_SIZE) As Integer
    Private iaPrefix_Code(TABLE_SIZE) As Integer
    Private baAppend_Character(TABLE_SIZE) As Byte

    '** This is the compression routine.  The code should be a fairly close
    '** match to the algorithm accompanying the article.
    Public Sub compress()
        Dim iNextCode As Integer = 0
        Dim iCharacter As Integer = 0
        Dim iStringCode As Integer = 0
        Dim iIndex As Integer = 0

        iNextCode = 256                   ' Next code is the next available string code

        For i As Integer = 0 To TABLE_SIZE - 1 ' Clear out the string table before starting
            iaCode_Value(i) = -1
        Next i

        ' Get the first iCharacter. Assuming it to be 0 - 255
        ' Hence only valid for ASCII text files */
        iStringCode = ReadByte()

        '** This is the main loop where it all happens.  This loop runs util all of
        '** the Input has been exhausted.  Note that it stops adding codes to the
        '** table after all of the possible codes have been defined.
        iCharacter = ReadByte()
        While iCharacter <> -1
            iIndex = find_match(iStringCode, iCharacter)    ' See if the string is in */
            If (iaCode_Value(iIndex) <> -1) Then            ' the table.  If it is,   */
                iStringCode = iaCode_Value(iIndex)          ' get the code value.  If */
            Else                                            ' the string is not in the table, try to add it.   */
                If (iNextCode <= MAX_CODE) Then
                    iaCode_Value(iIndex) = iNextCode
                    iNextCode += 1
                    iaPrefix_Code(iIndex) = iStringCode
                    baAppend_Character(iIndex) = CByte(iCharacter)
                End If
                output_code(iStringCode)    ' When a string is found  */
                iStringCode = iCharacter    ' that is not in the table */
            End If                          ' after adding the new one */
            iCharacter = ReadByte()
        End While

        ' End of the main loop.

        output_code(iStringCode)   ' Output the last code               
        output_code(MAX_VALUE)     ' Output the end of buffer code      */
        output_code(0)             ' This code flushes the Output buffer*/
    End Sub

    ' This is the hashing routine.  It tries to find a match for the prefix+char
    ' string in the string table.  If it finds it, the iIndex is returned.  If
    ' the string is not found, the first available iIndex in the string table is
    ' returned instead.
    Private Function find_match(ByVal iHashPrefix As Integer, ByVal iHashCharacter As Integer) As Integer
        Dim iIndex As Integer = 0
        Dim iOffset As Integer = 0

        iIndex = CInt((iHashCharacter << HASHING_SHIFT) Xor iHashPrefix)

        If (iIndex = 0) Then
            iOffset = 1
        Else
            iOffset = TABLE_SIZE - iIndex
        End If

        While (True)
            If iaCode_Value(iIndex) = -1 Then
                Return iIndex
            End If
            If (iaPrefix_Code(iIndex) = iHashPrefix) And (baAppend_Character(iIndex) = iHashCharacter) Then
                Return iIndex
            End If
            iIndex -= iOffset
            If (iIndex < 0) Then
                iIndex += TABLE_SIZE
            End If
        End While
    End Function

    ' The following routine is used to output variable length
    ' codes.  It is written strictly for clarity, and is not
    ' particularly efficient.

    Private Sub output_code(ByVal code As Integer)
        Static output_bit_count As Integer = 0
        Static output_bit_buffer As Long = 0

        output_bit_buffer = output_bit_buffer Or (code << (32 - BITS - output_bit_count))
        output_bit_count += BITS

        While output_bit_count >= 8
            WriteByte(CByte((output_bit_buffer >> 24) And 255))
            output_bit_buffer <<= 8
            output_bit_count -= 8
        End While
    End Sub



    ' This is the expansion routine.  It takes an LZW format file, and expands
    ' it to an bwOutput file.  The code here should be a fairly close match to
    ' the algorithm in the accompanying article.

    Public Sub expand()
        Dim baDecode_Stack(TABLE_SIZE) As Byte
        Dim iNextCode As Integer
        Dim iNewCode As Integer
        Dim iOldCode As Integer
        Dim bCharacter As Byte
        Dim iCurrCode As Integer
        Dim i As Integer

        'This is the next available code to define.
        iNextCode = 256

        ' Read in the first code, initialize the 
        ' character variable, and send the first 
        ' code to the output file.
        iOldCode = input_code()
        bCharacter = CType(iOldCode, Byte)
        WriteByte(CByte(iOldCode))

        ' This is the main expansion loop.  It reads in characters from the LZW file
        ' until it sees the special code used to inidicate the end of the data.
        iNewCode = input_code()
        While (iNewCode <> MAX_VALUE)
            If iNewCode >= iNextCode Then
                ' This code checks for the special STRING+CHARACTER+STRING+CHARACTER+STRING
                ' case which generates an undefined code.  It handles it by decoding
                ' the last code, and adding a single character to the end of the decode string.            
                baDecode_Stack(0) = bCharacter
                i = 1
                iCurrCode = iOldCode
            Else
                ' Otherwise we do a straight decode of the new code.
                i = 0
                iCurrCode = iNewCode
            End If
            While iCurrCode > 255
                ' This routine simply decodes a string from the string table, storing
                ' it in a buffer.  The buffer can then be output in reverse order by
                ' the expansion program.
                baDecode_Stack(i) = baAppend_Character(iCurrCode)
                i = i + 1
                If i >= MAX_CODE Then
                    Throw New ApplicationException("Fatal error during iCurrCode expansion.")
                End If
                iCurrCode = iaPrefix_Code(iCurrCode)
            End While
            baDecode_Stack(i) = CType(iCurrCode, Byte)
            bCharacter = baDecode_Stack(i)

            'Now we output the decoded string in reverse order.
            While i >= 0
                WriteByte(baDecode_Stack(i))
                i = i - 1
            End While

            ' Finally, if possible, add a new code to the string table.
            If (iNextCode <= MAX_CODE) Then
                iaPrefix_Code(iNextCode) = iOldCode
                baAppend_Character(iNextCode) = bCharacter
                iNextCode += 1
            End If
            iOldCode = iNewCode
            iNewCode = input_code()
        End While
    End Sub

    ' The following routine is used to input variable length
    ' codes.  It is written strictly for clarity, and is not
    ' particularly efficient.
    Private Function input_code() As Integer
        Dim return_value As Long
        Static input_bit_count As Integer = 0
        Static input_bit_buffer As Long = 0
        Static Mask32 As Long = CLng(2 ^ 32) - 1

        While input_bit_count <= 24
            input_bit_buffer = (input_bit_buffer Or _
                ReadByte() << (24 - input_bit_count)) And Mask32
            input_bit_count += 8
        End While
        return_value = (input_bit_buffer >> 32 - BITS) And Mask32
        input_bit_buffer = (input_bit_buffer << BITS) And Mask32
        input_bit_count -= BITS
        Return CInt(return_value)
    End Function

    Private Sub WriteByte(ByVal b As Byte)
        bwOutput.Write(b)
    End Sub

    Private Function ReadByte() As Integer
        Dim ba(1) As Byte
        Dim iResult As Integer
        iResult = brInput.Read(ba, 0, 1)
        If iResult = 0 Then
            Return -1
        End If
        Return ba(0)
    End Function

End Class
