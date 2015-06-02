using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jusolink.Example.csharp
{
    public partial class searchDeatil : Form
    {
        private string roadaddr1;
        private string roadaddr2;

        searchExample prevForm;

        public searchDeatil(string zipcode, string sectionNum, string road1, string road2, string jibun, searchExample form)
        {
            InitializeComponent();
         
            txtRoadZipcode.Text = zipcode;
            txtRoadSectionNum.Text = sectionNum;
            txtRoadAddr.Text = road1 + ' ' + road2;
            this.roadaddr1 = road1;
            this.roadaddr2 = road2;

            txtJibunZipcode.Text = zipcode;
            txtJibunSectionNum.Text = sectionNum;
            txtJibunAddr.Text = jibun;
            rbRoad.Checked = true;
            this.ActiveControl = txtRoadDetail;

            prevForm = form;

        }

        // 다시검색 
        private void btnResearch_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }

        // 확인 선택
        private void btnOk_Click(object sender, EventArgs e)
        {
            jusolinkExample.g_zipcode = txtRoadZipcode.Text;        // 우편번호
            jusolinkExample.g_sectionNum = txtRoadSectionNum.Text;  // 새우편번호
            
            string address;
            
            if (rbRoad.Checked)
            {
                // 표준화 도로명주소
                address = roadaddr1 + ", " +txtRoadDetail.Text + ' ' + roadaddr2;
            }
            else
            {
                // 표준화 지번주소
                address = txtJibunAddr.Text + ", " + txtJibunDetail.Text;
            }
            jusolinkExample.g_address = address;

            this.Close();
        }

        private void rbJibun_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtJibunDetail;
        }

        private void rbRoad_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtRoadDetail;
        }

        private void txtJibunDetail_Click(object sender, EventArgs e)
        {
            rbJibun.Checked = true;
        }

        private void txtRoadDetail_Click(object sender, EventArgs e)
        {
            rbRoad.Checked = true;
        }

        private void txtRoadDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
            else
            {
                return;
            }
        }

        private void txtJibunDetail_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
            else
            {
                return;
            }
        }
    }
}