namespace Árbol_Binario_de_Búsqueda__ABB_
{
    internal static class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--test")
            {
                (bool exito, string reporte) = PruebasABB.EjecutarTodas();
                Console.WriteLine(reporte);
                return exito ? 0 : 1;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            return 0;
        }
    }
}
