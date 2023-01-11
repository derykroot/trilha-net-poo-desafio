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
    }
}