using System;
					
public class Program
{
	public static void Main()
	{
		//DECLARAÇÃO DE VARIÁVEIS
		String nome;
		double peso;
		double altura;
		double imc;
		
		//COLETA DE VARIÁVEIS
		Console.WriteLine("INSIRA SEU NOME");
		nome = Console.ReadLine();
		Console.WriteLine("INSIRA SEU PESO");
		peso = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("INSIRA SUA ALTURA");
		altura = Convert.ToDouble(Console.ReadLine());
		
		//CALCULO DE IMC
		imc = peso / (altura * altura);
		
		//EXEBIÇÃO E TRATAMENTO DE DADOS 
		Console.WriteLine(" OLÁ " + nome + " ");
		Console.WriteLine("SEU IMC É:" + imc.ToString("F2"));
		
	//CONDICIONAIS BASEADAS NA TABELA DO IMC
		if (imc < 18.5)
		{
			Console.WriteLine("CLASSIFICAÇÃO: BAIXO PESO");
		}
		else if (imc >= 18.5 && imc <= 24.99)
		{
			Console.WriteLine("CLASSIFICAÇÃO: NORMAL");
		}
		else if (imc >= 25 && imc <= 29.99)
		{
			Console.WriteLine("CLASSIFICAÇÃO: SOBREPESO");
		}
		else
		{
			Console.WriteLine("CLASSIFICAÇÃO: OBESIDADE");
			
							  
	
		}
}		
}
