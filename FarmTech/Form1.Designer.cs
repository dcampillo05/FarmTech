namespace FarmTech
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnQuery = new System.Windows.Forms.Button();
            btnTest = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(68, 266);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 51);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(206, 266);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(121, 51);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(344, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(121, 51);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuery
            // 
            btnQuery.Location = new System.Drawing.Point(485, 266);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new System.Drawing.Size(121, 51);
            btnQuery.TabIndex = 3;
            btnQuery.Text = "Consulta";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new System.Drawing.Point(622, 266);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(121, 51);
            btnTest.TabIndex = 4;
            btnTest.Text = "Teste";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(btnTest);
            Controls.Add(btnQuery);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnTest;
    }
}

