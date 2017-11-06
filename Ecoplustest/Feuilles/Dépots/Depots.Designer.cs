namespace Ecoplustest.Feuilles
{
    partial class Depots
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add.Location = new System.Drawing.Point(78, 343);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 38);
            this.add.TabIndex = 1;
            this.add.Text = "Nouveau";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.update.Location = new System.Drawing.Point(169, 343);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 38);
            this.update.TabIndex = 2;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delete.Location = new System.Drawing.Point(260, 343);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 38);
            this.delete.TabIndex = 3;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.close.Location = new System.Drawing.Point(351, 343);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 38);
            this.close.TabIndex = 4;
            this.close.Text = "Fermer";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Depots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 408);
            this.Controls.Add(this.close);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Depots";
            this.Text = "Depots";
            this.Load += new System.EventHandler(this.Depots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button close;
    }
}