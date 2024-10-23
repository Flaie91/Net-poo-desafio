using Net_poo_desafio.Models;

Iphone IphoneNovo = new Iphone(numero: "84522-2545", modelo: "Pro Max", imei: "212456787878", memoria: 64 );

Nokia NokiaNovo = new Nokia(numero: "84522-3232", modelo: "Nokia 15", imei: "212456787878", memoria: 64);


Console.WriteLine($"Novo celular Nokia {NokiaNovo.Numero}");
NokiaNovo.Ligar();
NokiaNovo.ReceberLigacao();
NokiaNovo.InstalarAplicativo("WhatsApp");
Console.WriteLine("");
Console.WriteLine($"Novo celular Iphone {IphoneNovo.Numero}");
IphoneNovo.Ligar();
IphoneNovo.ReceberLigacao();
IphoneNovo.InstalarAplicativo("Telegram");
