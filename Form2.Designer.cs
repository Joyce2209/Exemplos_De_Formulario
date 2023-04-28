
namespace Atividade2804
{
    partial class frmDinner
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblMistura = new System.Windows.Forms.Label();
            this.lblSalada = new System.Windows.Forms.Label();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.cboComida = new System.Windows.Forms.ComboBox();
            this.cboMistura = new System.Windows.Forms.ComboBox();
            this.cboSalada = new System.Windows.Forms.ComboBox();
            this.cboSobremesa = new System.Windows.Forms.ComboBox();
            this.lblSobremesa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(12, 54);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(42, 13);
            this.lblComida.TabIndex = 1;
            this.lblComida.Text = "Comida";
            // 
            // lblMistura
            // 
            this.lblMistura.AutoSize = true;
            this.lblMistura.Location = new System.Drawing.Point(207, 54);
            this.lblMistura.Name = "lblMistura";
            this.lblMistura.Size = new System.Drawing.Size(41, 13);
            this.lblMistura.TabIndex = 2;
            this.lblMistura.Text = "Mistura";
            // 
            // lblSalada
            // 
            this.lblSalada.AutoSize = true;
            this.lblSalada.Location = new System.Drawing.Point(405, 54);
            this.lblSalada.Name = "lblSalada";
            this.lblSalada.Size = new System.Drawing.Size(40, 13);
            this.lblSalada.TabIndex = 3;
            this.lblSalada.Text = "Salada";
            // 
            // txtDinner
            // 
            this.txtDinner.Location = new System.Drawing.Point(73, 320);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.ReadOnly = true;
            this.txtDinner.Size = new System.Drawing.Size(673, 20);
            this.txtDinner.TabIndex = 4;
            // 
            // cboComida
            // 
            this.cboComida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboComida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboComida.FormattingEnabled = true;
            this.cboComida.Items.AddRange(new object[] {
            "Arroz",
            "Arroz e Feijão",
            "Feijão",
            "Macarrão"});
            this.cboComida.Location = new System.Drawing.Point(12, 99);
            this.cboComida.Name = "cboComida";
            this.cboComida.Size = new System.Drawing.Size(121, 21);
            this.cboComida.Sorted = true;
            this.cboComida.TabIndex = 5;
            this.cboComida.SelectedIndexChanged += new System.EventHandler(this.cboComida_SelectedIndexChanged);
            // 
            // cboMistura
            // 
            this.cboMistura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboMistura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMistura.FormattingEnabled = true;
            this.cboMistura.Items.AddRange(new object[] {
            "Bife à Milanesa",
            "Bisteca de Porco",
            "Calabresa Acebolada",
            "Filé de Frango Grelhado",
            "Frango Assado",
            "Ovo",
            "Peixe Frito"});
            this.cboMistura.Location = new System.Drawing.Point(210, 99);
            this.cboMistura.Name = "cboMistura";
            this.cboMistura.Size = new System.Drawing.Size(121, 21);
            this.cboMistura.Sorted = true;
            this.cboMistura.TabIndex = 6;
            this.cboMistura.SelectedIndexChanged += new System.EventHandler(this.cboMistura_SelectedIndexChanged);
            // 
            // cboSalada
            // 
            this.cboSalada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSalada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSalada.FormattingEnabled = true;
            this.cboSalada.Items.AddRange(new object[] {
            "Agrião",
            "Alface",
            "Brócolis",
            "Couve-Flor",
            "Pepino",
            "Rúcula",
            "Tomate"});
            this.cboSalada.Location = new System.Drawing.Point(408, 99);
            this.cboSalada.Name = "cboSalada";
            this.cboSalada.Size = new System.Drawing.Size(121, 21);
            this.cboSalada.Sorted = true;
            this.cboSalada.TabIndex = 7;
            this.cboSalada.SelectedIndexChanged += new System.EventHandler(this.cboSalada_SelectedIndexChanged);
            // 
            // cboSobremesa
            // 
            this.cboSobremesa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSobremesa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSobremesa.FormattingEnabled = true;
            this.cboSobremesa.Items.AddRange(new object[] {
            "Arroz-Doce",
            "Bolo de Chocolate",
            "Mousse de Maracujá",
            "Salada de Frutas",
            "Sorvete de Creme",
            "Torta de Banana",
            "Torta de Maçã"});
            this.cboSobremesa.Location = new System.Drawing.Point(571, 99);
            this.cboSobremesa.Name = "cboSobremesa";
            this.cboSobremesa.Size = new System.Drawing.Size(121, 21);
            this.cboSobremesa.Sorted = true;
            this.cboSobremesa.TabIndex = 9;
            this.cboSobremesa.SelectedIndexChanged += new System.EventHandler(this.cboSobremesa_SelectedIndexChanged);
            // 
            // lblSobremesa
            // 
            this.lblSobremesa.AutoSize = true;
            this.lblSobremesa.Location = new System.Drawing.Point(568, 54);
            this.lblSobremesa.Name = "lblSobremesa";
            this.lblSobremesa.Size = new System.Drawing.Size(60, 13);
            this.lblSobremesa.TabIndex = 8;
            this.lblSobremesa.Text = "Sobremesa";
            // 
            // frmDinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboSobremesa);
            this.Controls.Add(this.lblSobremesa);
            this.Controls.Add(this.cboSalada);
            this.Controls.Add(this.cboMistura);
            this.Controls.Add(this.cboComida);
            this.Controls.Add(this.txtDinner);
            this.Controls.Add(this.lblSalada);
            this.Controls.Add(this.lblMistura);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDinner";
            this.Text = "O Programa Refeição";
            this.Load += new System.EventHandler(this.frmDinner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblMistura;
        private System.Windows.Forms.Label lblSalada;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.ComboBox cboComida;
        private System.Windows.Forms.ComboBox cboMistura;
        private System.Windows.Forms.ComboBox cboSalada;
        private System.Windows.Forms.ComboBox cboSobremesa;
        private System.Windows.Forms.Label lblSobremesa;
    }
}