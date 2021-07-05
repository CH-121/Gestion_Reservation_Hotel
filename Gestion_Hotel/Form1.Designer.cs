namespace Gestion_Hotel
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
            this.ucHotel1 = new Gestion_Hotel.UC.ucHotel();
            this.SuspendLayout();
            // 
            // ucHotel1
            // 
            this.ucHotel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ucHotel1.Location = new System.Drawing.Point(12, 2);
            this.ucHotel1.Name = "ucHotel1";
            this.ucHotel1.Size = new System.Drawing.Size(705, 493);
            this.ucHotel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(734, 494);
            this.Controls.Add(this.ucHotel1);
            this.Name = "Form1";
            this.Text = "Hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucHotel ucHotel1;
    }
}

