Console.Clear();

//Tempo de uso diário (h) x Consumo do aparelho (kWh/mês) x Custo da energia (R$/kWh) = Custo de um mês de uso (R$)

/*
--- Custo de Energia ---

Consumo do aparelho (em kWh/mês)...: 17,1
Horas de uso por dia...............: 8
Custo da energia (em R$/kWh).......: 0,62258

Custo estimado: R$85,17
*/

float consumo;
int horas;
float custo;
float estima;

Console.WriteLine("Digite o consumo do aparelho (em kWh/mês)...:");
consumo = Convert.ToSingle(Console.ReadLine()!);

Console.WriteLine("Digite o número de horas de uso por dia ....:");
horas = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Digite o custo da energia (em R$/kWh).......:");
custo = Convert.ToSingle(Console.ReadLine()!);

estima = horas * consumo * custo;

Console.WriteLine($"Custo estimado: R${Math.Round(estima, 2)}");