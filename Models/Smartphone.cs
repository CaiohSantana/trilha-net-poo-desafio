namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private int Memoria { get; set; }
        private string IMEI { get; set; }

        public Smartphone(string numero, string modelo, int memoria, string imei)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            IMEI = imei;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeAplicativo);
    }
}