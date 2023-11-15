namespace S14LLab14_u202010338
{
    partial class FormAutos
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbNAsientos = new System.Windows.Forms.ComboBox();
            this.txtFabYear = new System.Windows.Forms.TextBox();
            this.dgvListaAutos = new System.Windows.Forms.DataGridView();
            this.cbIDOficina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarListaCompleta = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtMarcaFiltro = new System.Windows.Forms.TextBox();
            this.txtFabYearFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 274);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(227, 29);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(227, 29);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(227, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(12, 54);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(42, 16);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Location = new System.Drawing.Point(12, 25);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(83, 16);
            this.lblOficina.TabIndex = 4;
            this.lblOficina.Text = "ID de Oficina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número de Asientos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año de Fabricación";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(71, 51);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(168, 22);
            this.txtPlaca.TabIndex = 10;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(71, 79);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(168, 22);
            this.txtMarca.TabIndex = 11;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(71, 107);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(168, 22);
            this.txtModelo.TabIndex = 12;
            // 
            // cbNAsientos
            // 
            this.cbNAsientos.FormattingEnabled = true;
            this.cbNAsientos.Location = new System.Drawing.Point(147, 137);
            this.cbNAsientos.Name = "cbNAsientos";
            this.cbNAsientos.Size = new System.Drawing.Size(92, 24);
            this.cbNAsientos.TabIndex = 13;
            // 
            // txtFabYear
            // 
            this.txtFabYear.Location = new System.Drawing.Point(147, 171);
            this.txtFabYear.Name = "txtFabYear";
            this.txtFabYear.Size = new System.Drawing.Size(92, 22);
            this.txtFabYear.TabIndex = 14;
            // 
            // dgvListaAutos
            // 
            this.dgvListaAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAutos.Location = new System.Drawing.Point(269, 111);
            this.dgvListaAutos.Name = "dgvListaAutos";
            this.dgvListaAutos.RowHeadersWidth = 51;
            this.dgvListaAutos.RowTemplate.Height = 24;
            this.dgvListaAutos.Size = new System.Drawing.Size(894, 438);
            this.dgvListaAutos.TabIndex = 15;
            this.dgvListaAutos.DoubleClick += new System.EventHandler(this.dgvListaAutos_DoubleClick);
            // 
            // cbIDOficina
            // 
            this.cbIDOficina.FormattingEnabled = true;
            this.cbIDOficina.Location = new System.Drawing.Point(101, 21);
            this.cbIDOficina.Name = "cbIDOficina";
            this.cbIDOficina.Size = new System.Drawing.Size(138, 24);
            this.cbIDOficina.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filtrar Lista de Autos por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Año de Fabricación";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(967, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(181, 29);
            this.btnFiltrar.TabIndex = 22;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarListaCompleta
            // 
            this.btnMostrarListaCompleta.Location = new System.Drawing.Point(967, 54);
            this.btnMostrarListaCompleta.Name = "btnMostrarListaCompleta";
            this.btnMostrarListaCompleta.Size = new System.Drawing.Size(181, 29);
            this.btnMostrarListaCompleta.TabIndex = 23;
            this.btnMostrarListaCompleta.Text = "Mostrar Lista Completa";
            this.btnMostrarListaCompleta.UseVisualStyleBackColor = true;
            this.btnMostrarListaCompleta.Click += new System.EventHandler(this.btnMostrarListaCompleta_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 309);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(227, 29);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtMarcaFiltro
            // 
            this.txtMarcaFiltro.Location = new System.Drawing.Point(490, 18);
            this.txtMarcaFiltro.Name = "txtMarcaFiltro";
            this.txtMarcaFiltro.Size = new System.Drawing.Size(168, 22);
            this.txtMarcaFiltro.TabIndex = 25;
            // 
            // txtFabYearFiltro
            // 
            this.txtFabYearFiltro.Location = new System.Drawing.Point(836, 18);
            this.txtFabYearFiltro.Name = "txtFabYearFiltro";
            this.txtFabYearFiltro.Size = new System.Drawing.Size(91, 22);
            this.txtFabYearFiltro.TabIndex = 26;
            // 
            // FormAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 561);
            this.Controls.Add(this.txtFabYearFiltro);
            this.Controls.Add(this.txtMarcaFiltro);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnMostrarListaCompleta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbIDOficina);
            this.Controls.Add(this.dgvListaAutos);
            this.Controls.Add(this.txtFabYear);
            this.Controls.Add(this.cbNAsientos);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FormAutos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbNAsientos;
        private System.Windows.Forms.TextBox txtFabYear;
        private System.Windows.Forms.DataGridView dgvListaAutos;
        private System.Windows.Forms.ComboBox cbIDOficina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarListaCompleta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtMarcaFiltro;
        private System.Windows.Forms.TextBox txtFabYearFiltro;
    }
}

