Module Module1

    Sub Main()

        Dim myarray(3) As Integer

        myarray(1) = 5


        myarray = {1, 2, 3, 4}

        myarray(0) = 5

        Console.ReadLine()

        ReDim Preserve myarray(15)

        Dim infoarray() As String

        infoarray = Split("hello,goodbye,pizza,hungry,ice cream", ",")

        For Each thingy In infoarray

            Console.WriteLine(thingy)

            infoarray.Contains(thingy)

        Next

        For i = LBound(infoarray) To UBound(infoarray)
            Console.WriteLine("at" & Str(i) & "value is:" & infoarray(i))
        Next

    End Sub

End Module
