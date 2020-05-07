namespace PalmprintRecognition
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.trainingFile_btn = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.testPic = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.testImageFile_btn = new DevExpress.XtraEditors.ButtonEdit();
            this.matchpic = new DevExpress.XtraEditors.PictureEdit();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.resultlab = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.trainingFile_btn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testImageFile_btn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchpic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Black";
            // 
            // xtraFolderBrowserDialog1
            // 
            this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // trainingFile_btn
            // 
            this.trainingFile_btn.EditValue = "F:\\掌纹识别技术\\palmprint PCA\\TrainDatabase";
            this.trainingFile_btn.Location = new System.Drawing.Point(142, 24);
            this.trainingFile_btn.Name = "trainingFile_btn";
            this.trainingFile_btn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.trainingFile_btn.Size = new System.Drawing.Size(422, 20);
            this.trainingFile_btn.TabIndex = 0;
            this.trainingFile_btn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.trainingFile_btn_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "导入训练库";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(41, 299);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 36);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "开始掌纹识别";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // testPic
            // 
            this.testPic.Location = new System.Drawing.Point(41, 121);
            this.testPic.Name = "testPic";
            this.testPic.Properties.Caption.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.testPic.Properties.Caption.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.testPic.Properties.Caption.Appearance.Options.UseForeColor = true;
            this.testPic.Properties.Caption.Text = "测试掌纹";
            this.testPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.testPic.Size = new System.Drawing.Size(217, 152);
            this.testPic.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "选择待识别掌纹";
            // 
            // testImageFile_btn
            // 
            this.testImageFile_btn.EditValue = "F:\\掌纹识别技术\\palmprint PCA\\TestDatabase\\2.bmp";
            this.testImageFile_btn.Location = new System.Drawing.Point(142, 63);
            this.testImageFile_btn.Name = "testImageFile_btn";
            this.testImageFile_btn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.testImageFile_btn.Size = new System.Drawing.Size(422, 20);
            this.testImageFile_btn.TabIndex = 6;
            this.testImageFile_btn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.testImageFile_btn_ButtonClick);
            // 
            // matchpic
            // 
            this.matchpic.Location = new System.Drawing.Point(347, 121);
            this.matchpic.Name = "matchpic";
            this.matchpic.Properties.Caption.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.matchpic.Properties.Caption.Appearance.ForeColor = System.Drawing.Color.Aqua;
            this.matchpic.Properties.Caption.Appearance.Options.UseForeColor = true;
            this.matchpic.Properties.Caption.Text = "匹配掌纹";
            this.matchpic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.matchpic.Size = new System.Drawing.Size(217, 152);
            this.matchpic.TabIndex = 7;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // resultlab
            // 
            this.resultlab.Appearance.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Italic);
            this.resultlab.Appearance.ForeColor = System.Drawing.Color.DarkViolet;
            this.resultlab.Appearance.Options.UseFont = true;
            this.resultlab.Appearance.Options.UseForeColor = true;
            this.resultlab.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.resultlab.LineVisible = true;
            this.resultlab.Location = new System.Drawing.Point(131, 310);
            this.resultlab.Name = "resultlab";
            this.resultlab.Size = new System.Drawing.Size(64, 13);
            this.resultlab.TabIndex = 8;
            this.resultlab.Text = "resultlab";
            // 
            // MainFrm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 395);
            this.Controls.Add(this.resultlab);
            this.Controls.Add(this.matchpic);
            this.Controls.Add(this.testImageFile_btn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.testPic);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.trainingFile_btn);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "掌纹采集识别系统";
            ((System.ComponentModel.ISupportInitialize)(this.trainingFile_btn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testImageFile_btn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchpic.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
        private DevExpress.XtraEditors.ButtonEdit trainingFile_btn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit testPic;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit testImageFile_btn;
        private DevExpress.XtraEditors.PictureEdit matchpic;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.LabelControl resultlab;
    }
}

