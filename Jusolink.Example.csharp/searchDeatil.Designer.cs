namespace Jusolink.Example.csharp
{
    partial class searchDeatil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.rbJibun = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoadDetail = new System.Windows.Forms.TextBox();
            this.txtRoadAddr = new System.Windows.Forms.Label();
            this.txtRoadSectionNum = new System.Windows.Forms.Label();
            this.txtRoadZipcode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJibunDetail = new System.Windows.Forms.TextBox();
            this.txtJibunAddr = new System.Windows.Forms.Label();
            this.txtJibunSectionNum = new System.Windows.Forms.Label();
            this.txtJibunZipcode = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "* �Ʒ��� �ּҸ� Ȯ���Ͻð� ������ �� Ȯ�ι�ư�� ��������.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "* ��Ȯ�� ���� �߼��� ���� ǥ��ȭ���θ� �ּ� ����� �����մϴ�.";
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Location = new System.Drawing.Point(26, 79);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(123, 16);
            this.rbRoad.TabIndex = 1;
            this.rbRoad.TabStop = true;
            this.rbRoad.Text = "ǥ��ȭ ���θ��ּ�";
            this.rbRoad.UseVisualStyleBackColor = true;
            this.rbRoad.CheckedChanged += new System.EventHandler(this.rbRoad_CheckedChanged);
            // 
            // rbJibun
            // 
            this.rbJibun.AutoSize = true;
            this.rbJibun.Location = new System.Drawing.Point(445, 79);
            this.rbJibun.Name = "rbJibun";
            this.rbJibun.Size = new System.Drawing.Size(111, 16);
            this.rbJibun.TabIndex = 2;
            this.rbJibun.TabStop = true;
            this.rbJibun.Text = "ǥ��ȭ �����ּ�";
            this.rbJibun.UseVisualStyleBackColor = true;
            this.rbJibun.CheckedChanged += new System.EventHandler(this.rbJibun_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoadDetail);
            this.groupBox1.Controls.Add(this.txtRoadAddr);
            this.groupBox1.Controls.Add(this.txtRoadSectionNum);
            this.groupBox1.Controls.Add(this.txtRoadZipcode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(26, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtRoadDetail
            // 
            this.txtRoadDetail.Location = new System.Drawing.Point(86, 77);
            this.txtRoadDetail.Name = "txtRoadDetail";
            this.txtRoadDetail.Size = new System.Drawing.Size(297, 21);
            this.txtRoadDetail.TabIndex = 3;
            this.txtRoadDetail.Click += new System.EventHandler(this.txtRoadDetail_Click);
            this.txtRoadDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoadDetail_KeyDown);
            // 
            // txtRoadAddr
            // 
            this.txtRoadAddr.Location = new System.Drawing.Point(82, 46);
            this.txtRoadAddr.Name = "txtRoadAddr";
            this.txtRoadAddr.Size = new System.Drawing.Size(301, 28);
            this.txtRoadAddr.TabIndex = 6;
            // 
            // txtRoadSectionNum
            // 
            this.txtRoadSectionNum.AutoSize = true;
            this.txtRoadSectionNum.Location = new System.Drawing.Point(287, 20);
            this.txtRoadSectionNum.Name = "txtRoadSectionNum";
            this.txtRoadSectionNum.Size = new System.Drawing.Size(0, 12);
            this.txtRoadSectionNum.TabIndex = 5;
            // 
            // txtRoadZipcode
            // 
            this.txtRoadZipcode.AutoSize = true;
            this.txtRoadZipcode.Location = new System.Drawing.Point(93, 20);
            this.txtRoadZipcode.Name = "txtRoadZipcode";
            this.txtRoadZipcode.Size = new System.Drawing.Size(0, 12);
            this.txtRoadZipcode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "���ּ� : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "�⺻�ּ� : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "�������ȣ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "�������ȣ : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJibunDetail);
            this.groupBox2.Controls.Add(this.txtJibunAddr);
            this.groupBox2.Controls.Add(this.txtJibunSectionNum);
            this.groupBox2.Controls.Add(this.txtJibunZipcode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(446, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtJibunDetail
            // 
            this.txtJibunDetail.Location = new System.Drawing.Point(86, 77);
            this.txtJibunDetail.Name = "txtJibunDetail";
            this.txtJibunDetail.Size = new System.Drawing.Size(297, 21);
            this.txtJibunDetail.TabIndex = 4;
            this.txtJibunDetail.Click += new System.EventHandler(this.txtJibunDetail_Click);
            this.txtJibunDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJibunDetail_KeyDown);
            // 
            // txtJibunAddr
            // 
            this.txtJibunAddr.Location = new System.Drawing.Point(82, 46);
            this.txtJibunAddr.Name = "txtJibunAddr";
            this.txtJibunAddr.Size = new System.Drawing.Size(301, 28);
            this.txtJibunAddr.TabIndex = 6;
            // 
            // txtJibunSectionNum
            // 
            this.txtJibunSectionNum.AutoSize = true;
            this.txtJibunSectionNum.Location = new System.Drawing.Point(287, 20);
            this.txtJibunSectionNum.Name = "txtJibunSectionNum";
            this.txtJibunSectionNum.Size = new System.Drawing.Size(0, 12);
            this.txtJibunSectionNum.TabIndex = 5;
            // 
            // txtJibunZipcode
            // 
            this.txtJibunZipcode.AutoSize = true;
            this.txtJibunZipcode.Location = new System.Drawing.Point(93, 20);
            this.txtJibunZipcode.Name = "txtJibunZipcode";
            this.txtJibunZipcode.Size = new System.Drawing.Size(0, 12);
            this.txtJibunZipcode.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "���ּ� : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "�⺻�ּ� : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "�������ȣ : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "�������ȣ : ";
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(444, 219);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(84, 31);
            this.btnResearch.TabIndex = 6;
            this.btnResearch.Text = "�ٽð˻�";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(348, 220);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 31);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ȯ��";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // searchDeatil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 264);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbJibun);
            this.Controls.Add(this.rbRoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "searchDeatil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "�ּҰ˻� API SDK for dotnet2005";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRoad;
        private System.Windows.Forms.RadioButton rbJibun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoadDetail;
        private System.Windows.Forms.Label txtRoadAddr;
        private System.Windows.Forms.Label txtRoadSectionNum;
        private System.Windows.Forms.Label txtRoadZipcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtJibunDetail;
        private System.Windows.Forms.Label txtJibunAddr;
        private System.Windows.Forms.Label txtJibunSectionNum;
        private System.Windows.Forms.Label txtJibunZipcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnOk;
    }
}