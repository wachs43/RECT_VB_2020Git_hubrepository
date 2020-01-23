Module Module1

    Sub Main()
        Dim firstnumber As Integer
        Dim secoundnumber As Integer

        firstnumber = 3
        secoundnumber = 5

        If firstnumber > secoundnumber Then
            Console.WriteLine("first number is larger")
        ElseIf firstnumber < secoundnumber Then
            Console.WriteLine("secound number is larger")
        ElseIf firstnumber >= secoundnumber Then
            Console.WriteLine("first number is bigger or equal to")
        ElseIf firstnumber <= secoundnumber Then
            Console.WriteLine("the first number is smaller or equal")
        ElseIf firstnumber <> secoundnumber Then
            Console.WriteLine("the numbers are not equal")
        Else
            Console.WriteLine("something other")

        End If
        Console.ReadLine()
    End Sub

End Module
