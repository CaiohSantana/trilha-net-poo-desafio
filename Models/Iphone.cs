namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int memoria, string imei) : base(numero, modelo, memoria, imei)
        {

        }

        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeAplicativo}\" no Iphone!");
        }
    }
}