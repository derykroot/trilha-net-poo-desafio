namespace DesafioPOO
{
    public static class Utils {
        public static string selOpcao (string[] ops) {
            string op;
            while (true) {
                op = Console.ReadKey().KeyChar.ToString().ToLower();
                if (ops.Contains(op)) break;
                Console.Write("\b \b");
            }
            return op;
        }

        public static string obterValor (string Texto, bool IsNumeric = false) {
            string valor = "";
            Console.Write($" \n {Texto} ");
            while (true) {
                valor = Console.ReadLine();
                if (IsNumeric && !double.TryParse(valor, out double _)){
                    Console.Write(" \n Valor inválido! Digite um valor numérico: ");
                    continue;
                }
                if (valor.Trim().Length>0) break;
            }
            return valor;
        }
    }
}