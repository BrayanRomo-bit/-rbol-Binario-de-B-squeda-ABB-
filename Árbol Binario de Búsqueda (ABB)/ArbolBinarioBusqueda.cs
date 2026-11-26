namespace Árbol_Binario_de_Búsqueda__ABB_
{
    public class ArbolBinarioBusqueda
    {
        public NodoABB? Raiz { get; private set; }
        public int Cantidad { get; private set; }

        public ArbolBinarioBusqueda()
        {
            Raiz = null;
            Cantidad = 0;
        }

        public bool Insertar(int valor)
        {
            if (Raiz == null)
            {
                Raiz = new NodoABB(valor);
                Cantidad++;
                return true;
            }

            NodoABB actual = Raiz;
            while (true)
            {
                if (valor == actual.Valor)
                {
                    return false;
                }

                if (valor < actual.Valor)
                {
                    if (actual.Izquierdo == null)
                    {
                        actual.Izquierdo = new NodoABB(valor);
                        Cantidad++;
                        return true;
                    }
                    actual = actual.Izquierdo;
                }
                else
                {
                    if (actual.Derecho == null)
                    {
                        actual.Derecho = new NodoABB(valor);
                        Cantidad++;
                        return true;
                    }
                    actual = actual.Derecho;
                }
            }
        }

        public bool Buscar(int valor)
        {
            NodoABB? actual = Raiz;
            while (actual != null)
            {
                if (valor == actual.Valor)
                {
                    return true;
                }
                actual = valor < actual.Valor ? actual.Izquierdo : actual.Derecho;
            }
            return false;
        }

        public bool BuscarConRuta(int valor, List<int> ruta)
        {
            ruta.Clear();
            NodoABB? actual = Raiz;
            while (actual != null)
            {
                ruta.Add(actual.Valor);
                if (valor == actual.Valor)
                {
                    return true;
                }
                actual = valor < actual.Valor ? actual.Izquierdo : actual.Derecho;
            }
            return false;
        }

        public bool Eliminar(int valor)
        {
            bool eliminado = false;
            Raiz = EliminarRecursivo(Raiz, valor, ref eliminado);
            if (eliminado)
            {
                Cantidad--;
            }
            return eliminado;
        }

        private NodoABB? EliminarRecursivo(NodoABB? nodo, int valor, ref bool eliminado)
        {
            if (nodo == null)
            {
                return null;
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor, ref eliminado);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor, ref eliminado);
            }
            else
            {
                eliminado = true;

                if (nodo.Izquierdo == null)
                {
                    return nodo.Derecho;
                }

                if (nodo.Derecho == null)
                {
                    return nodo.Izquierdo;
                }

                NodoABB sucesor = ObtenerMinimo(nodo.Derecho);
                nodo.Valor = sucesor.Valor;
                bool dummy = false;
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, sucesor.Valor, ref dummy);
            }

            return nodo;
        }

        private static NodoABB ObtenerMinimo(NodoABB nodo)
        {
            NodoABB actual = nodo;
            while (actual.Izquierdo != null)
            {
                actual = actual.Izquierdo;
            }
            return actual;
        }

        public List<int> Preorden()
        {
            List<int> resultado = new List<int>(Cantidad);
            RecorrerPreorden(Raiz, resultado);
            return resultado;
        }

        private static void RecorrerPreorden(NodoABB? nodo, List<int> resultado)
        {
            if (nodo == null)
            {
                return;
            }
            resultado.Add(nodo.Valor);
            RecorrerPreorden(nodo.Izquierdo, resultado);
            RecorrerPreorden(nodo.Derecho, resultado);
        }

        public List<int> Inorden()
        {
            List<int> resultado = new List<int>(Cantidad);
            RecorrerInorden(Raiz, resultado);
            return resultado;
        }

        private static void RecorrerInorden(NodoABB? nodo, List<int> resultado)
        {
            if (nodo == null)
            {
                return;
            }
            RecorrerInorden(nodo.Izquierdo, resultado);
            resultado.Add(nodo.Valor);
            RecorrerInorden(nodo.Derecho, resultado);
        }

        public List<int> Postorden()
        {
            List<int> resultado = new List<int>(Cantidad);
            RecorrerPostorden(Raiz, resultado);
            return resultado;
        }

        private static void RecorrerPostorden(NodoABB? nodo, List<int> resultado)
        {
            if (nodo == null)
            {
                return;
            }
            RecorrerPostorden(nodo.Izquierdo, resultado);
            RecorrerPostorden(nodo.Derecho, resultado);
            resultado.Add(nodo.Valor);
        }

        public int ObtenerAltura()
        {
            return CalcularAltura(Raiz);
        }

        private static int CalcularAltura(NodoABB? nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            int alturaIzq = CalcularAltura(nodo.Izquierdo);
            int alturaDer = CalcularAltura(nodo.Derecho);
            return 1 + Math.Max(alturaIzq, alturaDer);
        }

        public void Limpiar()
        {
            Raiz = null;
            Cantidad = 0;
        }
    }
}
