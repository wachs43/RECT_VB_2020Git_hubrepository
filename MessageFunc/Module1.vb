Module Module1

    Sub Main()
        'MsgBox(usermessages(True, "hello", False))
        Console.WriteLine(usermessages(True, "hello 1", False))
        Console.WriteLine(usermessages(True, "hello 2", False))
        Console.WriteLine(usermessages(True, "hello 3", False))
        MsgBox(usermessages(True, "", False))
    End Sub

    Function usermessages(addmessage As Boolean, message As String, clearmessage As Boolean) As String
        Static formattedMessages As String '= ""
        formattedMessages &= message & vbNewLine
        Return formattedMessages
    End Function
End Module
