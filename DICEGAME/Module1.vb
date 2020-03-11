
Module Module1


    Sub Main()

    End Sub
    Private Sub DiceRoll()
        Dim Dice1 As Integer
        Dim Dice2 As Integer
        Dim DiceTotal As Integer
        Dim rollTotalArray(1, 11) As String

        Randomize()
        For i = 1 To 1000
            Dice1 = CInt((5 * Rnd()) + 1)
            Dice2 = CInt((5 * Rnd()) + 1)
            DiceTotal = Dice1 + Dice2

            ReDim DiceTotal(rollTotalArray)
        Next
    End Sub
    Private Sub DiceTotal(RollTotal As Integer)

        Static trackerTwo As Integer
        Static trackerThree As Integer
        Static trackerFour As Integer
        Static trackerFive As Integer
        Static trackerSix As Integer
        Static trackerSeven As Integer
        Static trackerEight As Integer
        Static trackerNine As Integer
        Static trackerTen As Integer
        Static trackerEleven As Integer
        Static trackerTwelve As Integer
        Dim tracker As Integer


        If RollTotal = 2 Then
                trackerTwo += 1
                tracker = trackerTwo
                WriteDiceTotal(0, tracker, RollTotal)
            End If
            If RollTotal = 3 Then
                trackerThree += 1
                tracker = trackerThree
                WriteDiceTotal(1, tracker, RollTotal)
            End If
            If RollTotal = 4 Then
                trackerFour += 1
                tracker = trackerFour
                WriteDiceTotal(2, tracker, RollTotal)
            End If
            If RollTotal = 5 Then
                trackerFive += 1
                tracker = trackerFive
                WriteDiceTotal(3, tracker, RollTotal)
            End If
            If RollTotal = 6 Then
                trackerSix += 1
                tracker = trackerSix
                WriteDiceTotal(4, tracker, RollTotal)
            End If
            If RollTotal = 7 Then
                trackerSeven += 1
                tracker = trackerSeven
                WriteDiceTotal(5, tracker, RollTotal)
            End If
            If RollTotal = 8 Then
                trackerEight += 1
                tracker = trackerEight
                WriteDiceTotal(6, tracker, RollTotal)
            End If
            If RollTotal = 9 Then
                trackerNine += 1
                tracker = trackerNine
                WriteDiceTotal(7, tracker, RollTotal)
            End If
            If RollTotal = 10 Then
                trackerTen += 1
                tracker = trackerTen
                WriteDiceTotal(8, tracker, RollTotal)
            End If
            If RollTotal = 11 Then
                trackerEleven += 1
                tracker = trackerEleven
                WriteDiceTotal(9, tracker, RollTotal)
            End If
            If RollTotal = 12 Then
                trackerTwelve += 1
                tracker = trackerTwelve
                WriteDiceTotal(10, tracker, RollTotal)
            End If



    End Sub

    Private Sub WriteDiceTotal(collumn As Integer, row As Integer, rollTotal As Integer)
        rollTotalArray(collumn, row) = rollTotal
        Console.WriteLine(rollTotal & " " & "row:" & row)
    End Sub

End Module
