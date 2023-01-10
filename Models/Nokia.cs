namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string nome, string modelo, string imei, int memoria) : base(nome, modelo, imei, memoria)
        {    
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Instalando App {nomeApp}...");
            Console.WriteLine($"App {nomeApp} Instalado.");
        }
    }
}