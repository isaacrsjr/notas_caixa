using System;
using System.Collections.Generic;
using System.Linq;
					
var valorNotas = new int [] { 200,100,50,20,10,2 };
var notasUsadas = new Dictionary<int, Nota>();

int qtd = ObterQuantidade();
var resto = qtd;

if (resto % 2 == 1)
{
	notasUsadas.Add(5, new Nota(5));
	resto -= 5;
}

while (resto > 0)
{
	int maiorNota = valorNotas.Where(n => n <= resto).First();
	if (notasUsadas.ContainsKey(maiorNota))
		notasUsadas[maiorNota].IncrementarQuantidade();
	else
		notasUsadas.Add(maiorNota, new Nota(maiorNota));
	resto -= maiorNota;
}

ImprimirResultados(notasUsadas.Values.OrderBy(n => n.valor));
return 0;

int ObterQuantidade() {
	int qtd = 0;
	while (qtd < 5)
	{
		Console.Write("Digite o valor inteiro em reais: R$");
		if (!int.TryParse(Console.ReadLine(), out qtd))
		{
			Console.WriteLine("Você não digitou um valor válido!");
			continue;
		}
		if (qtd == 2)
		{
			return 2;
		}
		else if (qtd == 4)
		{
			return 4;
		}
		else if (qtd < 5) 
		{
			Console.WriteLine("Você deve digitar uma valor maior ou igual a 5 ou 2 ou 4!");
			qtd = 0;
			continue;
		}
	}
	return qtd;
}

void ImprimirResultados(IEnumerable<Nota> notas)
{
	Console.WriteLine("\n***** RESULTADO *****");

	int provaReal = 0;
	foreach (Nota n in notas)
	{
		Console.WriteLine(n);	
		provaReal += n.valor*n.quantidade;
	}

	Console.Write("\r\nProva real: ");
	Console.WriteLine(provaReal == qtd? "Certo": "Errado");
}