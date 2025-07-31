using DesafioPOO.Models;

//Realizando teste com a classe Nokia.
Nokia nokia = new Nokia("123456789", "1234567891011", "Nokia", 12);
Console.WriteLine("Smartphone Nokia:\n");
Console.WriteLine($"{nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


//Realizando teste com a classe Iphone.
Iphone iphone = new Iphone("987654321", "1110987654321", "Iphone", 24);
Console.WriteLine("Smartphone Iphone:\n");
Console.WriteLine($"{iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");