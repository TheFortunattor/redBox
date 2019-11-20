namespace redBoxInterface
{
    partial class redBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(redBox));
            this.pictureBoxFlowey = new System.Windows.Forms.PictureBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlowey)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFlowey
            // 
            this.pictureBoxFlowey.Image = global::redBoxInterface.Properties.Resources.flowey;
            this.pictureBoxFlowey.Location = new System.Drawing.Point(308, 12);
            this.pictureBoxFlowey.MaximumSize = new System.Drawing.Size(180, 160);
            this.pictureBoxFlowey.Name = "pictureBoxFlowey";
            this.pictureBoxFlowey.Size = new System.Drawing.Size(180, 160);
            this.pictureBoxFlowey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlowey.TabIndex = 0;
            this.pictureBoxFlowey.TabStop = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.Black;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.ForeColor = System.Drawing.Color.White;
            this.textBoxMessage.Location = new System.Drawing.Point(169, 196);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(468, 128);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.Text = resources.GetString("textBoxMessage.Text");
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(308, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // redBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.pictureBoxFlowey);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "redBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "=)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RedBox_FormClosing);
            this.Load += new System.EventHandler(this.RedBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlowey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFlowey;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button button1;
    }
}

