﻿Console.WriteLine("--Decomposição Decimal--");
Console.WriteLine("Digite um número..:");
int numeroDigitado, centenas, dezenas, unidades;
numeroDigitado= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("O numero possui:..");
centenas = numeroDigitado / 100;
dezenas = (numeroDigitado % 100) / 10;
unidades = (numeroDigitado % 100) % 10;
Console.WriteLine($"{centenas,10} centena(S)");
Console.WriteLine($"{dezenas, 20} dezena(S)");
Console.WriteLine($"{unidades, 30} unidade(S)");
