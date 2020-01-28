'Alex Wachs
'RCET0265
'Spring 2020
'SIMPLE CALC
'RCET_VB_2020


Module Module1

    Sub Main()
        Dim firstnumber As Int32
        Dim secoundnumber As Int32
        Dim selector As Int32

        Console.WriteLine("enter 1st digit, enter secound digit, select 1 for addition and 2 for multiplication.")
        firstnumber = Console.ReadLine()
        secoundnumber = Console.ReadLine()
        selector = Console.ReadLine()



        If selector = 1 Then
            Console.WriteLine(firstnumber + secoundnumber)
            Console.ReadLine()
            'cint(variable) converts a sting to variable
        ElseIf selector = 2 Then
            Console.WriteLine(firstnumber * secoundnumber)
            Console.ReadLine()
        Else
            Console.WriteLine("invalid operation")
            Console.ReadLine()
        End If
        Console.WriteLine("press enter to end")
        Console.ReadLine()

    End Sub

End Module
