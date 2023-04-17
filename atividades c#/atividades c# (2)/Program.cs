//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

Console.WriteLine($"Digite a sua renda:");
float renda = float.Parse(Console.ReadLine());




static float LeaoFaminto(float n1 )
{      
    if (n1 <= 1500) {    
        return 0;
    }
    else if (n1 > 1500 && n1 <= 3500){
        return n1*20/100;
    }
    else if (n1 > 3500 && n1 <= 6000) {
        return n1*25/100;
    }
    else
    {
        return n1*35/100;
    }         
}

float resultado = LeaoFaminto (renda);

Console.WriteLine($"Você vai ter que pagar R${resultado} de imposto");

