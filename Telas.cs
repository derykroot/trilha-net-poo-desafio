using static DesafioPOO.Models.Dados;

namespace DesafioPOO
{
    public static class Telas {
        public static void TelaPrincipal(){
            while (true) {
                Console.WriteLine("     ╔══════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("     ║                                                                  ║");
                Console.WriteLine("     ║   Selecione a opção                                              ║");
                Console.WriteLine("     ║                                                                  ║");
                Console.WriteLine("     ║   1. Cadastrar Smartphone                                        ║");
                Console.WriteLine("     ║   2. Listar Smartphones                                          ║");
                Console.WriteLine("     ║   3. Fim                                                         ║");
                Console.WriteLine("     ║                                                                  ║");
                Console.WriteLine("     ╚══════════════════════════════════════════════════════════════════╝");
                Console.Write(" \n      Digite a opção (1/2/3): ");
                var op = Utils.selOpcao(new string[] {"1","2","3"});
                
                if (op=="1") Cadastrar();
                else if (op=="2") Listar();
                else if (op=="3") break; 
            }                       
        }

        public static void Listar(){
            // string tphone = typeof(Models.Iphone) == NovoSmartphone.GetType() ? "Iphone" : "Nokia";
            Console.Clear();
        }

        public static void Cadastrar(){
            Console.Clear();
            Console.Write(" \n Digite o numero: ");
            string Numero = Console.ReadLine();
            Console.Write(" \n Digite o modelo: ");
            string Modelo = Console.ReadLine();
            Console.Write(" \n Digite o IMEI: ");
            string Imei = Console.ReadLine();
            Console.Write(" \n Digite a Quantidade de Memoria (GB): ");
            int Memoria = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \n Selecione o tipo do Smartphone (1 - Iphone / 2 - Nokia): ");
            string tipo = Utils.selOpcao(new string[] {"1","2"});
            // Criar nova instância de objeto tipo Smartphone
            Models.Smartphone NovoSmartphone;
            if (tipo=="1") NovoSmartphone = new Models.Iphone(Numero, Modelo, Imei, Memoria);
            else NovoSmartphone = new Models.Iphone(Numero, Modelo, Imei, Memoria);
            // Adicionar no Repositório;
            SmartphoneList.Add(NovoSmartphone);

            // Instalar App
            Console.Write(" \n Deseja Instalar App (S/N): ");
            string op = Utils.selOpcao(new string[] {"s","n"});
            if (op=="s") {
                Console.Write(" \n Digite o nome do App: ");
                string Nome = Console.ReadLine();
                NovoSmartphone.InstalarAplicativo(Nome);

            }

            // Instalar App
            Console.Write(" \n Chamada detectada. Deja Atender? (S/N): ");
            op = Utils.selOpcao(new string[] {"s","n"});
            if (op=="s") {
                Console.Write(" \n ");
                NovoSmartphone.ReceberLigacao();
                Console.Write(" \n \n Pressione qualquer tecla para continuar. \n ");
                Console.ReadKey();
            }            
        }

    }
}