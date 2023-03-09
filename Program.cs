// Valores de faturamento por estado
decimal faturamentoSP = 67836.43m;
decimal faturamentoRJ = 36678.66m;
decimal faturamentoMG = 29229.88m;
decimal faturamentoES = 27165.48m;
decimal faturamentoOutros = 19849.53m;

// Cálculo do faturamento total mensal
decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

// Cálculo do percentual de representação de cada estado
decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

// Impressão dos resultados
Console.WriteLine("Percentual de representação do faturamento por estado:");
Console.WriteLine("SP: {0:f2}%", percentualSP);
Console.WriteLine("RJ: {0:f2}%", percentualRJ);
Console.WriteLine("MG: {0:f2}%", percentualMG);
Console.WriteLine("ES: {0:f2}%", percentualES);
Console.WriteLine("Outros: {0:f2}%", percentualOutros);

Console.ReadKey();