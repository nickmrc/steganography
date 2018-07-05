using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;

namespace StegProject
{

    //SplashScr splashScr = new SplashScr();
    //splashScr.Show();
    //        Thread.Sleep(2000);
    //        splashScr.Hide();
    //        splashScr.Dispose();


    public partial class Form1 : Form
    {
        

        public Form1()
        {


            //splashForm.Show();
            //Thread.Sleep(1000);
            //splashForm.Close();

            InitializeComponent();
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

            this.Encoding_tab_control.Size = this.Size;


            Point p = new Point();
            p.X = this.Size.Width/2 - 450;
            p.Y = shifr_panel.Location.Y;


            shifr_panel.Location = p;

            Point pd = new Point();
            pd.X = this.Size.Width/2 - 450;
            pd.Y = deshifr_panel.Location.Y;
            deshifr_panel.Location = pd;

            SetPropertyOfDataGrid();
            chose_radioButton.Checked = true;

        }

        List<FilePic> FilePicList = new List<FilePic>();
        List<FilePic> sortedFilePicList = new List<FilePic>();

        string pathDIR;
        //string pathText; //надо ли?
        string pathTxT = String.Empty;
        private Bitmap pic_box1_bmap;

        private bool IsSelectedFile;

        private string EncodeTextFromTxT;


        private void SetPropertyOfDataGrid()
        {
            mainTab_dataGridView.AutoGenerateColumns = false;

            mainTab_dataGridView.Columns.Add("fileName", "Имя файла");
            mainTab_dataGridView.Columns.Add("capacity", "Вместимость");
            //mainTab_dataGridView.Columns.Add("check", "Выбрать");


            //создание столбца кнопок
            DataGridViewButtonColumn button_column = new DataGridViewButtonColumn();
            button_column.Name = "check";
            button_column.HeaderText = "Выбрать";
            button_column.FlatStyle = FlatStyle.Popup;
            button_column.DefaultCellStyle.BackColor = Color.LightGreen;
            button_column.Text = "+";

            mainTab_dataGridView.Columns.Add(button_column);

            mainTab_dataGridView.Columns[0].DataPropertyName = "FileName";
            mainTab_dataGridView.Columns[1].DataPropertyName = "Capasity";

            //mainTab_dataGridView.Columns[0].Width = 137;
            //mainTab_dataGridView.Columns[1].Width = 100;
            //mainTab_dataGridView.Columns[2].Width = 162;


        }

        //private void SetPropertyOfDataGrid1()
        //{
        //    dataGridView1.AutoGenerateColumns = false;

        //    dataGridView1.Columns.Add("fileName", "Имя файла");
        //    dataGridView1.Columns.Add("capacity", "Вместимость");
        //    //mainTab_dataGridView.Columns.Add("check", "Выбрать");


        //    //создание столбца кнопок
        //    DataGridViewButtonColumn button_column = new DataGridViewButtonColumn();
        //    button_column.Name = "check";
        //    button_column.HeaderText = "Выбрать";
        //    button_column.FlatStyle = FlatStyle.Popup;
        //    button_column.DefaultCellStyle.BackColor = Color.Firebrick;
        //    button_column.Text = "✕";

        //    dataGridView1.Columns.Add(button_column);

        //    dataGridView1.Columns[0].DataPropertyName = "FileName";
        //    dataGridView1.Columns[1].DataPropertyName = "Capasity";
        //}

        private BitArray ByteToBit(byte src)
        {
            BitArray bitArray = new BitArray(8);
            bool st = false;
            for (int i = 0; i < 8; i++)
            {
                if ((src >> i & 1) == 1)
                {
                    st = true;
                }
                else st = false;
                bitArray[i] = st;
            }
            return bitArray;
        }

        private byte BitToByte(BitArray scr)
        {
            byte num = 0;
            for (int i = 0; i < scr.Count; i++)
                if (scr[i] == true)
                    num += (byte) Math.Pow(2, i);
            return num;
        }

        /*Проверяет, зашифрован ли файл,  возвраещает true, если символ в первом пикслеле равен / иначе false */

        private bool isEncryption(Bitmap scr)
        {
            byte[] rez = new byte[1];
            Color color = scr.GetPixel(0, 0);
            BitArray colorArray = ByteToBit(color.R); //получаем байт цвета и преобразуем в массив бит
            BitArray messageArray = ByteToBit(color.R);
            ; //инициализируем результирующий массив бит
            messageArray[0] = colorArray[0];
            messageArray[1] = colorArray[1];

            colorArray = ByteToBit(color.G); //получаем байт цвета и преобразуем в массив бит
            messageArray[2] = colorArray[0];
            messageArray[3] = colorArray[1];
            messageArray[4] = colorArray[2];

            colorArray = ByteToBit(color.B); //получаем байт цвета и преобразуем в массив бит
            messageArray[5] = colorArray[0];
            messageArray[6] = colorArray[1];
            messageArray[7] = colorArray[2];
            rez[0] = BitToByte(messageArray); //получаем байт символа, записанного в 1 пикселе
            string m = Encoding.Default.GetString(rez);
            if (m == "/")
            {
                return true;
            }
            else return false;
        }

        /*Записывает количество символов для шифрования в первые биты картинки */

