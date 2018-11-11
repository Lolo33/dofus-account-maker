namespace DCA_App
{
    partial class FormAccueil
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
            this.btnLaunchRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunchRequest
            // 
            this.btnLaunchRequest.Location = new System.Drawing.Point(12, 12);
            this.btnLaunchRequest.Name = "btnLaunchRequest";
            this.btnLaunchRequest.Size = new System.Drawing.Size(258, 66);
            this.btnLaunchRequest.TabIndex = 0;
            this.btnLaunchRequest.Text = "Lancer une requete";
            this.btnLaunchRequest.UseVisualStyleBackColor = true;
            this.btnLaunchRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnLaunchRequest);
            this.Name = "FormAccueil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchRequest;
    }
}

