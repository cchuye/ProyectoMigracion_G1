﻿
namespace CapaVistaERP.Mantenimientos
{
    partial class frmProductos
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
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.txt_descripProducto = new System.Windows.Forms.TextBox();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_MarcaProd = new System.Windows.Forms.ComboBox();
            this.cb_LineaProd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(641, 210);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(168, 22);
            this.txt_precioUnitario.TabIndex = 48;
            this.txt_precioUnitario.Tag = "precioUnitario_prod";
            // 
            // txt_descripProducto
            // 
            this.txt_descripProducto.Location = new System.Drawing.Point(640, 268);
            this.txt_descripProducto.Name = "txt_descripProducto";
            this.txt_descripProducto.Size = new System.Drawing.Size(251, 22);
            this.txt_descripProducto.TabIndex = 47;
            this.txt_descripProducto.Tag = "descripcion_prod";
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.Location = new System.Drawing.Point(232, 263);
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(185, 22);
            this.txt_nombreProducto.TabIndex = 44;
            this.txt_nombreProducto.Tag = "nombre_prod";
            // 
            // txt_codigoProducto
            // 
            this.txt_codigoProducto.Location = new System.Drawing.Point(232, 210);
            this.txt_codigoProducto.Name = "txt_codigoProducto";
            this.txt_codigoProducto.Size = new System.Drawing.Size(185, 22);
            this.txt_codigoProducto.TabIndex = 43;
            this.txt_codigoProducto.Tag = "cod_producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(512, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label6.Location = new System.Drawing.Point(488, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Precio Unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label5.Location = new System.Drawing.Point(160, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Línea:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(154, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(141, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(148, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Código:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 195);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Tag = "tbl_producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(413, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "PRODUCTOS";
            // 
            // cb_MarcaProd
            // 
            this.cb_MarcaProd.FormattingEnabled = true;
            this.cb_MarcaProd.Location = new System.Drawing.Point(232, 319);
            this.cb_MarcaProd.Name = "cb_MarcaProd";
            this.cb_MarcaProd.Size = new System.Drawing.Size(185, 24);
            this.cb_MarcaProd.TabIndex = 52;
            this.cb_MarcaProd.SelectedIndexChanged += new System.EventHandler(this.cb_MarcaProd_SelectedIndexChanged);
            // 
            // cb_LineaProd
            // 
            this.cb_LineaProd.FormattingEnabled = true;
            this.cb_LineaProd.Location = new System.Drawing.Point(232, 376);
            this.cb_LineaProd.Name = "cb_LineaProd";
            this.cb_LineaProd.Size = new System.Drawing.Size(185, 24);
            this.cb_LineaProd.TabIndex = 53;
            this.cb_LineaProd.SelectedIndexChanged += new System.EventHandler(this.cb_LineaProd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label9.Location = new System.Drawing.Point(488, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 54;
            this.label9.Text = "Fecha Registro:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(874, 421);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 56;
            this.textBox2.Tag = "tbl_marca_id_marca";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(874, 393);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 22);
            this.textBox3.TabIndex = 57;
            this.textBox3.Tag = "tbl_linea_id_linea";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 321);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker1.TabIndex = 68;
            this.dateTimePicker1.Tag = "fecha_registro";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 69;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 665);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_LineaProd);
            this.Controls.Add(this.cb_MarcaProd);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.txt_descripProducto);
            this.Controls.Add(this.txt_nombreProducto);
            this.Controls.Add(this.txt_codigoProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.TextBox txt_descripProducto;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.TextBox txt_codigoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MarcaProd;
        private System.Windows.Forms.ComboBox cb_LineaProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CapaVista.Navegador navegador1;
    }
}