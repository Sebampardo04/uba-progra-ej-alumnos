using System;

namespace CRECION_DE_TABLAS
{
    class Program
    {

        private static void Main(string[] args)
        {
           const int LimiteMinimodePrompcion = 7;
           const int LimiteMinimodeRegularizacion = 4;
           string ContinuarCarga = "S";
           string RegistroActual = "", RegistrodeNotaMinima = "", RegistrodeNotaMaxima = "";
           int NotaActual = 0;
            int NotaMaxima = -1;

        // Se coloca en el bool falso, xq uno de los tres sera verdadera dependiendo de la nota cargada
        // El booleano por defecto es false, por lo que no es necesario agregarlo

                bool Promocion = false, Regularizacion = false, Reprobado = false;
           int NotaMinima = 11;

                while (ContinuarCarga == "S")
            {
                //Pedir y validar Registro actual

                do
                {
                    Console.WriteLine("Ingrese un Registro NO vacio");
                    // DATO ingresado por el Alumno

                    RegistroActual = Console.ReadLine();
                    // Si el DATO NO cumple condicion de valicez 

                    // El doble ingual compara dos valores
                    // Los caracteres de asignacion tien un caracter y los de dos son de comp.
                    if (RegistroActual == "")
                    {
                        Console.WriteLine("El Registro no puede estar vacio");
                    }

                }

                while (RegistroActual == "");

                do
                {
                    Console.WriteLine("Ingrese una NOTA entre 0 y 10 inclusive");
                    //DATO ingresado del usuario
                    //El TryParse se usa para saber si se ingreso un numero o no

                    if (int32.TryParse(Console.ReadLine(), out NotaActual))
                    {
                    }
                    
                    {

                        //Si no ingreso nada se pone que la Nota acutal sea -1
                        //Esto es para que no pase la prueba    
                        NotaActual = -1;

                    }
                    if (!(0 <= NotaActual && NotaActual <= 10))
                    {
                        Console.WriteLine("Ingrese una NOTA entre 0 y 10 inclusive");

                    }
                }
                while (!(0 <= NotaActual && NotaActual <= 10));
                // Si NOTA actual es mayor a NOTA maxima

                if (NotaActual > NotaMaxima)
                {
                    RegistrodeNotaMaxima = RegistroActual;

                    NotaMaxima = NotaActual;

                }

                if (NotaActual > NotaMinima)
                {
                    RegistrodeNotaMinima = RegistroActual;

                    NotaMinima = NotaActual;

                }
                Promocion = NotaActual >= LimiteMinimodePrompcion;

                Regularizacion = NotaActual >= LimiteMinimodeRegularizacion && NotaActual < LimiteMinimodePrompcion;

                Reprobado = NotaActual < LimiteMinimodeRegularizacion;

                Console.WriteLine("Registro: " + RegistroActual);
                Console.WriteLine("Nota: " + NotaActual);
                //Operador Ternario: permite definir distintas salidas en base a un booleano, pero
                //se evalua en la line. el digno de interrogacion es el booleano. lo que sigue es lo
                //que iria si es verdadero en el segundo lugar lo falso
                Console.WriteLine("Estado: " + (Promocion ? "Pormociona": 
                                               (Regularizacion ? "Regulariza": 
                                               (Reprobado ? "Debe recursar la materia" : "Error desconocido"))));



                do
                {
                    Console.WriteLine("Ingrese S si desea continuar o N si no desea continuar");
                    ContinuarCarga = Console.ReadLine().ToUpper();

                if(ContinuarCarga != "S" && ContinuarCarga != "N")
                    {

                        Console.WriteLine("Debe ingresar S o N");
                    }



                }
                while (ContinuarCarga != "S" && ContinuarCarga != "N");



            }
        }
    }
}
