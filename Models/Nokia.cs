namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {    
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"\n Instalando App Android {nomeApp}...");
            Console.WriteLine($" App {nomeApp} Instalado.");
        }
    }
}