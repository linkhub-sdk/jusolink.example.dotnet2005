using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jusolink.Example.csharp
{
    public partial class jusolinkExample : Form
    {
        //�ּҸ�ũ ���Խ� �߱޹��� ��ũ���̵�
        private string LinkID = "TESTER_JUSO";
        //�ּҸ�ũ ���Խ� �߱޹��� ���Ű
        private string SecretKey = "FjaRgAfVUPvSDHTrdd/uw/dt/Cdo3GgSFKyE1+NQ+bc=";
                
        public static JusolinkService jusolinkService;

        public static string g_zipcode;     // �����ȣ
        public static string g_sectionNum;  // �������ȣ
        public static string g_address;     // ǥ��ȭ�ּ�

        public jusolinkExample()
        {
            InitializeComponent();

            // ����ʱ�ȭ
            jusolinkService = new JusolinkService(LinkID, SecretKey);
        }

        // �ܿ�����Ʈ Ȯ��
        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            try
            {
                double remainPoint = jusolinkService.GetBalance();

                MessageBox.Show("�ܿ�����Ʈ : " + remainPoint.ToString());

            }
            catch (JusolinkException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        //�˻��ܰ� Ȯ��
        private void btnUnitCost_Click(object sender, EventArgs e)
        {
            try
            {
                float unitCost = jusolinkService.GetUnitCost();

                MessageBox.Show("�˻��ܰ� : " + unitCost.ToString());

            }
            catch (JusolinkException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        // �ּҰ˻� �� ȣ��
        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            searchExample searchForm = new searchExample();
            searchForm.ShowDialog();
        }

        private void example_Activated(object sender, EventArgs e)
        {
            txtZipcode.Text = g_zipcode;
            txtSectionNum.Text = g_sectionNum;
            txtAddress.Text = g_address;
            this.ActiveControl = txtAddress;
        }
    }
}