        private void WriteCountText(int count, Bitmap src)
        {
            byte[] css = BitConverter.GetBytes(count);
            for (int i = 0; i < css.Length; i++)
            {
                BitArray bitCount = ByteToBit(css[i]); //биты количества символов
                Color pColor = src.GetPixel(0, i + 1); //1, 2, 3 пикселы
                BitArray bitsCurColor = ByteToBit(pColor.R); //бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[0];
                bitsCurColor[1] = bitCount[1];
                byte nR = BitToByte(bitsCurColor); //новый бит цвета пиксея

                bitsCurColor = ByteToBit(pColor.G); //бит бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[2];
                bitsCurColor[1] = bitCount[3];
                bitsCurColor[2] = bitCount[4];
                byte nG = BitToByte(bitsCurColor); //новый цвет пиксея

                bitsCurColor = ByteToBit(pColor.B); //бит бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[5];
                bitsCurColor[1] = bitCount[6];
                bitsCurColor[2] = bitCount[7];
                byte nB = BitToByte(bitsCurColor); //новый цвет пиксея

                Color nColor = Color.FromArgb(nR, nG, nB); //новый цвет из полученных битов
                src.SetPixel(0, i + 1, nColor); //записали полученный цвет в картинку
            }
        }

        /*Читает количество символов для дешифрования из первых бит картинки*/

        private int ReadCountText(Bitmap src)
        {
            byte[] rez = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                Color color = src.GetPixel(0, i + 1); //цвет 1, 2, 3 пикселей 
                BitArray colorArray = ByteToBit(color.R); //биты цвета
                BitArray bitCount = ByteToBit(color.R);
                ; //инициализация результирующего массива бит
                bitCount[0] = colorArray[0];
                bitCount[1] = colorArray[1];

                colorArray = ByteToBit(color.G);
                bitCount[2] = colorArray[0];
                bitCount[3] = colorArray[1];
                bitCount[4] = colorArray[2];

                colorArray = ByteToBit(color.B);
                bitCount[5] = colorArray[0];
                bitCount[6] = colorArray[1];
                bitCount[7] = colorArray[2];
                rez[i] = BitToByte(bitCount);
            }
            //string m = Encoding.ASCII.GetString(rez);

            int m = BitConverter.ToInt32(rez, 0);

            //return Convert.ToInt32(m, 10);
            return m;
        }

        /* Открыть файл для шифрования */

