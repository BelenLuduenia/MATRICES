using System;
using System.Collections.Generic;
using System.Text;


namespace MATRICES
{
    
    class Program
    {
        static void Main(string[] args)


        { 


            Console.WriteLine(" \n Introduzca ((1)) si quiere empezar a calcular" + " " + "/" + " " + "Introduzca ((0)) si quiere salir de la calculadora");
            Console.WriteLine(" ");

            while (Console.ReadLine()!= "0") // 
            {
               

                Console.WriteLine(" ");
                
                Console.WriteLine("--- CALCULADORA DE MATRICES ---");

                Console.WriteLine(" ");



                // le pedimos al usuario que introduzca las filas y columnas de la matrizA
                Console.WriteLine("Introduzca las dimenciones de la [Matriz A]");

                Console.Write("Filas: "); // filas
                int filaA = int.Parse(Console.ReadLine());

                Console.Write("Columnas: "); // columnas 
                int columnaA = int.Parse(Console.ReadLine());

                // le pedimos al usuario que introduzca las filas y columnas de la matrizB

                Console.WriteLine("\nIntroduzca las dimenciones de la [Matriz B]");

                Console.Write("Filas: "); // filas
                int filaB = int.Parse(Console.ReadLine());

                Console.Write("Columnas: "); // columnas
                int columnaB = int.Parse(Console.ReadLine());



                // declaración de matrices

                decimal[,] MatrizA = new decimal[filaA, columnaA];
                decimal[,] MatrizB = new decimal[filaB, columnaB];
                decimal[,] MatrizC = new decimal[filaA, columnaB];
                decimal[,] Multiplicacion = new decimal[filaA, columnaB];
                decimal[,] MatrizTraspuesta = new decimal[columnaA, filaA];
                decimal[,] escalar = new decimal[filaA, columnaA];



                // elegir la opción 

                Console.WriteLine(" ");
                Console.WriteLine("--- Eliga la opción: --- ");
                Console.WriteLine("Suma - A");
                Console.WriteLine("Resta - B");
                Console.WriteLine("Multiplicacion - C ");
                Console.WriteLine("Traspuesta - D ");
                Console.WriteLine("Producto de un escalar - E ");

                Console.WriteLine(" ");


                switch (Console.ReadLine())
                {


                    // suma de matrices
                    case "A":


                        if (filaA == filaB && columnaA == columnaB) // comparamos las filas y columnas, en caso de que las dimenciones de ambas matrices sean la misma, se procede a realizar la operacion 
                        {
                            // ingresamos matriz A
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingresando datos al matriz A");


                            //Usando for anidados si tuvieramos una matriz de 3x3, esta seria llenada comenzando desde la posicion (0,0) hasta la (0,2)
                            //esto seria controlado por el primer for (columnas), luego de terminar este for se pasaria al de las filas y comenzaria de nuevo el proceso del for interno de las columnas
                            //y se llenaria la segunda fila desde la posicion (1,0) al (1,2) y luego se llenaria la ultima fila de la misma forma.

                            for (int i = 0; i < filaA; i++) // recorrido de filas
                            {

                                for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                {


                                    Console.Write("Ingrese posicion [" + i + "," + j + "]: "); // le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                    MatrizA[i, j] = decimal.Parse(Console.ReadLine()); //  guardamos los elementos en la matriz                

                                }
                            }


                            // mostrar matriz A
                            Console.WriteLine(" ");
                            Console.WriteLine("MATRIZ-A");

                            for (int i = 0; i < filaA; i++) // recorrido de filas
                            {
                                for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                {

                                    Console.Write(MatrizA[i, j] + "  " ); // mostramos los elementos de la matriz 

                                }

                                Console.WriteLine();
                            }

                            Console.ReadKey();


                            //------------------------------------------------------------------------------
                            //------------------------------------------------------------------------------


                            // ingresamos matriz B
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingresando datos al matriz B");

                            for (int i = 0; i < filaB; i++)
                            {
                                for (int j = 0; j < columnaB; j++)
                                {
                                    Console.Write("Ingrese posicion [" + i + "," + j + "]: "); //le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                    MatrizB[i, j] = decimal.Parse(Console.ReadLine());

                                }

                            }

                            // IMPRIMIR MATRIZ-B

                            Console.WriteLine(" ");
                            Console.WriteLine("MATRIZ-B");

                            for (int i = 0; i < filaB; i++) // recorrido de filas
                            {
                                for (int j = 0; j < columnaB; j++) // recorrido de columnas
                                {

                                    Console.Write(MatrizB[i, j] + "  " ); // mostramos los elementos de la matriz 

                                }

                                Console.WriteLine();
                            }

                            Console.ReadKey();

                            //----------------------------------------------------------------------
                            //----------------------------------------------------------------------

                            //Sumamos la matrizA y la MatrizB
                            Console.WriteLine(" ");
                            Console.WriteLine("El resultado de la suma de la matriz es :");
                            Console.WriteLine(" ");
                            for (int i = 0; i < filaA; i++)
                            {

                                for (int j = 0; j < columnaB; j++)
                                {
                                     MatrizC[i, j] = decimal.Round( MatrizA[i, j] + MatrizB[i, j],3); // sumamos y te lo redondea a tres decimales despues de la coma

                                    Console.Write(MatrizC[i, j] + "  "); // visualizamos la matriz
                                }

                                Console.Write("\n");
                            }
                            Console.ReadKey();

                            Console.WriteLine(" \n presione((1)) si quiere continuar" + " " + " / " + " " + "Introduzca((0)) si quiere salir ");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine(" ERROR:las matrices deben tener la misma dimencion (nxm) para poder sumarce");
                        }

                        break;



                    // resta de matrices
                    case "B":

                        if (filaA == filaB && columnaA == columnaB) // comparamos las filas y columnas 
                        {
                            // ingresamos matriz A
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingresando datos al matriz A");

                            for (int i = 0; i < filaA; i++) // recorrido de filas
                            {
                                for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                {

                                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");//le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                    MatrizA[i, j] = decimal.Parse(Console.ReadLine());

                                }

                            }

                            // IMPRIMIR MATRIZ A
                            Console.WriteLine(" ");
                            Console.WriteLine("MATRIZ-A");

                            for (int i = 0; i < filaA; i++) // recorrido de filas
                            {
                                for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                {

                                    Console.Write(MatrizA[i, j] + "  "); // mostramos la matriz 

                                }

                                Console.WriteLine();
                            }

                            Console.ReadKey();


                            //------------------------------------------------------------------------------



                            // ingresamos matriz B
                            Console.WriteLine(" ");
                            Console.WriteLine("Ingresando datos al matriz B");

                            for (int i = 0; i < filaB; i++)
                            {
                                for (int j = 0; j < columnaB; j++)
                                {
                                    Console.Write("Ingrese posicion [" + i + "," + j + "]: "); //le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                    MatrizB[i, j] = decimal.Parse(Console.ReadLine());

                                }

                            }

                            // IMPRIMIR MATRIZ-B

                            Console.WriteLine(" ");
                            Console.WriteLine("MATRIZ-B");

                            for (int i = 0; i < filaB; i++) // recorrido de filas
                            {

                                for (int j = 0; j < columnaB; j++) // recorrido de columnas
                                {

                                    Console.Write(MatrizB[i, j] + "  "); // mostramos la matriz B

                                }

                                Console.WriteLine();
                            }

                            Console.ReadKey();

                            //----------------------------------------------------------------------


                            //Restamos la matrizA y la MatrizB
                            Console.WriteLine(" ");
                            Console.WriteLine("El resultado de la resta de la matriz es :");
                            for (int i = 0; i < filaA; i++)
                            {

                                for (int j = 0; j < columnaB; j++)
                                {
                                     MatrizC[i, j] = decimal.Round( MatrizA[i, j] - MatrizB[i, j],3); // sumamos 

                                    Console.Write(MatrizC[i, j] + "  "); // visualizamos la matriz
                                }

                                Console.WriteLine(" ");

                            }
                            Console.ReadKey();

                            Console.WriteLine(" \n presione((1)) si quiere continuar" + " " + " / " + " " + "Introduzca((0)) si quiere salir ");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine(" las matrices deben tener la misma dimencion (nxm) para poder restarce");
                        }

                        break;



                    // multiplicacion de matrices
                    case "C":


                        if (columnaA == filaB)
                        {
                            // ingresamos matrizA
                            //el primer for en ejecutarse es el mas interno que en este caso sera el de las colunmas
                            //luego de terminar este pasa al de las fila.

                            Console.WriteLine(" \n Datos [Matriz A]: ");
                            for (int i = 0; i < filaA; i++)
                            {
                                for (int j = 0; j < columnaA; j++)
                                {
                                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");//le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j


                                    MatrizA[i, j] = decimal.Parse(Console.ReadLine());
                                }
                            }

                            // mostramos matrizA

                            Console.WriteLine(" ");
                            Console.WriteLine("MATRIZ-A");

                            for (int i = 0; i < filaA; i++) // recorrido de filas
                            {
                                for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                {

                                    Console.Write(MatrizA[i, j] + "  "); // mostramos la matriz 

                                }

                                Console.WriteLine();
                            }

                            Console.ReadKey();



                            // ingresamos matrizB

                            Console.WriteLine("\nDatos [Matriz B]: ");
                            for (int i = 0; i < filaB; i++)
                            {
                                for (int j = 0; j < columnaB; j++)
                                {
                                    Console.Write("Ingrese posicion [" + i + "," + j + "]: "); //le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j


                                    MatrizB[i, j] = decimal.Parse(Console.ReadLine());
                                }
                            }
                            //mostramos matriB

                            Console.WriteLine(" ");
                            Console.WriteLine("MATRIZ-B");

                            for (int i = 0; i < filaB; i++) // recorrido de filas
                            {

                                for (int j = 0; j < columnaB; j++) // recorrido de columnas
                                {

                                    Console.Write(MatrizB[i, j] + "  "); // mostramos la matriz B

                                }

                                Console.WriteLine();
                            }

                            Console.ReadKey();

                            // multiplicamos las matrices

                            // i y j me van a servir para moverme por cada elemento de la matriz (multiplicacion)
                            for (int i = 0; i < filaA; i++) // recorre fila de matriz-A
                            { //1
                                for (int j = 0; j < columnaB; j++) // recorre columna de matriz-B
                                { //2
                                    Multiplicacion[i, j] = 0; // inicializo la matriz en cero para que no me afecte el resultado

                                    for (int z = 0; z < columnaA; z++) // esta variable z me agarra elemento por elemento 
                                                                       // de toda la fila de A y me lo va a ir multiplicando por cada elemento de toda la columna de B
                                                                       // Z va a ir agarrando un elemento de la fila de A y lo va a multiplicar por un elemento de la columna de B, 
                                                                       // y al resultado me lo va a ir sumando con lo que hizo anteriormente
                                    {
                                          Multiplicacion[i, j] += decimal.Round( MatrizA[i, z] * MatrizB[z, j],3);
                                        // al resultado lo redondea en tres decimales despues de la coma 


                                    }
                                }
                            }


                            // mostramos la matriz multiplicada 


                            Console.WriteLine(" \n Multiplicacion de 2 Matrices  ");
                            Console.WriteLine(" ");
                            for (int i = 0; i < filaA; i++)
                            {
                                for (int j = 0; j < columnaB; j++)
                                {
                                    Console.Write("{0} ", Multiplicacion[i, j]); // mostramos la matriz 
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine(" \n presione((1)) si quiere continuar" + " " + " / " + " " + "Introduzca((0)) si quiere salir ");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede multiplicar las matrices, porque la cantidad de columnas de la MatrizA deden ser igual a la cantidad de  filas de la MatrizB");
                        }
                        Console.Read();

                        break;



                    // traspuesta de una matriz

                    case "D":

                        // ingresamos matriz A
                        Console.WriteLine(" ");
                        Console.WriteLine("SOLAMENTE VA A TOMAR LA MATRIZ-A ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingresando datos al matriz A");

                        for (int i = 0; i < filaA; i++) // recorrido de filas
                        {
                            for (int j = 0; j < columnaA; j++) // recorrido de columnas
                            {

                                Console.Write("Ingrese posicion [" + i + "," + j + "]: ");// le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                MatrizA[i, j] = decimal.Parse(Console.ReadLine());

                            }

                        }


                        // mostrar matriz A
                        Console.WriteLine(" ");
                        Console.WriteLine("MATRIZ-A");

                        for (int i = 0; i < filaA; i++) // recorrido de filas
                        {
                            for (int j = 0; j < columnaA; j++) // recorrido de columnas
                            {

                                Console.Write(MatrizA[i, j] + "  "); // mostramos los datos 

                            }

                            Console.WriteLine();
                        }

                        Console.ReadKey();


                        //  PASANDO VALORES DE MATRIZ A TRASPUESTA


                        for (int i = 0; i < filaA; i++) // recorrido de filas
                        {
                            for (int j = 0; j < columnaA; j++) // recorrido de columnas
                            {

                                 MatrizTraspuesta[j, i] = decimal.Round(MatrizA[i, j],3); // se convierten las filas en columnas,por tanto, la primera fila de la matriz A
                                // pasa a ser la primera columna de su matriz traspuesta y asi sucesivamente.
                            }

                        }



                        // mostrar traspuesta de matrizA
                        Console.WriteLine(" ");
                        Console.WriteLine("TRASPUESTA DE MATRIZ-A");

                        for (int i = 0; i < columnaA; i++) // recorrido de columnas
                        {
                            for (int j = 0; j < filaA; j++) // recorrido de filas
                            {

                                Console.Write(MatrizTraspuesta[i, j] + " "); // mostrar la matriz
                            }

                            Console.WriteLine();
                        }

                        Console.ReadKey();

                        Console.WriteLine(" \n presione((1)) si quiere continuar" + " " + " / " + " " + "Introduzca((0)) si quiere salir ");
                        Console.WriteLine(" ");

                        break;



                    // producto de un escalar

                    case "E":

                        // elegir la opción 
                       
                        
                        Console.WriteLine("Eliga la opción: ");
                        Console.WriteLine("producto de un escalar con (PI) - 1");
                        Console.WriteLine("producto de un escalar con (numero) - 2");
                        Console.WriteLine("producto de un escalar con (e)- 3");
                        Console.WriteLine("");
                        Console.WriteLine("SOLAMENTE VA A TOMAR LA MATRIZ-A ");
                        Console.WriteLine(" ");
                        switch (Console.ReadLine())
                        {
                            // escalar con pi
                            case "1": 

                                Console.WriteLine("");

                                decimal M = (decimal)Math.PI; 
                                //La propiedad Math.PI representa la relacion entre la longitud de la circunferencia de un circulo y su diametro

                                // ingresamos la matrizA

                                for (int i = 0; i < filaA; i++) // recorrido de filas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                    {

                                        Console.Write("Ingrese posicion [" + i + "," + j + "]: "); //le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                        MatrizA[i, j] = decimal.Parse(Console.ReadLine());

                                    }

                                }

                                // imprimir matriz A

                                Console.WriteLine(" ");
                                Console.WriteLine("MATRIZ-A");

                                for (int i = 0; i < filaA; i++) // recorrido de filas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                    {

                                        Console.Write(MatrizA[i, j] + " "); // mostramos los datos 

                                    }

                                    Console.WriteLine();
                                }

                                Console.ReadKey();

                                // multiplicamos la matriz por su escalar

                                for (int i = 0; i < filaA; i++) // recorrido de columnas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de filas
                                    {

                                        escalar[i, j] = (MatrizA[i, j] * M ); // multiplicamos la matriz por su escalar 


                                    }

                                }


                                // mostramos la matriz resultante 

                                Console.WriteLine("\nLa matriz resultante es: ");
                                Console.WriteLine(" ");
                                for (int i = 0; i < filaA; i++) // recorrido de columnas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de filas
                                    {


                                        Console.Write(escalar[i, j] + "  "); // mostramos la matriz 

                                    }

                                    Console.WriteLine();
                                }

