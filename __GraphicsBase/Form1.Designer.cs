namespace __GraphicsBase
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.xy_radio = new System.Windows.Forms.RadioButton();
            this.xz_radio = new System.Windows.Forms.RadioButton();
            this.yz_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(778, 489);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            this.canvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseWheel);
            // 
            // xy_radio
            // 
            this.xy_radio.AutoSize = true;
            this.xy_radio.Location = new System.Drawing.Point(12, 507);
            this.xy_radio.Name = "xy_radio";
            this.xy_radio.Size = new System.Drawing.Size(39, 17);
            this.xy_radio.TabIndex = 1;
            this.xy_radio.TabStop = true;
            this.xy_radio.Text = "XY";
            this.xy_radio.UseVisualStyleBackColor = true;
            this.xy_radio.CheckedChanged += new System.EventHandler(this.xy_radio_CheckedChanged);
            // 
            // xz_radio
            // 
            this.xz_radio.AutoSize = true;
            this.xz_radio.Location = new System.Drawing.Point(148, 507);
            this.xz_radio.Name = "xz_radio";
            this.xz_radio.Size = new System.Drawing.Size(39, 17);
            this.xz_radio.TabIndex = 2;
            this.xz_radio.TabStop = true;
            this.xz_radio.Text = "XZ";
            this.xz_radio.UseVisualStyleBackColor = true;
            this.xz_radio.CheckedChanged += new System.EventHandler(this.xz_radio_CheckedChanged);
            // 
            // yz_radio
            // 
            this.yz_radio.AutoSize = true;
            this.yz_radio.Location = new System.Drawing.Point(284, 507);
            this.yz_radio.Name = "yz_radio";
            this.yz_radio.Size = new System.Drawing.Size(39, 17);
            this.yz_radio.TabIndex = 3;
            this.yz_radio.TabStop = true;
            this.yz_radio.Text = "YZ";
            this.yz_radio.UseVisualStyleBackColor = true;
            this.yz_radio.CheckedChanged += new System.EventHandler(this.yz_radio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 536);
            this.Controls.Add(this.yz_radio);
            this.Controls.Add(this.xz_radio);
            this.Controls.Add(this.xy_radio);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.RadioButton xy_radio;
        private System.Windows.Forms.RadioButton xz_radio;
        private System.Windows.Forms.RadioButton yz_radio;
    }
}

