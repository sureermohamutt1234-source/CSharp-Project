namespace WindowsFormsApp1
{
    partial class lucky_cafe_project
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.fileBtn = new System.Windows.Forms.Button();
            this.calBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantuty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCostomerInfo = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lblLucky = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(791, 546);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(144, 49);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(523, 546);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(144, 49);
            this.loadBtn.TabIndex = 12;
            this.loadBtn.Text = "load from file";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 20;
            this.OrderList.Location = new System.Drawing.Point(538, 66);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(397, 444);
            this.OrderList.TabIndex = 11;
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(265, 546);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(144, 49);
            this.fileBtn.TabIndex = 10;
            this.fileBtn.Text = "Save to file";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(43, 546);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(135, 49);
            this.calBtn.TabIndex = 9;
            this.calBtn.Text = "calculate order";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chkStudent);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblQuantuty);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblCostomerInfo);
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Location = new System.Drawing.Point(25, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 437);
            this.panel1.TabIndex = 8;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(231, 339);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(216, 24);
            this.chkStudent.TabIndex = 6;
            this.chkStudent.Text = "student member(10% off)";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(143, 335);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(61, 26);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantuty
            // 
            this.lblQuantuty.AutoSize = true;
            this.lblQuantuty.Location = new System.Drawing.Point(28, 339);
            this.lblQuantuty.Name = "lblQuantuty";
            this.lblQuantuty.Size = new System.Drawing.Size(68, 20);
            this.lblQuantuty.TabIndex = 4;
            this.lblQuantuty.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drink Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(29, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Juice (3$)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(29, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Coffe (2$)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(29, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tea (1$)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblCostomerInfo
            // 
            this.lblCostomerInfo.AutoSize = true;
            this.lblCostomerInfo.Location = new System.Drawing.Point(17, 52);
            this.lblCostomerInfo.Name = "lblCostomerInfo";
            this.lblCostomerInfo.Size = new System.Drawing.Size(121, 20);
            this.lblCostomerInfo.TabIndex = 1;
            this.lblCostomerInfo.Text = "customerName:";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblinfo.Location = new System.Drawing.Point(16, 11);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(197, 25);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Customer information";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(55, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 41);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = " Lucky Cafe Order ";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(62, 634);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(789, 39);
            this.lbTotal.TabIndex = 14;
            // 
            // lblLucky
            // 
            this.lblLucky.BackColor = System.Drawing.Color.White;
            this.lblLucky.Location = new System.Drawing.Point(60, 675);
            this.lblLucky.Name = "lblLucky";
            this.lblLucky.Size = new System.Drawing.Size(789, 42);
            this.lblLucky.TabIndex = 15;
            // 
            // lucky_cafe_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 738);
            this.Controls.Add(this.lblLucky);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "lucky_cafe_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lucky_cafe_project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantuty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCostomerInfo;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lblLucky;
    }
}