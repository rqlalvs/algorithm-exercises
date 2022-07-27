/*
Escreva um algoritmo que exiba a sequência de Fibonnacci iniciando em 1 até o "n" elemento.

Explicação: Na sequência de Fibonnacci, cada elemento é a soma dos dois elementos anteriores. Os dois primeiros elementos são 1 e 1. 
Recebe como entrada o valor de “n”.

1 + 1 .... n vezes 

/* Escreva um algoritmo que simule o funcionamento de um caixa eletrônico.
Explicação: Deverá receber o valor desejado de saque e ele retornará à quantidade de cédulas de cada valor.
As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2. Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.
*/

//recebe o valor de saque e particiona ele entre as cedulas que existem usando menor numero delas
//1 e 3 retornam valor invalido

class Solution
{

    public static void Main(String[] args)
    {

        //Caixa Eletronico
        int valorSaque = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CaixaEletronico(valorSaque));


        //Fibbonnacci
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write(String.Join(", ", Fibonnacci(n).ToArray()));

    }


    public static string CaixaEletronico(int valorSaque)
    {

        if (valorSaque == 1 || valorSaque == 3)
            return "Valor invalido para Saque";

        List<int> Cedulas = new List<int> { 100, 50, 20, 10, 5, 2 };
        List<int> Saques = new List<int> { };
        List<string> Resposta = new List<string> { };
        int i = 0;

        while (valorSaque != 0)
        {
            if (valorSaque - Cedulas[i] >= 0)
            {
                valorSaque -= Cedulas[i];
                Saques.Add(Cedulas[i]);
            }
            else
            {
                i++;
            }
        }

        for (int j = 0; j < Cedulas.Count; j++)
        {
            int count = Saques.Count(item => item.Equals(Cedulas[j]));
            if (count != 0)
            {
                Resposta.Add(count + " notas de " + Cedulas[j]);
            }
            else { }

        }

        return String.Join(", ", Resposta.ToArray());
    }


    public static List<int> Fibonnacci(int n)
    {
        List<int> arr = new List<int> { 1, 1 };
        arr.Add(arr[0] + arr[1]);

        if (n <= 2)
        {
            return arr;
        }
        else
        {
            n -= 1;
        }

        for (int i = 2; i < n; i++)
        {
            int val = arr[i] + arr[i - 1];
            arr.Add(val);
        }

        return arr;

    }
}


