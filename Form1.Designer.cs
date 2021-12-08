namespace Boleteria_Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtLimInferior = new System.Windows.Forms.TextBox();
            this.txtLimSuperior = new System.Windows.Forms.TextBox();
            this.txtDesviacion1 = new System.Windows.Forms.TextBox();
            this.txtMedia1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesviacion2 = new System.Windows.Forms.TextBox();
            this.txtMedia2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(683, 126);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(100, 31);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtLimInferior
            // 
            this.txtLimInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimInferior.Location = new System.Drawing.Point(45, 30);
            this.txtLimInferior.Name = "txtLimInferior";
            this.txtLimInferior.Size = new System.Drawing.Size(125, 26);
            this.txtLimInferior.TabIndex = 3;
            this.txtLimInferior.Text = "8";
            // 
            // txtLimSuperior
            // 
            this.txtLimSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimSuperior.Location = new System.Drawing.Point(45, 59);
            this.txtLimSuperior.Name = "txtLimSuperior";
            this.txtLimSuperior.Size = new System.Drawing.Size(125, 26);
            this.txtLimSuperior.TabIndex = 4;
            this.txtLimSuperior.Text = "12";
            // 
            // txtDesviacion1
            // 
            this.txtDesviacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacion1.Location = new System.Drawing.Point(240, 59);
            this.txtDesviacion1.Name = "txtDesviacion1";
            this.txtDesviacion1.Size = new System.Drawing.Size(125, 26);
            this.txtDesviacion1.TabIndex = 8;
            this.txtDesviacion1.Text = "4";
            // 
            // txtMedia1
            // 
            this.txtMedia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia1.Location = new System.Drawing.Point(240, 30);
            this.txtMedia1.Name = "txtMedia1";
            this.txtMedia1.Size = new System.Drawing.Size(125, 26);
            this.txtMedia1.TabIndex = 7;
            this.txtMedia1.Text = "11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "σ1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "μ1:";
            // 
            // txtDesviacion2
            // 
            this.txtDesviacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacion2.Location = new System.Drawing.Point(429, 59);
            this.txtDesviacion2.Name = "txtDesviacion2";
            this.txtDesviacion2.Size = new System.Drawing.Size(125, 26);
            this.txtDesviacion2.TabIndex = 12;
            this.txtDesviacion2.Text = "6";
            // 
            // txtMedia2
            // 
            this.txtMedia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia2.Location = new System.Drawing.Point(429, 30);
            this.txtMedia2.Name = "txtMedia2";
            this.txtMedia2.Size = new System.Drawing.Size(125, 26);
            this.txtMedia2.TabIndex = 11;
            this.txtMedia2.Text = "9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "σ2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "μ2:";
            // 
            // grdResultados
            // 
            this.grdResultados.AllowUserToAddRows = false;
            this.grdResultados.AllowUserToDeleteRows = false;
            this.grdResultados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Location = new System.Drawing.Point(16, 185);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.ReadOnly = true;
            this.grdResultados.Size = new System.Drawing.Size(767, 324);
            this.grdResultados.TabIndex = 13;
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(658, 59);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(125, 26);
            this.txtHasta.TabIndex = 17;
            this.txtHasta.Text = "250";
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(658, 30);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(125, 26);
            this.txtDesde.TabIndex = 16;
            this.txtDesde.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desde:";
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(16, 132);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(203, 21);
            this.combo.TabIndex = 18;
            this.combo.SelectedValueChanged += new System.EventHandler(this.combo_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(12, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Limite de simulación:";
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadClientes.Location = new System.Drawing.Point(323, 130);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.Size = new System.Drawing.Size(125, 26);
            this.txtCantidadClientes.TabIndex = 21;
            this.txtCantidadClientes.Text = "120";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(236, 133);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(79, 20);
            this.lblClientes.TabIndex = 20;
            this.lblClientes.Text = "Clientes:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(541, 130);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(125, 26);
            this.txtTiempo.TabIndex = 23;
            this.txtTiempo.Text = "1000";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(463, 133);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(72, 20);
            this.lblTiempo.TabIndex = 22;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtCantidadClientes);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grdResultados);
            this.Controls.Add(this.txtDesviacion2);
            this.Controls.Add(this.txtMedia2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesviacion1);
            this.Controls.Add(this.txtMedia1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLimSuperior);
            this.Controls.Add(this.txtLimInferior);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleteria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtLimInferior;
        private System.Windows.Forms.TextBox txtLimSuperior;
        private System.Windows.Forms.TextBox txtDesviacion1;
        private System.Windows.Forms.TextBox txtMedia1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesviacion2;
        private System.Windows.Forms.TextBox txtMedia2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempo;
    }
}

