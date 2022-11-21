Module Ejercicio07
    Sub Main()

        Dim x As Integer
        Dim ahorro As Decimal
        Dim aumento As Integer

        aumento = 3

        Console.WriteLine("Ingrese el monto de ahorro: ")

        ahorro = Console.ReadLine()



        For x = 1 To 12 Step 1

            ahorro = ahorro + aumento

            Console.WriteLine("El ahorro del mes {0} es de : ${1}", x, ahorro)

        Next

        Console.WriteLine("El monto anual de ahorro es de: " & ahorro)

        Console.ReadKey()

    End Sub
End Module
