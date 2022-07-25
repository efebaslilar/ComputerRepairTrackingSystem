
namespace ComputerRepairTrackingSystem
{
    partial class CoumputerRepairTrackingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoumputerRepairTrackingSystem));
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnPastRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.BackColor = System.Drawing.Color.Gray;
            this.btnAddRepair.Location = new System.Drawing.Point(307, 15);
            this.btnAddRepair.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(214, 111);
            this.btnAddRepair.TabIndex = 0;
            this.btnAddRepair.Text = "TAMİRAT EKLE";
            this.btnAddRepair.UseVisualStyleBackColor = false;
            this.btnAddRepair.Click += new System.EventHandler(this.btnAddRepair_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelivery.Location = new System.Drawing.Point(15, 324);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(214, 109);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "TAMİRATTA OLANLAR";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnPastRepair
            // 
            this.btnPastRepair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPastRepair.Location = new System.Drawing.Point(578, 319);
            this.btnPastRepair.Name = "btnPastRepair";
            this.btnPastRepair.Size = new System.Drawing.Size(214, 114);
            this.btnPastRepair.TabIndex = 3;
            this.btnPastRepair.Text = "GEÇMİŞ";
            this.btnPastRepair.UseVisualStyleBackColor = false;
            this.btnPastRepair.Click += new System.EventHandler(this.btnPastRepair_Click);
            // 
            // CoumputerRepairTrackingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 448);
            this.Controls.Add(this.btnPastRepair);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.btnAddRepair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CoumputerRepairTrackingSystem";
            this.Text = "Computer Repair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoumputerRepairTrackingSystem_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnPastRepair;
    }
}

