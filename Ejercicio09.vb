Module Ejercicio09
	Sub Main()
		Dim alta As Double
		Dim baja As Double
		Dim mayor7 As Integer
		Dim n As Double
		Dim suma As Double
		Dim x As Integer
		suma = 0
		mayor7 = 0
		For x = 1 To 6
			Console.WriteLine("Ingresa la nota {0}", x)
			n = Double.Parse(Console.ReadLine())
			suma = suma + n
			If n > 7 Then
				mayor7 = mayor7 + 1
			End If
			If x = 1 Then
				alta = n
				baja = n
			Else
				If n > alta Then
					alta = n
				Else
					If n < baja Then
						baja = n
					End If
				End If
			End If
		Next x
		Console.WriteLine("EL promedio de las 6 calificaciones es: " & suma / 6)
		Console.WriteLine("La calificacion mas baja es: " & baja)
		Console.WriteLine("La calificacion mas alta es: " & alta)
		Console.WriteLine("Calificaciones mayores a 7 es: " & mayor7)
	End Sub

End Module
