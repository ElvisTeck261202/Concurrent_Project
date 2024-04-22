namespace Project
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
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gif1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DGVCharacters = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ThreadStop = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.ThreadStop2 = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.SemaphoreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gif1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TASK 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(77, 102);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(164, 20);
            this.PathTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 210);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(344, 313);
            this.DataGridView1.TabIndex = 4;
            // 
            // ImageButton
            // 
            this.ImageButton.Location = new System.Drawing.Point(499, 141);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(75, 23);
            this.ImageButton.TabIndex = 8;
            this.ImageButton.Text = "Show";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ImagePath
            // 
            this.ImagePath.Location = new System.Drawing.Point(499, 105);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(164, 20);
            this.ImagePath.TabIndex = 6;
            this.ImagePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "TASK 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Gif1
            // 
            this.Gif1.Location = new System.Drawing.Point(418, 210);
            this.Gif1.Name = "Gif1";
            this.Gif1.Size = new System.Drawing.Size(381, 313);
            this.Gif1.TabIndex = 9;
            this.Gif1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1026, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "TASK 3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1004, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Obtain Characters";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DGVCharacters
            // 
            this.DGVCharacters.AllowUserToAddRows = false;
            this.DGVCharacters.AllowUserToDeleteRows = false;
            this.DGVCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Gender,
            this.Species,
            this.Origin});
            this.DGVCharacters.Location = new System.Drawing.Point(884, 210);
            this.DGVCharacters.Name = "DGVCharacters";
            this.DGVCharacters.ReadOnly = true;
            this.DGVCharacters.Size = new System.Drawing.Size(358, 313);
            this.DGVCharacters.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Species
            // 
            this.Species.HeaderText = "Species";
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 177);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // ThreadStop
            // 
            this.ThreadStop.Location = new System.Drawing.Point(166, 141);
            this.ThreadStop.Name = "ThreadStop";
            this.ThreadStop.Size = new System.Drawing.Size(75, 23);
            this.ThreadStop.TabIndex = 14;
            this.ThreadStop.Text = "Stop";
            this.ThreadStop.UseVisualStyleBackColor = true;
            this.ThreadStop.Click += new System.EventHandler(this.ThreadStop_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(418, 177);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(381, 23);
            this.progressBar2.TabIndex = 15;
            // 
            // ThreadStop2
            // 
            this.ThreadStop2.Location = new System.Drawing.Point(588, 141);
            this.ThreadStop2.Name = "ThreadStop2";
            this.ThreadStop2.Size = new System.Drawing.Size(75, 23);
            this.ThreadStop2.TabIndex = 16;
            this.ThreadStop2.Text = "Stop";
            this.ThreadStop2.UseVisualStyleBackColor = true;
            this.ThreadStop2.Click += new System.EventHandler(this.ThreadStop2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(884, 177);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(358, 23);
            this.progressBar3.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(323, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 51);
            this.button3.TabIndex = 18;
            this.button3.Text = "3 in 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SemaphoreBtn
            // 
            this.SemaphoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemaphoreBtn.Location = new System.Drawing.Point(603, 12);
            this.SemaphoreBtn.Name = "SemaphoreBtn";
            this.SemaphoreBtn.Size = new System.Drawing.Size(251, 51);
            this.SemaphoreBtn.TabIndex = 19;
            this.SemaphoreBtn.Text = "Semaphores";
            this.SemaphoreBtn.UseVisualStyleBackColor = true;
            this.SemaphoreBtn.Click += new System.EventHandler(this.SemaphoreBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 535);
            this.Controls.Add(this.SemaphoreBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.ThreadStop2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.ThreadStop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DGVCharacters);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gif1);
            this.Controls.Add(this.ImageButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gif1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImagePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Gif1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGVCharacters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ThreadStop;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button ThreadStop2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SemaphoreBtn;
    }
}

