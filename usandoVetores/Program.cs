
        int[] numeros = new int[10];
        int[] numerosImpares = new int[0]; // Inicializar com tamanho 0
        int[] numerosPares = new int[0];

        int indiceImpares = 0;
        int indicePares = 0;

Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVetor lido:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.WriteLine("\nVetor de trás para frente:");
        for (int i = 9; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.WriteLine("\nVetor até a metade:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 != 0 && numeros[i] != 0) 
            {
                numerosImpares[indiceImpares++] = numeros[i]; // Adiciona o valor ímpar
            }
            else if (numeros[i] % 2 == 0 && numeros[i] != 0) // Verifica se par e diferente de 0
            {
                numerosPares[indicePares++] = numeros[i]; // Adiciona o valor par
            }
        }

        // Impressão do vetor de ímpares
        Console.WriteLine("\nVetor de ímpares (sem zeros):");
        for (int i = 0; i < indiceImpares; i++)
        {
            Console.Write(numerosImpares[i] + " ");
        }

        // Impressão do vetor de pares
        Console.WriteLine("\nVetor de pares (sem zeros):");
        for (int i = 0; i < indicePares; i++)
        {
            Console.Write(numerosPares[i] + " ");
        }
