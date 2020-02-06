Module Module1

    Sub Main()
        Dim mynumber As Integer
        mynumber = 7
        Console.WriteLine("in sub main")
        Console.WriteLine("press enter to continue")
        Console.WriteLine(mynumber)
        Console.ReadLine()
        mysub(mynumber)
        Console.WriteLine("in sub main")
        Console.WriteLine(mynumber)
        mynumber = myfunc(mynumber)
        Console.WriteLine("in sub main")
        Console.WriteLine(mynumber)
        Console.ReadLine()


    End Sub

    Sub mysub(mynumber As Integer)
        ' Dim mynumber As Integer
        mynumber += 2

        Console.WriteLine("in my sub")
        Console.WriteLine(mynumber)

        Console.ReadLine()


    End Sub
    Function myfunc(mynumber As Integer) As Integer
        'Dim mynumber As Integer
        mynumber -= 3

        Console.WriteLine("in function MyFunc")
        Console.WriteLine(mynumber)
        Console.ReadLine()

        Return mynumber
    End Function





End Module
