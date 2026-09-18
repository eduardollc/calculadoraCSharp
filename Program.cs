// Calculadora(somar, subtrair, multiplicar, dividir)
Console.WriteLine("Bem vindo(a) a minha calculadora .v.");
MenuPrincipal();

void MenuPrincipal() {

    Console.WriteLine("Entrar (1) - Sair (2)");

    if (SolicitarOpcao())
    {
        Calculadora();
    }
    }

bool SolicitarOpcao()
{

    while (true)
    {
        string? entrada = Console.ReadLine();
        switch (entrada)
        {
            case "1":
                return true;

            case "2":
                Console.WriteLine("Obrigado por usar minha calculadora .v.!");
                return false;

            default:
                Console.WriteLine("Informe um valor válido! Digite 1 ou 2:");
                break;
        }
    }
}

void Calculadora()
{
    string operador;
    double num1;
    double num2;

    do
    {
        Console.WriteLine("\nCalculadora - Dijite \"sair\" para finalizar \nPrimeiro valor:");
        if(!VerificarNumero(out num1))
        {
            break;
        }

        Console.WriteLine("\nOperador (+, -, x , /): ");
        operador = VerificarOperador();

        Console.WriteLine("\nSegundo valor:");
        if(!VerificarNumero(out num2))
        {
            break;
        }

        double resultado = 0;
        bool calculoValido = true;

        switch (operador)
        {
            case "+":
                resultado = num1 + num2;
                break;

            case "-":
                resultado = num1 - num2;
                break;

            case "x":
                resultado = num1 * num2;
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("\nNão é possível dividir por zero!");
                    calculoValido = false;
                }
                else
                {
                    resultado = num1 / num2;
                }
                break;

            default:
                resultado = 0;
                break;
        }

        if (calculoValido)
        {
            Console.WriteLine($"\nResultado: {num1} {operador} {num2} = {resultado}");
        }

        Console.WriteLine("\nDeseja realizar um novo cálculo? Sim(1) - Não(2)");

        if (!SolicitarOpcao())
        {
            break;
        }

    } while (true);
}

string VerificarOperador()
{
    string[] operadores = { "+", "-", "x", "/" };
    string operador;
    do
    {

        operador = Console.ReadLine() ?? "";

        if (!operadores.Contains(operador))
        {
            Console.WriteLine("Operador Inválido, tente novamente: ");

        }

    } while (!operadores.Contains(operador));

    return operador;
}

bool VerificarNumero(out double numero)
{
while (true)
    {
        string? entrada = Console.ReadLine();

        if (entrada?.ToLower() == "sair")
        {
            numero = 0;
            Console.WriteLine("Obrigado por usar minha calculadora .v.!");
            return false;
        }

        if (double.TryParse(entrada, out numero))
        {
            return true;
        }

        Console.WriteLine("Número inválido! Digite novamente:");
    }

}
