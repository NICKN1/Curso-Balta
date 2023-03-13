
//Criando uma Calculadora

Menu();

    static void Menu()
    {
        Console.Clear();
        
        Console.WriteLine("Digite a opção de cálculo");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Encerrar Calculadora");
        
        Console.WriteLine("----------------------------");
        short result = short.Parse(Console.ReadLine());

        switch (result)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 0: Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float var1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float var2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        float result = var1 + var2;
        // Console.WriteLine("O resultado da soma é " + result);
        Console.WriteLine($"O resultado da soma é {result}");
        // Console.WriteLine($"O resultado da soma é {var1 + var2}");
        // Console.WriteLine("O resultado da soma é " + (var1 + var2));
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();
        
        Console.WriteLine("Digite o primeiro valor:");
        float var1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo valor:");
        float var2 = float.Parse(Console.ReadLine());

        float result = var1 - var2;
        Console.WriteLine("");
        Console.WriteLine($"O resultado da subtração é {result}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        
        Console.WriteLine("Digite o primeiro valor:");
        float var1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine(("Digite o segundo valor:"));
        float var2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float result = var1 / var2;
        Console.WriteLine($"O resultado da divisão é: {result}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        
        Console.WriteLine("Digite o primeiro valor:");
        float var1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo valor:");
        float var2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");
        float result = var1 * var2;
        Console.WriteLine($"O resultado da multiplicação é: {result}");
        Console.ReadKey();
        Menu();
    }