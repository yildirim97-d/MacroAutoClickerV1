
namespace AutoClickerV1._0
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartStop = new System.Windows.Forms.Button();
            this.xPosition = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RadioLeft = new System.Windows.Forms.RadioButton();
            this.RadioRight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.q4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AllRepeat = new System.Windows.Forms.Label();
            this.clickCount = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStop
            // 
            this.StartStop.BackColor = System.Drawing.Color.Coral;
            this.StartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartStop.ForeColor = System.Drawing.Color.White;
            this.StartStop.Location = new System.Drawing.Point(8, 328);
            this.StartStop.Margin = new System.Windows.Forms.Padding(5);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(135, 64);
            this.StartStop.TabIndex = 0;
            this.StartStop.TabStop = false;
            this.StartStop.Text = "START";
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // xPosition
            // 
            this.xPosition.AutoSize = true;
            this.xPosition.BackColor = System.Drawing.Color.Coral;
            this.xPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xPosition.Font = new System.Drawing.Font("Orator Std", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosition.ForeColor = System.Drawing.Color.White;
            this.xPosition.Location = new System.Drawing.Point(21, 15);
            this.xPosition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.xPosition.Name = "xPosition";
            this.xPosition.Size = new System.Drawing.Size(210, 25);
            this.xPosition.TabIndex = 1;
            this.xPosition.Text = "Mouse Position X: ";
            // 
            // yPosition
            // 
            this.yPosition.AutoSize = true;
            this.yPosition.BackColor = System.Drawing.Color.Coral;
            this.yPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yPosition.Font = new System.Drawing.Font("Orator Std", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPosition.ForeColor = System.Drawing.Color.White;
            this.yPosition.Location = new System.Drawing.Point(21, 52);
            this.yPosition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.yPosition.Name = "yPosition";
            this.yPosition.Size = new System.Drawing.Size(210, 25);
            this.yPosition.TabIndex = 2;
            this.yPosition.Text = "Mouse Position Y: ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Coral;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(313, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 384);
            this.listBox1.TabIndex = 5;
            this.listBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listBox1_PreviewKeyDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Coral;
            this.numericUpDown1.Font = new System.Drawing.Font("Orator Std", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(104, 180);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RadioLeft
            // 
            this.RadioLeft.AutoSize = true;
            this.RadioLeft.BackColor = System.Drawing.Color.Coral;
            this.RadioLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioLeft.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RadioLeft.FlatAppearance.BorderSize = 5;
            this.RadioLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.RadioLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.RadioLeft.ForeColor = System.Drawing.Color.White;
            this.RadioLeft.Location = new System.Drawing.Point(21, 120);
            this.RadioLeft.Margin = new System.Windows.Forms.Padding(4);
            this.RadioLeft.Name = "RadioLeft";
            this.RadioLeft.Size = new System.Drawing.Size(110, 23);
            this.RadioLeft.TabIndex = 7;
            this.RadioLeft.TabStop = true;
            this.RadioLeft.Text = "Left Click";
            this.RadioLeft.UseVisualStyleBackColor = false;
            // 
            // RadioRight
            // 
            this.RadioRight.AutoSize = true;
            this.RadioRight.BackColor = System.Drawing.Color.Coral;
            this.RadioRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioRight.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RadioRight.FlatAppearance.BorderSize = 5;
            this.RadioRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.RadioRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.RadioRight.ForeColor = System.Drawing.Color.White;
            this.RadioRight.Location = new System.Drawing.Point(21, 150);
            this.RadioRight.Margin = new System.Windows.Forms.Padding(4);
            this.RadioRight.Name = "RadioRight";
            this.RadioRight.Size = new System.Drawing.Size(118, 23);
            this.RadioRight.TabIndex = 8;
            this.RadioRight.TabStop = true;
            this.RadioRight.Text = "Right Click";
            this.RadioRight.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Orator Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Second:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Orator Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Repeat Count:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Coral;
            this.numericUpDown2.Font = new System.Drawing.Font("Orator Std", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(156, 207);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // q4
            // 
            this.q4.BackColor = System.Drawing.Color.Coral;
            this.q4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.q4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.q4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.q4.ForeColor = System.Drawing.Color.White;
            this.q4.Location = new System.Drawing.Point(153, 365);
            this.q4.Margin = new System.Windows.Forms.Padding(5);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(124, 27);
            this.q4.TabIndex = 13;
            this.q4.TabStop = false;
            this.q4.Text = "Clear";
            this.q4.UseVisualStyleBackColor = false;
            this.q4.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(153, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 27);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "First Array";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllRepeat
            // 
            this.AllRepeat.AutoSize = true;
            this.AllRepeat.BackColor = System.Drawing.Color.Coral;
            this.AllRepeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllRepeat.Font = new System.Drawing.Font("Orator Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllRepeat.ForeColor = System.Drawing.Color.White;
            this.AllRepeat.Location = new System.Drawing.Point(21, 235);
            this.AllRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllRepeat.Name = "AllRepeat";
            this.AllRepeat.Size = new System.Drawing.Size(182, 22);
            this.AllRepeat.TabIndex = 15;
            this.AllRepeat.Text = "All Repeat Count: 0";
            // 
            // clickCount
            // 
            this.clickCount.AutoSize = true;
            this.clickCount.BackColor = System.Drawing.Color.Coral;
            this.clickCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clickCount.Font = new System.Drawing.Font("Orator Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickCount.ForeColor = System.Drawing.Color.White;
            this.clickCount.Location = new System.Drawing.Point(21, 265);
            this.clickCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clickCount.Name = "clickCount";
            this.clickCount.Size = new System.Drawing.Size(137, 22);
            this.clickCount.TabIndex = 16;
            this.clickCount.Text = "Click Count: 0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 23);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show Positions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(643, 400);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clickCount);
            this.Controls.Add(this.AllRepeat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.q4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioRight);
            this.Controls.Add(this.RadioLeft);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.yPosition);
            this.Controls.Add(this.xPosition);
            this.Controls.Add(this.StartStop);
            this.Font = new System.Drawing.Font("Orator Std", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Deniz YILDIRIM AutoClick";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label yPosition;
        private System.Windows.Forms.Label xPosition;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton RadioLeft;
        private System.Windows.Forms.RadioButton RadioRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button q4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AllRepeat;
        private System.Windows.Forms.Label clickCount;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

