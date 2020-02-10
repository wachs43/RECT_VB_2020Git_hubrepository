'Alex Wachs
'RCET0265
'Spring 2020
'SIMPLE CALC
'RCET_VB_2020

Option Explicit On
Option Compare Binary


Module Module1

    Sub Main()
        Dim firstnumber As Int32
        Dim secoundnumber As Int32
        Dim selector As Int32
        Dim QUIT As Boolean
        Dim userpromt As Boolean

        userpromt = True
        Do While QUIT = False

            Console.WriteLine("enter 1st digit, enter secound digit, select 1 for addition and 2 for multiplication.")
            Console.WriteLine("for subtraction input a 3 and for division input a 4")
            Console.WriteLine("please enter a number")
            Do While userpromt = True
                Try
                    firstnumber = CInt(Console.ReadLine())
                    userpromt = False
                Catch ex As Exception
                    Console.WriteLine("please enter a whole number")
                    userpromt = True
                End Try
            Loop
            Do While userpromt = False


                Try
                    secoundnumber = CInt(Console.ReadLine())
                    userpromt = True
                Catch ex As Exception
                    Console.WriteLine("please enter a whole number")
                    userpromt = False

                End Try
            Loop



            selector = Console.ReadLine()



            If selector = 1 Then
                Console.WriteLine(firstnumber + secoundnumber)
                Console.ReadLine()
                'cint(variable) converts a sting to variable
            ElseIf selector = 2 Then
                Console.WriteLine(firstnumber * secoundnumber)
                Console.ReadLine()
            ElseIf selector = 3 Then
                Console.WriteLine(firstnumber - secoundnumber)
                Console.ReadLine()
            ElseIf selector = 4 Then
                Console.WriteLine(firstnumber / secoundnumber)
                Console.ReadLine()

            Else
                Console.WriteLine("invalid operation")
                    Console.ReadLine()
                End If
                Console.WriteLine("HAVE A NICE DAY!!!")
                Console.WriteLine("PRESS ANYKEY To RUN AGAIN PRESS q To QUIT")
                If Console.ReadLine() = "q" Then
                    QUIT = True
                Else
                    QUIT = False
                End If

                Console.Clear()
            Loop
    End Sub

End Module
