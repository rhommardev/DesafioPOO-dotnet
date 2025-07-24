using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("123456789", "iPhone 12", "ED23456789012345", 128);
Nokia nokia = new Nokia("987654321", "Nokia 3310", "123456789012345", 32);

// Testando os métodos do iPhone
Console.WriteLine("Testando celular iPhone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

// Testando os métodos do Nokia
Console.WriteLine("Testando celular Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Binance");

Console.WriteLine("Teste realizado com sucesso!");