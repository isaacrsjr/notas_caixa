using System;
using System.Collections.Generic;
using System.Linq;
					
var notas = new int [] {200,100,50,20,10,2,5};
var notasUsadas = new List<Nota>();

var qtd = 33;
var resto = qtd;

if (resto % 2 == 1)
{
	notasUsadas.Add(new Nota(5));
	resto -= 5;
}

while (resto > 0)
{
	int maiorNota = notas.Where(n => n <= resto).First();
	notasUsadas.Add(new Nota(maiorNota));
	resto -= maiorNota;
}

int provaReal = 0;
foreach (Nota n in notasUsadas)
{
	Console.WriteLine(n.valor);	
	provaReal += n.valor;
}

Console.WriteLine(provaReal == qtd? "Certo": "Errado");

public class Nota {
		public readonly int valor;
	
	    public Nota (int valor){
			this.valor =valor;	
		}  
}
