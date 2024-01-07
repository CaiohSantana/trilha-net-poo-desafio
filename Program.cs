using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("0223", "Modelo 11 Pro", 128, "123321" ); 
iphone.Ligar();
iphone.InstalarAplicativo("LinkedIn");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("53465", "Modelo G60 5g", 256, "43233" ); 
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Netflix");