        private void button1_Click(object sender, EventArgs e)
        {
            string FilePic;
            string FileText;
            OpenFileDialog dPic = new OpenFileDialog();
            dPic.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (dPic.ShowDialog() == DialogResult.OK)
            {
                FilePic = dPic.FileName;
            }
            else
            {
                FilePic = "";
                return;
            }

            FileStream rFile;
            try
            {
                rFile = new FileStream(FilePic, FileMode.Open); //открываем поток
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bPic = new Bitmap(rFile);

            OpenFileDialog dText = new OpenFileDialog();
            dText.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (dText.ShowDialog() == DialogResult.OK)
            {
                FileText = dText.FileName;
            }
            else
            {
                FileText = "";
                return;
            }

            FileStream rText;
            try
            {
                rText = new FileStream(FileText, FileMode.Open); //открываем поток
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BinaryReader bText = new BinaryReader(rText, Encoding.Default);

            List<byte> bList = new List<byte>();
            while (bText.PeekChar() != -1)
            {
                //считали весь текстовый файл для шифрования в лист байт
                bList.Add(bText.ReadByte());
            }
            int CountText = bList.Count; // в CountText - количество в байтах текста, который нужно закодировать
            bText.Close();
            rFile.Close();

            //проверяем, поместиться ли исходный текст в картинке
            if (CountText > ((bPic.Width*bPic.Height)) - 4)
            {
                MessageBox.Show("Выбранная картинка мала для размещения выбранного текста", "Информация - Стеганография",
                    MessageBoxButtons.OK);
                return;
            }

            //проверяем, может быть картинка уже зашифрована
            if (isEncryption(bPic))
            {
                MessageBox.Show("Файл уже зашифрован", "Информация - Стеганография", MessageBoxButtons.OK);
                return;
            }

            byte[] Symbol = Encoding.Default.GetBytes("/");
            BitArray ArrBeginSymbol = ByteToBit(Symbol[0]);

            Color curColor = bPic.GetPixel(0, 0);
            BitArray tempArray = ByteToBit(curColor.R);
            tempArray[0] = ArrBeginSymbol[0];
            tempArray[1] = ArrBeginSymbol[1];
            byte nR = BitToByte(tempArray);

            tempArray = ByteToBit(curColor.G);
            tempArray[0] = ArrBeginSymbol[2];
            tempArray[1] = ArrBeginSymbol[3];
            tempArray[2] = ArrBeginSymbol[4];
            byte nG = BitToByte(tempArray);

            tempArray = ByteToBit(curColor.B);
            tempArray[0] = ArrBeginSymbol[5];
            tempArray[1] = ArrBeginSymbol[6];
            tempArray[2] = ArrBeginSymbol[7];
            byte nB = BitToByte(tempArray);

            Color nColor = Color.FromArgb(nR, nG, nB);
            bPic.SetPixel(0, 0, nColor);
            //то есть в первом пикселе будет символ /, который говорит о том, что картика зашифрована

            WriteCountText(CountText, bPic); //записываем количество символов для шифрования

            int index = 0;
            bool st = false;
            for (int i = 4; i < bPic.Width; i++)
            {
                for (int j = 0; j < bPic.Height; j++)
                {
                    Color pixelColor = bPic.GetPixel(i, j);
                    if (index == bList.Count)
                    {
                        st = true;
                        break;
                    }
                    BitArray colorArray = ByteToBit(pixelColor.R);
                    BitArray messageArray = ByteToBit(bList[index]);
                    colorArray[0] = messageArray[0]; //меняем
                    colorArray[1] = messageArray[1]; // в нашем цвете биты
                    byte newR = BitToByte(colorArray);

                    colorArray = ByteToBit(pixelColor.G);
                    colorArray[0] = messageArray[2];
                    colorArray[1] = messageArray[3];
                    colorArray[2] = messageArray[4];
                    byte newG = BitToByte(colorArray);

                    colorArray = ByteToBit(pixelColor.B);
                    colorArray[0] = messageArray[5];
                    colorArray[1] = messageArray[6];
                    colorArray[2] = messageArray[7];
                    byte newB = BitToByte(colorArray);

                    Color newColor = Color.FromArgb(newR, newG, newB);
                    bPic.SetPixel(i, j, newColor);
                    index++;
                }
                if (st)
                {
                    break;
                }
            }
            pic_box1.Image = bPic;

            String sFilePic;
            SaveFileDialog dSavePic = new SaveFileDialog();
            dSavePic.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (dSavePic.ShowDialog() == DialogResult.OK)
            {
                sFilePic = dSavePic.FileName;
            }
            else
            {
                sFilePic = "";
                return;
            }
            ;

            FileStream wFile;
            try
            {
                wFile = new FileStream(sFilePic, FileMode.Create); //открываем поток на запись результатов
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла на запись", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bPic.Save(wFile, System.Drawing.Imaging.ImageFormat.Bmp);
            wFile.Close(); //закрываем поток
        }

        /*Открыть файл для дешифрования */

        private void button2_Click(object sender, EventArgs e)
        {
            string FilePic;
            OpenFileDialog dPic = new OpenFileDialog();
            dPic.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (dPic.ShowDialog() == DialogResult.OK)
            {
                FilePic = dPic.FileName;
            }
            else
            {
                FilePic = "";
                return;
            }

            FileStream rFile;
            try
            {
                rFile = new FileStream(FilePic, FileMode.Open); //открываем поток
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bPic = new Bitmap(rFile);
            if (!isEncryption(bPic))
            {
                MessageBox.Show("В файле нет зашифрованной информации", "Информация - Стеганография", MessageBoxButtons.OK);
                return;
            }

            int countSymbol = ReadCountText(bPic); //считали количество зашифрованных символов

            byte[] message = new byte[countSymbol];
            int index = 0;
            bool st = false;
            for (int i = 4; i < bPic.Width; i++)
            {
                for (int j = 0; j < bPic.Height; j++)
                {
                    Color pixelColor = bPic.GetPixel(i, j);
                    if (index == message.Length)
                    {
                        st = true;
                        break;
                    }
                    BitArray colorArray = ByteToBit(pixelColor.R);
                    BitArray messageArray = ByteToBit(pixelColor.R);
                    
                    messageArray[0] = colorArray[0];
                    messageArray[1] = colorArray[1];

                    colorArray = ByteToBit(pixelColor.G);
                    messageArray[2] = colorArray[0];
                    messageArray[3] = colorArray[1];
                    messageArray[4] = colorArray[2];

                    colorArray = ByteToBit(pixelColor.B);
                    messageArray[5] = colorArray[0];
                    messageArray[6] = colorArray[1];
                    messageArray[7] = colorArray[2];
                    message[index] = BitToByte(messageArray);
                    index++;
                }
                if (st)
                {
                    break;
                }
            }
            string strMessage = Encoding.Default.GetString(message);

            string sFileText;
            SaveFileDialog dSaveText = new SaveFileDialog();
            dSaveText.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (dSaveText.ShowDialog() == DialogResult.OK)
            {
                sFileText = dSaveText.FileName;
            }
            else
            {
                sFileText = "";
                return;
            }
            ;

            FileStream wFile;
            try
            {
                wFile = new FileStream(sFileText, FileMode.Create); //открываем поток на запись результатов
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла на запись", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamWriter wText = new StreamWriter(wFile, Encoding.Default);
            wText.Write(strMessage);
            MessageBox.Show("Текст записан в файл", "Информация - Стеганография", MessageBoxButtons.OK);
            wText.Close();
            wFile.Close(); //закрываем поток

        }







        private void choosePic_btn_Click(object sender, EventArgs e)
        {
            string FilePic;
            string FileText;
            OpenFileDialog dPic = new OpenFileDialog();
            dPic.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (dPic.ShowDialog() == DialogResult.OK)
            {
                FilePic = dPic.FileName;
            }
            else
            {
                FilePic = "";
                return;
            }


            FileStream rFile;
            try
            {
                rFile = new FileStream(FilePic, FileMode.Open); //открываем поток

            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            pic_box1_bmap = new Bitmap(rFile);
            this.pic_box1.Image = pic_box1_bmap;
            rFile.Close();


        }

        private void resetPic_btn_Click(object sender, EventArgs e)
        {
            this.code_progressBar.Value = 0;
            pic_box1_bmap = null;
            pic_box2.Image = null;
            this.pic_box1.Image = pic_box1_bmap;
            CheckedImageCapasity = 0;

            fullPathOrName_lbl.Text = "";
           
        }




        private void chooseTextFile_btn_Click(object sender, EventArgs e)
        {
            IsSelectedFile = false;

            OpenFileDialog dText = new OpenFileDialog();
            dText.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (dText.ShowDialog() == DialogResult.OK)
            {
                pathTxT = dText.FileName;
            }
            else
            {
                pathTxT = "";
                return;
            }

            FileStream rText;
            try
            {
                rText = new FileStream(pathTxT, FileMode.Open); //открываем поток
                IsSelectedFile = true;
                selectedfile_lbl.Text = pathTxT;


            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] bytes = new byte[rText.Length];
            rText.Read(bytes, 0, bytes.Length);

            EncodeTextFromTxT = Encoding.Default.GetString(bytes);
            //file_richTextBox.Text = EncodeTextFromTxT;

            //размер и вместимость: задание значение и вывод в лейбл
            GlobalLenght = bytes.Length;
            capacityText_lbl.Text = "Требуемая вместимость: " + GlobalLenght;


            rText.Close();
            GetSortedList(bytes.Length);
            DecodeBtn();
            UpdateDGV();

        }


        private int GlobalLenght;

        private void resetTextFile_btn_Click(object sender, EventArgs e)
        {
            IsSelectedFile = false;
            selectedfile_lbl.Text = ".";

            EncodeTextFromTxT = "";
            file_richTextBox.Text = "";
            if (chose_radioButton.Checked) chose_radioButton_CheckedChanged(sender, e);
            GetSortedList(GlobalLenght);
            UpdateDGV();
            DecodeBtn();
        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            if (IsSelectedFile)
            {
                if (pic_box1_bmap != null)
                {
                    Steganography st = new Steganography(pic_box1_bmap, EncodeTextFromTxT);
                    //добавить условие для тега

                    pic_box2.Image = st.CastEncodeRGB(1, code_progressBar);
                    //pic_box2.Image = st.MyEncode(8);

                }
                else
                {
                    MessageBox.Show("Необходимо выбрать изображение для шифрования", "Ошибка - Стеганография", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (!crypto_rTB.Text.Equals(""))
            {
                if (pic_box1_bmap != null)
                {
                    Steganography st = new Steganography(pic_box1_bmap, crypto_rTB.Text);
                    //добавить условие для тега

                    pic_box2.Image = st.CastEncodeRGB(1, code_progressBar);
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать изображение для шифрования", "Ошибка - Стеганография", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл или заполнить текстовое поле", "Ошибка - Стеганография", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void saveEncodedPic_btn_Click(object sender, EventArgs e)
        {
            if (pic_box2.Image != null)
            {
                String sFilePic;
                SaveFileDialog dSavePic = new SaveFileDialog();
                dSavePic.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
                if (dSavePic.ShowDialog() == DialogResult.OK)
                {
                    sFilePic = dSavePic.FileName;
                }
                else
                {
                    sFilePic = "";
                    return;
                }
                ;

                FileStream wFile;
                try
                {
                    wFile = new FileStream(sFilePic, FileMode.Create); //открываем поток на запись результатов
                }
                catch (IOException)
                {
                    MessageBox.Show("Ошибка открытия файла на запись", "Ошибка - Стеганография", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                //pic_box2.Image.Save(wFile, System.Drawing.Imaging.ImageFormat.Bmp);
                Bitmap b = new Bitmap(pic_box2.Image);
                b.Save(wFile, System.Drawing.Imaging.ImageFormat.Bmp);
                wFile.Close();
            }
        }

        private  void chooseDecPic_btn_Click(object sender, EventArgs e)
        {
            string FilePic;
            OpenFileDialog dPic = new OpenFileDialog();
            dPic.Filter = "Файлы изображений (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (dPic.ShowDialog() == DialogResult.OK)
            {
                FilePic = dPic.FileName;
            }
            else
            {
                FilePic = "";
                return;
            }

            FileStream rFile;
            try
            {
                rFile = new FileStream(FilePic, FileMode.Open); //открываем поток
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка открытия файла", "Ошибка - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap bPic = new Bitmap(rFile);
            decode_PB.Image = bPic;
           
            Steganography st = new Steganography(rFile);

            //string s = st.MyDecode(3);
            string s;

            if (st.ReadCountText(bPic) <= 0)
            {
                DialogResult result = MessageBox.Show("Не удалось считать объем закодированных данных. Возможно данное изображение не содержит скрытого содержимого. Продолжить считывание?", "Внимание - Стеганография", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    s = st.CastDecodeRGB(1, deshifr_progressBar);
                    decode_rtb.Text = s;
                }
                else if (result == DialogResult.No)
                {
                    //...
                }
            }

            else
            {
                s = st.CastDecodeRGB(1, deshifr_progressBar);
                decode_rtb.Text = s;
            }

         
        
            

            rFile.Close();
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar_label.Text = trackBar1.Value.ToString();
        }



        string[] allDir;



        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.KeyPreview = true;
            changepass_button.Enabled = false;
            //задание темы оформления
            switch (Properties.Settings.Default.Theme)
            {
                case 1:
                {
                    theme1_rb.Checked=true;
                   break;
                }

                case 2:
                    {
                        theme2_rb.Checked = true;
                        break;
                    }
                case 3:
                    {
                        theme3_rb.Checked = true;
                        break;
                    }

                case 4:
                    {
                        theme4_rb.Checked = true;
                        break;
                    }
            }



            //help_rtb.LoadFile(@"C:\Users\sv\Desktop\Зайвый-Стеганография\О программе.rtf");
            //help_rtb.LoadFile(@"C:\Users\sv\Desktop\Зайвый-Стеганография\help.rtf");
            help_rtb.LoadFile(@"help.rtf");
            string s = help_rtb.Text;



            //foreach (string item in Directory.GetFiles(@"C:\Users\sv\Desktop\"))
            //{
            //    FileInfo d = new FileInfo(item);
            //    crypto_rTB.Text += item + "  ";
            //    crypto_rTB.Text+= d.Length;
            //    crypto_rTB.Text += "\n";

            //}



        }




        private void GetSortedList(int length)
        {
            sortedFilePicList.Clear();
            if (FilePicList != null && FilePicList.Count > 0)
            {
                foreach (FilePic item in FilePicList)
                {
                    if (item.GetPicCapasity() >= length)
                    {
                        sortedFilePicList.Add(item);
                    }
                }
            }

        }

        private void chooseDir_btn_Click(object sender, EventArgs e)
        {

            DeleteDirInfo();
            FolderBrowserDialog Dir = new FolderBrowserDialog();

            if (Dir.ShowDialog() == DialogResult.OK)
            {
                pathDIR = Dir.SelectedPath;
                selectedDir_lbl.Text = pathDIR;

                GetListOfPic(pathDIR, this.crypt_progressBar);
                GetSortedList(GlobalLenght);
                UpdateDGV();

                if (this.FilePicList.Count == 0)
                {
                    MessageBox.Show("Выбранный каталог не содержит файлов с раширением bmp.", "Внимание - Стеганография", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                pathDIR = "";
                return;
            }



        }



        private void GetListOfPic(string pathDir, ProgressBar progressBar)
        {
            string[] allFiles = Directory.GetFiles(pathDir);

            progressBar.Maximum = allFiles.Length;

            if (allFiles != null)
            {
                foreach (string item in allFiles)
                {
                    if (Path.GetExtension(item) == ".bmp")
                    {
                        FileStream fsPic;
                        try
                        {
                            fsPic = new FileStream(item, FileMode.Open); //открываем поток

                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Ошибка открытия файла", "Ошибка - Стеганография", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }


                        FilePicList.Add(new FilePic(new Bitmap(fsPic), item));
                        sortedFilePicList.Add(new FilePic(new Bitmap(fsPic), item));
                        fsPic.Close();
                    }

                    progressBar.Value++;
                }
            }

        }

        public void UpdateDGV()
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = sortedFilePicList;




            BindingSource source1 = new BindingSource();
            source1.DataSource = sortedFilePicList;


            mainTab_dataGridView.DataSource = source1;

            //source1.Filter = "[capacity]=22500";

        }


        private void DecodeBtn()
        {
            if (chose_radioButton.Checked)
            {
                if (IsSelectedFile)
                {
                    if (pic_box1.Image != null)
                    {
                        decode_btn.Enabled = true;
                    }
                    else
                    {
                        decode_btn.Enabled = false;
                    }
                }
                else
                {
                    decode_btn.Enabled = false;
                }
            }
            else
            {
                if (pic_box1.Image != null)
                {
                    decode_btn.Enabled = true;
                }

                else
                {
                    decode_btn.Enabled = false;
                }
            }
        }

        private void deleteDir_btn_Click(object sender, EventArgs e)
        {

            this.crypt_progressBar.Value = 0;
            //должны очистится два листа, лейбл, выбранный файл, когда он будет выбран + обновить таблицу

            DeleteDirInfo();

            allDir = null;
            DecodeBtn();
        }

        private void DeleteDirInfo()
        {
            pathDIR = ""; //посмотреть надо или нет
            sortedFilePicList.Clear();
            FilePicList.Clear();
            selectedDir_lbl.Text = "";

            UpdateDGV();
            this.pic_box1.Image = null;
            fullPathOrName_lbl.Text = ".";
        }


        private void selectedfile_lbl_Click(object sender, EventArgs e)
        {

        }


        private void crypto_rTB_TextChanged(object sender, EventArgs e)
        {
            if (!crypto_rTB.Text.Equals(""))
            {




                GlobalLenght = Encoding.Default.GetBytes(crypto_rTB.Text).Length;

               
                    //if (CheckedImageCapasity < GlobalLenght)
                    //{
                    //    this.pic_box1.Image = null;
                    //    this.fullPathOrName_lbl.Text = "";
                    //}
                
                


                capacityText_lbl.Text = "Требуемая вместимость: " + GlobalLenght;
                GetSortedList(GlobalLenght);
                UpdateDGV();

                if (chose_radioButton.Checked) chose_radioButton_CheckedChanged(sender, e);
            }
            else
            {
                GlobalLenght = 0;
                capacityText_lbl.Text = "Требуемая вместимость: " + GlobalLenght;
                GetSortedList(GlobalLenght);
                UpdateDGV();
            }
        }

        public void RadioBtn()
        {
            if (chose_radioButton.Checked)
            {
                chooseTextFile_btn.Enabled = true;
                crypto_rTB.Enabled = false;
            }

            if (writeOn_radioButton.Checked)
            {
                crypto_rTB.Enabled = true;
                chooseTextFile_btn.Enabled = false;

            }
        }

        private void chose_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioBtn();

            if (pathTxT.Equals(""))
            {
                GlobalLenght = 0;
            }
            else
            {
                GlobalLenght = Encoding.Default.GetBytes(EncodeTextFromTxT).Length;

                GetSortedList(GlobalLenght);
                UpdateDGV();
            }
            DecodeBtn();

            capacityText_lbl.Text = "Требуемая вместимость: " + GlobalLenght;
        }

        private void writeOn_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioBtn();
            crypto_rTB_TextChanged(sender, e);
            capacityText_lbl.Text = "Требуемая вместимость: " + GlobalLenght;
            DecodeBtn();

        }

        private void pic_box2_Click(object sender, EventArgs e)
        {

        }

        private int CheckedImageCapasity;

        private void mainTab_dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 2) //индекс столбца, в которой находится кнопка.
                {
                    fullPathOrName_lbl.Text = this.sortedFilePicList[e.RowIndex].FileName;
                    this.pic_box1.Image = this.sortedFilePicList[e.RowIndex].GetPic();
                    CheckedImageCapasity = this.pic_box1.Image.Height*this.pic_box1.Image.Width;
                    DecodeBtn();
                }
            }
        }

        private void mainTab_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainTab_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void decode_btn_Click(object sender, EventArgs e)
        {
            if (chose_radioButton.Checked)
            {
                if (IsSelectedFile)
                {
                    if (pic_box1.Image != null)
                    {
                        Steganography st = new Steganography((Bitmap) pic_box1.Image, EncodeTextFromTxT);
                        //добавить условие для тега

                        pic_box2.Image = st.CastEncodeRGB(1, code_progressBar);
                    }
                }
            }
            else
            {
                if (pic_box1.Image != null)
                {
                    Steganography st = new Steganography((Bitmap) pic_box1.Image, crypto_rTB.Text);
                    //добавить условие для тегас

                    pic_box2.Image = st.CastEncodeRGB(1, code_progressBar);
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            //if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            //{
            //    Size size = new Size();
            //    size.Width = this.pic_box1.Width;
            //    size.Height = this.pic_box1.Height;
            //    pic_box1.Size = this.shifr_panel.Size;
            //}

            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

            this.Encoding_tab_control.Size = this.Size;


            resolution.Width = shifr_panel.Width + 50;

            this.MinimumSize = resolution;


            Point p = new Point();
            p.X = this.Size.Width/2 - 450;
            p.Y = shifr_panel.Location.Y;
            shifr_panel.Location = p;

            Point pd = new Point();
            pd.X = this.Size.Width/2 - 450;
            pd.Y = deshifr_panel.Location.Y;
            deshifr_panel.Location = pd;

            Point pm  = new Point();
            pm.X = this.Size.Width / 2 - 450;
            pm.Y = menu_panel.Location.Y;
            menu_panel.Location = pd;

            Point ps = new Point();
            ps.X = this.Size.Width / 2 - 450;
            ps.Y = settings_panel.Location.Y;
            settings_panel.Location = pd;

            Point pgs = new Point();
            pgs.X = this.Size.Width / 2 - 450;
            pgs.Y = help_groupBox.Location.Y;
            help_groupBox.Location = pd;


            Point pga = new Point();
            pga.X = this.Size.Width / 2 - 450;
            pga.Y = about_groupBox.Location.Y;
            about_groupBox.Location = pd;

            Size gbHelp = new Size();
            gbHelp.Width = this.help_groupBox.Size.Width;
            gbHelp.Height = this.Size.Height;
            gbHelp.Height -= 100;
            help_groupBox.Size = gbHelp;

            Size rtbHelp = new Size();
            rtbHelp.Width = this.help_rtb.Size.Width;
            rtbHelp.Height = this.Size.Height;
            rtbHelp.Height -= 100;
            help_rtb.Size = rtbHelp;

        }

        private void resetDecPic_btn_Click_Click(object sender, EventArgs e)
        {
            decode_PB.Image = null;
            decode_rtb.Text = "";
            deshifr_progressBar.Value = 0;
          
        }

        private void shifr_clear_text_btn_Click(object sender, EventArgs e)
        {
            crypto_rTB.Text = "";
           int w0 = mainTab_dataGridView.Columns[0].Width;
            int w1 = mainTab_dataGridView.Columns[1].Width;
            int w2 = mainTab_dataGridView.Columns[2].Width;
            

        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(this.decode_rtb.Text);
                MessageBox.Show("Текст скопирован в буфер обмена", "Копирование - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Information);        

            }
            catch (Exception)
            {

            }
            
             
        }


        private void encode_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void crypt_button_Click(object sender, EventArgs e)
        {
            this.Encoding_tab_control.SelectedIndex = 1;
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            this.Encoding_tab_control.SelectedIndex = 2;
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            this.Encoding_tab_control.SelectedIndex = 3;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            this.Encoding_tab_control.SelectedIndex = 4;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            this.Encoding_tab_control.SelectedIndex = 5;

        }

        private void oldpass_label_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //Бирюзовая
        private void theme3_rb_CheckedChanged(object sender, EventArgs e)
        {
            menu_groupBox1.BackColor = Color.LightSkyBlue;
            menu_groupBox2.BackColor = Color.LightSkyBlue;
            groupBox1.BackColor = Color.LightSkyBlue;
            textFile_groupBox.BackColor = Color.LightSkyBlue;
            mainTab_dataGridView.BackgroundColor = Color.LightSkyBlue;
            crypto_rTB.BackColor = Color.LightSkyBlue;
            pic_box1.BackColor = Color.LightSkyBlue;
            pic_box2.BackColor = Color.LightSkyBlue;
            encodePic_gB.BackColor = Color.LightSkyBlue;
            decode_PB.BackColor = Color.LightSkyBlue;
            decode_rtb.BackColor = Color.LightSkyBlue;
            help_rtb.BackColor = Color.LightSkyBlue;
            theme_groupBox.BackColor = Color.LightSkyBlue;
            password_groupBox.BackColor = Color.LightSkyBlue;
            about_groupBox.BackColor = Color.LightSkyBlue;
            about_rtb.BackColor = Color.LightSkyBlue;
            help_groupBox.BackColor = Color.LightSkyBlue;


            menu_groupBox1.ForeColor = Color.Black;
            menu_groupBox2.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            textFile_groupBox.ForeColor = Color.Black;
            encodePic_gB.ForeColor = Color.Black;
            decode_rtb.ForeColor = Color.Black;
            help_rtb.ForeColor = Color.Black;
            theme_groupBox.ForeColor = Color.Black;
            password_groupBox.ForeColor = Color.Black;
            about_groupBox.ForeColor = Color.Black;
            about_rtb.ForeColor = Color.Black;
            help_groupBox.ForeColor = Color.Black;



            welcome_tabPage.BackColor = Color.LightBlue;
            encode_tabPage.BackColor = Color.LightBlue;
            decode_tabPage.BackColor = Color.LightBlue;
            help_tabPage.BackColor = Color.LightBlue;
            setings_tabPage.BackColor = Color.LightBlue;
            about_tabPage.BackColor = Color.LightBlue;

            panelh1.BackColor = Color.DeepSkyBlue;
            panelh2.BackColor = Color.Turquoise;
            panelh3.BackColor = Color.Turquoise;
            panelh4.BackColor = Color.DeepSkyBlue;
            panelh5.BackColor = Color.DeepSkyBlue;

            panelm1.BackColor = Color.DodgerBlue;
            panelm2.BackColor = Color.MediumTurquoise;
            panelm3.BackColor = Color.MediumTurquoise;
            panelm4.BackColor = Color.DodgerBlue;
            panelm5.BackColor = Color.MediumTurquoise;

            crypt_button.BackColor = Color.RoyalBlue;
            encrypt_button.BackColor = Color.DarkTurquoise;
            settings_button.BackColor = Color.MediumTurquoise;
            help_button.BackColor = Color.SlateBlue;
            about_button.BackColor = Color.DarkTurquoise;

            Properties.Settings.Default.Theme = 3;
            Properties.Settings.Default.Save();
        }

        //Cветло-бирюзовая
        private void theme4_rb_CheckedChanged(object sender, EventArgs e)
        {
            menu_groupBox1.BackColor = Color.LightSkyBlue;
            menu_groupBox2.BackColor = Color.LightSkyBlue;
            groupBox1.BackColor = Color.LightSkyBlue;
            textFile_groupBox.BackColor = Color.LightSkyBlue;
            mainTab_dataGridView.BackgroundColor = Color.LightSkyBlue;
            crypto_rTB.BackColor = Color.LightSkyBlue;
            pic_box1.BackColor = Color.LightSkyBlue;
            pic_box2.BackColor = Color.LightSkyBlue;
            encodePic_gB.BackColor = Color.LightSkyBlue;
            decode_PB.BackColor = Color.LightSkyBlue;
            decode_rtb.BackColor = Color.LightSkyBlue;
            help_rtb.BackColor = Color.LightSkyBlue;
            theme_groupBox.BackColor = Color.LightSkyBlue;
            password_groupBox.BackColor = Color.LightSkyBlue;
            about_groupBox.BackColor = Color.LightSkyBlue;
            about_rtb.BackColor = Color.LightSkyBlue;
            help_groupBox.BackColor = Color.LightSkyBlue;


            menu_groupBox1.ForeColor = Color.Black;
            menu_groupBox2.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            textFile_groupBox.ForeColor = Color.Black;
            encodePic_gB.ForeColor = Color.Black;
            decode_rtb.ForeColor = Color.Black;
            help_rtb.ForeColor = Color.Black;
            theme_groupBox.ForeColor = Color.Black;
            password_groupBox.ForeColor = Color.Black;
            about_groupBox.ForeColor = Color.Black;
            about_rtb.ForeColor = Color.Black;
            help_groupBox.ForeColor = Color.Black;

            welcome_tabPage.BackColor = Color.White;
            encode_tabPage.BackColor = Color.White;
            decode_tabPage.BackColor = Color.White;
            help_tabPage.BackColor = Color.White;
            setings_tabPage.BackColor = Color.White;
            about_tabPage.BackColor = Color.White;

            panelh1.BackColor = Color.DeepSkyBlue;
            panelh2.BackColor = Color.Turquoise;
            panelh3.BackColor = Color.Turquoise;
            panelh4.BackColor = Color.DeepSkyBlue;
            panelh5.BackColor = Color.DeepSkyBlue;

            panelm1.BackColor = Color.DodgerBlue;
            panelm2.BackColor = Color.MediumTurquoise;
            panelm3.BackColor = Color.MediumTurquoise;
            panelm4.BackColor = Color.DodgerBlue;
            panelm5.BackColor = Color.MediumTurquoise;

            crypt_button.BackColor = Color.RoyalBlue;
            encrypt_button.BackColor = Color.DarkTurquoise;
            settings_button.BackColor = Color.MediumTurquoise;
            help_button.BackColor = Color.SlateBlue;
            about_button.BackColor = Color.DarkTurquoise;
            Properties.Settings.Default.Theme = 4;
            Properties.Settings.Default.Save();
        }

        //Темная
        private void theme1_rb_CheckedChanged(object sender, EventArgs e)
        {
            menu_groupBox1.BackColor = Color.DimGray;
            menu_groupBox2.BackColor = Color.DimGray;
            groupBox1.BackColor = Color.DimGray;
            textFile_groupBox.BackColor = Color.DimGray;
            mainTab_dataGridView.BackgroundColor = Color.DimGray;
            crypto_rTB.BackColor = Color.DimGray;
            pic_box1.BackColor = Color.DimGray;
            pic_box2.BackColor = Color.DimGray;
            encodePic_gB.BackColor = Color.DimGray;
            decode_PB.BackColor = Color.DimGray;
            decode_rtb.BackColor = Color.DimGray;
            help_rtb.BackColor = Color.DimGray;
            theme_groupBox.BackColor = Color.DimGray;
            password_groupBox.BackColor = Color.DimGray;
            about_groupBox.BackColor = Color.DimGray;
            about_rtb.BackColor = Color.DimGray;
            help_groupBox.BackColor = Color.DimGray;


            menu_groupBox1.ForeColor = Color.White;
            menu_groupBox2.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
            textFile_groupBox.ForeColor = Color.White;
            encodePic_gB.ForeColor = Color.White;
            decode_rtb.ForeColor = Color.White;
            help_rtb.ForeColor = Color.White;
            theme_groupBox.ForeColor = Color.White;
            password_groupBox.ForeColor = Color.White;
            about_groupBox.ForeColor = Color.White;
            about_rtb.ForeColor = Color.White;
            help_groupBox.ForeColor = Color.White;

            welcome_tabPage.BackColor = Color.Gray;
            encode_tabPage.BackColor = Color.Gray;
            decode_tabPage.BackColor = Color.Gray;
            help_tabPage.BackColor = Color.Gray;
            setings_tabPage.BackColor = Color.Gray;
            about_tabPage.BackColor = Color.Gray;
            fullPathOrName_lbl.BackColor = Color.White;
            selectedDir_lbl.BackColor = Color.White;
            selectedfile_lbl.BackColor = Color.White;
            capacityText_lbl.BackColor = Color.White;

            help_button.ForeColor = Color.Black;
            crypt_button.ForeColor = Color.Black;
            encrypt_button.ForeColor = Color.Black;
            about_button.ForeColor = Color.Black;
            settings_button.ForeColor = Color.Black;

            Properties.Settings.Default.Theme = 1;
            Properties.Settings.Default.Save();
        }

        //Cветлая
        private void theme2_rb_CheckedChanged(object sender, EventArgs e)
        {
            menu_groupBox1.BackColor = Color.Lavender;
            menu_groupBox2.BackColor = Color.Lavender;
            groupBox1.BackColor = Color.Lavender;
            textFile_groupBox.BackColor = Color.Lavender;
            mainTab_dataGridView.BackgroundColor = Color.Lavender;
            crypto_rTB.BackColor = Color.Lavender;
            pic_box1.BackColor = Color.Lavender;
            pic_box2.BackColor = Color.Lavender;
            encodePic_gB.BackColor = Color.Lavender;
            decode_PB.BackColor = Color.Lavender;
            decode_rtb.BackColor = Color.Lavender;
            help_rtb.BackColor = Color.Lavender;
            theme_groupBox.BackColor = Color.Lavender;
            password_groupBox.BackColor = Color.Lavender;
            about_groupBox.BackColor = Color.Lavender;
            about_rtb.BackColor = Color.Lavender;
            help_groupBox.BackColor = Color.Lavender;


            menu_groupBox1.ForeColor = Color.Black;
            menu_groupBox2.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            textFile_groupBox.ForeColor = Color.Black;
            encodePic_gB.ForeColor = Color.Black;
            decode_rtb.ForeColor = Color.Black;
            help_rtb.ForeColor = Color.Black;
            theme_groupBox.ForeColor = Color.Black;
            password_groupBox.ForeColor = Color.Black;
            about_groupBox.ForeColor = Color.Black;
            about_rtb.ForeColor = Color.Black;
            help_groupBox.ForeColor = Color.Black;

            welcome_tabPage.BackColor = Color.White;
            encode_tabPage.BackColor = Color.White;
            decode_tabPage.BackColor = Color.White;
            help_tabPage.BackColor = Color.White;
            setings_tabPage.BackColor = Color.White;
            about_tabPage.BackColor = Color.White;

            panelh1.BackColor= Color.Gainsboro;
            panelh2.BackColor = Color.LightGray;
            panelh3.BackColor = Color.WhiteSmoke;
            panelh4.BackColor = Color.LightGray;
            panelh5.BackColor = Color.Gainsboro;

            panelm1.BackColor = Color.LightGray;
            panelm2.BackColor = Color.Gainsboro;
            panelm3.BackColor = Color.LightGray;
            panelm4.BackColor = Color.WhiteSmoke;
            panelm5.BackColor = Color.LightGray;

            help_button.BackColor = Color.LightGray;
            crypt_button.BackColor = Color.WhiteSmoke;
            encrypt_button.BackColor = Color.GhostWhite;
            about_button.BackColor = Color.Lavender;
            settings_button.BackColor = Color.Gainsboro;

            Properties.Settings.Default.Theme = 2;
            Properties.Settings.Default.Save();

        }

     
        


        private void welcome_tabPage_Click(object sender, EventArgs e)
        {

        }

        private void decode_PB_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                if (Properties.Settings.Default.Password == textBox1.Text)
                {
                    textBox1.BackColor = Color.Aquamarine;
                    changepass_button.Enabled = true;

                }
                else
                {
                    textBox1.BackColor = Color.LightCoral;
                    changepass_button.Enabled = false;
                }
            }

            else
            {
                textBox1.BackColor = Color.White;
                changepass_button.Enabled = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void changepass_button_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password == textBox1.Text)
            {
                if (newpass_textBox.Text != "")
                {
                    Properties.Settings.Default.Password = newpass_textBox.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Пароль изменен", "Смена пароля - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    newpass_textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Не удалось изменить пароль. Пароль должен состоять минимум из одного символа", "Смена пароля - Стеганография", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void save_deshifr_btn_Click(object sender, EventArgs e)
        {
            
                String sText;
                SaveFileDialog saveTextDialog = new SaveFileDialog();
                saveTextDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (saveTextDialog.ShowDialog() == DialogResult.OK)
                {
                    sText = saveTextDialog.FileName;
                }
                else
                {
                    sText = "";
                    return;
                }
               ;

                FileStream wFile;
                try
                {
                    wFile = new FileStream(sText, FileMode.Create); //открываем поток на запись результатов
                }
                catch (IOException)
                {
                    MessageBox.Show("Ошибка открытия файла на запись", "Ошибка - Стеганография", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                decode_rtb.SaveFile(wFile, RichTextBoxStreamType.PlainText);
                wFile.Close();
            
        }

        private void text_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_tabControl.SelectedIndex == 1)
            {
                file_richTextBox.Text = EncodeTextFromTxT;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Encoding_tab_control.SelectedIndex = 3;
            }
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F1)
            {
                Encoding_tab_control.SelectedIndex = 3;
            }
        }

        private void newpass_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deshifr_progressBar_Click(object sender, EventArgs e)
        {
            
        }

        private void deshifr_progressBar_TabIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
