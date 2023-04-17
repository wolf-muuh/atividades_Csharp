//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int pares = 0;
int impares = 0;


int [] num = new int [6];

for (int i = 0; i < 6; i ++)
{
    Console.WriteLine($"Digite um número inteiro.");
    num[i] = int.Parse(Console.ReadLine());

    if ((num[i] % 2 == 0) && (num[i]>0)){
        pares++;
    }
    else {
        impares++;
    }    
}

foreach (int x in num)
{
    if (x % 2 == 0)
    {
        Console.WriteLine($"O numero {x} é par!");
        
    }
    else 
    {
        Console.WriteLine($"O número {x} é impar");
           
    }
}