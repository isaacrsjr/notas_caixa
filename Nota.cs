public class Nota {
		public readonly int valor;
		public int quantidade{get; private set;}
	
	    public Nota (int valor)
		{
			this.valor =valor;	
			this.quantidade = 1;
		}

		public int IncrementarQuantidade(int incr = 1) => quantidade += incr;

		public override string ToString() => $"{quantidade} x R${valor}.00 \t= R${quantidade * valor}.00";
}
