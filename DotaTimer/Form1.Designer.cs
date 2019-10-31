namespace DotaTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aegisLabel = new System.Windows.Forms.Label();
            this.roshanMainLabel = new System.Windows.Forms.Label();
            this.roshanAdditionalLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.globalLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.blackHoleLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.glyphLabel = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pos5Label = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pos4Label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.pos3Label = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pos2Label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pos1Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // aegisLabel
            // 
            this.aegisLabel.AutoSize = true;
            this.aegisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aegisLabel.Location = new System.Drawing.Point(87, 19);
            this.aegisLabel.Margin = new System.Windows.Forms.Padding(3);
            this.aegisLabel.Name = "aegisLabel";
            this.aegisLabel.Size = new System.Drawing.Size(54, 25);
            this.aegisLabel.TabIndex = 2;
            this.aegisLabel.Text = "5:00";
            // 
            // roshanMainLabel
            // 
            this.roshanMainLabel.AutoSize = true;
            this.roshanMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roshanMainLabel.Location = new System.Drawing.Point(87, 48);
            this.roshanMainLabel.Margin = new System.Windows.Forms.Padding(3);
            this.roshanMainLabel.Name = "roshanMainLabel";
            this.roshanMainLabel.Size = new System.Drawing.Size(54, 25);
            this.roshanMainLabel.TabIndex = 5;
            this.roshanMainLabel.Text = "8:00";
            // 
            // roshanAdditionalLabel
            // 
            this.roshanAdditionalLabel.AutoSize = true;
            this.roshanAdditionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roshanAdditionalLabel.Location = new System.Drawing.Point(147, 48);
            this.roshanAdditionalLabel.Margin = new System.Windows.Forms.Padding(3);
            this.roshanAdditionalLabel.Name = "roshanAdditionalLabel";
            this.roshanAdditionalLabel.Size = new System.Drawing.Size(54, 25);
            this.roshanAdditionalLabel.TabIndex = 6;
            this.roshanAdditionalLabel.Text = "3:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.roshanMainLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.roshanAdditionalLabel);
            this.groupBox1.Controls.Add(this.aegisLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aegis";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.globalLabel);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.blackHoleLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 82);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spells";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Global";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // globalLabel
            // 
            this.globalLabel.AutoSize = true;
            this.globalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.globalLabel.Location = new System.Drawing.Point(87, 48);
            this.globalLabel.Margin = new System.Windows.Forms.Padding(3);
            this.globalLabel.Name = "globalLabel";
            this.globalLabel.Size = new System.Drawing.Size(54, 25);
            this.globalLabel.TabIndex = 4;
            this.globalLabel.Text = "2:10";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Blackhole";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // blackHoleLabel
            // 
            this.blackHoleLabel.AutoSize = true;
            this.blackHoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blackHoleLabel.Location = new System.Drawing.Point(87, 19);
            this.blackHoleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.blackHoleLabel.Name = "blackHoleLabel";
            this.blackHoleLabel.Size = new System.Drawing.Size(54, 25);
            this.blackHoleLabel.TabIndex = 2;
            this.blackHoleLabel.Text = "2:40";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.glyphLabel);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.pos5Label);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.pos4Label);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.pos3Label);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.pos2Label);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.pos1Label);
            this.groupBox4.Location = new System.Drawing.Point(239, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 217);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buybacks";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Glyph";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // glyphLabel
            // 
            this.glyphLabel.AutoSize = true;
            this.glyphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.glyphLabel.Location = new System.Drawing.Point(87, 164);
            this.glyphLabel.Margin = new System.Windows.Forms.Padding(3);
            this.glyphLabel.Name = "glyphLabel";
            this.glyphLabel.Size = new System.Drawing.Size(54, 25);
            this.glyphLabel.TabIndex = 12;
            this.glyphLabel.Text = "5:00";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Support 5";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pos5Label
            // 
            this.pos5Label.AutoSize = true;
            this.pos5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos5Label.Location = new System.Drawing.Point(87, 135);
            this.pos5Label.Margin = new System.Windows.Forms.Padding(3);
            this.pos5Label.Name = "pos5Label";
            this.pos5Label.Size = new System.Drawing.Size(54, 25);
            this.pos5Label.TabIndex = 10;
            this.pos5Label.Text = "8:00";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Support 4";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // pos4Label
            // 
            this.pos4Label.AutoSize = true;
            this.pos4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos4Label.Location = new System.Drawing.Point(87, 106);
            this.pos4Label.Margin = new System.Windows.Forms.Padding(3);
            this.pos4Label.Name = "pos4Label";
            this.pos4Label.Size = new System.Drawing.Size(54, 25);
            this.pos4Label.TabIndex = 8;
            this.pos4Label.Text = "8:00";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Offlaner";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pos3Label
            // 
            this.pos3Label.AutoSize = true;
            this.pos3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos3Label.Location = new System.Drawing.Point(87, 77);
            this.pos3Label.Margin = new System.Windows.Forms.Padding(3);
            this.pos3Label.Name = "pos3Label";
            this.pos3Label.Size = new System.Drawing.Size(54, 25);
            this.pos3Label.TabIndex = 6;
            this.pos3Label.Text = "8:00";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Mid";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pos2Label
            // 
            this.pos2Label.AutoSize = true;
            this.pos2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos2Label.Location = new System.Drawing.Point(87, 48);
            this.pos2Label.Margin = new System.Windows.Forms.Padding(3);
            this.pos2Label.Name = "pos2Label";
            this.pos2Label.Size = new System.Drawing.Size(54, 25);
            this.pos2Label.TabIndex = 4;
            this.pos2Label.Text = "8:00";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Carry";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pos1Label
            // 
            this.pos1Label.AutoSize = true;
            this.pos1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pos1Label.Location = new System.Drawing.Point(87, 19);
            this.pos1Label.Margin = new System.Windows.Forms.Padding(3);
            this.pos1Label.Name = "pos1Label";
            this.pos1Label.Size = new System.Drawing.Size(54, 25);
            this.pos1Label.TabIndex = 2;
            this.pos1Label.Text = "8:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dota Timers";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(18, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Enable overlay";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 215);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Overlay test";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(158, 192);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 241);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(490, 280);
            this.MinimumSize = new System.Drawing.Size(490, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dota Timers";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aegisLabel;
        private System.Windows.Forms.Label roshanMainLabel;
        private System.Windows.Forms.Label roshanAdditionalLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label blackHoleLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label pos5Label;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label pos4Label;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label pos3Label;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label pos2Label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label pos1Label;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label globalLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label glyphLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button10;
    }
}

