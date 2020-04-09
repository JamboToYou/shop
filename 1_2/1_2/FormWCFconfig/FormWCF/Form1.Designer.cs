namespace FormWCF
{
    partial class WCF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSelectView = new System.Windows.Forms.DataGridView();
            this.lblCounter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectView
            // 
            this.dgvSelectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectView.Location = new System.Drawing.Point(12, 12);
            this.dgvSelectView.Name = "dgvSelectView";
            this.dgvSelectView.Size = new System.Drawing.Size(245, 138);
            this.dgvSelectView.TabIndex = 6;
            this.dgvSelectView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectView_CellContentClick);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.Location = new System.Drawing.Point(263, 133);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(92, 17);
            this.lblCounter.TabIndex = 14;
            this.lblCounter.Text = "0 вызовов(а)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(287, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "да";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Асинхронно";
            // 
            // btnSelectClients
            // 
            this.btnSelectClients.Location = new System.Drawing.Point(263, 12);
            this.btnSelectClients.Name = "btnSelectClients";
            this.btnSelectClients.Size = new System.Drawing.Size(92, 84);
            this.btnSelectClients.TabIndex = 5;
            this.btnSelectClients.Text = "Получить клиентов";
            this.btnSelectClients.UseVisualStyleBackColor = true;
            this.btnSelectClients.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // WCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.dgvSelectView);
            this.Controls.Add(this.btnSelectClients);
            this.Name = "WCF";
            this.Text = "WCF";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSelectView;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectClients;
    }
}

