
namespace CapaVistaNomina
{
    partial class Departamentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombrepeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidDerechos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridDerechos = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDerechos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 86);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERECHOS PELI.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtnombrepeli);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtidDerechos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridDerechos);
            this.panel2.Location = new System.Drawing.Point(16, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 299);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 9;
            this.label4.Tag = "";
            this.label4.Text = "Estado Departamento";
            // 
            // txtnombrepeli
            // 
            this.txtnombrepeli.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtnombrepeli.Location = new System.Drawing.Point(21, 89);
            this.txtnombrepeli.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrepeli.Name = "txtnombrepeli";
            this.txtnombrepeli.Size = new System.Drawing.Size(255, 26);
            this.txtnombrepeli.TabIndex = 15;
            this.txtnombrepeli.Tag = "fkPelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Pelicula";
            // 
            // txtidDerechos
            // 
            this.txtidDerechos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtidDerechos.Location = new System.Drawing.Point(21, 30);
            this.txtidDerechos.Margin = new System.Windows.Forms.Padding(4);
            this.txtidDerechos.Name = "txtidDerechos";
            this.txtidDerechos.Size = new System.Drawing.Size(255, 26);
            this.txtidDerechos.TabIndex = 5;
            this.txtidDerechos.Tag = "idDerechos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Derechos";
            // 
            // dataGridDerechos
            // 
            this.dataGridDerechos.AllowUserToAddRows = false;
            this.dataGridDerechos.AllowUserToDeleteRows = false;
            this.dataGridDerechos.AllowUserToResizeColumns = false;
            this.dataGridDerechos.AllowUserToResizeRows = false;
            this.dataGridDerechos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDerechos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDerechos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDerechos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDerechos.Location = new System.Drawing.Point(320, 20);
            this.dataGridDerechos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDerechos.MultiSelect = false;
            this.dataGridDerechos.Name = "dataGridDerechos";
            this.dataGridDerechos.ReadOnly = true;
            this.dataGridDerechos.RowHeadersVisible = false;
            this.dataGridDerechos.RowHeadersWidth = 51;
            this.dataGridDerechos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDerechos.ShowEditingIcon = false;
            this.dataGridDerechos.Size = new System.Drawing.Size(617, 270);
            this.dataGridDerechos.TabIndex = 0;
            this.dataGridDerechos.Tag = "derechos";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(101, 94);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 598);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDerechos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombrepeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidDerechos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridDerechos;
        private NavegadorVista.Navegador navegador1;
    }
}