using System.Threading;

namespace StegProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.choosePic_btn = new System.Windows.Forms.Button();
            this.Encoding_tab_control = new System.Windows.Forms.TabControl();
            this.welcome_tabPage = new System.Windows.Forms.TabPage();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.menu_groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelh5 = new System.Windows.Forms.Panel();
            this.panelm5 = new System.Windows.Forms.Panel();
            this.about_button = new System.Windows.Forms.Button();
            this.panelh4 = new System.Windows.Forms.Panel();
            this.panelm4 = new System.Windows.Forms.Panel();
            this.help_button = new System.Windows.Forms.Button();
            this.panelh3 = new System.Windows.Forms.Panel();
            this.panelm3 = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.menu_groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelh2 = new System.Windows.Forms.Panel();
            this.panelm2 = new System.Windows.Forms.Panel();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.panelh1 = new System.Windows.Forms.Panel();
            this.panelm1 = new System.Windows.Forms.Panel();
            this.crypt_button = new System.Windows.Forms.Button();
            this.encode_tabPage = new System.Windows.Forms.TabPage();
            this.scrol_groupBox = new System.Windows.Forms.GroupBox();
            this.trackBar_label = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pic_groupBox = new System.Windows.Forms.GroupBox();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.shifr_panel = new System.Windows.Forms.Panel();
            this.shifr_clear_text_btn = new System.Windows.Forms.Button();
            this.code_progressBar = new System.Windows.Forms.ProgressBar();
            this.capacityText_lbl = new System.Windows.Forms.Label();
            this.decode_btn = new System.Windows.Forms.Button();
            this.fullPathOrName_lbl = new System.Windows.Forms.Label();
            this.resetPic_btn = new System.Windows.Forms.Button();
            this.saveEncodedPic_btn = new System.Windows.Forms.Button();
            this.pic_box2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crypt_progressBar = new System.Windows.Forms.ProgressBar();
            this.mainTab_dataGridView = new System.Windows.Forms.DataGridView();
            this.selectedDir_lbl = new System.Windows.Forms.Label();
            this.deleteDir_btn = new System.Windows.Forms.Button();
            this.chooseDir_btn = new System.Windows.Forms.Button();
            this.textFile_groupBox = new System.Windows.Forms.GroupBox();
            this.text_tabControl = new System.Windows.Forms.TabControl();
            this.text_tabPage = new System.Windows.Forms.TabPage();
            this.crypto_rTB = new System.Windows.Forms.RichTextBox();
            this.file_tabPage = new System.Windows.Forms.TabPage();
            this.file_richTextBox = new System.Windows.Forms.RichTextBox();
            this.writeOn_radioButton = new System.Windows.Forms.RadioButton();
            this.chose_radioButton = new System.Windows.Forms.RadioButton();
            this.selectedfile_lbl = new System.Windows.Forms.Label();
            this.chooseTextFile_btn = new System.Windows.Forms.Button();
            this.resetTextFile_btn = new System.Windows.Forms.Button();
            this.pic_box1 = new System.Windows.Forms.PictureBox();
            this.decode_tabPage = new System.Windows.Forms.TabPage();
            this.deshifr_panel = new System.Windows.Forms.Panel();
            this.deshifr_progressBar = new System.Windows.Forms.ProgressBar();
            this.deshifr_clear_text_btn = new System.Windows.Forms.Button();
            this.encodePic_gB = new System.Windows.Forms.GroupBox();
            this.resetDecPic_btn_Click = new System.Windows.Forms.Button();
            this.chooseDecPic_btn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.decode_rtb = new System.Windows.Forms.RichTextBox();
            this.save_deshifr_btn = new System.Windows.Forms.Button();
            this.decode_PB = new System.Windows.Forms.PictureBox();
            this.help_tabPage = new System.Windows.Forms.TabPage();
            this.help_groupBox = new System.Windows.Forms.GroupBox();
            this.help_rtb = new System.Windows.Forms.RichTextBox();
            this.setings_tabPage = new System.Windows.Forms.TabPage();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.password_groupBox = new System.Windows.Forms.GroupBox();
            this.changepass_button = new System.Windows.Forms.Button();
            this.newpass_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newpass_label = new System.Windows.Forms.Label();
            this.oldpass_label = new System.Windows.Forms.Label();
            this.theme_groupBox = new System.Windows.Forms.GroupBox();
            this.theme4_rb = new System.Windows.Forms.RadioButton();
            this.theme3_rb = new System.Windows.Forms.RadioButton();
            this.theme2_rb = new System.Windows.Forms.RadioButton();
            this.theme1_rb = new System.Windows.Forms.RadioButton();
            this.about_tabPage = new System.Windows.Forms.TabPage();
            this.about_groupBox = new System.Windows.Forms.GroupBox();
            this.about_rtb = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Encoding_tab_control.SuspendLayout();
            this.welcome_tabPage.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.menu_groupBox2.SuspendLayout();
            this.panelh5.SuspendLayout();
            this.panelm5.SuspendLayout();
            this.panelh4.SuspendLayout();
            this.panelm4.SuspendLayout();
            this.panelh3.SuspendLayout();
            this.panelm3.SuspendLayout();
            this.menu_groupBox1.SuspendLayout();
            this.panelh2.SuspendLayout();
            this.panelm2.SuspendLayout();
            this.panelh1.SuspendLayout();
            this.panelm1.SuspendLayout();
            this.encode_tabPage.SuspendLayout();
            this.scrol_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.pic_groupBox.SuspendLayout();
            this.shifr_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTab_dataGridView)).BeginInit();
            this.textFile_groupBox.SuspendLayout();
            this.text_tabControl.SuspendLayout();
            this.text_tabPage.SuspendLayout();
            this.file_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box1)).BeginInit();
            this.decode_tabPage.SuspendLayout();
            this.deshifr_panel.SuspendLayout();
            this.encodePic_gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decode_PB)).BeginInit();
            this.help_tabPage.SuspendLayout();
            this.help_groupBox.SuspendLayout();
            this.setings_tabPage.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.password_groupBox.SuspendLayout();
            this.theme_groupBox.SuspendLayout();
            this.about_tabPage.SuspendLayout();
            this.about_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(987, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 15);
            this.button1.TabIndex = 0;
            this.button1.Text = "Записать ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(971, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 14);
            this.button2.TabIndex = 2;
            this.button2.Text = "Прочитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // choosePic_btn
            // 
            this.choosePic_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.choosePic_btn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePic_btn.Location = new System.Drawing.Point(6, 39);
            this.choosePic_btn.Name = "choosePic_btn";
            this.choosePic_btn.Size = new System.Drawing.Size(40, 37);
            this.choosePic_btn.TabIndex = 27;
            this.choosePic_btn.Text = "+";
            this.choosePic_btn.UseVisualStyleBackColor = false;
            this.choosePic_btn.Click += new System.EventHandler(this.choosePic_btn_Click);
            // 
            // Encoding_tab_control
            // 
            this.Encoding_tab_control.Controls.Add(this.welcome_tabPage);
            this.Encoding_tab_control.Controls.Add(this.encode_tabPage);
            this.Encoding_tab_control.Controls.Add(this.decode_tabPage);
            this.Encoding_tab_control.Controls.Add(this.help_tabPage);
            this.Encoding_tab_control.Controls.Add(this.setings_tabPage);
            this.Encoding_tab_control.Controls.Add(this.about_tabPage);
            this.Encoding_tab_control.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encoding_tab_control.Location = new System.Drawing.Point(2, 3);
            this.Encoding_tab_control.Name = "Encoding_tab_control";
            this.Encoding_tab_control.SelectedIndex = 0;
            this.Encoding_tab_control.Size = new System.Drawing.Size(1160, 611);
            this.Encoding_tab_control.TabIndex = 28;
            // 
            // welcome_tabPage
            // 
            this.welcome_tabPage.BackColor = System.Drawing.Color.LightBlue;
            this.welcome_tabPage.Controls.Add(this.menu_panel);
            this.welcome_tabPage.Location = new System.Drawing.Point(4, 25);
            this.welcome_tabPage.Name = "welcome_tabPage";
            this.welcome_tabPage.Size = new System.Drawing.Size(1152, 582);
            this.welcome_tabPage.TabIndex = 3;
            this.welcome_tabPage.Text = " ≡ Меню";
            this.welcome_tabPage.Click += new System.EventHandler(this.welcome_tabPage_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.menu_groupBox2);
            this.menu_panel.Controls.Add(this.menu_groupBox1);
            this.menu_panel.Location = new System.Drawing.Point(6, 5);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(831, 488);
            this.menu_panel.TabIndex = 6;
            // 
            // menu_groupBox2
            // 
            this.menu_groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_groupBox2.Controls.Add(this.panelh5);
            this.menu_groupBox2.Controls.Add(this.panelh4);
            this.menu_groupBox2.Controls.Add(this.panelh3);
            this.menu_groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_groupBox2.Location = new System.Drawing.Point(12, 135);
            this.menu_groupBox2.Name = "menu_groupBox2";
            this.menu_groupBox2.Size = new System.Drawing.Size(800, 291);
            this.menu_groupBox2.TabIndex = 5;
            this.menu_groupBox2.TabStop = false;
            this.menu_groupBox2.Text = "Поддержка";
            this.menu_groupBox2.Enter += new System.EventHandler(this.menu_groupBox2_Enter);
            // 
            // panelh5
            // 
            this.panelh5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelh5.Controls.Add(this.panelm5);
            this.panelh5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelh5.Location = new System.Drawing.Point(278, 151);
            this.panelh5.Name = "panelh5";
            this.panelh5.Size = new System.Drawing.Size(215, 72);
            this.panelh5.TabIndex = 6;
            // 
            // panelm5
            // 
            this.panelm5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelm5.Controls.Add(this.about_button);
            this.panelm5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelm5.Location = new System.Drawing.Point(16, 7);
            this.panelm5.Name = "panelm5";
            this.panelm5.Size = new System.Drawing.Size(187, 57);
            this.panelm5.TabIndex = 5;
            // 
            // about_button
            // 
            this.about_button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.about_button.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_button.Location = new System.Drawing.Point(12, 6);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(161, 45);
            this.about_button.TabIndex = 5;
            this.about_button.Text = "О программе..";
            this.toolTip1.SetToolTip(this.about_button, "О программе");
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // panelh4
            // 
            this.panelh4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelh4.Controls.Add(this.panelm4);
            this.panelh4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelh4.Location = new System.Drawing.Point(400, 52);
            this.panelh4.Name = "panelh4";
            this.panelh4.Size = new System.Drawing.Size(215, 72);
            this.panelh4.TabIndex = 5;
            // 
            // panelm4
            // 
            this.panelm4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelm4.Controls.Add(this.help_button);
            this.panelm4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelm4.Location = new System.Drawing.Point(16, 7);
            this.panelm4.Name = "panelm4";
            this.panelm4.Size = new System.Drawing.Size(187, 57);
            this.panelm4.TabIndex = 5;
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.SlateBlue;
            this.help_button.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_button.Location = new System.Drawing.Point(12, 6);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(161, 45);
            this.help_button.TabIndex = 4;
            this.help_button.Text = "Справка..";
            this.toolTip1.SetToolTip(this.help_button, "Справка");
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // panelh3
            // 
            this.panelh3.BackColor = System.Drawing.Color.Turquoise;
            this.panelh3.Controls.Add(this.panelm3);
            this.panelh3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelh3.Location = new System.Drawing.Point(155, 52);
            this.panelh3.Name = "panelh3";
            this.panelh3.Size = new System.Drawing.Size(215, 72);
            this.panelh3.TabIndex = 4;
            // 
            // panelm3
            // 
            this.panelm3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelm3.Controls.Add(this.settings_button);
            this.panelm3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelm3.Location = new System.Drawing.Point(16, 7);
            this.panelm3.Name = "panelm3";
            this.panelm3.Size = new System.Drawing.Size(187, 57);
            this.panelm3.TabIndex = 5;
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.settings_button.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_button.Location = new System.Drawing.Point(12, 6);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(161, 45);
            this.settings_button.TabIndex = 3;
            this.settings_button.Text = "Настройки..";
            this.toolTip1.SetToolTip(this.settings_button, "Настройки");
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // menu_groupBox1
            // 
            this.menu_groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu_groupBox1.Controls.Add(this.panelh2);
            this.menu_groupBox1.Controls.Add(this.panelh1);
            this.menu_groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_groupBox1.Location = new System.Drawing.Point(12, 15);
            this.menu_groupBox1.Name = "menu_groupBox1";
            this.menu_groupBox1.Size = new System.Drawing.Size(800, 105);
            this.menu_groupBox1.TabIndex = 4;
            this.menu_groupBox1.TabStop = false;
            this.menu_groupBox1.Text = "Шифрование";
            // 
            // panelh2
            // 
            this.panelh2.BackColor = System.Drawing.Color.Turquoise;
            this.panelh2.Controls.Add(this.panelm2);
            this.panelh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelh2.Location = new System.Drawing.Point(400, 22);
            this.panelh2.Name = "panelh2";
            this.panelh2.Size = new System.Drawing.Size(215, 72);
            this.panelh2.TabIndex = 5;
            // 
            // panelm2
            // 
            this.panelm2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelm2.Controls.Add(this.encrypt_button);
            this.panelm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelm2.Location = new System.Drawing.Point(16, 7);
            this.panelm2.Name = "panelm2";
            this.panelm2.Size = new System.Drawing.Size(187, 57);
            this.panelm2.TabIndex = 5;
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.encrypt_button.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_button.Location = new System.Drawing.Point(13, 6);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(161, 45);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "||| Дешифровать..";
            this.toolTip1.SetToolTip(this.encrypt_button, "Дешифровать");
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // panelh1
            // 
            this.panelh1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelh1.Controls.Add(this.panelm1);
            this.panelh1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelh1.Location = new System.Drawing.Point(155, 22);
            this.panelh1.Name = "panelh1";
            this.panelh1.Size = new System.Drawing.Size(215, 72);
            this.panelh1.TabIndex = 2;
            // 
            // panelm1
            // 
            this.panelm1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelm1.Controls.Add(this.crypt_button);
            this.panelm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelm1.Location = new System.Drawing.Point(16, 7);
            this.panelm1.Name = "panelm1";
            this.panelm1.Size = new System.Drawing.Size(187, 57);
            this.panelm1.TabIndex = 5;
            // 
            // crypt_button
            // 
            this.crypt_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.crypt_button.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crypt_button.Location = new System.Drawing.Point(12, 6);
            this.crypt_button.Name = "crypt_button";
            this.crypt_button.Size = new System.Drawing.Size(161, 45);
            this.crypt_button.TabIndex = 1;
            this.crypt_button.Text = "Ⳮ Зашифровать..";
            this.toolTip1.SetToolTip(this.crypt_button, "Зашифровать");
            this.crypt_button.UseVisualStyleBackColor = false;
            this.crypt_button.Click += new System.EventHandler(this.crypt_button_Click);
            // 
            // encode_tabPage
            // 
            this.encode_tabPage.BackColor = System.Drawing.Color.LightBlue;
            this.encode_tabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encode_tabPage.Controls.Add(this.scrol_groupBox);
            this.encode_tabPage.Controls.Add(this.pic_groupBox);
            this.encode_tabPage.Controls.Add(this.encrypt_btn);
            this.encode_tabPage.Controls.Add(this.button1);
            this.encode_tabPage.Controls.Add(this.button2);
            this.encode_tabPage.Controls.Add(this.shifr_panel);
            this.encode_tabPage.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encode_tabPage.Location = new System.Drawing.Point(4, 25);
            this.encode_tabPage.Name = "encode_tabPage";
            this.encode_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encode_tabPage.Size = new System.Drawing.Size(1152, 582);
            this.encode_tabPage.TabIndex = 0;
            this.encode_tabPage.Text = "Ⳮ Шифрация..";
            this.encode_tabPage.Click += new System.EventHandler(this.encode_tabPage_Click);
            // 
            // scrol_groupBox
            // 
            this.scrol_groupBox.Controls.Add(this.trackBar_label);
            this.scrol_groupBox.Controls.Add(this.trackBar1);
            this.scrol_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrol_groupBox.Location = new System.Drawing.Point(997, 349);
            this.scrol_groupBox.Name = "scrol_groupBox";
            this.scrol_groupBox.Size = new System.Drawing.Size(121, 75);
            this.scrol_groupBox.TabIndex = 38;
            this.scrol_groupBox.TabStop = false;
            this.scrol_groupBox.Text = "Кодируемых байт";
            this.scrol_groupBox.Visible = false;
            // 
            // trackBar_label
            // 
            this.trackBar_label.AutoSize = true;
            this.trackBar_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.trackBar_label.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackBar_label.Location = new System.Drawing.Point(50, 19);
            this.trackBar_label.Name = "trackBar_label";
            this.trackBar_label.Size = new System.Drawing.Size(17, 20);
            this.trackBar_label.TabIndex = 37;
            this.trackBar_label.Text = "1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 46);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(83, 45);
            this.trackBar1.TabIndex = 36;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pic_groupBox
            // 
            this.pic_groupBox.Controls.Add(this.choosePic_btn);
            this.pic_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pic_groupBox.Location = new System.Drawing.Point(924, 209);
            this.pic_groupBox.Name = "pic_groupBox";
            this.pic_groupBox.Size = new System.Drawing.Size(115, 70);
            this.pic_groupBox.TabIndex = 33;
            this.pic_groupBox.TabStop = false;
            this.pic_groupBox.Text = "Изображение";
            this.pic_groupBox.Visible = false;
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.BackColor = System.Drawing.Color.DarkKhaki;
            this.encrypt_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_btn.Location = new System.Drawing.Point(1069, 253);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(27, 252);
            this.encrypt_btn.TabIndex = 31;
            this.encrypt_btn.Text = "▷";
            this.encrypt_btn.UseVisualStyleBackColor = false;
            this.encrypt_btn.Visible = false;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // shifr_panel
            // 
            this.shifr_panel.Controls.Add(this.shifr_clear_text_btn);
            this.shifr_panel.Controls.Add(this.code_progressBar);
            this.shifr_panel.Controls.Add(this.capacityText_lbl);
            this.shifr_panel.Controls.Add(this.decode_btn);
            this.shifr_panel.Controls.Add(this.fullPathOrName_lbl);
            this.shifr_panel.Controls.Add(this.resetPic_btn);
            this.shifr_panel.Controls.Add(this.saveEncodedPic_btn);
            this.shifr_panel.Controls.Add(this.pic_box2);
            this.shifr_panel.Controls.Add(this.groupBox1);
            this.shifr_panel.Controls.Add(this.textFile_groupBox);
            this.shifr_panel.Controls.Add(this.pic_box1);
            this.shifr_panel.Location = new System.Drawing.Point(6, 5);
            this.shifr_panel.Name = "shifr_panel";
            this.shifr_panel.Size = new System.Drawing.Size(872, 577);
            this.shifr_panel.TabIndex = 42;
            // 
            // shifr_clear_text_btn
            // 
            this.shifr_clear_text_btn.BackColor = System.Drawing.Color.Silver;
            this.shifr_clear_text_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifr_clear_text_btn.Location = new System.Drawing.Point(797, 112);
            this.shifr_clear_text_btn.Name = "shifr_clear_text_btn";
            this.shifr_clear_text_btn.Size = new System.Drawing.Size(40, 37);
            this.shifr_clear_text_btn.TabIndex = 42;
            this.shifr_clear_text_btn.Text = "✖";
            this.toolTip1.SetToolTip(this.shifr_clear_text_btn, "Очистить текстовое поле");
            this.shifr_clear_text_btn.UseVisualStyleBackColor = false;
            this.shifr_clear_text_btn.Click += new System.EventHandler(this.shifr_clear_text_btn_Click);
            // 
            // code_progressBar
            // 
            this.code_progressBar.Location = new System.Drawing.Point(9, 568);
            this.code_progressBar.Name = "code_progressBar";
            this.code_progressBar.Size = new System.Drawing.Size(781, 15);
            this.code_progressBar.TabIndex = 42;
            this.toolTip1.SetToolTip(this.code_progressBar, "Процесс записи текста в контейнер");
            // 
            // capacityText_lbl
            // 
            this.capacityText_lbl.AutoSize = true;
            this.capacityText_lbl.Location = new System.Drawing.Point(428, 283);
            this.capacityText_lbl.Name = "capacityText_lbl";
            this.capacityText_lbl.Size = new System.Drawing.Size(12, 16);
            this.capacityText_lbl.TabIndex = 36;
            this.capacityText_lbl.Text = ".";
            // 
            // decode_btn
            // 
            this.decode_btn.BackColor = System.Drawing.Color.LightGreen;
            this.decode_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode_btn.Location = new System.Drawing.Point(386, 301);
            this.decode_btn.Name = "decode_btn";
            this.decode_btn.Size = new System.Drawing.Size(27, 252);
            this.decode_btn.TabIndex = 7;
            this.decode_btn.Text = "▷";
            this.toolTip1.SetToolTip(this.decode_btn, "Записать в контейнер");
            this.decode_btn.UseVisualStyleBackColor = false;
            this.decode_btn.Click += new System.EventHandler(this.decode_btn_Click);
            // 
            // fullPathOrName_lbl
            // 
            this.fullPathOrName_lbl.AutoSize = true;
            this.fullPathOrName_lbl.Location = new System.Drawing.Point(16, 283);
            this.fullPathOrName_lbl.Name = "fullPathOrName_lbl";
            this.fullPathOrName_lbl.Size = new System.Drawing.Size(12, 16);
            this.fullPathOrName_lbl.TabIndex = 39;
            this.fullPathOrName_lbl.Text = ".";
            this.toolTip1.SetToolTip(this.fullPathOrName_lbl, "Имя выбранного файла");
            // 
            // resetPic_btn
            // 
            this.resetPic_btn.BackColor = System.Drawing.Color.Tomato;
            this.resetPic_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetPic_btn.Location = new System.Drawing.Point(797, 301);
            this.resetPic_btn.Name = "resetPic_btn";
            this.resetPic_btn.Size = new System.Drawing.Size(40, 37);
            this.resetPic_btn.TabIndex = 30;
            this.resetPic_btn.Text = "✖";
            this.toolTip1.SetToolTip(this.resetPic_btn, "Очистить формы изображений");
            this.resetPic_btn.UseVisualStyleBackColor = false;
            this.resetPic_btn.Click += new System.EventHandler(this.resetPic_btn_Click);
            // 
            // saveEncodedPic_btn
            // 
            this.saveEncodedPic_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveEncodedPic_btn.Font = new System.Drawing.Font("Gigi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEncodedPic_btn.Location = new System.Drawing.Point(797, 516);
            this.saveEncodedPic_btn.Name = "saveEncodedPic_btn";
            this.saveEncodedPic_btn.Size = new System.Drawing.Size(40, 37);
            this.saveEncodedPic_btn.TabIndex = 35;
            this.saveEncodedPic_btn.Text = "💾";
            this.toolTip1.SetToolTip(this.saveEncodedPic_btn, "Сохранить bmp-контейнер");
            this.saveEncodedPic_btn.UseVisualStyleBackColor = false;
            this.saveEncodedPic_btn.Click += new System.EventHandler(this.saveEncodedPic_btn_Click);
            // 
            // pic_box2
            // 
            this.pic_box2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pic_box2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_box2.Location = new System.Drawing.Point(419, 301);
            this.pic_box2.Name = "pic_box2";
            this.pic_box2.Size = new System.Drawing.Size(371, 252);
            this.pic_box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box2.TabIndex = 1;
            this.pic_box2.TabStop = false;
            this.pic_box2.Click += new System.EventHandler(this.pic_box2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.crypt_progressBar);
            this.groupBox1.Controls.Add(this.mainTab_dataGridView);
            this.groupBox1.Controls.Add(this.selectedDir_lbl);
            this.groupBox1.Controls.Add(this.deleteDir_btn);
            this.groupBox1.Controls.Add(this.chooseDir_btn);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 273);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать директорию для анализа изображений";
            // 
            // crypt_progressBar
            // 
            this.crypt_progressBar.Location = new System.Drawing.Point(10, 64);
            this.crypt_progressBar.Name = "crypt_progressBar";
            this.crypt_progressBar.Size = new System.Drawing.Size(352, 10);
            this.crypt_progressBar.TabIndex = 40;
            this.toolTip1.SetToolTip(this.crypt_progressBar, "Процесс анализа изображений");
            // 
            // mainTab_dataGridView
            // 
            this.mainTab_dataGridView.AllowUserToAddRows = false;
            this.mainTab_dataGridView.AllowUserToDeleteRows = false;
            this.mainTab_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTab_dataGridView.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.mainTab_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTab_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainTab_dataGridView.Location = new System.Drawing.Point(10, 105);
            this.mainTab_dataGridView.Name = "mainTab_dataGridView";
            this.mainTab_dataGridView.ReadOnly = true;
            this.mainTab_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.mainTab_dataGridView.RowHeadersVisible = false;
            this.mainTab_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTab_dataGridView.Size = new System.Drawing.Size(351, 155);
            this.mainTab_dataGridView.TabIndex = 39;
            this.mainTab_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTab_dataGridView_CellContentClick_1);
            this.mainTab_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTab_dataGridView_CellValueChanged);
            // 
            // selectedDir_lbl
            // 
            this.selectedDir_lbl.AutoSize = true;
            this.selectedDir_lbl.Location = new System.Drawing.Point(7, 75);
            this.selectedDir_lbl.MaximumSize = new System.Drawing.Size(777, 0);
            this.selectedDir_lbl.Name = "selectedDir_lbl";
            this.selectedDir_lbl.Size = new System.Drawing.Size(12, 18);
            this.selectedDir_lbl.TabIndex = 36;
            this.selectedDir_lbl.Text = ".";
            this.selectedDir_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.selectedDir_lbl, "Путь к директории");
            // 
            // deleteDir_btn
            // 
            this.deleteDir_btn.BackColor = System.Drawing.Color.Tomato;
            this.deleteDir_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDir_btn.Location = new System.Drawing.Point(56, 20);
            this.deleteDir_btn.Name = "deleteDir_btn";
            this.deleteDir_btn.Size = new System.Drawing.Size(40, 37);
            this.deleteDir_btn.TabIndex = 2;
            this.deleteDir_btn.Text = "✖";
            this.toolTip1.SetToolTip(this.deleteDir_btn, "Отменить выбор директории");
            this.deleteDir_btn.UseVisualStyleBackColor = false;
            this.deleteDir_btn.Click += new System.EventHandler(this.deleteDir_btn_Click);
            // 
            // chooseDir_btn
            // 
            this.chooseDir_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.chooseDir_btn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDir_btn.Location = new System.Drawing.Point(10, 20);
            this.chooseDir_btn.Name = "chooseDir_btn";
            this.chooseDir_btn.Size = new System.Drawing.Size(40, 37);
            this.chooseDir_btn.TabIndex = 1;
            this.chooseDir_btn.Text = "+";
            this.toolTip1.SetToolTip(this.chooseDir_btn, "Выбрать директорию с bmp-изображениями");
            this.chooseDir_btn.UseVisualStyleBackColor = false;
            this.chooseDir_btn.Click += new System.EventHandler(this.chooseDir_btn_Click);
            // 
            // textFile_groupBox
            // 
            this.textFile_groupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textFile_groupBox.Controls.Add(this.text_tabControl);
            this.textFile_groupBox.Controls.Add(this.writeOn_radioButton);
            this.textFile_groupBox.Controls.Add(this.chose_radioButton);
            this.textFile_groupBox.Controls.Add(this.selectedfile_lbl);
            this.textFile_groupBox.Controls.Add(this.chooseTextFile_btn);
            this.textFile_groupBox.Controls.Add(this.resetTextFile_btn);
            this.textFile_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textFile_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFile_groupBox.Location = new System.Drawing.Point(412, 7);
            this.textFile_groupBox.Name = "textFile_groupBox";
            this.textFile_groupBox.Size = new System.Drawing.Size(379, 273);
            this.textFile_groupBox.TabIndex = 34;
            this.textFile_groupBox.TabStop = false;
            this.textFile_groupBox.Text = "Выбрать текстовый файл или ввести текст";
            // 
            // text_tabControl
            // 
            this.text_tabControl.Controls.Add(this.text_tabPage);
            this.text_tabControl.Controls.Add(this.file_tabPage);
            this.text_tabControl.Location = new System.Drawing.Point(11, 105);
            this.text_tabControl.Name = "text_tabControl";
            this.text_tabControl.SelectedIndex = 0;
            this.text_tabControl.Size = new System.Drawing.Size(362, 155);
            this.text_tabControl.TabIndex = 36;
            this.text_tabControl.SelectedIndexChanged += new System.EventHandler(this.text_tabControl_SelectedIndexChanged);
            // 
            // text_tabPage
            // 
            this.text_tabPage.Controls.Add(this.crypto_rTB);
            this.text_tabPage.Location = new System.Drawing.Point(4, 27);
            this.text_tabPage.Name = "text_tabPage";
            this.text_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.text_tabPage.Size = new System.Drawing.Size(354, 124);
            this.text_tabPage.TabIndex = 0;
            this.text_tabPage.Text = "Введенный текст";
            this.text_tabPage.UseVisualStyleBackColor = true;
            // 
            // crypto_rTB
            // 
            this.crypto_rTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.crypto_rTB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.crypto_rTB.Location = new System.Drawing.Point(0, 0);
            this.crypto_rTB.Name = "crypto_rTB";
            this.crypto_rTB.Size = new System.Drawing.Size(354, 124);
            this.crypto_rTB.TabIndex = 28;
            this.crypto_rTB.Text = "";
            this.crypto_rTB.TextChanged += new System.EventHandler(this.crypto_rTB_TextChanged);
            // 
            // file_tabPage
            // 
            this.file_tabPage.Controls.Add(this.file_richTextBox);
            this.file_tabPage.Location = new System.Drawing.Point(4, 27);
            this.file_tabPage.Name = "file_tabPage";
            this.file_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.file_tabPage.Size = new System.Drawing.Size(354, 124);
            this.file_tabPage.TabIndex = 1;
            this.file_tabPage.Text = "Просмотр файла";
            this.file_tabPage.UseVisualStyleBackColor = true;
            // 
            // file_richTextBox
            // 
            this.file_richTextBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.file_richTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.file_richTextBox.Location = new System.Drawing.Point(0, 0);
            this.file_richTextBox.Name = "file_richTextBox";
            this.file_richTextBox.Size = new System.Drawing.Size(354, 126);
            this.file_richTextBox.TabIndex = 29;
            this.file_richTextBox.Text = "";
            // 
            // writeOn_radioButton
            // 
            this.writeOn_radioButton.AutoSize = true;
            this.writeOn_radioButton.Location = new System.Drawing.Point(135, 60);
            this.writeOn_radioButton.Name = "writeOn_radioButton";
            this.writeOn_radioButton.Size = new System.Drawing.Size(91, 22);
            this.writeOn_radioButton.TabIndex = 4;
            this.writeOn_radioButton.TabStop = true;
            this.writeOn_radioButton.Text = "Вести текст";
            this.toolTip1.SetToolTip(this.writeOn_radioButton, "Ввести текст");
            this.writeOn_radioButton.UseVisualStyleBackColor = true;
            this.writeOn_radioButton.CheckedChanged += new System.EventHandler(this.writeOn_radioButton_CheckedChanged);
            // 
            // chose_radioButton
            // 
            this.chose_radioButton.AutoSize = true;
            this.chose_radioButton.Location = new System.Drawing.Point(135, 32);
            this.chose_radioButton.Name = "chose_radioButton";
            this.chose_radioButton.Size = new System.Drawing.Size(105, 22);
            this.chose_radioButton.TabIndex = 3;
            this.chose_radioButton.TabStop = true;
            this.chose_radioButton.Text = "Выбрать файл";
            this.toolTip1.SetToolTip(this.chose_radioButton, "Выбрать файл");
            this.chose_radioButton.UseVisualStyleBackColor = true;
            this.chose_radioButton.CheckedChanged += new System.EventHandler(this.chose_radioButton_CheckedChanged);
            // 
            // selectedfile_lbl
            // 
            this.selectedfile_lbl.AutoSize = true;
            this.selectedfile_lbl.Location = new System.Drawing.Point(8, 77);
            this.selectedfile_lbl.Name = "selectedfile_lbl";
            this.selectedfile_lbl.Size = new System.Drawing.Size(12, 18);
            this.selectedfile_lbl.TabIndex = 35;
            this.selectedfile_lbl.Text = ".";
            this.toolTip1.SetToolTip(this.selectedfile_lbl, "Путь к файлу");
            this.selectedfile_lbl.Click += new System.EventHandler(this.selectedfile_lbl_Click);
            // 
            // chooseTextFile_btn
            // 
            this.chooseTextFile_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.chooseTextFile_btn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTextFile_btn.Location = new System.Drawing.Point(6, 22);
            this.chooseTextFile_btn.Name = "chooseTextFile_btn";
            this.chooseTextFile_btn.Size = new System.Drawing.Size(40, 37);
            this.chooseTextFile_btn.TabIndex = 5;
            this.chooseTextFile_btn.Text = "+";
            this.toolTip1.SetToolTip(this.chooseTextFile_btn, "Выбрать текстовый файл");
            this.chooseTextFile_btn.UseVisualStyleBackColor = false;
            this.chooseTextFile_btn.Click += new System.EventHandler(this.chooseTextFile_btn_Click);
            // 
            // resetTextFile_btn
            // 
            this.resetTextFile_btn.BackColor = System.Drawing.Color.Tomato;
            this.resetTextFile_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetTextFile_btn.Location = new System.Drawing.Point(57, 20);
            this.resetTextFile_btn.Name = "resetTextFile_btn";
            this.resetTextFile_btn.Size = new System.Drawing.Size(40, 37);
            this.resetTextFile_btn.TabIndex = 6;
            this.resetTextFile_btn.Text = "✖";
            this.toolTip1.SetToolTip(this.resetTextFile_btn, "Отменить выбор текстового файла");
            this.resetTextFile_btn.UseVisualStyleBackColor = false;
            this.resetTextFile_btn.Click += new System.EventHandler(this.resetTextFile_btn_Click);
            // 
            // pic_box1
            // 
            this.pic_box1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pic_box1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_box1.Location = new System.Drawing.Point(9, 301);
            this.pic_box1.Name = "pic_box1";
            this.pic_box1.Size = new System.Drawing.Size(371, 252);
            this.pic_box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box1.TabIndex = 1;
            this.pic_box1.TabStop = false;
            // 
            // decode_tabPage
            // 
            this.decode_tabPage.BackColor = System.Drawing.Color.LightBlue;
            this.decode_tabPage.Controls.Add(this.deshifr_panel);
            this.decode_tabPage.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decode_tabPage.Location = new System.Drawing.Point(4, 25);
            this.decode_tabPage.Name = "decode_tabPage";
            this.decode_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.decode_tabPage.Size = new System.Drawing.Size(1152, 582);
            this.decode_tabPage.TabIndex = 1;
            this.decode_tabPage.Text = "||| Дешифрация..";
            // 
            // deshifr_panel
            // 
            this.deshifr_panel.BackColor = System.Drawing.Color.Transparent;
            this.deshifr_panel.Controls.Add(this.deshifr_progressBar);
            this.deshifr_panel.Controls.Add(this.deshifr_clear_text_btn);
            this.deshifr_panel.Controls.Add(this.encodePic_gB);
            this.deshifr_panel.Controls.Add(this.copy_btn);
            this.deshifr_panel.Controls.Add(this.decode_rtb);
            this.deshifr_panel.Controls.Add(this.save_deshifr_btn);
            this.deshifr_panel.Controls.Add(this.decode_PB);
            this.deshifr_panel.Location = new System.Drawing.Point(6, 5);
            this.deshifr_panel.Name = "deshifr_panel";
            this.deshifr_panel.Size = new System.Drawing.Size(925, 457);
            this.deshifr_panel.TabIndex = 38;
            // 
            // deshifr_progressBar
            // 
            this.deshifr_progressBar.Location = new System.Drawing.Point(18, 414);
            this.deshifr_progressBar.Name = "deshifr_progressBar";
            this.deshifr_progressBar.Size = new System.Drawing.Size(811, 12);
            this.deshifr_progressBar.TabIndex = 38;
            this.toolTip1.SetToolTip(this.deshifr_progressBar, "Процесс дешифрации");
            this.deshifr_progressBar.TabIndexChanged += new System.EventHandler(this.deshifr_progressBar_TabIndexChanged);
            this.deshifr_progressBar.Click += new System.EventHandler(this.deshifr_progressBar_Click);
            // 
            // deshifr_clear_text_btn
            // 
            this.deshifr_clear_text_btn.BackColor = System.Drawing.Color.Silver;
            this.deshifr_clear_text_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deshifr_clear_text_btn.Location = new System.Drawing.Point(829, 88);
            this.deshifr_clear_text_btn.Name = "deshifr_clear_text_btn";
            this.deshifr_clear_text_btn.Size = new System.Drawing.Size(40, 37);
            this.deshifr_clear_text_btn.TabIndex = 30;
            this.deshifr_clear_text_btn.Text = "✖";
            this.toolTip1.SetToolTip(this.deshifr_clear_text_btn, "Очистить текстовое поле");
            this.deshifr_clear_text_btn.UseVisualStyleBackColor = false;
            this.deshifr_clear_text_btn.Click += new System.EventHandler(this.shifr_clear_text_btn_Click);
            // 
            // encodePic_gB
            // 
            this.encodePic_gB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.encodePic_gB.Controls.Add(this.resetDecPic_btn_Click);
            this.encodePic_gB.Controls.Add(this.chooseDecPic_btn);
            this.encodePic_gB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodePic_gB.Location = new System.Drawing.Point(12, 12);
            this.encodePic_gB.Name = "encodePic_gB";
            this.encodePic_gB.Size = new System.Drawing.Size(810, 70);
            this.encodePic_gB.TabIndex = 34;
            this.encodePic_gB.TabStop = false;
            this.encodePic_gB.Text = "Выбрать изображение для дешифрации";
            // 
            // resetDecPic_btn_Click
            // 
            this.resetDecPic_btn_Click.BackColor = System.Drawing.Color.Tomato;
            this.resetDecPic_btn_Click.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetDecPic_btn_Click.Location = new System.Drawing.Point(57, 20);
            this.resetDecPic_btn_Click.Name = "resetDecPic_btn_Click";
            this.resetDecPic_btn_Click.Size = new System.Drawing.Size(40, 37);
            this.resetDecPic_btn_Click.TabIndex = 2;
            this.resetDecPic_btn_Click.Text = "✖";
            this.toolTip1.SetToolTip(this.resetDecPic_btn_Click, "Очистить форму изображений и текстовое поле");
            this.resetDecPic_btn_Click.UseVisualStyleBackColor = false;
            this.resetDecPic_btn_Click.Click += new System.EventHandler(this.resetDecPic_btn_Click_Click);
            // 
            // chooseDecPic_btn
            // 
            this.chooseDecPic_btn.BackColor = System.Drawing.Color.LightGreen;
            this.chooseDecPic_btn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDecPic_btn.Location = new System.Drawing.Point(6, 20);
            this.chooseDecPic_btn.Name = "chooseDecPic_btn";
            this.chooseDecPic_btn.Size = new System.Drawing.Size(40, 37);
            this.chooseDecPic_btn.TabIndex = 1;
            this.chooseDecPic_btn.Text = "+";
            this.toolTip1.SetToolTip(this.chooseDecPic_btn, "Выбрать bmp-изображение для дешифрации");
            this.chooseDecPic_btn.UseVisualStyleBackColor = false;
            this.chooseDecPic_btn.Click += new System.EventHandler(this.chooseDecPic_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.copy_btn.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_btn.Location = new System.Drawing.Point(829, 131);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(40, 38);
            this.copy_btn.TabIndex = 37;
            this.copy_btn.Text = "❐";
            this.toolTip1.SetToolTip(this.copy_btn, "Скопировать текст в буфер обмена");
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // decode_rtb
            // 
            this.decode_rtb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decode_rtb.Location = new System.Drawing.Point(423, 88);
            this.decode_rtb.Name = "decode_rtb";
            this.decode_rtb.Size = new System.Drawing.Size(400, 300);
            this.decode_rtb.TabIndex = 35;
            this.decode_rtb.Text = "";
            this.toolTip1.SetToolTip(this.decode_rtb, "Дешифрованный текст");
            // 
            // save_deshifr_btn
            // 
            this.save_deshifr_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.save_deshifr_btn.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_deshifr_btn.Location = new System.Drawing.Point(829, 351);
            this.save_deshifr_btn.Name = "save_deshifr_btn";
            this.save_deshifr_btn.Size = new System.Drawing.Size(40, 37);
            this.save_deshifr_btn.TabIndex = 37;
            this.save_deshifr_btn.Text = "💾";
            this.toolTip1.SetToolTip(this.save_deshifr_btn, "Сохранить текст в текстовый файл");
            this.save_deshifr_btn.UseVisualStyleBackColor = false;
            this.save_deshifr_btn.Click += new System.EventHandler(this.save_deshifr_btn_Click);
            // 
            // decode_PB
            // 
            this.decode_PB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decode_PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.decode_PB.Location = new System.Drawing.Point(12, 88);
            this.decode_PB.Name = "decode_PB";
            this.decode_PB.Size = new System.Drawing.Size(400, 300);
            this.decode_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decode_PB.TabIndex = 36;
            this.decode_PB.TabStop = false;
            this.decode_PB.Click += new System.EventHandler(this.decode_PB_Click);
            // 
            // help_tabPage
            // 
            this.help_tabPage.BackColor = System.Drawing.Color.LightBlue;
            this.help_tabPage.Controls.Add(this.help_groupBox);
            this.help_tabPage.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_tabPage.Location = new System.Drawing.Point(4, 25);
            this.help_tabPage.Name = "help_tabPage";
            this.help_tabPage.Size = new System.Drawing.Size(1152, 582);
            this.help_tabPage.TabIndex = 2;
            this.help_tabPage.Text = "? Справка..";
            // 
            // help_groupBox
            // 
            this.help_groupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.help_groupBox.Controls.Add(this.help_rtb);
            this.help_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_groupBox.Location = new System.Drawing.Point(6, 15);
            this.help_groupBox.Name = "help_groupBox";
            this.help_groupBox.Size = new System.Drawing.Size(800, 491);
            this.help_groupBox.TabIndex = 1;
            this.help_groupBox.TabStop = false;
            this.help_groupBox.Text = "Справка";
            // 
            // help_rtb
            // 
            this.help_rtb.AcceptsTab = true;
            this.help_rtb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.help_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.help_rtb.Location = new System.Drawing.Point(16, 23);
            this.help_rtb.Name = "help_rtb";
            this.help_rtb.ReadOnly = true;
            this.help_rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.help_rtb.Size = new System.Drawing.Size(745, 439);
            this.help_rtb.TabIndex = 0;
            this.help_rtb.Text = "";
            // 
            // setings_tabPage
            // 
            this.setings_tabPage.BackColor = System.Drawing.Color.LightBlue;
            this.setings_tabPage.Controls.Add(this.settings_panel);
            this.setings_tabPage.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setings_tabPage.Location = new System.Drawing.Point(4, 25);
            this.setings_tabPage.Name = "setings_tabPage";
            this.setings_tabPage.Size = new System.Drawing.Size(1152, 582);
            this.setings_tabPage.TabIndex = 4;
            this.setings_tabPage.Text = "⚙ Настройки..";
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.password_groupBox);
            this.settings_panel.Controls.Add(this.theme_groupBox);
            this.settings_panel.Location = new System.Drawing.Point(6, 5);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(741, 333);
            this.settings_panel.TabIndex = 2;
            // 
            // password_groupBox
            // 
            this.password_groupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.password_groupBox.Controls.Add(this.changepass_button);
            this.password_groupBox.Controls.Add(this.newpass_textBox);
            this.password_groupBox.Controls.Add(this.textBox1);
            this.password_groupBox.Controls.Add(this.newpass_label);
            this.password_groupBox.Controls.Add(this.oldpass_label);
            this.password_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_groupBox.ForeColor = System.Drawing.Color.Black;
            this.password_groupBox.Location = new System.Drawing.Point(7, 174);
            this.password_groupBox.Name = "password_groupBox";
            this.password_groupBox.Size = new System.Drawing.Size(700, 132);
            this.password_groupBox.TabIndex = 1;
            this.password_groupBox.TabStop = false;
            this.password_groupBox.Text = "Изменить пароль для входа";
            // 
            // changepass_button
            // 
            this.changepass_button.BackColor = System.Drawing.Color.Transparent;
            this.changepass_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changepass_button.Location = new System.Drawing.Point(528, 94);
            this.changepass_button.Name = "changepass_button";
            this.changepass_button.Size = new System.Drawing.Size(81, 25);
            this.changepass_button.TabIndex = 3;
            this.changepass_button.Text = " Изменить";
            this.changepass_button.UseVisualStyleBackColor = false;
            this.changepass_button.Click += new System.EventHandler(this.changepass_button_Click);
            // 
            // newpass_textBox
            // 
            this.newpass_textBox.Location = new System.Drawing.Point(193, 65);
            this.newpass_textBox.Name = "newpass_textBox";
            this.newpass_textBox.PasswordChar = '*';
            this.newpass_textBox.Size = new System.Drawing.Size(416, 23);
            this.newpass_textBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.newpass_textBox, "Пароль должен состоять минимум из 1 символа");
            this.newpass_textBox.TextChanged += new System.EventHandler(this.newpass_textBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newpass_label
            // 
            this.newpass_label.AutoSize = true;
            this.newpass_label.Location = new System.Drawing.Point(21, 70);
            this.newpass_label.Name = "newpass_label";
            this.newpass_label.Size = new System.Drawing.Size(149, 18);
            this.newpass_label.TabIndex = 0;
            this.newpass_label.Text = "Введите новый пароль:";
            this.toolTip1.SetToolTip(this.newpass_label, "Пароль должен состоять минимум из 1 символа");
            this.newpass_label.Click += new System.EventHandler(this.oldpass_label_Click);
            // 
            // oldpass_label
            // 
            this.oldpass_label.AutoSize = true;
            this.oldpass_label.Location = new System.Drawing.Point(21, 34);
            this.oldpass_label.Name = "oldpass_label";
            this.oldpass_label.Size = new System.Drawing.Size(154, 18);
            this.oldpass_label.TabIndex = 0;
            this.oldpass_label.Text = "Введите старый пароль:";
            this.oldpass_label.Click += new System.EventHandler(this.oldpass_label_Click);
            // 
            // theme_groupBox
            // 
            this.theme_groupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.theme_groupBox.Controls.Add(this.theme4_rb);
            this.theme_groupBox.Controls.Add(this.theme3_rb);
            this.theme_groupBox.Controls.Add(this.theme2_rb);
            this.theme_groupBox.Controls.Add(this.theme1_rb);
            this.theme_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme_groupBox.ForeColor = System.Drawing.Color.Black;
            this.theme_groupBox.Location = new System.Drawing.Point(7, 16);
            this.theme_groupBox.Name = "theme_groupBox";
            this.theme_groupBox.Size = new System.Drawing.Size(700, 144);
            this.theme_groupBox.TabIndex = 0;
            this.theme_groupBox.TabStop = false;
            this.theme_groupBox.Text = "Выбрать тему оформления";
            // 
            // theme4_rb
            // 
            this.theme4_rb.AutoSize = true;
            this.theme4_rb.Location = new System.Drawing.Point(24, 112);
            this.theme4_rb.Name = "theme4_rb";
            this.theme4_rb.Size = new System.Drawing.Size(137, 22);
            this.theme4_rb.TabIndex = 0;
            this.theme4_rb.TabStop = true;
            this.theme4_rb.Text = "Светло-бирюзовая";
            this.theme4_rb.UseVisualStyleBackColor = true;
            this.theme4_rb.CheckedChanged += new System.EventHandler(this.theme4_rb_CheckedChanged);
            // 
            // theme3_rb
            // 
            this.theme3_rb.AutoSize = true;
            this.theme3_rb.Location = new System.Drawing.Point(24, 86);
            this.theme3_rb.Name = "theme3_rb";
            this.theme3_rb.Size = new System.Drawing.Size(90, 22);
            this.theme3_rb.TabIndex = 0;
            this.theme3_rb.TabStop = true;
            this.theme3_rb.Text = "Бирюзовая";
            this.theme3_rb.UseVisualStyleBackColor = true;
            this.theme3_rb.CheckedChanged += new System.EventHandler(this.theme3_rb_CheckedChanged);
            // 
            // theme2_rb
            // 
            this.theme2_rb.AutoSize = true;
            this.theme2_rb.Location = new System.Drawing.Point(24, 55);
            this.theme2_rb.Name = "theme2_rb";
            this.theme2_rb.Size = new System.Drawing.Size(75, 22);
            this.theme2_rb.TabIndex = 0;
            this.theme2_rb.TabStop = true;
            this.theme2_rb.Text = "Светлая";
            this.theme2_rb.UseVisualStyleBackColor = true;
            this.theme2_rb.CheckedChanged += new System.EventHandler(this.theme2_rb_CheckedChanged);
            // 
            // theme1_rb
            // 
            this.theme1_rb.AutoSize = true;
            this.theme1_rb.Location = new System.Drawing.Point(24, 27);
            this.theme1_rb.Name = "theme1_rb";
            this.theme1_rb.Size = new System.Drawing.Size(71, 22);
            this.theme1_rb.TabIndex = 0;
            this.theme1_rb.TabStop = true;
            this.theme1_rb.Text = "Темная";
            this.theme1_rb.UseVisualStyleBackColor = true;
            this.theme1_rb.CheckedChanged += new System.EventHandler(this.theme1_rb_CheckedChanged);
            // 
            // about_tabPage
            // 
            this.about_tabPage.BackColor = System.Drawing.Color.LightBlue;
            this.about_tabPage.Controls.Add(this.about_groupBox);
            this.about_tabPage.Location = new System.Drawing.Point(4, 25);
            this.about_tabPage.Name = "about_tabPage";
            this.about_tabPage.Size = new System.Drawing.Size(1152, 582);
            this.about_tabPage.TabIndex = 5;
            this.about_tabPage.Text = "О программе..";
            // 
            // about_groupBox
            // 
            this.about_groupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.about_groupBox.Controls.Add(this.about_rtb);
            this.about_groupBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_groupBox.Location = new System.Drawing.Point(15, 20);
            this.about_groupBox.Name = "about_groupBox";
            this.about_groupBox.Size = new System.Drawing.Size(790, 230);
            this.about_groupBox.TabIndex = 2;
            this.about_groupBox.TabStop = false;
            this.about_groupBox.Text = "О программе";
            // 
            // about_rtb
            // 
            this.about_rtb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.about_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.about_rtb.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_rtb.Location = new System.Drawing.Point(9, 32);
            this.about_rtb.Name = "about_rtb";
            this.about_rtb.ReadOnly = true;
            this.about_rtb.Size = new System.Drawing.Size(745, 168);
            this.about_rtb.TabIndex = 1;
            this.about_rtb.Text = resources.GetString("about_rtb.Text");
            this.about_rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 610);
            this.Controls.Add(this.Encoding_tab_control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стеганография";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Encoding_tab_control.ResumeLayout(false);
            this.welcome_tabPage.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.menu_groupBox2.ResumeLayout(false);
            this.panelh5.ResumeLayout(false);
            this.panelm5.ResumeLayout(false);
            this.panelh4.ResumeLayout(false);
            this.panelm4.ResumeLayout(false);
            this.panelh3.ResumeLayout(false);
            this.panelm3.ResumeLayout(false);
            this.menu_groupBox1.ResumeLayout(false);
            this.panelh2.ResumeLayout(false);
            this.panelm2.ResumeLayout(false);
            this.panelh1.ResumeLayout(false);
            this.panelm1.ResumeLayout(false);
            this.encode_tabPage.ResumeLayout(false);
            this.scrol_groupBox.ResumeLayout(false);
            this.scrol_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.pic_groupBox.ResumeLayout(false);
            this.shifr_panel.ResumeLayout(false);
            this.shifr_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTab_dataGridView)).EndInit();
            this.textFile_groupBox.ResumeLayout(false);
            this.textFile_groupBox.PerformLayout();
            this.text_tabControl.ResumeLayout(false);
            this.text_tabPage.ResumeLayout(false);
            this.file_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box1)).EndInit();
            this.decode_tabPage.ResumeLayout(false);
            this.deshifr_panel.ResumeLayout(false);
            this.encodePic_gB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.decode_PB)).EndInit();
            this.help_tabPage.ResumeLayout(false);
            this.help_groupBox.ResumeLayout(false);
            this.setings_tabPage.ResumeLayout(false);
            this.settings_panel.ResumeLayout(false);
            this.password_groupBox.ResumeLayout(false);
            this.password_groupBox.PerformLayout();
            this.theme_groupBox.ResumeLayout(false);
            this.theme_groupBox.PerformLayout();
            this.about_tabPage.ResumeLayout(false);
            this.about_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_box1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button choosePic_btn;
        private System.Windows.Forms.TabControl Encoding_tab_control;
        private System.Windows.Forms.TabPage encode_tabPage;
        private System.Windows.Forms.RichTextBox crypto_rTB;
        private System.Windows.Forms.PictureBox pic_box2;
        private System.Windows.Forms.TabPage decode_tabPage;
        private System.Windows.Forms.Button resetPic_btn;
        private System.Windows.Forms.Button chooseTextFile_btn;
        private System.Windows.Forms.Button resetTextFile_btn;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.GroupBox textFile_groupBox;
        private System.Windows.Forms.GroupBox pic_groupBox;
        private System.Windows.Forms.Label selectedfile_lbl;
        private System.Windows.Forms.Button saveEncodedPic_btn;
        private System.Windows.Forms.Button save_deshifr_btn;
        private System.Windows.Forms.PictureBox decode_PB;
        private System.Windows.Forms.RichTextBox decode_rtb;
        private System.Windows.Forms.GroupBox encodePic_gB;
        private System.Windows.Forms.Button resetDecPic_btn_Click;
        private System.Windows.Forms.Button chooseDecPic_btn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label trackBar_label;
        private System.Windows.Forms.GroupBox scrol_groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteDir_btn;
        private System.Windows.Forms.Button chooseDir_btn;
        private System.Windows.Forms.Label selectedDir_lbl;
        private System.Windows.Forms.DataGridView mainTab_dataGridView;
        private System.Windows.Forms.Label fullPathOrName_lbl;
        private System.Windows.Forms.Label capacityText_lbl;
        private System.Windows.Forms.RadioButton writeOn_radioButton;
        private System.Windows.Forms.RadioButton chose_radioButton;
        private System.Windows.Forms.Button decode_btn;
        private System.Windows.Forms.Panel shifr_panel;
        private System.Windows.Forms.Panel deshifr_panel;
        private System.Windows.Forms.Button deshifr_clear_text_btn;
        private System.Windows.Forms.Button shifr_clear_text_btn;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.TabPage welcome_tabPage;
        private System.Windows.Forms.TabPage help_tabPage;
        private System.Windows.Forms.TabPage setings_tabPage;
        private System.Windows.Forms.GroupBox menu_groupBox1;
        private System.Windows.Forms.Button crypt_button;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.GroupBox menu_groupBox2;
        private System.Windows.Forms.TabPage about_tabPage;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.ProgressBar crypt_progressBar;
        private System.Windows.Forms.ProgressBar code_progressBar;
        private System.Windows.Forms.GroupBox password_groupBox;
        private System.Windows.Forms.Label oldpass_label;
        private System.Windows.Forms.GroupBox theme_groupBox;
        private System.Windows.Forms.Button changepass_button;
        private System.Windows.Forms.TextBox newpass_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label newpass_label;
        private System.Windows.Forms.RadioButton theme3_rb;
        private System.Windows.Forms.RadioButton theme2_rb;
        private System.Windows.Forms.RadioButton theme1_rb;
        private System.Windows.Forms.RichTextBox about_rtb;
        private System.Windows.Forms.GroupBox about_groupBox;
        private System.Windows.Forms.RichTextBox help_rtb;
        private System.Windows.Forms.GroupBox help_groupBox;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel panelh1;
        private System.Windows.Forms.Panel panelm1;
        private System.Windows.Forms.Panel panelh2;
        private System.Windows.Forms.Panel panelm2;
        private System.Windows.Forms.Panel panelh3;
        private System.Windows.Forms.Panel panelm3;
        private System.Windows.Forms.Panel panelh4;
        private System.Windows.Forms.Panel panelm4;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Panel panelh5;
        private System.Windows.Forms.Panel panelm5;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.RadioButton theme4_rb;
        private System.Windows.Forms.ProgressBar deshifr_progressBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl text_tabControl;
        private System.Windows.Forms.TabPage text_tabPage;
        private System.Windows.Forms.TabPage file_tabPage;
        private System.Windows.Forms.RichTextBox file_richTextBox;
    }
}

