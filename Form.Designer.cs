namespace HelpMe
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAddress2 = new System.Windows.Forms.TextBox();
            this.txtBoxAddress3 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMango1 = new System.Windows.Forms.Button();
            this.btnMango2 = new System.Windows.Forms.Button();
            this.btnNoTerminal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "망고 주문번호 입력:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(119, 20);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(313, 21);
            this.txtOrderID.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "주소1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "주소2:";
            // 
            // txtBoxAddress2
            // 
            this.txtBoxAddress2.Location = new System.Drawing.Point(49, 59);
            this.txtBoxAddress2.Name = "txtBoxAddress2";
            this.txtBoxAddress2.Size = new System.Drawing.Size(383, 21);
            this.txtBoxAddress2.TabIndex = 12;
            // 
            // txtBoxAddress3
            // 
            this.txtBoxAddress3.Location = new System.Drawing.Point(49, 97);
            this.txtBoxAddress3.Name = "txtBoxAddress3";
            this.txtBoxAddress3.Size = new System.Drawing.Size(383, 21);
            this.txtBoxAddress3.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMango1
            // 
            this.btnMango1.Location = new System.Drawing.Point(6, 23);
            this.btnMango1.Name = "btnMango1";
            this.btnMango1.Size = new System.Drawing.Size(75, 23);
            this.btnMango1.TabIndex = 15;
            this.btnMango1.Text = "Mango01";
            this.btnMango1.UseVisualStyleBackColor = true;
            this.btnMango1.Click += new System.EventHandler(this.btnMango1_Click);
            // 
            // btnMango2
            // 
            this.btnMango2.Location = new System.Drawing.Point(87, 23);
            this.btnMango2.Name = "btnMango2";
            this.btnMango2.Size = new System.Drawing.Size(75, 23);
            this.btnMango2.TabIndex = 16;
            this.btnMango2.Text = "Mango02";
            this.btnMango2.UseVisualStyleBackColor = true;
            this.btnMango2.Click += new System.EventHandler(this.btnMango2_Click);
            // 
            // btnNoTerminal
            // 
            this.btnNoTerminal.Location = new System.Drawing.Point(6, 20);
            this.btnNoTerminal.Name = "btnNoTerminal";
            this.btnNoTerminal.Size = new System.Drawing.Size(94, 23);
            this.btnNoTerminal.TabIndex = 18;
            this.btnNoTerminal.Text = "확인";
            this.btnNoTerminal.UseVisualStyleBackColor = true;
            this.btnNoTerminal.Click += new System.EventHandler(this.btnNoTerminal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMango2);
            this.groupBox1.Controls.Add(this.btnMango1);
            this.groupBox1.Location = new System.Drawing.Point(588, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 58);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[RDT에서 로그인이 안되는 경우에만 사용하세요.]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtOrderID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxAddress3);
            this.groupBox2.Controls.Add(this.txtBoxAddress2);
            this.groupBox2.Location = new System.Drawing.Point(18, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 134);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[잘못된 주소에 대해서는, 망고 고객센터에 문의후 다시 입력 해주세요.]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "최대 45글자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "최대 45글자";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView);
            this.groupBox3.Controls.Add(this.btnNoTerminal);
            this.groupBox3.Location = new System.Drawing.Point(12, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(966, 367);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "잘못된 주소 확인 (CJ 터미널 코드 없는 주문)";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(954, 312);
            this.dataGridView.TabIndex = 19;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(987, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form";
            this.Text = "Mango SOS Ver1.2";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAddress2;
        private System.Windows.Forms.TextBox txtBoxAddress3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMango1;
        private System.Windows.Forms.Button btnMango2;
        private System.Windows.Forms.Button btnNoTerminal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

