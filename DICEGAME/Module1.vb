'Alex Wachs
'RCET0265
'Spring 2020
'SIMPLE CALC
'RECT_VB_2020Git_hubrepository
Module Module1
    Sub Main()

        Dim diceOne As Integer
        Dim diceTwo As Integer
        Dim diceTotal As Integer = 0
        Dim diceValues(12, 2) As Integer

        For i = 2 To 12

            diceValues(i, 1) = i

        Next


        For numberOfDiceRoll = 1 To 1000


            diceOne = Int((6 - 1 + 1) * Rnd() + 1)
            diceTwo = Int((6 - 1 + 1) * Rnd() + 1)

            diceTotal = diceOne + diceTwo
            diceValues(diceTotal, 2) += 1

        Next


        Console.WriteLine("1000 dice rolls")
        Console.WriteLine()
        Console.WriteLine("       Number Rolled   V.S.    Times Rolled")


        For j = 2 To 12

            For p = 1 To 2
                Console.Write(diceValues(j, p).ToString().PadLeft(15) & "|")
            Next
            Console.WriteLine()

        Next

        Console.ReadLine()

    End Sub

End Module
