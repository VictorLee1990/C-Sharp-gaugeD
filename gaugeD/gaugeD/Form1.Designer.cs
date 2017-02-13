namespace gaugeD
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.drawCircle = new System.Windows.Forms.Button();
            this.x_point = new System.Windows.Forms.TextBox();
            this.y_point = new System.Windows.Forms.TextBox();
            this.y1_point = new System.Windows.Forms.TextBox();
            this.x1_point = new System.Windows.Forms.TextBox();
            this.y2_point = new System.Windows.Forms.TextBox();
            this.x2_point = new System.Windows.Forms.TextBox();
            this.y3_point = new System.Windows.Forms.TextBox();
            this.x3_point = new System.Windows.Forms.TextBox();
            this.drawLine = new System.Windows.Forms.Button();
            this.clculate = new System.Windows.Forms.Button();
            this.ruslt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawCircle
            // 
            this.drawCircle.Location = new System.Drawing.Point(459, 31);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(85, 34);
            this.drawCircle.TabIndex = 0;
            this.drawCircle.Text = "drawCircle";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // x_point
            // 
            this.x_point.Location = new System.Drawing.Point(459, 122);
            this.x_point.Name = "x_point";
            this.x_point.Size = new System.Drawing.Size(100, 22);
            this.x_point.TabIndex = 1;
            // 
            // y_point
            // 
            this.y_point.Location = new System.Drawing.Point(459, 150);
            this.y_point.Name = "y_point";
            this.y_point.Size = new System.Drawing.Size(100, 22);
            this.y_point.TabIndex = 2;
            // 
            // y1_point
            // 
            this.y1_point.Location = new System.Drawing.Point(459, 208);
            this.y1_point.Name = "y1_point";
            this.y1_point.Size = new System.Drawing.Size(100, 22);
            this.y1_point.TabIndex = 4;
            // 
            // x1_point
            // 
            this.x1_point.Location = new System.Drawing.Point(459, 180);
            this.x1_point.Name = "x1_point";
            this.x1_point.Size = new System.Drawing.Size(100, 22);
            this.x1_point.TabIndex = 3;
            // 
            // y2_point
            // 
            this.y2_point.Location = new System.Drawing.Point(459, 289);
            this.y2_point.Name = "y2_point";
            this.y2_point.Size = new System.Drawing.Size(100, 22);
            this.y2_point.TabIndex = 6;
            // 
            // x2_point
            // 
            this.x2_point.Location = new System.Drawing.Point(459, 261);
            this.x2_point.Name = "x2_point";
            this.x2_point.Size = new System.Drawing.Size(100, 22);
            this.x2_point.TabIndex = 5;
            // 
            // y3_point
            // 
            this.y3_point.Location = new System.Drawing.Point(459, 345);
            this.y3_point.Name = "y3_point";
            this.y3_point.Size = new System.Drawing.Size(100, 22);
            this.y3_point.TabIndex = 8;
            // 
            // x3_point
            // 
            this.x3_point.Location = new System.Drawing.Point(459, 317);
            this.x3_point.Name = "x3_point";
            this.x3_point.Size = new System.Drawing.Size(100, 22);
            this.x3_point.TabIndex = 7;
            // 
            // drawLine
            // 
            this.drawLine.Location = new System.Drawing.Point(459, 71);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(85, 34);
            this.drawLine.TabIndex = 9;
            this.drawLine.Text = "drawLine";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // clculate
            // 
            this.clculate.Location = new System.Drawing.Point(12, 333);
            this.clculate.Name = "clculate";
            this.clculate.Size = new System.Drawing.Size(85, 34);
            this.clculate.TabIndex = 10;
            this.clculate.Text = "clculate";
            this.clculate.UseVisualStyleBackColor = true;
            this.clculate.Click += new System.EventHandler(this.clculate_Click);
            // 
            // ruslt
            // 
            this.ruslt.Location = new System.Drawing.Point(121, 341);
            this.ruslt.Name = "ruslt";
            this.ruslt.Size = new System.Drawing.Size(221, 22);
            this.ruslt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruslt);
            this.Controls.Add(this.clculate);
            this.Controls.Add(this.drawLine);
            this.Controls.Add(this.y3_point);
            this.Controls.Add(this.x3_point);
            this.Controls.Add(this.y2_point);
            this.Controls.Add(this.x2_point);
            this.Controls.Add(this.y1_point);
            this.Controls.Add(this.x1_point);
            this.Controls.Add(this.y_point);
            this.Controls.Add(this.x_point);
            this.Controls.Add(this.drawCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.TextBox x_point;
        private System.Windows.Forms.TextBox y_point;
        private System.Windows.Forms.TextBox y1_point;
        private System.Windows.Forms.TextBox x1_point;
        private System.Windows.Forms.TextBox y2_point;
        private System.Windows.Forms.TextBox x2_point;
        private System.Windows.Forms.TextBox y3_point;
        private System.Windows.Forms.TextBox x3_point;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.Button clculate;
        private System.Windows.Forms.TextBox ruslt;
        private System.Windows.Forms.Label label1;
    }
}

