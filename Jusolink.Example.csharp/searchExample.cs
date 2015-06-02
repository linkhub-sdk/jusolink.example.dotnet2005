using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jusolink.Example.csharp
{
    public partial class searchExample : Form
    {
        private JusolinkService jusolinkService;

        private int? pageNum = 1;       // ���� ������ ��ȣ
        private int? totalPage;         // ��ü ������ �� 
        private string suggestIndex;    // �������þ�

        public searchExample()
        {
            InitializeComponent();
            jusolinkService = jusolinkExample.jusolinkService;
        }

        // �ּҰ˻�
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int perPage = 20;           // �������� ��� ���� �ִ� 100��
            bool noSuggest = false;     // �������þ� ����
            bool noDiffer = false;      // ����˻� ����
            
            string relatedJibun;

            this.ActiveControl = txtIndex;

            try
            {
                SearchResult jusoInfo = jusolinkService.search(txtIndex.Text, pageNum, perPage, noSuggest, noDiffer);
                
                pageNum = jusoInfo.page;            // ������ ��ȣ
                totalPage = jusoInfo.totalPage;     // ��ü ������ �� 
                txtCurrentPage.Text = jusoInfo.page.ToString();
                txtTotalpage.Text = jusoInfo.totalPage.ToString();

                if (jusoInfo.suggest != null)
                {
                    suggestIndex = jusoInfo.suggest;    // �������þ� 
                    txtSuggestIndex.Text = "�������þ� : [" + jusoInfo.suggest + "] �˻���� ����";

                }
                else
                {
                    txtSuggestIndex.Text = "";
                }

                listView1.Items.Clear();

                if (jusoInfo.juso != null)
                {

                    for (int i = 0; i < jusoInfo.juso.Count; i++)
                    {
                        listView1.Items.Add(jusoInfo.juso[i].zipcode, 1);       // �����ȣ
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].sectionNum);   // �������ȣ
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].roadAddr1);    // ���θ��ּ�
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].roadAddr2);    // ���θ��ּ�(�����׸�)
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].jibunAddr);    // �����ּ�

                        relatedJibun = "";

                        if (jusoInfo.juso[i].relatedJibun != null)
                        {
                            for (int j = 0; j < jusoInfo.juso[i].relatedJibun.Count; j++)
                            {
                                relatedJibun += jusoInfo.juso[i].relatedJibun[j] + ' ';
                            }

                            listView1.Items[i].SubItems.Add(relatedJibun);      // �������� ���
                        }
                    }
                }
                else
                {
                    MessageBox.Show("�˻��� �ּ������� �����ϴ�");
                    this.ActiveControl = txtIndex;
                }
            }
            catch (JusolinkException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);
                
            }
        }

        private void searchExample_Load(object sender, EventArgs e)
        {
            // listview ������ height ������ ���� imageList �߰� 
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);
            listView1.SmallImageList = imgList;
            this.ActiveControl = txtIndex;
        }

        // �������þ� ����
        private void txtSuggestIndex_Click(object sender, EventArgs e)
        {
            if (suggestIndex != null && suggestIndex != "")
            {
                pageNum = 1;
                txtIndex.Text = suggestIndex;
                btnSearch.PerformClick();
            }
        }

        // ����������
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum = pageNum - 1;
                btnSearch.PerformClick();
            }

        }
        
        // ����������
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNum < totalPage)
            {
                pageNum = pageNum + 1;
                btnSearch.PerformClick();
            }
        }

        // �˻��� ����
        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            pageNum = 1;
        }

        // �ּ����� ����
        private void listView1_Click(object sender, EventArgs e)
        {
            string zipcode = listView1.SelectedItems[0].Text; // �����ȣ
            string sectionNum = listView1.SelectedItems[0].SubItems[1].Text;     // �������ȣ
            string roadaddr1 = listView1.SelectedItems[0].SubItems[2].Text;     // ���θ��ּ�
            string roadaddr2 = listView1.SelectedItems[0].SubItems[3].Text;     // ���θ��ּ� �����׸�
            string jibunaddr = listView1.SelectedItems[0].SubItems[4].Text;     // �����ּ�
            this.Hide();

            searchDeatil detailForm = new searchDeatil(zipcode, sectionNum, roadaddr1, roadaddr2, jibunaddr, this);
            detailForm.ShowDialog();
            
        }
        
        private void searchExample_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = txtIndex;
        }

        private void txtIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
            else
            {
                return;
            }
        }
    }
}


