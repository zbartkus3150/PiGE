namespace WinForms_Memory
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
            this.components = new System.ComponentModel.Container();
            this.UpDownLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BottomLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.UpDownLayoutPanel.SuspendLayout();
            this.BottomLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpDownLayoutPanel
            // 
            this.UpDownLayoutPanel.ColumnCount = 1;
            this.UpDownLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UpDownLayoutPanel.Controls.Add(this.BottomLayoutPanel, 0, 1);
            this.UpDownLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.UpDownLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpDownLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.UpDownLayoutPanel.Name = "UpDownLayoutPanel";
            this.UpDownLayoutPanel.RowCount = 2;
            this.UpDownLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UpDownLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.UpDownLayoutPanel.Size = new System.Drawing.Size(478, 344);
            this.UpDownLayoutPanel.TabIndex = 0;
            this.UpDownLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BottomLayoutPanel
            // 
            this.BottomLayoutPanel.ColumnCount = 3;
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomLayoutPanel.Controls.Add(this.PlayButton, 0, 0);
            this.BottomLayoutPanel.Controls.Add(this.ResetButton, 1, 0);
            this.BottomLayoutPanel.Controls.Add(this.TimerLabel, 2, 0);
            this.BottomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomLayoutPanel.Location = new System.Drawing.Point(3, 307);
            this.BottomLayoutPanel.Name = "BottomLayoutPanel";
            this.BottomLayoutPanel.RowCount = 1;
            this.BottomLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomLayoutPanel.Size = new System.Drawing.Size(472, 34);
            this.BottomLayoutPanel.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayButton.AutoSize = true;
            this.PlayButton.Location = new System.Drawing.Point(41, 3);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 31);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResetButton.AutoSize = true;
            this.ResetButton.Location = new System.Drawing.Point(198, 3);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 31);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimerLabel.Location = new System.Drawing.Point(393, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 34);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button8, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button10, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button11, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button12, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button14, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button15, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button16, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 298);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 68);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(239, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 70);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(357, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 70);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(3, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 70);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(121, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 70);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(121, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 68);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(239, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 68);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            this.button7.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(357, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 68);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            this.button8.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(3, 77);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 68);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            this.button9.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.AliceBlue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(121, 77);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 68);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            this.button10.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button10.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.AliceBlue;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(239, 77);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 68);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            this.button11.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button11.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.AliceBlue;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(357, 77);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 68);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            this.button12.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button12.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.AliceBlue;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(3, 151);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 68);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            this.button13.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button13.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.AliceBlue;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(121, 151);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 68);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button1_Click);
            this.button14.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button14.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.AliceBlue;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(239, 151);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 68);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button1_Click);
            this.button15.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button15.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.AliceBlue;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(357, 151);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 68);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button1_Click);
            this.button16.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button16.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.UpDownLayoutPanel);
            this.Name = "Form1";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UpDownLayoutPanel.ResumeLayout(false);
            this.BottomLayoutPanel.ResumeLayout(false);
            this.BottomLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UpDownLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel BottomLayoutPanel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

