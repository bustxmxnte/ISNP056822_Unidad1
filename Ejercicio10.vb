Module Ejercicio10
    Sub Main()

        Dim nombres(2) As String
        Dim num_horas(2) As Integer
        Dim salariohora(2) As Double
        Dim contador = 0

        While contador < 2
            Console.WriteLine("======= Datos de casilla {0} =======", contador)

            Console.WriteLine("Nombre empleado {0}:  ", contador)
            nombres(contador) = Console.ReadLine()

            Console.WriteLine("Horas trabajadas por empleado {0}: ", contador)
            num_horas(contador) = Console.ReadLine()

            Console.WriteLine("Salario por hora del empleado {0}: ", contador)
            salariohora(contador) = Console.ReadLine()

            Console.WriteLine("=================================")

            contador = contador + 1

        End While

        contador = 0

        Console.WriteLine("====== Datos de los empleados ======")

        While contador < 2
            Console.WriteLine("Empleado {0}", contador)
            Console.WriteLine("Nombre          : {0}", nombres(contador))
            Console.WriteLine("Horas trabajadas: {0}", num_horas(contador))
            Console.WriteLine("Salario por hora: {0}", salariohora(contador))
            Console.WriteLine("Salario Empleado: {0}", num_horas(contador) * salariohora(contador))
            contador = contador + 1
            Console.WriteLine("=================================")
        End While

        contador = 0

        Console.WriteLine("'\n'\n")
        Console.WriteLine("====== Datos de los empleados ======")

        Console.WriteLine("Casilla[N]" + Space(5) + "Nombre" + Space(5) + "Horas" + Space(5) + "PagoHora" + Space(5) + "Salario")

        While contador < 2
            Console.WriteLine("Casilla[{0}]" + Space(5) + "{1}" + Space(5) + "{2}" + Space(5) + "{3}" + Space(5) + "{4}", contador, nombres(contador), num_horas(contador), salariohora(contador), num_horas(contador) * salariohora(contador))
            contador = contador + 1
        End While

        Console.ReadKey()

    End Sub


End Module
