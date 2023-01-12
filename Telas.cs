using static DesafioPOO.Models.Dados;
using static DesafioPOO.Utils;

namespace DesafioPOO
{
    public static class Telas {
        public static void TelaPrincipal(){
            while (true) {
                Console.Clear();
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
            Console.WriteLine("     ╔══════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("     ║                           Smartphones                            ║");
            Console.WriteLine("     ╚══════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n \n");
            SmartphoneList.ForEach( item => {
                string tipo = typeof(Models.Iphone) == item.GetType() ? "Iphone" : "Nokia";
                Console.WriteLine($"     {tipo}, Número: {item.Numero}, Modelo: {item.Modelo}, IMEI: {item.IMEI}, Memória (GB): {item.Memoria}");
            });
            Console.Write(" \n \n Pressione qualquer tecla para continuar. \n ");
            Console.ReadKey();
        }

        public static void Cadastrar(){
            Console.Clear();
            //Console.Write(" \n Digite o numero: ");
            string Numero = obterValor("Digite o numero:"); //Console.ReadLine();
            string Modelo =  obterValor("Digite o modelo:");
            string Imei = obterValor("Digite o IMEI: ");
            int Memoria = Convert.ToInt32(obterValor("Digite a Quantidade de Memoria (GB): ", true));

            Console.Write(" \n Selecione o tipo do Smartphone (1 - Iphone / 2 - Nokia): ");
            string tipo = Utils.selOpcao(new string[] {"1","2"});

            // Criar nova instância de objeto tipo Smartphone
            Models.Smartphone NovoSmartphone;
            if (tipo=="1") NovoSmartphone = new Models.Iphone(Numero, Modelo, Imei, Memoria);
            else NovoSmartphone = new Models.Nokia(Numero, Modelo, Imei, Memoria);
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
            }
            Console.Write(" \n \n Pressione qualquer tecla para continuar. \n ");
            Console.ReadKey();
        }

    }
}