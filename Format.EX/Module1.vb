Option Strict On

Module Module1


    Sub Main()

        '  Dim value As Double
        ' value = 25.5
        'value.ToString("C")
        'Console.WriteLine(10)
        'Console.WriteLine(value.ToString("c"))
        '  Console.WriteLine(value.ToString("X"))

        'toomanyspaces()
        timestable()
        Console.ReadLine()

    End Sub
    Sub toomanyspaces()
        Dim message As String
        message = "         hello   "
        Console.WriteLine(Len(message))
        message = Trim(message)
        Console.WriteLine(Len(message))
    End Sub
    Sub timestable()
        Dim result As Integer

        For i = 1 To 12
            ' Console.WriteLine()
            For j As Integer = 1 To 12
                result = i * j
                Console.Write(result.ToString("C").PadLeft(10) & "  l  ")
            Next
            Console.WriteLine()

        Next



    End Sub


End Module
