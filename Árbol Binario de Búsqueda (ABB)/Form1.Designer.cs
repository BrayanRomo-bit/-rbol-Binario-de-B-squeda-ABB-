namespace Árbol_Binario_de_Búsqueda__ABB_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            flpControles = new FlowLayoutPanel();
            lblValor = new Label();
            txtValor = new TextBox();
            btnInsertar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnEjemplo = new Button();
            btnEjecutarPruebas = new Button();
            pbArbol = new PictureBox();
            tlpResultados = new TableLayoutPanel();
            lblPreorden = new Label();
            txtPreorden = new TextBox();
            lblInorden = new Label();
            txtInorden = new TextBox();
            lblPostorden = new Label();
            txtPostorden = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            tlpPrincipal.SuspendLayout();
            flpControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArbol).BeginInit();
            tlpResultados.SuspendLayout();
            SuspendLayout();

            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(flpControles, 0, 0);
            tlpPrincipal.Controls.Add(pbArbol, 0, 1);
            tlpPrincipal.Controls.Add(tlpResultados, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(10);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpPrincipal.Size = new Size(984, 621);
            tlpPrincipal.TabIndex = 0;

            flpControles.AutoSize = true;
            flpControles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpControles.Controls.Add(lblValor);
            flpControles.Controls.Add(txtValor);
            flpControles.Controls.Add(btnInsertar);
            flpControles.Controls.Add(btnBuscar);
            flpControles.Controls.Add(btnEliminar);
            flpControles.Controls.Add(btnLimpiar);
            flpControles.Controls.Add(btnEjemplo);
            flpControles.Controls.Add(btnEjecutarPruebas);
            flpControles.Dock = DockStyle.Fill;
            flpControles.Location = new Point(13, 13);
            flpControles.Name = "flpControles";
            flpControles.Padding = new Padding(0, 0, 0, 6);
            flpControles.Size = new Size(958, 41);
            flpControles.TabIndex = 0;

            lblValor.AutoSize = true;
            lblValor.Margin = new Padding(0, 8, 6, 3);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(42, 17);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor:";

            txtValor.Location = new Point(51, 4);
            txtValor.Margin = new Padding(3, 4, 8, 3);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 25);
            txtValor.TabIndex = 1;
            txtValor.KeyDown += txtValor_KeyDown;

            btnInsertar.AutoSize = true;
            btnInsertar.Location = new Point(162, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Padding = new Padding(8, 2, 8, 2);
            btnInsertar.Size = new Size(85, 29);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;

            btnBuscar.AutoSize = true;
            btnBuscar.Location = new Point(253, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(8, 2, 8, 2);
            btnBuscar.Size = new Size(80, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;

            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(339, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(8, 2, 8, 2);
            btnEliminar.Size = new Size(88, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;

            btnLimpiar.AutoSize = true;
            btnLimpiar.Location = new Point(433, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(8, 2, 8, 2);
            btnLimpiar.Size = new Size(83, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;

            btnEjemplo.AutoSize = true;
            btnEjemplo.Location = new Point(522, 3);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Padding = new Padding(8, 2, 8, 2);
            btnEjemplo.Size = new Size(124, 29);
            btnEjemplo.TabIndex = 6;
            btnEjemplo.Text = "Cargar Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = true;
            btnEjemplo.Click += btnEjemplo_Click;

            btnEjecutarPruebas.AutoSize = true;
            btnEjecutarPruebas.Location = new Point(652, 3);
            btnEjecutarPruebas.Name = "btnEjecutarPruebas";
            btnEjecutarPruebas.Padding = new Padding(8, 2, 8, 2);
            btnEjecutarPruebas.Size = new Size(134, 29);
            btnEjecutarPruebas.TabIndex = 7;
            btnEjecutarPruebas.Text = "Ejecutar Pruebas";
            btnEjecutarPruebas.UseVisualStyleBackColor = true;
            btnEjecutarPruebas.Click += btnEjecutarPruebas_Click;

            pbArbol.BackColor = Color.White;
            pbArbol.BorderStyle = BorderStyle.FixedSingle;
            pbArbol.Dock = DockStyle.Fill;
            pbArbol.Location = new Point(13, 60);
            pbArbol.Name = "pbArbol";
            pbArbol.Size = new Size(958, 351);
            pbArbol.TabIndex = 1;
            pbArbol.TabStop = false;
            pbArbol.Paint += pbArbol_Paint;
            pbArbol.Resize += pbArbol_Resize;

            tlpResultados.ColumnCount = 2;
            tlpResultados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpResultados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpResultados.Controls.Add(lblPreorden, 0, 0);
            tlpResultados.Controls.Add(txtPreorden, 1, 0);
            tlpResultados.Controls.Add(lblInorden, 0, 1);
            tlpResultados.Controls.Add(txtInorden, 1, 1);
            tlpResultados.Controls.Add(lblPostorden, 0, 2);
            tlpResultados.Controls.Add(txtPostorden, 1, 2);
            tlpResultados.Controls.Add(lblEstado, 0, 3);
            tlpResultados.Controls.Add(txtEstado, 1, 3);
            tlpResultados.Dock = DockStyle.Fill;
            tlpResultados.Location = new Point(13, 417);
            tlpResultados.Name = "tlpResultados";
            tlpResultados.Padding = new Padding(0, 6, 0, 0);
            tlpResultados.RowCount = 4;
            tlpResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpResultados.Size = new Size(958, 191);
            tlpResultados.TabIndex = 2;

            lblPreorden.Anchor = AnchorStyles.Left;
            lblPreorden.AutoSize = true;
            lblPreorden.Location = new Point(3, 20);
            lblPreorden.Name = "lblPreorden";
            lblPreorden.Size = new Size(71, 17);
            lblPreorden.TabIndex = 0;
            lblPreorden.Text = "Preorden:";

            txtPreorden.BackColor = SystemColors.Window;
            txtPreorden.Dock = DockStyle.Fill;
            txtPreorden.Location = new Point(103, 9);
            txtPreorden.Multiline = true;
            txtPreorden.Name = "txtPreorden";
            txtPreorden.ReadOnly = true;
            txtPreorden.ScrollBars = ScrollBars.Vertical;
            txtPreorden.Size = new Size(852, 40);
            txtPreorden.TabIndex = 1;

            lblInorden.Anchor = AnchorStyles.Left;
            lblInorden.AutoSize = true;
            lblInorden.Location = new Point(3, 66);
            lblInorden.Name = "lblInorden";
            lblInorden.Size = new Size(60, 17);
            lblInorden.TabIndex = 2;
            lblInorden.Text = "Inorden:";

            txtInorden.BackColor = SystemColors.Window;
            txtInorden.Dock = DockStyle.Fill;
            txtInorden.Location = new Point(103, 55);
            txtInorden.Multiline = true;
            txtInorden.Name = "txtInorden";
            txtInorden.ReadOnly = true;
            txtInorden.ScrollBars = ScrollBars.Vertical;
            txtInorden.Size = new Size(852, 40);
            txtInorden.TabIndex = 3;

            lblPostorden.Anchor = AnchorStyles.Left;
            lblPostorden.AutoSize = true;
            lblPostorden.Location = new Point(3, 112);
            lblPostorden.Name = "lblPostorden";
            lblPostorden.Size = new Size(77, 17);
            lblPostorden.TabIndex = 4;
            lblPostorden.Text = "Postorden:";

            txtPostorden.BackColor = SystemColors.Window;
            txtPostorden.Dock = DockStyle.Fill;
            txtPostorden.Location = new Point(103, 101);
            txtPostorden.Multiline = true;
            txtPostorden.Name = "txtPostorden";
            txtPostorden.ReadOnly = true;
            txtPostorden.ScrollBars = ScrollBars.Vertical;
            txtPostorden.Size = new Size(852, 40);
            txtPostorden.TabIndex = 5;

            lblEstado.Anchor = AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(3, 159);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 17);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";

            txtEstado.BackColor = SystemColors.Window;
            txtEstado.Dock = DockStyle.Fill;
            txtEstado.Location = new Point(103, 147);
            txtEstado.Multiline = true;
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.ScrollBars = ScrollBars.Vertical;
            txtEstado.Size = new Size(852, 41);
            txtEstado.TabIndex = 7;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 621);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(800, 540);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arbol Binario de Busqueda (ABB)";
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            flpControles.ResumeLayout(false);
            flpControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbArbol).EndInit();
            tlpResultados.ResumeLayout(false);
            tlpResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private FlowLayoutPanel flpControles;
        private Label lblValor;
        private TextBox txtValor;
        private Button btnInsertar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnEjemplo;
        private Button btnEjecutarPruebas;
        private PictureBox pbArbol;
        private TableLayoutPanel tlpResultados;
        private Label lblPreorden;
        private TextBox txtPreorden;
        private Label lblInorden;
        private TextBox txtInorden;
        private Label lblPostorden;
        private TextBox txtPostorden;
        private Label lblEstado;
        private TextBox txtEstado;
    }
}
