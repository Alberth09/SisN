namespace PresentaciónSYSN
{
    partial class FMProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgP = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblP_Compra = new System.Windows.Forms.Label();
            this.lblP_Venta = new System.Windows.Forms.Label();
            this.txtP_Compra = new System.Windows.Forms.TextBox();
            this.txtP_Venta = new System.Windows.Forms.TextBox();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgP
            // 
            this.dtgP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgP.Location = new System.Drawing.Point(14, 256);
            this.dtgP.Name = "dtgP";
            this.dtgP.Size = new System.Drawing.Size(576, 177);
            this.dtgP.TabIndex = 21;
            this.dtgP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgP_CellClick);
            this.dtgP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgP_CellEnter);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(179, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(433, 132);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(129, 20);
            this.txtTipo.TabIndex = 19;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(116, 104);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(192, 20);
            this.txtProducto.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 20);
            this.txtID.TabIndex = 17;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(379, 132);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 18);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(98, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 31);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(31, 106);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 18);
            this.lblProducto.TabIndex = 14;
            this.lblProducto.Text = "Producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.IndianRed;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(17, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(59, 79);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // lblP_Compra
            // 
            this.lblP_Compra.AutoSize = true;
            this.lblP_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_Compra.Location = new System.Drawing.Point(14, 132);
            this.lblP_Compra.Name = "lblP_Compra";
            this.lblP_Compra.Size = new System.Drawing.Size(96, 18);
            this.lblP_Compra.TabIndex = 22;
            this.lblP_Compra.Text = "P de Compra";
            // 
            // lblP_Venta
            // 
            this.lblP_Venta.AutoSize = true;
            this.lblP_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_Venta.Location = new System.Drawing.Point(31, 156);
            this.lblP_Venta.Name = "lblP_Venta";
            this.lblP_Venta.Size = new System.Drawing.Size(79, 18);
            this.lblP_Venta.TabIndex = 23;
            this.lblP_Venta.Text = "P de Venta";
            // 
            // txtP_Compra
            // 
            this.txtP_Compra.Location = new System.Drawing.Point(116, 130);
            this.txtP_Compra.Name = "txtP_Compra";
            this.txtP_Compra.Size = new System.Drawing.Size(192, 20);
            this.txtP_Compra.TabIndex = 24;
            // 
            // txtP_Venta
            // 
            this.txtP_Venta.Location = new System.Drawing.Point(116, 156);
            this.txtP_Venta.Name = "txtP_Venta";
            this.txtP_Venta.Size = new System.Drawing.Size(192, 20);
            this.txtP_Venta.TabIndex = 25;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(370, 80);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(57, 18);
            this.lblMinimo.TabIndex = 26;
            this.lblMinimo.Text = "Minimo";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(366, 106);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(61, 18);
            this.lblMaximo.TabIndex = 27;
            this.lblMaximo.Text = "Maximo";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(433, 106);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(129, 20);
            this.txtMaximo.TabIndex = 28;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(433, 80);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(129, 20);
            this.txtMinimo.TabIndex = 29;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.IndianRed;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Location = new System.Drawing.Point(501, 204);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(89, 31);
            this.btnDescargar.TabIndex = 30;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(357, 211);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(138, 20);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(232, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Buscar";
            // 
            // FMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.txtP_Venta);
            this.Controls.Add(this.txtP_Compra);
            this.Controls.Add(this.lblP_Venta);
            this.Controls.Add(this.lblP_Compra);
            this.Controls.Add(this.dtgP);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblID);
            this.Name = "FMProducto";
            this.Text = "FMProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgP;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblP_Compra;
        private System.Windows.Forms.Label lblP_Venta;
        private System.Windows.Forms.TextBox txtP_Compra;
        private System.Windows.Forms.TextBox txtP_Venta;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}