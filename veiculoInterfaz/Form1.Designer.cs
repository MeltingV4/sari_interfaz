﻿namespace veiculoInterfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnBrazo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(12, 196);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(110, 54);
            this.btnCarro.TabIndex = 1;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            // 
            // btnBrazo
            // 
            this.btnBrazo.Location = new System.Drawing.Point(12, 100);
            this.btnBrazo.Name = "btnBrazo";
            this.btnBrazo.Size = new System.Drawing.Size(110, 54);
            this.btnBrazo.TabIndex = 2;
            this.btnBrazo.Text = "Brazo";
            this.btnBrazo.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 1);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::veiculoInterfaz.Properties.Resources.back_arrow__menos;
            this.button2.Location = new System.Drawing.Point(168, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Image = global::veiculoInterfaz.Properties.Resources.forward_arrow__menos;
            this.button1.Location = new System.Drawing.Point(378, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::veiculoInterfaz.Properties.Resources.back_arrow;
            this.btnBack.Location = new System.Drawing.Point(378, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 100);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            this.btnForward.Image = global::veiculoInterfaz.Properties.Resources.forward_arrow;
            this.btnForward.Location = new System.Drawing.Point(166, 93);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 100);
            this.btnForward.TabIndex = 7;
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLeft.Image = global::veiculoInterfaz.Properties.Resources.left_arrow;
            this.btnLeft.Location = new System.Drawing.Point(168, 199);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 100);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "button6";
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            this.btnRight.Image = global::veiculoInterfaz.Properties.Resources.right_arrow;
            this.btnRight.Location = new System.Drawing.Point(378, 199);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 100);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "button5";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Image = global::veiculoInterfaz.Properties.Resources.down_arrow;
            this.btnDown.Location = new System.Drawing.Point(272, 305);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Image = global::veiculoInterfaz.Properties.Resources.up_arrow;
            this.btnUp.Location = new System.Drawing.Point(272, 93);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnBrazo);
            this.Controls.Add(this.btnCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnBrazo;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

