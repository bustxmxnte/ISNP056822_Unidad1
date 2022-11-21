Module Ejercicio03

    Sub Main()

        Dim monto_compra As Decimal
        Dim monto_total As Decimal
        Dim descuento As Decimal

        Console.WriteLine("Ingrese monto de compra: ")

        monto_compra = Console.ReadLine()

        Select Case monto_compra

            Case >= 1000
                descuento = (monto_compra * 0.3)
                monto_total = (monto_compra - descuento)
                Console.WriteLine("Se aplicará el 30% de descuento ")
                Console.WriteLine("El Monto total a pagar es de: $" & monto_total)
            Case >= 500
                descuento = (monto_compra * 0.2)
                monto_total = (monto_compra - descuento)
                Console.WriteLine("Se aplicará el 20% de descuento ")
                Console.WriteLine("El Monto total a pagar es de: $" & monto_total)
            Case > 250
                descuento = (monto_compra * 0.1)
                monto_total = (monto_compra - descuento)
                Console.WriteLine("Se aplicará el 10% de descuento ")
                Console.WriteLine("El Monto total a pagar es de: $ " & monto_total)
            Case < 250
                descuento = monto_compra * 0.05
                monto_total = (monto_compra - descuento)
                Console.WriteLine("Se aplicará el 05% de descuento ")
                Console.WriteLine("El Monto total a pagar es de: $" & monto_total)

        End Select

        Console.ReadKey(True)

    End Sub

End Module