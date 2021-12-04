namespace GeneradorAleatorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblx0 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.NumericUpDown();
            this.txtX1 = new System.Windows.Forms.NumericUpDown();
            this.txtCant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblx0
            // 
            resources.ApplyResources(this.lblx0, "lblx0");
            this.lblx0.Name = "lblx0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblx1
            // 
            resources.ApplyResources(this.lblx1, "lblx1");
            this.lblx1.Name = "lblx1";
            // 
            // txtX0
            // 
            resources.ApplyResources(this.txtX0, "txtX0");
            this.txtX0.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.txtX0.Name = "txtX0";
            // 
            // txtX1
            // 
            resources.ApplyResources(this.txtX1, "txtX1");
            this.txtX1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.txtX1.Name = "txtX1";
            // 
            // txtCant
            // 
            resources.ApplyResources(this.txtCant, "txtCant");
            this.txtCant.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.txtCant.Name = "txtCant";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.lblx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblx0);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblx0;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label lblx1;
        private NumericUpDown txtX0;
        private NumericUpDown txtX1;
        private NumericUpDown txtCant;
        private Label label1;
    }
}