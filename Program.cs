using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace SuporteDev 
{
    public class EntradaDeDados
    {

        static void Main()
        {
            
            //**** Treinamento - Parte 1 - C# : variáveis e passagem de valor ou referência ******//
            //-----------------------------------------------------------------------------------//            
            
            // Variável bool (booleana)
            // bool isTrue = true;

            // // Variáveis numéricas
            // int number = 10; // Número inteiro
            // float floatValue = 3.14f; // Número de ponto flutuante de precisão simples
            // double doubleValue = 2.71828; // Número de ponto flutuante de precisão dupla
            // decimal decimalValue = 123.456m; // Número decimal de alta precisão

            // var x = "Teste";

            // // Variável char (caractere)
            // char character = 'A';

            // // Variável string (cadeia de caracteres)
            // string text = "Hello, World!";

            // // Variável enum (enumerador)
            // DaysOfWeek day = DaysOfWeek.Monday;

            // // Variável struct (estrutura)
            // Point point;
            // point.x = 5;
            // point.y = 10;

            // // Variável array (matriz)
            // // int[] numbers = { 1, 2, 3, 4, 5 };

            // // Variável object (objeto)
            // // usado para armazenar qualquer tipo de valor.
            // object obj = "This is an object.";

            // // Variável dynamic (dinâmica)
            // // usado para permitir a resolução de tipos em tempo de execução.
            // dynamic dynamicVar = 10;

            // //Imprimir os valores das variáveis
            // Console.WriteLine($"isTrue: {isTrue}");
            // Console.WriteLine($"number: {number}");
            // Console.WriteLine($"floatValue: {floatValue}");
            // Console.WriteLine($"doubleValue: {doubleValue}");
            // Console.WriteLine($"decimalValue: {decimalValue}");
            // Console.WriteLine($"character: {character}");
            // Console.WriteLine($"text: {text}");
            // Console.WriteLine($"day: {day}");
            // Console.WriteLine($"point: ({point.x}, {point.y})");
            // Console.WriteLine("numbers: " + string.Join(", ", numbers));
            // Console.WriteLine($"obj: {obj}");
            // Console.WriteLine($"dynamicVar: {dynamicVar}");
        

            // **** Treinamento - Parte 2 - Laço de repetição ******
            //----------------------------------------------------//

            // Laço de repetição While 
            // Console.WriteLine($"****** Laço de repetição While ******");


            // int counter = 0;
            // while (counter < 10)
            // {   
            //     Console.WriteLine($" | While ! The counter is {counter} |");
            //     counter++;
            // }
        
            // // Laço de repetição Do While
            // Console.WriteLine($"****** Laço de repetição Do While ******");
        
            // int counter2 = 0;
            // do
            // {
            //     Console.WriteLine($" | Do While ! The counter is {counter2} | ");
            //     counter2++;
            // } while (counter2 < 10); // Exemplo Brute Force (Quebra de Senha) 
   
            // // Laço de repetição For
            // Console.WriteLine($"****** Laço de repetição For ******");

            // for (int counter3 = 0; counter3 < 10; counter3++)
            // {
            //     Console.WriteLine($" | For! The counter is {counter3} |");
            // } 

            // // Laço de repetição Foreach
            // Console.WriteLine($"****** Laço de repetição Foreach ******");

            // var names = new List<string> { "Danilo", "Gabriel", "Isis", "Caio" };

            // foreach (var name in names)
            // {
            //     Console.WriteLine($" | Laço de repetição Foreach {name.ToUpper()}! | ");
            // }
        

            // **** Treinamento - Parte 3 - Expressões lambda ******
            //----------------------------------------------------//

            
            // Expressões lambda sem parâmetros:
            // () => Console.WriteLine("Olá, mundo!");

            // Expressões lambda com um parâmetro:
            // x => x * x;

            // Expressões lambda com múltiplos parâmetros:
            // (x, y) => x + y;
                      
            // Expressões lambda com corpo de bloco:
            // (x, y) =/> {
            //     int resultado = x + y;
            //     return resultado;
            // };

            // Expressões lambda com chamada de método:
            // x => Math.Sqrt(x);

            // Expressões lambda para filtrar uma coleção:
            // int[] numeros = { 1, 2, 3, 4, 5 };
            // var numerosPares = numeros.Where(n => n % 2 == 0);

            // Expressões lambda para ordenar uma coleção:
            // List<string> nomes = new List<string> { "Ana", "Carlos", "Beto", "Zoe" };
            // var nomesOrdenados = nomes.OrderBy(nome => nome);
            
            // Filtrar elementos de uma lista:
            // Suponha que você tenha uma lista de números inteiros e deseje filtrar apenas os números pares. 
            // Você pode usar uma expressão lambda com o método Where da classe Enumerable para isso:
            // var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Usando expressão lambda para filtrar números pares
            // var evenNumbers = numbers.Where(x => x % 2 == 0);

            // Console.WriteLine($"Apenas Números Pares:");
            // foreach (var number in evenNumbers)
            // {   
            //     Console.WriteLine(number);
            // }; 

            // Ordenar uma lista:
            // Você pode usar expressões lambda para definir o critério de ordenação ao classificar uma lista de objetos personalizados. 
            // Por exemplo, para ordenar uma lista de objetos Person por idade:

            // var people = new List<Person>
            // {
            //     new Person { Name = "Alice", Age = 30 },
            //     new Person { Name = "Bob", Age = 25 },
            //     new Person { Name = "Charlie", Age = 40 }
            // };

            // Ordenando por idade usando expressão lambda
            // var sortedPeople = people.OrderBy(person => person.Age);

            // foreach (var person in sortedPeople)
            // {
            //     Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            // }

            // -----------

            // var numerosString = new List<string> { "1", "2", "3", "4", "5" };

            // Convertendo a lista de strings para lista de inteiros usando expressão lambda
            // var numerosInteiros = numerosString.Select(str => int.Parse(str));

            // foreach (var numero in numerosInteiros)
            // {
            //     Console.WriteLine(numero);
            // }
        

            // **** Treinamento - Parte 4 - Operadores Ternários em C# ******
            //----------------------------------------------------// 

            //Exemplo simples:

            // Console.WriteLine("Digite um número:");
            // int numero = int.Parse(Console.ReadLine());
            // string resultado = (numero > 5) ? "Maior que 5" : "Menor ou igual a 5";
            // Console.WriteLine(resultado);

            //Verificar paridade:

            // Console.WriteLine("Digite um número:");
            // int valor = int.Parse(Console.ReadLine());
            // string paridade = (valor % 2 == 0) ? "Par" : "Ímpar";
            // Console.WriteLine(paridade);

            // Selecionar o maior de dois números:

            // Console.WriteLine("Digite primeiro número (a):");
            // int a = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite segundo número (b):");
            // int b = int.Parse(Console.ReadLine());
            // int maior = (a > b) ? a : b;
            // Console.WriteLine("O maior número é: " + maior); 

            // Determinar se um ano é bissexto:

            // Console.WriteLine("Digite o ano:");
            // int ano = int.Parse(Console.ReadLine());
            // bool bissexto = (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0)) ? true : false;
            // Console.WriteLine("Ano bissexto? " + bissexto);  

            // Atribuir valores baseados em múltiplas condições:

            // Console.WriteLine("Digite a nota do aluno:");
            // int nota = int.Parse(Console.ReadLine());
            // string conceito = (nota >= 90) ? "A" :
            //       (nota >= 80) ? "B" :
            //       (nota >= 70) ? "C" :
            //       (nota >= 60) ? "D" : "F";
            // Console.WriteLine("Conceito: " + conceito);  

            // Realizar cálculos condicionais:
            
            // Console.WriteLine("Digite o Salário Base:");
            // int salarioBase = int.Parse(Console.ReadLine());
            // int bonus = (salarioBase > 2500) ? (int)(salarioBase * 0.1) : (int)(salarioBase * 0.05);
            // Console.WriteLine("Bônus: " + bonus);

        
            // **** Treinamento - Parte 5 - Propriedades em C#: Aprenda a Simplificar seu Código ******
            //----------------------------------------------------//

            // // Recebe o valor digitado pelo usuário
            // Console.WriteLine("Digite as horas:");
            // int horas = int.Parse(Console.ReadLine());

            // //Instancia uma classe do tipo TimePeriod no objeto segundos
            // TimePeriod segundos = new TimePeriod(horas);
            
            // // Seta o valor recebida pelo usuário a propriedade da classe TimePeriod
            // segundos.Hours = horas;

            // //Pega os valores da propriedade privada
            // double valorprivado = segundos.GetMinhaPropriedadePrivada();

            // //Escreve o valor após o calculo de segundos
            // Console.WriteLine($"Time in hours: {segundos.Hours}");

            // //Escreve o valor após o calculo de segundos
            // Console.WriteLine($"Time in hours: {valorprivado}");

            // **** Treinamento - Parte 6 - Syntactic Sugar ******
            //----------------------------------------------------//

            // Propriedades Automáticas: Em vez de definir campos privados e criar métodos Getters e Setters, você pode usar propriedades automáticas. Isso simplifica a sintaxe:
            
            // // Sem propriedades automáticas
            // private string _nome;
            // public string Nome
            // {
            //     get { return _nome; }
            //     set { _nome = value; }
            // }

            // // Com propriedades automáticas
            // public string Nome { get; set; }

            // //Inicializadores de Objetos: Você pode inicializar propriedades de um objeto diretamente na declaração:
            // var pessoa = new Pessoa{Nome = "João",Idade = 30};

            // //Interpolação de Strings: Permite incorporar expressões em strings sem usar o operador de concatenação (+):
            // string nome = "Alice";
            // int idade = 25;
            // string mensagem = $"Olá, meu nome é {nome} e tenho {idade} anos.";

            // //Métodos de Extensão LINQ e Lambda Expressions
            // var numeros = new List<int> { 1, 2, 3, 4, 5 };
            // var numerosPares = numeros.Where(n => n % 2 == 0);

            // //Valida se o primeiro valor é NULL caso sim atribui o valor do nome alternativo.
            // string Nome = NomePrincipal ?? NomeAlternativo;

            // **** Treinamento - Parte 7 - Generics ******
            //----------------------------------------------------//

            //Classe Genérica:
            public class ListaGenerica<T>
            {
                private List<T> elementos = new List<T>();

                public void Adicionar(T item)
                {
                    elementos.Add(item);
                }       

                public T Obter(int indice)
                {
                    return elementos[indice];
                }

            }

                //--------------------------------//
                //Método Genérico:
            public T Max<T>(T a, T b) where T : IComparable<T>
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
                
            //--------------------------------//
            //Interfaces Genéricas:
            public interface IRepositorio<T>
            {
                    void Inserir(T item);
                    T BuscarPorId(int id);
            }

            public class Repositorio<T> : IRepositorio<T>
            {   
                private Dictionary<int, T> data = new Dictionary<int, T>();

                public void Inserir(T item)
                {   
                    // Implementação da inserção
                }

                public T BuscarPorId(int id)
                {
                    // Implementação da busca por ID
                    return default(T);
                }
            }

            // Uso da interface e classe genérica:
            IRepositorio<string> repositorioDeStrings = new Repositorio<string>();
            repositorioDeStrings.Inserir("Exemplo");
            string resultado = repositorioDeStrings.BuscarPorId(1);

            // Uso do método genérico:
            int maximoInt = Max(5, 10);
            double maximoDouble = Max(3.14, 2.71);

        

            // Uso da classe genérica:
            ListaGenerica<int> listaDeInteiros = new ListaGenerica<int>();
            listaDeInteiros.Adicionar(1);
            listaDeInteiros.Adicionar(2);
            int numero = listaDeInteiros.Obter(0);

        }

        /*
        // Definição de uma struct (estrutura)
        struct Point
        {
            public int x;
            public int y;
        }

            // Definição de um enum (enumerador)
            enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        */
    
    }
}
