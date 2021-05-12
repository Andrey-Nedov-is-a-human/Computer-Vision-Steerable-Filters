namespace _3._12_Steerable_filters
{
    partial class frame
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
            this.button1 = new System.Windows.Forms.Button();
            this.img_main = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Load_image);
            // 
            // img_main
            // 
            this.img_main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.img_main.Location = new System.Drawing.Point(12, 69);
            this.img_main.Name = "img_main";
            this.img_main.Size = new System.Drawing.Size(640, 480);
            this.img_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_main.TabIndex = 1;
            this.img_main.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gaussian filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Gaussian_d1);
            // 
            // frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 742);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.img_main);
            this.Controls.Add(this.button1);
            this.Name = "frame";
            this.Text = "Ex 3.12 Steerable filters";
            this.Load += new System.EventHandler(this.Frame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox img_main;
        private System.Windows.Forms.Button button2;
    }
}