                                Console.ReadKey();

                                break;


                            // escalar con cualquier numero 
                            case "2": 

                                Console.WriteLine("ingrese el valor a multipicar:");



                                decimal N = decimal.Parse(Console.ReadLine()); // variable en donde se guarda el escalar 


                                // ingresamos la matrizA

                                for (int i = 0; i < filaA; i++) // recorrido de filas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                    {

                                        Console.Write("Ingrese posicion [" + i + "," + j + "]: "); //le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                        MatrizA[i, j] = decimal.Parse(Console.ReadLine());

                                    }

                                }

                                // imprimir matriz A

                                Console.WriteLine(" ");
                                Console.WriteLine("MATRIZ-A");

                                for (int i = 0; i < filaA; i++) // recorrido de filas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                    {

                                        Console.Write(MatrizA[i, j] + " "); // mostramos los datos 

                                    }

                                    Console.WriteLine();
                                }

                                Console.ReadKey();



                                // multiplicamos la matriz por su escalar

                                for (int i = 0; i < filaA; i++) // recorrido de columnas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de filas
                                    {

                                        escalar[i, j] = decimal.Round(MatrizA[i, j] * N, 3); // multiplicamos la matriz por su escalar, en este caso te redondea el resultado
                                                                                             // con tres decimales despues de la coma.



                                    }

                                }

                                // mostramos la matriz resultante 

                                Console.WriteLine("\nLa matriz resultante es: ");
                                Console.WriteLine(" ");
                                for (int i = 0; i < filaA; i++) // recorrido de columnas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de filas
                                    {


                                        Console.Write(escalar[i, j] + "  "); // mostramos la matriz 

                                    }

                                    Console.WriteLine();
                                }

                                Console.ReadKey();

                                break;

                                // producto de un escalar con (e)
                            case "3":


                                decimal O = (decimal)Math.E; //Representa la base logarítmica natural, especificada por la constante, e.

                                // ingresamos la matrizA

                                for (int i = 0; i < filaA; i++) // recorrido de filas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                    {

                                        Console.Write("Ingrese posicion [" + i + "," + j + "]: "); //le pedimos al usuario que ingrese los elementos que van a estar guargados en la posicion i y j

                                        MatrizA[i, j] = decimal.Parse(Console.ReadLine());

                                    }

                                }
                                // imprimir matriz A

                                Console.WriteLine(" ");
                                Console.WriteLine("MATRIZ-A");

                                for (int i = 0; i < filaA; i++) // recorrido de filas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de columnas
                                    {

                                        Console.Write(MatrizA[i, j] + " "); // mostramos los datos 

                                    }

                                    Console.WriteLine();
                                }

                                Console.ReadKey();

                                // multiplicamos la matriz por su escalar

                                for (int i = 0; i < filaA; i++) // recorrido de columnas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de filas
                                    {
                                        // escalar[i, j] = decimal.Round(MatrizA[i, j] * O, 3);
                                        escalar[i, j] = (MatrizA[i, j] * O); // multiplicamos la matriz por su escalar 


                                    }

                                }

                                // mostramos la matriz resultante 

                                Console.WriteLine("\nLa matriz resultante es: ");
                                Console.WriteLine(" ");
                                for (int i = 0; i < filaA; i++) // recorrido de columnas
                                {
                                    for (int j = 0; j < columnaA; j++) // recorrido de filas
                                    {


                                        Console.Write(escalar[i, j] + "  "); // mostramos la matriz 

                                    }

                                    Console.WriteLine();
                                }

                                Console.ReadKey();

                                break;

                        }

                        Console.WriteLine(" \n presione((1)) si quiere continuar" + " " + " / " + " " + "Introduzca((0)) si quiere salir ");
                        Console.WriteLine(" ");

                        break;
                }


            }


        }

    }
}



