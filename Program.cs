try
{

    //decimal[] typedNumbers = new decimal[2];
    List<decimal> typedNumbers = new List<decimal>();
    bool running = true;


    // Todo el código principal dentro del try
    Console.WriteLine("=== CALCULADORA BÁSICA ===");

    while (running)
    {


        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Exit");

        Console.Write("Digite el número de la opción: ");
        int typedOption = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Porfavor digite la cantidad de números que desea operar (2, tres o mas): ");
        //int quantityOfNumbers = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < quantityOfNumbers; i++)
        //{
        //    Console.Write($"Digite el número {i + 1}: ");
        //    decimal typedNumber = Convert.ToDecimal(Console.ReadLine());
        //    // Aquí puedes almacenar los números en una lista o array si deseas operar con más de dos números
        //}

        Console.Write("Digite el primer número: ");
        //decimal typedNumber1 = Convert.ToDecimal(Console.ReadLine());
        //typedNumbers.Add(0);
        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
        //typedNumbers[0] = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite el segundo número: ");
        //decimal typedNumber2 = Convert.ToDecimal(Console.ReadLine());
        //typedNumbers.Add(0); 
        //typedNumbers[1] = Convert.ToDecimal(Console.ReadLine());

        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
        //Console.Write("Digite el tercer número: ");
        //decimal typedNumber3 = Convert.ToDecimal(Console.ReadLine());

        var wantToContinue = true;

        Console.WriteLine("¿Desea continuar con otra operación? 1. si, 2. No");

        var userInput = int.Parse(Console.ReadLine());

        //if (userInput == 1)
        //{
        //    wantToContinue = true;
        //}
        ////else if (userInput == 2)
        ////{
        ////    wantToContinue = false;
        ////}
        //else
        //{
        //    wantToContinue = false;
        //}


        if (userInput == 1)
        {
            wantToContinue = true;
        }
        else if (userInput == 2 || userInput == 3)
        {
            wantToContinue = false;
        }
        else
        {
            wantToContinue = false;
        }
        //wantToContinue = (userInput == 1) ? true : false;
        //wantToContinue = !(userInput == 1) ? false : true;
        //wantToContinue = (userInput == 1);

        wantToContinue = (int.Parse(Console.ReadLine()) == 1);


        ////    // and &&     or ||     not  !


        ////    // and
        ////    // v && v = V
        ////    // v && f = F
        ////    // f && v = F
        ////    // f && f = F
        ////    // 

        ////    // or
        ////    // v || v = V
        ////    // v || f = V
        ////    // f || v = V
        ////    // f || f = F
        ////    //

        ////    //not 
        ////    //!(v) = f
        ////    //!(f) = v

        ////    // v && v   && f && v && f || v || f || v && v
        ////    // v        && f && v && f || v || f || v && v
        ////    // f             && v && f || v || f || v && v
        ////    // f                  && f || v || f || v && v
        ////    // f                       || v || f || v && v
        ////    // v                            || f || v && v
        ////    // v                                 || v && v
        ////    // v                                      && v
        ////    // v

        ////    Console.WriteLine("I told you than type 1 or 2, no more");

        //while (wantToContinue == true)
        while (wantToContinue)
        {
            //var tempTypedNumbers = typedNumbers;
            //typedNumbers = new decimal[typedNumbers.Length + 1];

            //for (int i = 0; i < tempTypedNumbers.Length; i++)
            //{
            //    typedNumbers[i] = tempTypedNumbers[i];
            //}
            //typedNumbers.CopyTo(tempTypedNumbers, 0);

            //  typedNumbers.Append(newTypeValue);

            //  Array.Resize(ref typedNumbers, typedNumbers.Length + 1);


            Console.WriteLine("Porfavor digite un nuevo numero");

            //var tempTypedNumber = Convert.ToDecimal(Console.ReadLine());
            //typedNumbers[typedNumbers.Length - 1] = Convert.ToDecimal(Console.ReadLine());
            typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("¿Desea continuar con otra operación? 1. si, 2. No");
            wantToContinue = (int.Parse(Console.ReadLine()) == 1);

        }

        //if(wantToContinue==true)
        //if (wantToContinue)
        //{
        //    Console.WriteLine("Continuando con otra operación...");
        //    if (wantToContinue)
        //    {
        //        Console.WriteLine("Continuando con otra operación...");
        //        if (wantToContinue)
        //        {
        //            Console.WriteLine("Continuando con otra operación...");
        //            if (wantToContinue)
        //            {
        //                Console.WriteLine("Continuando con otra operación...");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Saliendo del programa...");
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Saliendo del programa...");
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Saliendo del programa...");
        //        return;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Saliendo del programa...");
        //    return;
        //}
        //if (!(wantToContinue == false))
        //if (!wantToContinue)
        //{
        //    Console.WriteLine("Saliendo del programa...");
        //    return;
        //}
        //else
        //{
        //    Console.WriteLine("Continuando con otra operación...");
        //}

        decimal result = 0;

        switch (typedOption)
        {
            case 1:
                {
                    //for (int i = 0; i < typedNumbers.Length; i++)
                    for (int i = 0; i < typedNumbers.Count; i++)
                    {
                        result = result + typedNumbers[i];
                    }
                    break;
                }
            case 2:

                foreach (var item in typedNumbers)
                {
                    result = result - item;

                }

                break;
            case 3:
                result = typedNumbers[0] * typedNumbers[1];
                break;
            case 4:
                result = typedNumbers[0] / typedNumbers[1];
                break;
            case 5:
                running = false;
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        Console.WriteLine($"El resultado es: {result}");
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine("El programa no pudo completarse debido al error");
}

