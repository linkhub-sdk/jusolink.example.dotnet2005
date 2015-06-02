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
        //주소링크 가입시 발급받은 링크아이디
        private string LinkID = "TESTER_JUSO";
        //주소링크 가입시 발급받은 비밀키
        private string SecretKey = "FjaRgAfVUPvSDHTrdd/uw/dt/Cdo3GgSFKyE1+NQ+bc=";
                
        public static JusolinkService jusolinkService;

        public static string g_zipcode;     // 우편번호
        public static string g_sectionNum;  // 새우편번호
        public static string g_address;     // 표준화주소

        public jusolinkExample()
        {
            InitializeComponent();

            // 모듈초기화
            jusolinkService = new JusolinkService(LinkID, SecretKey);
        }

        // 잔여포인트 확인
        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            try
            {
                double remainPoint = jusolinkService.GetBalance();

                MessageBox.Show("잔여포인트 : " + remainPoint.ToString());

            }
            catch (JusolinkException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        //검색단가 확인
        private void btnUnitCost_Click(object sender, EventArgs e)
        {
            try
            {
                float unitCost = jusolinkService.GetUnitCost();

                MessageBox.Show("검색단가 : " + unitCost.ToString());

            }
            catch (JusolinkException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        // 주소검색 폼 호출
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