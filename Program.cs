using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone sNokia = new Nokia(numero: "912345678", modelo: "Lumia 920", imei: "111111111", memoria: 256);
sNokia.Ligar();
sNokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone sIPhone = new Iphone(numero: "998765432", modelo:"13 Pro Max", imei: "222222222", memoria: 64);
sIPhone.ReceberLigacao();
sIPhone.InstalarAplicativo("X");