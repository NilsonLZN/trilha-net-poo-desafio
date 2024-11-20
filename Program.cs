using DesafioPOO.Models;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "99970-7070", modelo: "Nokia N20", imei: "352512345600001", memoria: 128);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "99960-6060", modelo: "Iphone 15", imei: "352512345600002", memoria: 256);
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}