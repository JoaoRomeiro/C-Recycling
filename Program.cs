using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula028.Aula();
            //Jogo.Jogar();
        }
    }

    // Olá mundo
    public static class Aula001
    {
        public static void Aula()
        {
            Console.WriteLine("Hello World");
        }
    }

    // Argumentos
    public static class Aula002
    {
        public static void Aula(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }

    // Tipos de dados
    public static class Aula003
    {
        public static void Aula()
        {
            int x = 10;

            Console.WriteLine(x.ToString());
        }
    }

    // Escopo de variáveis
    public static class Aula004
    {
        static int i = 10;
        public static void Aula()
        {
            //int i = 20;
            Exercicio1(i);
        }

        private static void Exercicio1(int i)
        {
            Console.WriteLine(i);
        }
    }

    // Operadores e operações
    public static class Aula005
    {
        public static void Aula()
        {
            int res = (10 + 5) * 2;

            Console.WriteLine(res);
        }
    }

    // Formatação de saida de string
    public static class Aula006
    {
        public static void Aula()
        {
            int n1 = 1, n2 = 2, n3 = 3;

            Console.WriteLine("n1 =\t{0}\nn2 =\t{1}\nn3 =\t{2}", n1, n2, n3);

            double compra = 5.5, lucro = 0.1, venda = 0;
            string produto = "Pastel";

            venda = compra + (compra * lucro);

            Console.WriteLine("Produto.........:{0,15}", produto);
            Console.WriteLine("Val Compra......:{0,15:c}", compra);
            Console.WriteLine("Lucro...........:{0,15:p}", lucro);
            Console.WriteLine("Val Venda.......:{0,15:c}", venda);
        }
    }

    // Constantes
    public static class Aula007
    {
        public static void Aula()
        {
            const string s = "Olá Mundo";
            //s = "";
            Console.WriteLine(s);
        }
    }

    // Lendo valores do teclado
    public static class Aula008
    {
        public static void Aula()
        {
            /*
                A principal diferença entre Parse e Convert é:
                - Parse só converte uma string para o tipo de dado que se quer converter
                - Convert pode converter mais tipos de dados no tipo de dado que se quer converter
            */

            int i1, i2, i3;
            string s1;

            Console.Write("Digite o seu nome:");
            s1 = Console.ReadLine();

            Console.Write("Olá {0}", s1);

            Console.Write("Digite o primeiro valor:");
            i1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            i2 = int.Parse(Console.ReadLine());

            i3 = i1 + i2;

            Console.WriteLine("A soma dos valores digitados é: {0}", i3);
        }
    }

    // Operações de bitwise
    public static class Aula009
    {
        public static void Aula()
        {
            /*
                Bitwise para a esquerda <<, dobra o valor da variável
                Bitwise para a direita >>, reduz o valor da variável pela metade
            */

            int i = 10, j = 10;

            i = i << 1;
            j = j >> 1;

            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }

    // Enumeradores
    public static class Aula010
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado };
        public static void Aula()
        {
            DiasSemana ds = DiasSemana.Domingo;
            int i = (int)DiasSemana.Terça;

            Console.WriteLine(ds);
            Console.WriteLine(i);
        }
    }

    // Typecast
    public static class Aula011
    {
        public static void Aula()
        {
            // Conversão implicita, conversão segura
            int i = 10;
            float j = i;

            Console.WriteLine("Conversão implícita: int ({0}) to float ({1})", i, j);

            // Conversão explicita, conversão não segura
            char a = 'A';
            string b = a.ToString();

            Console.WriteLine("Conversão explícita: char ({0}) to string ({1})", a, b);

            float l = 10.25f;
            int m = Convert.ToInt32(l);

            Console.WriteLine("Conversão explícita: float ({0}) to int ({1})", l, m);
        }
    }

    // Comando codicional IF
    public static class Aula012
    {
        public static void Aula()
        {
            int n1, n2, n3, n4, media;
            media = n1 = n2 = n3 = n4 = 0;

            Console.Write("Digite a nota 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 4: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            string resultado = "Reprovado";

            media = (n1 + n2 + n3 + n4) / 4;
            if (media >= 6)
            {
                resultado = "Aprovado";
            }

            Console.WriteLine("Média: {0} - Resultado: {1}", media, resultado);
        }
    }

    // Comando codicional IF ELSE
    public static class Aula013
    {
        public static void Aula()
        {
            int n1, n2, n3, n4, media;
            media = n1 = n2 = n3 = n4 = 0;

            Console.Write("Digite a nota 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 4: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            string resultado = string.Empty;

            media = (n1 + n2 + n3 + n4) / 4;

            if (media < 4)
            {
                resultado = "Reprovado";
            }
            else if (media < 6)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Aprovado";
            }

            Console.WriteLine("Média: {0} - Resultado: {1}", media, resultado);
        }
    }

    // Comando codicional IF aninhados
    public static class Aula014
    {
        public static void Aula()
        {
            int n1, n2, n3, n4, media;
            media = n1 = n2 = n3 = n4 = 0;

            Console.Write("Digite a nota 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 4: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            string resultado = string.Empty;

            media = (n1 + n2 + n3 + n4) / 4;

            if (media < 4)
            {
                resultado = "Reprovado";
            }
            else if (media < 6)
            {
                resultado = "Recuperação";
            }
            else
            {
                if (media >= 9)
                {
                    resultado = "Aprovado com Louvor";
                }
                else
                {
                    resultado = "Aprovado";
                }
            }

            Console.WriteLine("Média: {0} - Resultado: {1}", media, resultado);
        }
    }

    // Switch
    public static class Aula015
    {
        public static void Aula()
        {
            int tempo = 0;
            string escolha = string.Empty;

            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [o] Ônibus");

            escolha = Console.ReadLine();

            switch (escolha.ToLower())
            {
                case "a":
                    tempo = 50;
                    break;
                case "c":
                    tempo = 480;
                    break;
                case "o":
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            string mensagem = "";

            if (tempo < 0)
            {
                mensagem = "Transporte indisponível";
            }
            else
            {
                mensagem = string.Format("Para o transporte escolhido o tempo é: {0} minutos", tempo);
            }

            Console.WriteLine(mensagem);
        }
    }

    // GoTo
    public static class Aula016
    {
        public static void Aula()
        {
            int tempo = 0;
            string escolha = string.Empty;

        // Label para o desvio do Goto
        inicio:

            Console.Clear();
            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [o] Ônibus");

            escolha = Console.ReadLine();

            switch (escolha.ToLower())
            {
                case "a":
                    tempo = 50;
                    break;
                case "c":
                    tempo = 480;
                    break;
                case "o":
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            string mensagem = "";

            if (tempo < 0)
            {
                mensagem = "Transporte indisponível";
            }
            else
            {
                mensagem = string.Format("Para o transporte escolhido o tempo é: {0} minutos", tempo);
            }

            Console.WriteLine(mensagem);

            Console.WriteLine("Calcular outro transporte?[s/n]:");
            escolha = Console.ReadLine().ToLower();

            if (escolha.Equals("s"))
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do processo...");
            }
        }
    }

    // Arrays Vetor Unidimensionais
    public static class Aula017
    {
        public static void Aula()
        {
            //int[] n = {11, 22, 33, 44, 55};
            /*
            int[] n = new int[5];
            n[0] = 11;
            n[1] = 22;
            n[2] = 33;
            n[3] = 44;
            n[4] = 55;
            */

            int[] n = new int[5] { 11, 22, 33, 44, 55 };

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Posicao {0} contém a {1}", i, n[i]);
            }
        }
    }

    // Arrays Bidimensionais
    public static class Aula018
    {
        public static void Aula()
        {
            int[,] n = new int[3, 5];
            n[0, 0] = 10;
            n[0, 1] = 20;
            n[0, 2] = 30;
            n[0, 3] = 40;
            n[0, 4] = 50;

            n[1, 0] = 11;
            n[1, 1] = 21;
            n[1, 2] = 31;
            n[1, 3] = 41;
            n[1, 4] = 51;

            n[2, 0] = 12;
            n[2, 1] = 22;
            n[2, 2] = 32;
            n[2, 3] = 42;
            n[2, 4] = 52;

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("Posicao {0},{1} contém a {2}", i, j, n[i, j]);
                    }
                }
            }
            catch (System.Exception e)
            {
                Console.Beep();
                Console.WriteLine("Ops! Algo deu errado!\nMensagem: {0}", e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
            }
        }
    }

    // Loop FOR / Estruturas de iteração
    public class Aula019
    {
        public static void Aula()
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Conteúdo de num na posição {0} é {1}", i, num[i]);
            }
        }
    }

    // Loop WHILE / Estruturas de iteração
    public class Aula020
    {
        public static void Aula()
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int i = 0;

            while (i < num.Length)
            {
                Console.WriteLine("Conteúdo de num na posição {0} é {1}", i, num[i]);
                i++;
            }

            Console.WriteLine("Fim do looping...");
        }
    }

    // Loop DO WHILE / Estruturas de iteração
    public class Aula021
    {
        public static void Aula()
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int i = 0;

            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 5);

            Console.WriteLine("Fim do looping...");
        }
    }

    // Loop FOREACH / Estruturas de iteração
    public class Aula022
    {
        public static void Aula()
        {
            int[] vetor1 = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Métodos para arrays
    public class Aula023
    {
        public static void Aula()
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5] { 1, 2, 3, 2, 5 };
            int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

            Console.WriteLine("Random");
            UseRandom(vetor1);

            Console.WriteLine("BinarySearch");
            UseBinarySearch(vetor1, 1);

            Console.WriteLine("Copy");
            UseCopy(vetor1, vetor2, 5);

            Console.WriteLine("CopyTo");
            UserCopyTo(vetor1, vetor2, 0);

            Console.WriteLine("GetLongLength");
            UseGetLongLength(matriz, 0);

            Console.WriteLine("GetLowerBound");
            UseGetLowerBound(matriz, 0);

            Console.WriteLine("GetUpperBound");
            UseGetUpperBound(matriz, 1);

            Console.WriteLine("GetValue");
            UseGetValue(vetor1, matriz, 1, 1);

            Console.WriteLine("IndexOf");
            UseIndexOf(vetor3, 2);

            Console.WriteLine("LastIndexOf");
            UseLastIndexOf(vetor3, 2);

            Console.WriteLine("Reverse");
            UseReverse(vetor3);

            Console.WriteLine("SetValue");
            UseSetValue(vetor3, 1, 33);

            Console.WriteLine("Sort");
            UseSort(vetor3);

            Console.WriteLine("Fim...");
        }

        // Ordena o array
        private static void UseSort(int[] vetor)
        {
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }

            Array.Sort(vetor);

            Console.WriteLine("");

            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
        }

        // Seta o valor de uma determinada posição do array
        private static void UseSetValue(int[] vetor, int index, int value)
        {
            Console.WriteLine("Valor antes da atualização, indice: {0} valor: {1}", index, vetor.GetValue(index));

            vetor.SetValue(value, index);

            Console.WriteLine("Valor após a atualização, indice: {0} valor: {1}", index, vetor.GetValue(index));
        }

        // Inverte a posição do array
        private static void UseReverse(int[] vetor)
        {
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(vetor);

            Console.WriteLine();

            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
        }

        // Retorna o último indice de um array que contenha o valor procurado
        private static void UseLastIndexOf(int[] vetor, int value)
        {
            int indice = Array.LastIndexOf(vetor, value);
            Console.WriteLine("O último indice encontrado para o valor {0} é {1}", value, indice);
        }

        // Retorna o primeiro indice de um array que contenha o valor procurado
        private static void UseIndexOf(int[] vetor, int value)
        {
            int indice = Array.IndexOf(vetor, value);
            Console.WriteLine("O primeiro indice encontrado para o valor {0} é {1}", value, indice);
        }

        // Retorna o valor do array de acordo com o indice passado,
        // se o array for uma matriz será necessário passar o indice da dimensão
        private static void UseGetValue(int[] vetor, int[,] matriz, int index, int dimension)
        {
            int valor1 = Convert.ToInt32(vetor.GetValue(index));
            int valor2 = Convert.ToInt32(matriz.GetValue(dimension, index));

            Console.WriteLine("O valor da posição {0} é {1}", index, valor1);
            Console.WriteLine("O valor da posição {0} da dimensão {1} é {2}", index, dimension, valor2);
        }

        // Retorna o maior indice de uma matriz\vetor
        private static void UseGetUpperBound(int[,] vetor, int dimension)
        {
            Console.WriteLine(vetor.GetUpperBound(dimension));
        }

        // Retorna o menor indice de uma matriz\vetor
        private static void UseGetLowerBound(int[,] vetor, int dimension)
        {
            Console.WriteLine(vetor.GetLowerBound(dimension));
        }

        // Retorna a quantidade de elementos do array
        private static void UseGetLongLength(int[,] vetor, int dimension)
        {
            Console.WriteLine(vetor.GetLongLength(dimension));
        }

        private static void UserCopyTo(int[] vetor1, int[] vetor2, int index)
        {
            vetor1.CopyTo(vetor2, index);

            foreach (var item in vetor2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
        }

        // Copia o conteúdo de um array para outro array
        private static void UseCopy(int[] vetor1, int[] vetor2, int length)
        {
            Array.Copy(vetor1, vetor2, length);

            foreach (var item in vetor2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        // Procura um valor dentro de um Array
        private static void UseBinarySearch(int[] vetor, int find)
        {
            int pos = Array.BinarySearch(vetor, find);
            Console.WriteLine("O valor {0} encontra-se na posição {1}", find, pos);
            Console.WriteLine("");
        }

        // Gera números aleatórios e preenche o array com estes valores
        private static void UseRandom(int[] vetor)
        {
            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(10);

                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("");
        }
    }

    // Métodos
    public class Aula024
    {
        public static void Aula()
        {
            DizerOla(5);
            SomaInteiros(10, 20);
        }

        public static void DizerOla(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Olá Mundo: {0, 5}", i);
            }
        }

        public static int SomaInteiros(int num1, int num2)
        {
            int retorno = 0;

            retorno = num1 + num2;

            Console.WriteLine("O resultado da soma de {0} + {1} = {2}", num1, num2, retorno);

            return retorno;
        }
    }

    /**
        Passagem por valor e passagem por referência

        A palavra-chave ref indica que um valor é passado por referencia.
    */
    public class Aula025
    {
        public static void Aula()
        {
            int num1 = 50;
            Console.WriteLine("\nPassgem por referência");
            Console.WriteLine("De: {0}", num1);
            Dobrar1(ref num1);
            Console.WriteLine("Para: {0}", num1);

            int num2 = 50;
            Console.WriteLine("\nPassgem por referência");
            Console.WriteLine("De: {0}", num2);
            Dobrar2(num2);
            Console.WriteLine("Para: {0}", num2);
        }

        // Passagem por referencia, utiliza a mesma posição de memória da variável que esta sendo passada na chamada do método
        static void Dobrar1(ref int valor)
        {
            valor *= 2;
        }

        // Passagem por valor, cria uma nova posição de memória e para retornar o valor calculado é preciso adicionar um retorno ao método
        static void Dobrar2(int valor)
        {
            valor *= 2;
        }
    }

    /**
        Argumento out - Curso Programação Completo C# - Aula 26
        A palavra-chave out faz com que os argumentos sejam passados por referência.
        Ele funciona semelhante a palavra-chave ref, com a diferença de que ref requer que a
        variável seja inicializada antes de ser passada.
    */
    public class Aula026
    {
        public static void Aula()
        {
            double dividendo = 10;
            double divisor = 3;
            double resto = 0;
            double quociente = Divide(dividendo, divisor, out resto);

            Console.WriteLine(quociente);
            Console.WriteLine(resto);
        }

        static double Divide(double dividendo, double divisor, out double resto)
        {
            resto = dividendo % divisor;
            return dividendo / divisor;
        }
    }

    /**
        Argumento params - Curso Programação Completo C# - Aula 27
        Usando a palavra-chave params, você pode especificar um parâmetro do método que aceita um número variável de argumentos.
        O tipo de parâmetro deve ser uma matriz unidimensional.
        Nenhum parâmetro adicional é permitido após a palavra-chave params em uma declaração de método e
        apenas uma palavra-chave params é permitida em uma declaração de método.
    */
    public class Aula027
    {
        public static void Aula()
        {
            Console.WriteLine(Somar(1, 2, 3, 4));
        }

        public static int Somar(params int[] n)
        {
            int resultado = 0;

            for (int i = 0; i < n.Length; i++)
            {
                resultado += n[i];
            }

            return resultado;
        }
    }

    /**
        Classes e Objetos - Curso Programação Completo C# - Aula 28

        Uma classe é uma estrutura de dados que pode conter membros de dados (constantes e campos),
        membros de função (métodos, propriedades, eventos, indexadores, operadores, construtores de instância,
        destruidores e construtores estáticos) e tipos aninhados. Os tipos de classe dão suporte à herança,
        um mecanismo no qual uma classe derivada pode estender e especializar uma classe base.
    */
    public class Aula028
    {
        public static void Aula()
        {

        }
    }

    public class Jogo
    {
        public static void Jogar()
        {
            Console.WriteLine("Jo... Ken... Po...\n");
            string[] opcoes = new string[] { "Pedra", "Papel", "Tesoura" };
            string mensagem = string.Empty;

            for (int i = 0; i < opcoes.Length; i++)
                mensagem = string.Format("{0} {1}: {2}", mensagem, i, opcoes[i]);

            Console.WriteLine(string.Format("Selecione {0}", mensagem));
            int usuario = Int32.Parse(Console.ReadLine());

            Random random = new Random();
            int computador = random.Next(3);

            string resultado = string.Format("Usuário: {0} x Computador: {1}", opcoes.GetValue(usuario), opcoes.GetValue(computador));

            if (usuario == 0 && computador == 1)
                resultado += " - Computador venceu";
            else if (usuario == 0 && computador == 2)
                resultado += " - Voce venceu";
            else if (usuario == 1 && computador == 0)
                resultado += " - Voce venceu";
            else if (usuario == 1 && computador == 2)
                resultado += " - Computador venceu";
            else if (usuario == 2 && computador == 0)
                resultado += " - Computador venceu";
            else if (usuario == 2 && computador == 1)
                resultado += " - Você venceu";
            else
                resultado += " - Empate";

            Console.WriteLine("{0}\n", resultado);
        }
    }
}
