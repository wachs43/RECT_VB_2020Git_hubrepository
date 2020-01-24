'Alex Wachs
'RCET0265
'Spring 2020
'Hello World
'RECT_VB_2020
Module Module1
    Sub Main()

        Dim name As String
        Console.WriteLine("who is you? ")
        name = Console.ReadLine()

        If name = "emily" Then
            Console.WriteLine("welcome madam emily")
        ElseIf name = "joe" Then
            Console.WriteLine("what up big joe!!!?")
        ElseIf name = "alex" Then
            Console.WriteLine("welcome supream overlord god of all 30 lines of this unworthy program creator and maintainer of code.")
        Else
            Console.WriteLine("fool you are no user of mine be gone!!!")

        End If
        Console.ReadLine()
    End Sub

End Module
