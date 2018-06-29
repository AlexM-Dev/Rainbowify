namespace Rainbowify {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnRainbowify = new System.Windows.Forms.Button();
            this.tmrRainbow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRainbowify
            // 
            this.btnRainbowify.Location = new System.Drawing.Point(32, 37);
            this.btnRainbowify.Name = "btnRainbowify";
            this.btnRainbowify.Size = new System.Drawing.Size(151, 36);
            this.btnRainbowify.TabIndex = 0;
            this.btnRainbowify.Text = "Click to RAINBOWIFY";
            this.btnRainbowify.UseVisualStyleBackColor = true;
            this.btnRainbowify.Click += new System.EventHandler(this.btnRainbowify_Click);
            // 
            // tmrRainbow
            // 
            this.tmrRainbow.Tick += new System.EventHandler(this.tmrRainbow_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(214, 111);
            this.Controls.Add(this.btnRainbowify);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Rainbowify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRainbowify;
        private System.Windows.Forms.Timer tmrRainbow;
    }
}

