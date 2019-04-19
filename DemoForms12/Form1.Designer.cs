namespace DemoForms12
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFichier = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.lstProprietes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFichier
            // 
            this.txtFichier.Location = new System.Drawing.Point(57, 43);
            this.txtFichier.Name = "txtFichier";
            this.txtFichier.Size = new System.Drawing.Size(397, 20);
            this.txtFichier.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(656, 39);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Parcourir";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lstClasses
            // 
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.Location = new System.Drawing.Point(57, 115);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(397, 173);
            this.lstClasses.TabIndex = 2;
            this.lstClasses.SelectedIndexChanged += new System.EventHandler(this.lstClasses_SelectedIndexChanged);
            // 
            // lstProprietes
            // 
            this.lstProprietes.FormattingEnabled = true;
            this.lstProprietes.Location = new System.Drawing.Point(57, 300);
            this.lstProprietes.Name = "lstProprietes";
            this.lstProprietes.Size = new System.Drawing.Size(397, 212);
            this.lstProprietes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.lstProprietes);
            this.Controls.Add(this.lstClasses);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtFichier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFichier;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.ListBox lstProprietes;
    }
}

