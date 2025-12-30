using Sistema_bancario;

public class program{
	static cliente cliente = new cliente();

	public static void Main(string[] args)
	{
		menu();
	}

	static void menu()
	{
		
		string[] opcoes =
		{
			"1- Sacar", "2- Depositar", "3- Ajuda", "4- Sair ", "5- Creditos"
		};

		Console.WriteLine("--BEM VINDO AO BANCO NANOTRASEN--");
		if (cliente.cadastradoo == false)
		{
			cadastro();
		}

		foreach (var opcao in opcoes)
		{
			Console.WriteLine(opcao);
		}
		int escolha = int.Parse(Console.ReadLine());
		switch(escolha){
			case 1:
				Sacar();
				break;
			case 2:
				Depositar();
				break;
			case 3:
				menuajuda();
				break;
			case 4:
				Console.ReadLine();
				break;
			case 5:
				Console.WriteLine("Codigo - Áquila Pacito");
				break;
		}
	}
	static void cadastro()
	{
		
		if(cliente.cadastradoo == false){
			Console.WriteLine("Para continuar precisamos de algumas informações.");
			Console.WriteLine("Diga seu nome: ");
			cliente.nome = Console.ReadLine();
			Console.WriteLine("Diga seu cpf: ");
			cliente.cpf = int.Parse(Console.ReadLine());
			Console.WriteLine("Diga seu idade: ");
			cliente.idade = int.Parse(Console.ReadLine());
			Console.WriteLine("Diga seu saldo: ");
			cliente.saldo = int.Parse(Console.ReadLine());
			Console.WriteLine("CADASTRO FEITO!");
			cliente.cadastradoo = true;
		}
		else
		{
			Console.WriteLine("ERROR NO CADASTRO PORFAVOR TENTE NOVAMENTE");
		}
	}

	static void Sacar()
	{
		
		if (cliente.saldo < 0)
		{
			Console.WriteLine("Você não pode sacar nada pois tem 0 no saldo");
			Console.ReadLine();
		}
		else
		{
			Console.WriteLine("Insira o dinheiro que deseja sacar: ");
			int dinheiro_Do_saque = int.Parse(Console.ReadLine());
			if (cliente.saldo < dinheiro_Do_saque)
			{
				Console.WriteLine("Seu valor é inválido com seu saldo.");
			}
			cliente.saldo = dinheiro_Do_saque - cliente.saldo;
			Random random = new Random();
			int codigodelevantamento = random.Next(0, 1000);
			Console.WriteLine($"Vá para o caixa mais proximo, seu codigo de levantamento é {codigodelevantamento}");
			
		}
		
	}
	static void Depositar()
	{
		
		Console.WriteLine("Digite o valor que deseja sacar: ");
		int valordodeposito = int.Parse(Console.ReadLine());
		cliente.saldo += valordodeposito;
		Console.WriteLine("Deposito feito voltando para o menu...");
		menu();
		
	}

	static void menuajuda()
	{
		Console.WriteLine("Converse comigo! Discord: forgiveme145");
	}
	
	
}

