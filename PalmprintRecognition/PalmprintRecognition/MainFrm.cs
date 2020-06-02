using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MathWorks.MATLAB.NET.Arrays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalmprintRecognition
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
            xtraOpenFileDialog1.Filter = "BMP图片|*.bmp|图片文件|*.jpg|Gif图片|*.gif";
            resultlab.Text = "";
        }

        private palmprintPCA.PCA pCA = new palmprintPCA.PCA();

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            matchpic.Image = null;
            resultlab.Text = "";
            string trainingPath = trainingFile_btn.Text;
            string testImage = testImageFile_btn.Text;

            if (string.IsNullOrEmpty(trainingPath))
            {
                XtraMessageBox.Show("训练数据库为空！");
                return;
            }
            if (string.IsNullOrEmpty(testImage))
            {
                XtraMessageBox.Show("测试掌纹路径为空！");
                return;
            }

            IOverlaySplashScreenHandle handle = null;
            try
            {
                handle = SplashScreenManager.ShowOverlayForm(this);
                string equalImage = await Task.Run(() =>
                {
                    string mathImage;
                    try
                    {
                        MWArray arr = pCA.palmprintPCA(trainingPath, testImage);
                        mathImage = Convert.ToString(arr);
                        Thread.Sleep(500);//故意在此处休眠模拟识别时间
                    }
                    catch (Exception ex)
                    {
                        mathImage = "";
                        XtraMessageBox.Show($"掌纹识别出错：{ex.Message}");
                    }

                    return mathImage;
                });

                matchpic.Image = Image.FromFile(equalImage);
                int index = equalImage.LastIndexOf("\\");
                resultlab.Text = $"匹配到的掌纹为训练库中的{equalImage.Substring(index + 1, equalImage.Length - index - 1)}";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"掌纹加载出错：{ex.Message}");
            }
            finally
            {
                SplashScreenManager.CloseOverlayForm(handle);
            }
        }

        private void trainingFile_btn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                trainingFile_btn.Text = xtraFolderBrowserDialog1.SelectedPath;
            }
        }

        private void testImageFile_btn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    testImageFile_btn.Text = xtraOpenFileDialog1.FileName;
                    testPic.Image = Image.FromFile(testImageFile_btn.Text, true);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"加载掌纹图片出错：{ex.Message}");
                }

            }
        }
    }
}
