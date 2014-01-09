Module Module1
    Public Class Operaciones
        'Funciones con las siguientes operaciones suma, resta multiplicación, división
        Public Function DevuelveSuma(valor1 As Double, valor2 As Double) As Double
            Return valor1 + valor2
        End Function
        Public Function DevuelveResta(valor1 As Double, valor2 As Double) As Double
            Return valor1 - valor2
        End Function
        Public Function DevuelveMultiplicacion(valor1 As Double, valor2 As Double) As Double
            Return valor1 * valor2
        End Function
        Public Function DevuelveDivision(valor1 As Double, valor2 As Double) As Double
            Return valor1 / valor2
        End Function
    End Class
    Public Sub Opciones()
        'Declaramos las variables
        Dim numero1, numero2 As Double
        Dim operacion As Integer
        Dim repetir As String
        'Instrucción  do while
        Do
            'Mensjes con las siguientes opciones
            Console.WriteLine("Que tipo de operación desea realizar")
            Console.WriteLine("1 - Suma")
            Console.WriteLine("2 - Resta")
            Console.WriteLine("3 - Multiplicación")
            Console.WriteLine("4 - División")
            'capturamos el valor de la opción
            operacion = Convert.ToInt32(Console.ReadLine())
            'Mostramos los menajes y capturamos los números
            Console.WriteLine("Ingrese el primer número")
            numero1 = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Ingrese el segundo número")
            numero2 = Convert.ToDouble(Console.ReadLine())
            'instanciamos la clase Operaciones
            Dim op = New Operaciones
            'Select case que evalúa la variable operación
            Select Case operacion
                Case 1
                    'Mostramos el mensaje con la operación seleccionada
                    Console.WriteLine("La suma de los números es: " & op.DevuelveSuma(numero1, numero2))
                Case 2
                    'Mostramos el mensaje con la operación seleccionada
                    Console.WriteLine("La resta de los números es: " & op.DevuelveResta(numero1, numero2))
                Case 3
                    'Mostramos el mensaje con la operación seleccionada
                    Console.WriteLine("La multiplicacion de los números es: " & op.DevuelveMultiplicacion(numero1, numero2))
                Case 4
                    'Mostramos el mensaje con la operación seleccionada
                    Console.WriteLine("La division de los números es: " & op.DevuelveDivision(numero1, numero2))
                Case Else
                    Console.WriteLine("La operación no existe")
            End Select
            ''Mensaje que pregunta si desea repetir 
            Console.WriteLine("Desea repetir la operación coloque la tetra S")
            repetir = Console.ReadLine()

        Loop While (repetir = "s")
    End Sub
    Sub Main()
        Opciones()
    End Sub

End Module
