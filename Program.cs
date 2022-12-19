using DesafioPOO.Models;
using static System.Console;
// TODO: Realizar os testes com as classes Nokia e Iphone
WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("124536", "Modelo 1", "196516519", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Google Chrome");

WriteLine();
WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("6541951951", "Modelo 2", "2222222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Dio.me");
