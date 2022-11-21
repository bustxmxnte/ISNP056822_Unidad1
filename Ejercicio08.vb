Module Ejercicio08
    Sub Main()

        Dim años, x As Integer
        Dim ahorro, total, interes As Decimal

        Console.WriteLine("Ingresa los años de ahorro: ")
        años = Console.ReadLine()

        total = 0
        interes = 0

        While años > 0
            For x = 1 To 12 Step 1
                Console.WriteLine("Ingresa el ahorro del mes {0}", x)
                ahorro = Console.ReadLine()
                total = total + ahorro
            Next
            interes = interes + (total * 0.15)
            años = años - 1

            Console.WriteLine("El rendimiento anual es igual a: $" & interes)
            Console.WriteLine("La inversión final que se tendra es de: $" & total + interes)
        End While

        Console.ReadKey(True)

    End Sub

End Module
