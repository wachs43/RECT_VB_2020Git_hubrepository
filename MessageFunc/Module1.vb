Module Module1
    'Alex Wachs
    'RCET0265
    'Spring 2020
    'message accumulator
    'https://github.com/wachs43/RECT_VB_2020Git_hubrepository/tree/master/MessageFunc
    Sub Main()

        Console.WriteLine(usermessages(True, "you'll shoot your eye out kid", False))

        Console.WriteLine(usermessages(True, "Red Ryder BB gun", False))

        Console.WriteLine(usermessages(True, "A+++++++++++++++++", False))

        Console.WriteLine(usermessages(True, "guess the movie", False))

        MsgBox(usermessages(True, "", False))
    End Sub

    Function usermessages(addmessage As Boolean, message As String, clearmessage As Boolean) As String

        Static formattedMessages As String
        Dim test1 As Boolean
        addmessage = False
        test1 = False
        If test1 = True Then
            addmessage = True
        End If
        formattedMessages &= message & vbNewLine
        Return formattedMessages

    End Function
End Module
