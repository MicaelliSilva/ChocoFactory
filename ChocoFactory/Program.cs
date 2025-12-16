var minutosMaquina = 0;
var qtdMateriaPrima = 0.00;

do
{
    if (minutosMaquina <= 0)
    {
        Console.WriteLine("Quantos minutos a maquina deve trabalhar?");
        minutosMaquina = int.Parse(Console.ReadLine());
    }

    if (qtdMateriaPrima <= 0)
    {
        Console.WriteLine("Qual a quantidade de matéria-prima (chocolate liquido) disponivel em gramas?");
        qtdMateriaPrima = double.Parse(Console.ReadLine());
    }
}
while (minutosMaquina <= 0 || qtdMateriaPrima <= 0);

var temperatura = 20;
var producaoTotal = 0;
for (int i = 1; i <= minutosMaquina; i++)
{
    if (temperatura > 80)
    {
        temperatura -= 5;
        Console.WriteLine("Minuto: " + i + " Ventilador ligado! Resfriando...");
    }
    else
    {
        temperatura += 15;
    }

    if (qtdMateriaPrima <= 0.00)
    {
        Console.WriteLine("Parada: Estoque insuficiente !!");
        break;
    }

    if (temperatura > 120)
    {
        Console.WriteLine("PERIGO: A MÁQUINA EXPLODIU!!!");
        break;
    }

    producaoTotal += 50;
    qtdMateriaPrima -= 1000.00;
}

Console.WriteLine("Total de barras produzidas: " + producaoTotal);

if (temperatura < 120)
{
    Console.WriteLine("A maquina sobreviveu!");
}
