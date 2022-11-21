Module Ejercicio05
    Sub Main()

        Dim numero As Integer
        Dim valor_n As Integer
        Dim suma As Integer

        numero = 1

        suma = 0

        Console.WriteLine("Ingrese el número hasta el que sumará:")

        valor_n = Console.ReadLine()

        While numero <= valor_n

            suma = suma + numero

            numero = numero + 1

        End While

        Console.WriteLine("La suma de los numeros del 1 al {0} es: {1}", valor_n, suma)

        Console.ReadKey()

    End Sub

End Module
