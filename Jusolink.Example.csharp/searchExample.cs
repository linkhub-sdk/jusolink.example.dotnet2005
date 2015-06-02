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

        private int? pageNum = 1;       // 현재 페이지 번호
        private int? totalPage;         // 전체 페이지 수 
        private string suggestIndex;    // 수정제시어

        public searchExample()
        {
            InitializeComponent();
            jusolinkService = jusolinkExample.jusolinkService;
        }

        // 주소검색
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int perPage = 20;           // 페이지당 목록 갯수 최대 100개
            bool noSuggest = false;     // 수정제시어 끄기
            bool noDiffer = false;      // 차등검색 끄기
            
            string relatedJibun;

            this.ActiveControl = txtIndex;

            try
            {
                SearchResult jusoInfo = jusolinkService.search(txtIndex.Text, pageNum, perPage, noSuggest, noDiffer);
                
                pageNum = jusoInfo.page;            // 페이지 번호
                totalPage = jusoInfo.totalPage;     // 전체 페이지 수 
                txtCurrentPage.Text = jusoInfo.page.ToString();
                txtTotalpage.Text = jusoInfo.totalPage.ToString();

                if (jusoInfo.suggest != null)
                {
                    suggestIndex = jusoInfo.suggest;    // 수정제시어 
                    txtSuggestIndex.Text = "수정제시어 : [" + jusoInfo.suggest + "] 검색결과 보기";

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
                        listView1.Items.Add(jusoInfo.juso[i].zipcode, 1);       // 우편번호
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].sectionNum);   // 새우편번호
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].roadAddr1);    // 도로명주소
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].roadAddr2);    // 도로명주소(참고항목)
                        listView1.Items[i].SubItems.Add(jusoInfo.juso[i].jibunAddr);    // 지번주소

                        relatedJibun = "";

                        if (jusoInfo.juso[i].relatedJibun != null)
                        {
                            for (int j = 0; j < jusoInfo.juso[i].relatedJibun.Count; j++)
                            {
                                relatedJibun += jusoInfo.juso[i].relatedJibun[j] + ' ';
                            }

                            listView1.Items[i].SubItems.Add(relatedJibun);      // 관련지번 목록
                        }
                    }
                }
                else
                {
                    MessageBox.Show("검색된 주소정보가 없습니다");
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
            // listview 아이템 height 조정을 위한 imageList 추가 
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);
            listView1.SmallImageList = imgList;
            this.ActiveControl = txtIndex;
        }

        // 수정제시어 선택
        private void txtSuggestIndex_Click(object sender, EventArgs e)
        {
            if (suggestIndex != null && suggestIndex != "")
            {
                pageNum = 1;
                txtIndex.Text = suggestIndex;
                btnSearch.PerformClick();
            }
        }

        // 이전페이지
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum = pageNum - 1;
                btnSearch.PerformClick();
            }

        }
        
        // 다음페이지
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNum < totalPage)
            {
                pageNum = pageNum + 1;
                btnSearch.PerformClick();
            }
        }

        // 검색어 수정
        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            pageNum = 1;
        }

        // 주소정보 선택
        private void listView1_Click(object sender, EventArgs e)
        {
            string zipcode = listView1.SelectedItems[0].Text; // 우편번호
            string sectionNum = listView1.SelectedItems[0].SubItems[1].Text;     // 새우편번호
            string roadaddr1 = listView1.SelectedItems[0].SubItems[2].Text;     // 도로명주소
            string roadaddr2 = listView1.SelectedItems[0].SubItems[3].Text;     // 도로명주소 참고항목
            string jibunaddr = listView1.SelectedItems[0].SubItems[4].Text;     // 지번주소
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


