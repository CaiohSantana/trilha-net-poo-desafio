namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int memoria, string imei) : base(numero, modelo, memoria, imei)
        {

        }

        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeAplicativo}\" no Nokia!");
        }
    }
}