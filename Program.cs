using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "1100", iMEI: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Bíblia");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "111111", modelo: "XR", iMEI: "122222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Skoob");