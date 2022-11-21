Module Ejercicio06
    Sub Main()

        Dim numero As Integer
        Dim contador As Integer
        Dim multip As Integer

        Console.WriteLine("Ingrese el número a sacar tabla: ")

        numero = Console.ReadLine()

        Console.WriteLine("Tabla de multiplicar del numero {0}", numero)

        For contador = 1 To 10 Step 1

            multip = numero * contador

            Console.WriteLine("{0} x {1} = {2}", numero, contador, multip)

        Next

        Console.ReadKey()

    End Sub
End Module
