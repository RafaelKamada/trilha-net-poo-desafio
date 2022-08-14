using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "123", modelo: "Nokia", imei: "12345", memoria: 2);
iphone.Ligar();
iphone.InstalarAplicativo("Candy Crush");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123", modelo: "Nokia", imei: "12345", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Clash of Clans");