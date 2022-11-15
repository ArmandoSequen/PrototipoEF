
namespace CapaVistaNomina
{
    partial class TrabajadoresInfo
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
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomcine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDcine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCine = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CINES";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.txtdireccion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtnomcine);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIDcine);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridCine);
            this.panel2.Location = new System.Drawing.Point(43, 295);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 415);
            this.panel2.TabIndex = 0;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtdireccion.Location = new System.Drawing.Point(29, 264);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(255, 26);
            this.txtdireccion.TabIndex = 14;
            this.txtdireccion.Tag = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(29, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 9;
            this.label4.Tag = "";
            this.label4.Text = "Direccion";
            // 
            // txtnomcine
            // 
            this.txtnomcine.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtnomcine.Location = new System.Drawing.Point(29, 205);
            this.txtnomcine.Margin = new System.Windows.Forms.Padding(4);
            this.txtnomcine.Name = "txtnomcine";
            this.txtnomcine.Size = new System.Drawing.Size(255, 26);
            this.txtnomcine.TabIndex = 15;
            this.txtnomcine.Tag = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // txtIDcine
            // 
            this.txtIDcine.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtIDcine.Location = new System.Drawing.Point(29, 146);
            this.txtIDcine.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDcine.Name = "txtIDcine";
            this.txtIDcine.Size = new System.Drawing.Size(255, 26);
            this.txtIDcine.TabIndex = 5;
            this.txtIDcine.Tag = "idCines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Cine";
            // 
            // dataGridCine
            // 
            this.dataGridCine.AllowUserToAddRows = false;
            this.dataGridCine.AllowUserToDeleteRows = false;
            this.dataGridCine.AllowUserToResizeColumns = false;
            this.dataGridCine.AllowUserToResizeRows = false;
            this.dataGridCine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCine.Location = new System.Drawing.Point(320, 20);
            this.dataGridCine.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCine.MultiSelect = false;
            this.dataGridCine.Name = "dataGridCine";
            this.dataGridCine.ReadOnly = true;
            this.dataGridCine.RowHeadersVisible = false;
            this.dataGridCine.RowHeadersWidth = 51;
            this.dataGridCine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCine.ShowEditingIcon = false;
            this.dataGridCine.Size = new System.Drawing.Size(619, 385);
            this.dataGridCine.TabIndex = 0;
            this.dataGridCine.Tag = "cines";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(139, 98);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // TrabajadoresInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 719);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrabajadoresInfo";
            this.Text = "TrabajadoresInfo";
            this.Load += new System.EventHandler(this.TrabajadoresInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridCine;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomcine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDcine;
        private System.Windows.Forms.Label label2;
        private NavegadorVista.Navegador navegador1;
    }
}