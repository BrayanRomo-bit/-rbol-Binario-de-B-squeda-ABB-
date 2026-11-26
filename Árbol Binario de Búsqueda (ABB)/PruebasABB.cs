using System.Text;

namespace Árbol_Binario_de_Búsqueda__ABB_
{
    public static class PruebasABB
    {
        public static (bool Exito, string Reporte) EjecutarTodas()
        {
            StringBuilder sb = new StringBuilder();
            int total = 0;
            int aprobadas = 0;

            void Registrar(string nombre, bool condicion, string detalle)
            {
                total++;
                if (condicion)
                {
                    aprobadas++;
                    sb.AppendLine($"[APROBADA] {nombre}: {detalle}");
                }
                else
                {
                    sb.AppendLine($"[FALLIDA] {nombre}: {detalle}");
                }
            }

            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

            Registrar(
                "Arbol vacio inicial",
                arbol.Cantidad == 0 && arbol.Preorden().Count == 0 && arbol.Inorden().Count == 0 && arbol.Postorden().Count == 0,
                "Cantidad = 0, recorridos vacios");

            int[] datos = { 50, 30, 70, 20, 40, 60, 80 };
            bool insercionesOk = true;
            foreach (int v in datos)
            {
                if (!arbol.Insertar(v))
                {
                    insercionesOk = false;
                }
            }
            bool duplicadoRechazado = !arbol.Insertar(50);

            Registrar(
                "Insercion y rechazo de duplicados",
                insercionesOk && duplicadoRechazado && arbol.Cantidad == 7,
                $"Cantidad = {arbol.Cantidad}, duplicado(50) rechazado = {duplicadoRechazado}");

            string preorden = string.Join(", ", arbol.Preorden());
            string inorden = string.Join(", ", arbol.Inorden());
            string postorden = string.Join(", ", arbol.Postorden());

            Registrar(
                "Recorrido Preorden",
                preorden == "50, 30, 20, 40, 70, 60, 80",
                $"Obtenido: [{preorden}]");

            Registrar(
                "Recorrido Inorden (orden ascendente)",
                inorden == "20, 30, 40, 50, 60, 70, 80",
                $"Obtenido: [{inorden}]");

            Registrar(
                "Recorrido Postorden",
                postorden == "20, 40, 30, 60, 80, 70, 50",
                $"Obtenido: [{postorden}]");

            bool buscaExistente = arbol.Buscar(60);
            bool buscaInexistente = !arbol.Buscar(99);
            Registrar(
                "Busqueda de nodos",
                buscaExistente && buscaInexistente,
                $"Buscar(60) = {buscaExistente}, Buscar(99) = {!buscaInexistente}");

            bool elimHoja = arbol.Eliminar(20);
            string inordenHoja = string.Join(", ", arbol.Inorden());
            Registrar(
                "Eliminacion de nodo hoja (20)",
                elimHoja && inordenHoja == "30, 40, 50, 60, 70, 80" && arbol.Cantidad == 6,
                $"Inorden: [{inordenHoja}]");

            bool elimUnHijo = arbol.Eliminar(30);
            string inordenUnHijo = string.Join(", ", arbol.Inorden());
            string preordenUnHijo = string.Join(", ", arbol.Preorden());
            Registrar(
                "Eliminacion de nodo con un hijo (30)",
                elimUnHijo && inordenUnHijo == "40, 50, 60, 70, 80" && preordenUnHijo == "50, 40, 70, 60, 80" && arbol.Cantidad == 5,
                $"Inorden: [{inordenUnHijo}] | Preorden: [{preordenUnHijo}]");

            bool elimDosHijos = arbol.Eliminar(50);
            string inordenDosHijos = string.Join(", ", arbol.Inorden());
            string preordenDosHijos = string.Join(", ", arbol.Preorden());
            string postordenDosHijos = string.Join(", ", arbol.Postorden());
            Registrar(
                "Eliminacion de raiz con dos hijos (50)",
                elimDosHijos && inordenDosHijos == "40, 60, 70, 80" && preordenDosHijos == "60, 40, 70, 80" && postordenDosHijos == "40, 80, 70, 60" && arbol.Cantidad == 4,
                $"Inorden: [{inordenDosHijos}] | Preorden: [{preordenDosHijos}] | Postorden: [{postordenDosHijos}]");

            bool elimInexistente = !arbol.Eliminar(999);
            Registrar(
                "Eliminacion de nodo inexistente (999)",
                elimInexistente && arbol.Cantidad == 4,
                $"Resultado = {elimInexistente}, Cantidad = {arbol.Cantidad}");

            sb.AppendLine();
            sb.AppendLine($"Resumen: {aprobadas}/{total} pruebas aprobadas.");
            return (aprobadas == total, sb.ToString());
        }
    }
}
