namespace Árbol_Binario_de_Búsqueda__ABB_
{
    public partial class Form1 : Form
    {
        private readonly ArbolBinarioBusqueda arbol;
        private readonly RenderizadorArbol renderizador;
        private HashSet<int>? rutaResaltada;
        private int? nodoEncontrado;

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolBinarioBusqueda();
            renderizador = new RenderizadorArbol();
            ActualizarVista("Arbol inicializado en memoria dinamica.");
        }

        private bool IntentarLeerValor(out int valor)
        {
            if (int.TryParse(txtValor.Text.Trim(), out valor))
            {
                return true;
            }

            txtEstado.Text = "Ingrese un numero entero valido.";
            txtValor.Focus();
            txtValor.SelectAll();
            return false;
        }

        private void LimpiarResaltado()
        {
            rutaResaltada = null;
            nodoEncontrado = null;
        }

        private void ActualizarVista(string mensajeEstado)
        {
            txtPreorden.Text = FormatearRecorrido(arbol.Preorden());
            txtInorden.Text = FormatearRecorrido(arbol.Inorden());
            txtPostorden.Text = FormatearRecorrido(arbol.Postorden());
            txtEstado.Text = $"{mensajeEstado} | Nodos: {arbol.Cantidad} | Altura: {arbol.ObtenerAltura()}";
            pbArbol.Invalidate();
        }

        private static string FormatearRecorrido(List<int> valores)
        {
            return valores.Count == 0 ? "(vacio)" : string.Join(", ", valores);
        }

        private void btnInsertar_Click(object? sender, EventArgs e)
        {
            if (!IntentarLeerValor(out int valor))
            {
                return;
            }

            LimpiarResaltado();
            bool insertado = arbol.Insertar(valor);
            string mensaje = insertado
                ? $"Valor {valor} insertado correctamente."
                : $"El valor {valor} ya existe en el arbol.";

            txtValor.Clear();
            txtValor.Focus();
            ActualizarVista(mensaje);
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            if (!IntentarLeerValor(out int valor))
            {
                return;
            }

            List<int> ruta = new List<int>();
            bool encontrado = arbol.BuscarConRuta(valor, ruta);
            rutaResaltada = new HashSet<int>(ruta);
            nodoEncontrado = encontrado ? valor : null;

            string recorridoRuta = ruta.Count > 0 ? string.Join(" -> ", ruta) : "(ninguno)";
            string mensaje = encontrado
                ? $"Valor {valor} encontrado. Ruta: {recorridoRuta}"
                : $"Valor {valor} no encontrado. Ruta revisada: {recorridoRuta}";

            txtValor.SelectAll();
            txtValor.Focus();
            ActualizarVista(mensaje);
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (!IntentarLeerValor(out int valor))
            {
                return;
            }

            LimpiarResaltado();
            bool eliminado = arbol.Eliminar(valor);
            string mensaje = eliminado
                ? $"Valor {valor} eliminado correctamente."
                : $"El valor {valor} no se encuentra en el arbol.";

            txtValor.Clear();
            txtValor.Focus();
            ActualizarVista(mensaje);
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarResaltado();
            arbol.Limpiar();
            txtValor.Clear();
            txtValor.Focus();
            ActualizarVista("Arbol limpiado.");
        }

        private void btnEjemplo_Click(object? sender, EventArgs e)
        {
            LimpiarResaltado();
            arbol.Limpiar();
            int[] valoresEjemplo = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (int valor in valoresEjemplo)
            {
                arbol.Insertar(valor);
            }
            ActualizarVista("Ejemplo cargado (50, 30, 70, 20, 40, 60, 80).");
        }

        private void pbArbol_Paint(object? sender, PaintEventArgs e)
        {
            renderizador.Dibujar(e.Graphics, pbArbol.ClientSize, arbol, rutaResaltada, nodoEncontrado);
        }

        private void pbArbol_Resize(object? sender, EventArgs e)
        {
            pbArbol.Invalidate();
        }

        private void txtValor_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnInsertar_Click(sender, EventArgs.Empty);
            }
        }
    }
}
