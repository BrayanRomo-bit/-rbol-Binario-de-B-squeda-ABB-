using System.Drawing.Drawing2D;

namespace Árbol_Binario_de_Búsqueda__ABB_
{
    public class RenderizadorArbol
    {
        public void Dibujar(Graphics g, Size area, ArbolBinarioBusqueda arbol, HashSet<int>? rutaResaltada, int? nodoEncontrado)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (arbol.Raiz == null || area.Width <= 40 || area.Height <= 40)
            {
                using Font fuenteVacio = new Font("Segoe UI", 11F, FontStyle.Regular);
                using Brush pincelTexto = new SolidBrush(Color.Gray);
                StringFormat formato = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString("Arbol vacio. Inserte valores o cargue un ejemplo.", fuenteVacio, pincelTexto, new RectangleF(0, 0, area.Width, area.Height), formato);
                return;
            }

            int altura = Math.Max(1, arbol.ObtenerAltura());
            float margenX = 24F;
            float margenY = 20F;
            float radio = Math.Clamp(Math.Min(area.Width / 40F, area.Height / (altura * 3.4F)), 9F, 16F);
            float altoDisponible = Math.Max(20F, area.Height - (margenY + radio) * 2F);
            float pasoVertical = altura > 1 ? Math.Min(64F, altoDisponible / (altura - 1)) : 0F;
            float altoTotal = (altura - 1) * pasoVertical;
            float yInicial = Math.Max(margenY + radio, (area.Height - altoTotal) / 2F);
            float anchoMaximo = Math.Min(area.Width - (margenX + radio) * 2F, Math.Max(240F, (float)Math.Pow(2, Math.Min(altura, 6)) * radio * 2.1F));
            float xInicio = (area.Width - anchoMaximo) / 2F;
            float xFin = xInicio + anchoMaximo;

            Dictionary<NodoABB, PointF> posiciones = new Dictionary<NodoABB, PointF>();
            CalcularPosiciones(arbol.Raiz, xInicio, xFin, yInicial, pasoVertical, 0, posiciones);

            using Pen lapizArista = new Pen(Color.FromArgb(120, 130, 145), 1.5F);
            using Pen lapizAristaRuta = new Pen(Color.FromArgb(217, 119, 6), 2.2F);
            DibujarAristas(g, arbol.Raiz, posiciones, rutaResaltada, lapizArista, lapizAristaRuta);

            float tamFuente = Math.Clamp(radio * 0.56F, 7F, 10F);
            using Font fuenteNodo = new Font("Segoe UI", tamFuente, FontStyle.Bold);
            DibujarNodos(g, arbol.Raiz, posiciones, radio, fuenteNodo, rutaResaltada, nodoEncontrado);
        }

        private static void CalcularPosiciones(
            NodoABB? nodo,
            float xMin,
            float xMax,
            float yInicial,
            float pasoVertical,
            int nivel,
            Dictionary<NodoABB, PointF> posiciones)
        {
            if (nodo == null)
            {
                return;
            }

            float x = (xMin + xMax) / 2F;
            float y = yInicial + nivel * pasoVertical;
            posiciones[nodo] = new PointF(x, y);

            CalcularPosiciones(nodo.Izquierdo, xMin, x, yInicial, pasoVertical, nivel + 1, posiciones);
            CalcularPosiciones(nodo.Derecho, x, xMax, yInicial, pasoVertical, nivel + 1, posiciones);
        }

        private static void DibujarAristas(
            Graphics g,
            NodoABB? nodo,
            Dictionary<NodoABB, PointF> posiciones,
            HashSet<int>? rutaResaltada,
            Pen lapizNormal,
            Pen lapizRuta)
        {
            if (nodo == null)
            {
                return;
            }

            PointF origen = posiciones[nodo];

            if (nodo.Izquierdo != null)
            {
                PointF destino = posiciones[nodo.Izquierdo];
                bool enRuta = rutaResaltada != null && rutaResaltada.Contains(nodo.Valor) && rutaResaltada.Contains(nodo.Izquierdo.Valor);
                g.DrawLine(enRuta ? lapizRuta : lapizNormal, origen, destino);
                DibujarAristas(g, nodo.Izquierdo, posiciones, rutaResaltada, lapizNormal, lapizRuta);
            }

            if (nodo.Derecho != null)
            {
                PointF destino = posiciones[nodo.Derecho];
                bool enRuta = rutaResaltada != null && rutaResaltada.Contains(nodo.Valor) && rutaResaltada.Contains(nodo.Derecho.Valor);
                g.DrawLine(enRuta ? lapizRuta : lapizNormal, origen, destino);
                DibujarAristas(g, nodo.Derecho, posiciones, rutaResaltada, lapizNormal, lapizRuta);
            }
        }

        private static void DibujarNodos(
            Graphics g,
            NodoABB? nodo,
            Dictionary<NodoABB, PointF> posiciones,
            float radio,
            Font fuente,
            HashSet<int>? rutaResaltada,
            int? nodoEncontrado)
        {
            if (nodo == null)
            {
                return;
            }

            PointF centro = posiciones[nodo];
            RectangleF rect = new RectangleF(centro.X - radio, centro.Y - radio, radio * 2F, radio * 2F);

            Color colorFondo = Color.FromArgb(37, 99, 235);
            Color colorBorde = Color.FromArgb(29, 78, 216);

            if (nodoEncontrado.HasValue && nodo.Valor == nodoEncontrado.Value)
            {
                colorFondo = Color.FromArgb(22, 163, 74);
                colorBorde = Color.FromArgb(21, 128, 61);
            }
            else if (rutaResaltada != null && rutaResaltada.Contains(nodo.Valor))
            {
                colorFondo = Color.FromArgb(217, 119, 6);
                colorBorde = Color.FromArgb(180, 83, 9);
            }

            using Brush pincelFondo = new SolidBrush(colorFondo);
            using Pen lapizBorde = new Pen(colorBorde, 2F);
            using Brush pincelTexto = new SolidBrush(Color.White);

            g.FillEllipse(pincelFondo, rect);
            g.DrawEllipse(lapizBorde, rect);

            StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(nodo.Valor.ToString(), fuente, pincelTexto, rect, formato);

            DibujarNodos(g, nodo.Izquierdo, posiciones, radio, fuente, rutaResaltada, nodoEncontrado);
            DibujarNodos(g, nodo.Derecho, posiciones, radio, fuente, rutaResaltada, nodoEncontrado);
        }
    }
}
