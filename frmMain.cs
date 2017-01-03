using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using Google.Apis.Services;
using System.Text.RegularExpressions;
using System.Collections;

namespace signDrivenMenu
{
    public partial class frmMain : Form
    {
        private const String API_KEY = "AIzaSyAbwjAFgPR53yYq9pBqYVps6ro6Xlufsos";
        private const String ENGINE_ID = "Taehyun";
        private const int MIN_MENU_FREQUENCY = 3;
        private const int MIN_WORD_LENGTH = 3;
        
        private String[] GARBAGE_TEXT = {"cal", "Cal", "CaL"};

        private CustomLog mCustomLog;
        private CustomSearch mCustomSearch;
        private CustomTranslation mCustomTranslation;
        private CustomOCR mConvertOCR;
        private ImageProcess mImageProcess;

        private PictureBox[] mPbxMenu;

        private String mImageFilePath = "";
        private String mSignText = "";
        private String[] mMenuImagePath;
        private String mMenuText = "";
        private String mMenuInfo = "";

        public frmMain()
        {
            InitializeComponent();

            initializeVariable();

            pbxSign.SizeMode = PictureBoxSizeMode.Zoom;
            for (int i = 0; i < mPbxMenu.Length; i++)
            {
                mPbxMenu[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void initializeVariable()
        {
            mCustomLog = new CustomLog();
            mCustomLog.setLogTextBox(tbxLog);

            mCustomSearch = new CustomSearch();
            mCustomSearch.setKey(API_KEY);
            mCustomSearch.setEngineId(ENGINE_ID);

            mCustomTranslation = new CustomTranslation();
            mCustomTranslation.setKey(API_KEY);
            mCustomTranslation.setEngineId(ENGINE_ID);

            mConvertOCR = new CustomOCR();

            mImageProcess = new ImageProcess();

            mPbxMenu = new PictureBox[6];
            mPbxMenu[0] = pbxMenu1;
            mPbxMenu[1] = pbxMenu2;
            mPbxMenu[2] = pbxMenu3;
            mPbxMenu[3] = pbxMenu4;
            mPbxMenu[4] = pbxMenu5;
            mPbxMenu[5] = pbxMenu6;

            mMenuImagePath = new String[6];
            for (int i = 0; i < mMenuImagePath.Length; i++)
            {
                mMenuImagePath[i] = "";
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxSign.Image = Image.FromFile(openFileDialog.FileName);
                mImageFilePath = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void btnExtractSign_Click(object sender, EventArgs e)
        {
            //ocr
            String tempSignText = "";
            tempSignText = mConvertOCR.Convert2OCR(mImageFilePath);
            mCustomLog.d("Sign text extracted \n " + tempSignText);

            //text            
            String pattern = @"\d{3}\-\d{3,4}\-\d{4}$";
            tempSignText = Regex.Replace(tempSignText, pattern, "");   //핸드폰 번호 삭제 
            pattern = @"\d{2}\-\d{3,4}\-\d{4}$";
            tempSignText = Regex.Replace(tempSignText, pattern, "");   //일반 전화번호 삭제

            mSignText = tempSignText;

            tbxSignName.Clear();
            tbxSignName.AppendText(mSignText);
        }

        private void btnSearchKeyword_Click(object sender, EventArgs e)
        {
            //google web search            
            Search search = mCustomSearch.searchFromKeyword("맥도날드");
            int count = 0;
            try
            {
                foreach (var item in search.Items)
                {
                    Result.ImageData image = item.Image;

                    count++;
                    if (count > 10)
                    {
                        break;
                    }
                }
            }
            catch (Exception e2)
            {
                mCustomLog.e(e2.Message + " / " + e2.StackTrace);
            }

            String text = null;
            text = mCustomTranslation.translate("");

            mCustomLog.d("Keyword searching is finished");

            mCustomLog.d("Some menu images is selected");
        }

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            mCustomLog.d("Image searching is finished");
        }

        private void btnExtractInfo_Click(object sender, EventArgs e)
        {
            //simple extract text from menu images
            for (int i = 0; i < mPbxMenu.Length; i++) 
            {
                if (mMenuImagePath[i].Length > 0)
                {
                    mMenuText += mConvertOCR.Convert2OCR(mMenuImagePath[i]);
                    mCustomLog.d("menu image[" + (i + 1) + "]'s data is extracted");
                }                
            }

            //extract keyword from menu text
            mMenuText = Regex.Replace(mMenuText, @"[^a-zA-Z]", " ");    //remove symbol //^0-9a-zA-Z
            for (int i = 0; i < GARBAGE_TEXT.Length; i++)               //remove no meaning word
            {
                mMenuText = mMenuText.Replace(GARBAGE_TEXT[i], "");  
            }

            Dictionary<String, int> hashtable = new Dictionary<String, int>();
            String[] words = mMenuText.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > MIN_WORD_LENGTH)
                {
                    if (hashtable.ContainsKey(words[i]))
                    {
                        hashtable[words[i]] = (int)hashtable[words[i]] + 1;
                    }
                    else
                    {
                        hashtable.Add(words[i], 1);
                    }
                }
            }

            mMenuText = "";
            mMenuInfo = "";
            List<KeyValuePair<String, int>> sortList = new List<KeyValuePair<String, int>>();
            sortList.AddRange(hashtable);
            sortList.Sort
            (
                delegate(KeyValuePair<string, int> kvp1, KeyValuePair<string, int> kvp2)
                {
                    return Comparer<int>.Default.Compare(kvp1.Value, kvp2.Value);
                }
            );
            sortList.Reverse();
            foreach (KeyValuePair<string, int> item in sortList)
            {
                mMenuText += item.Key + " : " + item.Value + "회 \n";
                if (item.Value > MIN_MENU_FREQUENCY)
                {
                    mMenuInfo += item.Key + " / ";
                }            
            }

            tbxMenuData.Clear();
            tbxMenuData.AppendText(mMenuText);
            mCustomLog.d("extracting menu data is complete");

            mMenuInfo = mMenuInfo.Substring(0, mMenuInfo.Length - 2);
            tbxMenuInfo.Clear();
            tbxMenuInfo.AppendText(mMenuInfo);
            mCustomLog.d("making menu is complete");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnImageProcess_Click(object sender, EventArgs e)
        {
            //Image processing and save
            mImageFilePath = mImageProcess.getVividImage(mImageFilePath);
            mCustomLog.d("Image processing is complete");
        }

        private void pbxMenu1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mPbxMenu[0].Image = Image.FromFile(openFileDialog.FileName);
                mMenuImagePath[0] = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void pbxMenu2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mPbxMenu[1].Image = Image.FromFile(openFileDialog.FileName);
                mMenuImagePath[1] = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void pbxMenu3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mPbxMenu[2].Image = Image.FromFile(openFileDialog.FileName);
                mMenuImagePath[2] = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void pbxMenu4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mPbxMenu[3].Image = Image.FromFile(openFileDialog.FileName);
                mMenuImagePath[3] = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void pbxMenu5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mPbxMenu[4].Image = Image.FromFile(openFileDialog.FileName);
                mMenuImagePath[4] = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void pbxMenu6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mPbxMenu[5].Image = Image.FromFile(openFileDialog.FileName);
                mMenuImagePath[5] = openFileDialog.FileName;

                mCustomLog.d("Image loading is complete");
            }
            else
            {
                mCustomLog.d("Image loading is failed");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
