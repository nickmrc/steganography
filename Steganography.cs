using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StegProject
{
    class Steganography
    {
        public Bitmap bPic;
        private List<byte> bList = new List<byte>();


        public Steganography(Stream picFile, Stream textFile)
        {
            bPic = new Bitmap(picFile);
            BinaryReader bText = new BinaryReader(textFile, Encoding.Default);

            while (bText.PeekChar() != -1)
            {
                //считали весь текстовый файл для шифрования в лист байт
                bList.Add(bText.ReadByte());
            }
        }

        public int GetLengthBytes()
        {
            if (bytes != null) return bytes.Length;
            else return 0;
        }

        byte[] bytes;
        public Steganography(Bitmap bmap, string text)
        {
            bPic = bmap;
             bytes = Encoding.Default.GetBytes(text);

            foreach (byte VARIABLE in bytes)
            {
                bList.Add(VARIABLE);
            }
        }

        public Steganography(Stream picFile)
        {
            bPic = new Bitmap(picFile);
        }

        private bool IsEnoughToPut()
        {
            if (bList.Count > ((bPic.Width*bPic.Height)) - 4) return false;
            else return true;
        }

        private void WriteEncodingTag(string s)
        {
            byte[] Symbol = Encoding.Default.GetBytes(s);
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
        }

        private void WriteEncodingTagDefault()
        {
            WriteEncodingTag("/");
        }

        public Bitmap EncodeRGB()
        {
            Bitmap buf = new Bitmap(this.bPic);
            WriteCountText(bList.Count, buf);

            int index = 0;
            bool stop = false;
            for (int i = 4; i < buf.Width; i++)
            {
                for (int j = 0; j < buf.Height; j++)
                {
                    Color pixelColor = buf.GetPixel(i, j);
                    if (index == bList.Count)
                    {
                        stop = true;
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
                    buf.SetPixel(i, j, newColor);
                    index++;
                }
                if (stop)
                {
                    break;
                }
            }
            return buf;
        }

        private int CountNeededPixel(int count, double num)
        {
            return (int)Math.Ceiling(count/num);
        }

        public Bitmap CastEncodeRGB(int countBytes, ProgressBar progress)
        {
            Bitmap buf = new Bitmap(this.bPic);

            WriteCountText(bList.Count, buf);

            if (progress != null)
            {
                progress.Maximum = bList.Count;
            }

            int index = 0;
            bool stop = false;

            switch (countBytes)
            {
                case 1:
                    {
                        #region 1 байт

                        for (int j = 0; j < buf.Height; j++)
                        {
                            for (int i = 0; i < buf.Width; i++)
                            {
                                if (j == 0 && i < 5) continue;

                                if (index == bList.Count)
                                {
                                    stop = true;
                                    break;
                                }
                                Color pixelColor = buf.GetPixel(i, j);
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
                                buf.SetPixel(i, j, newColor);
                                index++;

                                if (progress != null)
                                {
                                    progress.Value = index;
                                }
                                
                            }
                            if (stop)
                            {
                                break;
                            }
                        }

                        #endregion
                        break;
                    }
                case 2:
                    {
                        #region 2 бита

                        Color[] colors = GetColorArrayFromBitmap(buf, bList.Count, countBytes);

                        stop = false;
                        int bi = 0;
                        int bli = 0;
                        for (int i = 0; i < colors.Length; i++)
                        {
                            List<BitArray> rgb = new List<BitArray>();
                            rgb.Add(ByteToBit(colors[i].R));
                            rgb.Add(ByteToBit(colors[i].G));
                            rgb.Add(ByteToBit(colors[i].B));

                           
                            for (int irgb = 0; irgb < rgb.Count; irgb++)
                            {
                                BitArray messageArray = ByteToBit(bList[bi]);
                                for (int j = 0; j < countBytes; j++)
                                {
                                    
                                    rgb[irgb][j] = messageArray[bli++];
                                    if (bli==8)
                                    {
                                        bli = 0;
                                        bi++;
                                        break;
                                    }
                                 
                                }
                               
                                if (bi == bList.Count)
                                {
                                    stop = true;
                                    break;
                                }
                            }

                            colors[i] = Color.FromArgb(BitToByte(rgb[0]), BitToByte(rgb[1]), BitToByte(rgb[2]));
                            if (stop)
                            {
                                break;
                            }

                        }

                        SetBitmapFromColorArray(buf, colors);


                        #endregion
                        break;
                    }
                case 3:
                    {
                        #region 3 байта

                        Color [] colors = GetColorArrayFromBitmap(buf, bList.Count, countBytes);

                        stop = false;
                        int bi = 0;
                        for (int i = 0; i < colors.Length; i++)
                        {
                            List<BitArray> rgb = new List<BitArray>();
                            rgb.Add(ByteToBit(colors[i].R));
                            rgb.Add(ByteToBit(colors[i].G));
                            rgb.Add(ByteToBit(colors[i].B));

                            foreach (BitArray VARIABLE in rgb)
                            {
                                BitArray messageArray = ByteToBit(bList[bi++]);
                                VARIABLE[0] = messageArray[0];
                                VARIABLE[1] = messageArray[1];
                                VARIABLE[2] = messageArray[2];
                                VARIABLE[3] = messageArray[3];
                                VARIABLE[4] = messageArray[4];
                                VARIABLE[5] = messageArray[5];
                                VARIABLE[6] = messageArray[6];
                                VARIABLE[7] = messageArray[7];
                                if (bi == bList.Count)
                                {
                                    stop = true;
                                    break;
                                }
                            }
                            colors[i] = Color.FromArgb(BitToByte(rgb[0]), BitToByte(rgb[1]), BitToByte(rgb[2]));
                            if (stop)
                            {
                                break;
                            }
                            
                        }
                        
                        SetBitmapFromColorArray(buf, colors);
                        

                        #endregion
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

           
           

            return buf;
        }

        private static void SetBitmapFromColorArray(Bitmap buf, Color[] colors)
        {
            bool stop=false;
            for (int j = 0, total = 0; j < buf.Height; j++)
            {
                for (int i = 0; i < buf.Width; i++)
                {
                    buf.SetPixel(i, j, colors[total++]);
                    if (total == colors.Length)
                    {
                        stop = true;
                        break;
                    }
                }

                if (stop)
                {
                    break;
                }
            }
        }

        private Color[] GetColorArrayFromBitmap(Bitmap buf, int count,int countBytes)
        {
            Color[] colors = new Color[CountNeededPixel(count, countBytes)];
            bool stop = false;

            for (int j = 0, total = 0; j < buf.Height; j++)
            {
                for (int i = 0; i < buf.Width; i++)
                {
                    if (total == colors.Length)
                    {
                        stop = true;
                        break;
                    }
                    colors[total++] = buf.GetPixel(i, j);
                }

                if (stop)
                {
                    break;
                }
            }
            return colors;
        }

        public Bitmap MyCastEncodeRGB()
        {
            Bitmap buf = new Bitmap(this.bPic);

            WriteCountText(bList.Count, buf);
            int index = 0;
            bool stop = false;

            for (int j = 0; j < buf.Height; j++)
            {
                for (int i = 0; i < buf.Width; i++)
                {
                    if (j == 0 && i < 5) continue;

                    if (index == bList.Count)
                    {
                        stop = true;
                        break;
                    }
                    Color pixelColor = buf.GetPixel(i, j);
                    BitArray colorArray = ByteToBit(pixelColor.G);
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
                    buf.SetPixel(i, j, newColor);
                    index++;
                }
                if (stop)
                {
                    break;
                }
            }
            return buf;
        }

        public Image MyEncode(int countCodeBit)
        {
            Bitmap buf = new Bitmap(this.bPic);
            Bitmap copy = new Bitmap(buf);


            MemoryStream msInn = new MemoryStream();
            buf.Save(msInn, ImageFormat.Bmp);
            byte[] b = msInn.ToArray();
            msInn.Close();


            //ImageConverter converter = new ImageConverter();
            //byte[] b = (byte[]) converter.ConvertTo(buf, typeof(byte[]));
            //copy.Save(ms, copy.RawFormat);

            //int offset = BitConverter.ToInt32(b, 10);
            int offset = 2000;
            byte[] buffer = BitConverter.GetBytes(bList.Count);

            for (int i = 0; i < buffer.Length; i++)
            {
                b[offset] = buffer[i];
                offset++;
            }
            //простой вариант, но надо сделать как и основное кодирование. 
            //byte[] css = BitConverter.GetBytes(bList.Count);
            //for (int i = 0; i < css.Length; i++)
            //{
            //    BitArray bitCount = ByteToBit(css[i]); //биты количества символов
            //    BitArray colorArray = ByteToBit(b[offset]);

            //    colorArray[0] = bitCount[0];
            //    colorArray[1] = bitCount[1];
            //    colorArray[2] = bitCount[2];
            //    colorArray[3] = bitCount[3];
            //    colorArray[4] = bitCount[4];
            //    colorArray[5] = bitCount[5];
            //    colorArray[6] = bitCount[6];
            //    colorArray[7] = bitCount[7];

            //    b[offset++] = BitToByte(colorArray);

            //}

            string s = "";
            for (int i = 0; i < 100; i++)
            {
                s = s +i+": " +b[i] + "\n";
            }

            switch (countCodeBit)
            {
                case 1:
                {
                    break;
                }
                case 2:
                {
                    break;
                }
                case 3:
                {
                    int pixi=0;

                        for (int bi = 0; bi < this.bList.Count; bi++)
                        {
                            BitArray messageArray = ByteToBit(bList[bi]);

                            for (int mi = 0; mi < messageArray.Length; mi++)
                            {
                                BitArray colorArray = ByteToBit(b[offset]);

                                if (pixi < 3 /*countCodeBit*/)
                                {
                                    colorArray[pixi] = messageArray[mi];
                                    b[offset] = BitToByte(colorArray);
                                    pixi++;
                                }
                                else
                                {
                                    offset++;
                                    pixi = 0;
                                }
                            }
                        }
                        
                        break;
                }
                case 4:
                {
                    break;
                }
                case 5:
                {
                    break;
                }
                case 6:
                    {
                        for (int bi = 0; bi < this.bList.Count; bi++)
                        {
                            BitArray messageArray = ByteToBit(bList[bi]);

                            for (int mi = 0; mi < messageArray.Length; mi++)
                            {
                                
                            }
                        }
                        break;
                    }
                case 7:
                {
                        for (int i = offset, j = 0; j < this.bList.Count; i++, j++)
                        {

                            BitArray colorArray = ByteToBit(b[i]);


                           BitArray messageArray = ByteToBit(bList[j]);

                            for (int k = 0; k < countCodeBit; k++)
                            {

                            }
                            
                            colorArray[0] = messageArray[0];

                            b[i] = BitToByte(colorArray);

                        }
                        break;
                }
                case 8:
                {
                        for (int i = offset, j=0, k=0; j < this.bList.Count; i++, j++, k++)
                        {
                            //if (k==2)
                            //{
                            //    i++;
                            //    k = 0;
                            //}
                            BitArray colorArray = ByteToBit(b[i]);
                            BitArray messageArray = ByteToBit(bList[j]);
                            colorArray[0] = messageArray[0];
                            colorArray[1] = messageArray[1];
                            colorArray[2] = messageArray[2];
                            colorArray[3] = messageArray[3];
                            colorArray[4] = messageArray[4];
                            colorArray[5] = messageArray[5];
                            colorArray[6] = messageArray[6];
                            colorArray[7] = messageArray[7];
                            b[i] = BitToByte(colorArray);


                        }
                        s = "";
                        for (int i = 0; i < 100; i++)
                        {
                            s = s + i + ": " + b[i] + "\n";
                        }
                        break;
                }

                default:
                {
                    break;

                }
            }


            //ImageConverter ic = new ImageConverter();
            //Image img = (Image)ic.ConvertFrom(b);
            //Bitmap bmp = new Bitmap(img);

            //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            //Bitmap bmp = (Bitmap)tc.ConvertFrom(b);

            Bitmap bmp;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(b, 0, b.Length);
                    bmp = (Bitmap)Image.FromStream(ms);
                }
            }
            catch
            {

                bmp = null;
            }

            Bitmap vv = new Bitmap(bmp);

            MemoryStream msInn1 = new MemoryStream();
            vv.Save(msInn1, ImageFormat.Bmp);
            byte[] b1 = msInn.ToArray();
            s = "";
            for (int i = 0; i < 100; i++)
            {
                s = s + i + ": " + b1[i] + "\n";
            }
            msInn.Close();

            return bmp;
        }



        public string MyDecode(int countCodeBit)
        {
            Bitmap buf = new Bitmap(this.bPic);
          


            MemoryStream msInn = new MemoryStream();
            this.bPic.Save(msInn, ImageFormat.Bmp);
            byte[] b = msInn.ToArray();
            msInn.Close();
            //return "";
            string s = "";
            for (int i = 0; i < 100; i++)
            {
                s = s + i + ": " + b[i] + "\n";
            }
            //int offset = BitConverter.ToInt32(b, 10);
            int offset = 2000;

            int countSymbol = BitConverter.ToInt32(b, offset);

            offset = offset + 4;

            byte[] message;
            try
            {
                message = new byte[countSymbol];
            }
            catch
            {
                countSymbol = (int)bPic.Height * bPic.Width;
                message = new byte[countSymbol];
            }

            for (int i = offset, j = 0, k = 0; j < message.Length; i++, j++, k++ )
            {
                //if (k == 2)
                //{
                //    i++;
                //    k = 0;
                //}

                BitArray colorArray = ByteToBit(b[i]);
                BitArray messageArray = ByteToBit(message[j]);
                messageArray[0] = colorArray[0];
                messageArray[1] = colorArray[1];
                messageArray[2] = colorArray[2];
                messageArray[3] = colorArray[3];
                messageArray[4] = colorArray[4];
                messageArray[5] = colorArray[5];
                messageArray[6] = colorArray[6];
                messageArray[7] = colorArray[7];
                message[j] = BitToByte(messageArray);

            }

            //int pixi = 0;
            //for (int i = 0; i < message.Length; i++)
            //{
            //    BitArray messageArray = ByteToBit(message[i]);

            //    for (int mi = 0; mi < messageArray.Length; mi++)
            //    {
            //        BitArray colorArray = ByteToBit(b[offset]);

            //        if (pixi < 3 /*countCodeBit*/)
            //        {
            //            messageArray[mi] = colorArray[pixi];
            //            b[offset] = BitToByte(colorArray);
            //            pixi++;
            //        }
            //        else
            //        {
            //            offset++;
            //            pixi = 0;
            //        }
            //        message[i] = BitToByte(messageArray);
            //    }
            //}

            string strMessage = Encoding.Default.GetString(message);
            return strMessage;
        }

        public string CastDecodeRGB(int countBytes, ProgressBar progress)
        {
            string strMessage = "";
            int countSymbol = ReadCountText(bPic); //считали количество зашифрованных символов
            byte[] message;
            try
            {
                message = new byte[countSymbol];
            }
            catch
            {
                countSymbol = (int)bPic.Height * bPic.Width;
                message = new byte[countSymbol];
            }

            if (progress != null)
            {
                progress.Maximum = message.Length;
            }
            int index = 0;
            bool stop = false;
            switch (countBytes)
            {

                case 1:
                    {

                        for (int j = 0; j < bPic.Height; j++)
                        {
                            for (int i = 0; i < bPic.Width; i++)
                            {
                                if (j == 0 && i < 5) continue;


                                if (index == message.Length)
                                {
                                    stop = true;
                                   
                                    //progress.TabIndex = 1;
                                    //progress.TabIndex = 2;
                                    break;
                                }

                                Color pixelColor = bPic.GetPixel(i, j);

                                BitArray colorArray = ByteToBit(pixelColor.R);
                                BitArray messageArray = new BitArray(8);
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

                            if (progress != null)
                            {
                                progress.Value = index;
                                progress.TabIndex = 1;
                                progress.TabIndex = 2;

                            }

                            if (stop)
                            {
                                
                                break;
                            }

                        }
                         strMessage = Encoding.Default.GetString(message);
                        break;
                    }
                case 2:
                {
                        #region 2 бита

                        Color[] colors = GetColorArrayFromBitmap(bPic,message.Length, countBytes);

                        stop = false;
                        int bi = 0;
                        int bli = 0;
                        for (int i = 0; i < colors.Length; i++)
                        {
                            List<BitArray> rgb = new List<BitArray>();
                            rgb.Add(ByteToBit(colors[i].R));
                            rgb.Add(ByteToBit(colors[i].G));
                            rgb.Add(ByteToBit(colors[i].B));

                            
                            for (int irgb = 0; irgb < rgb.Count; irgb++)
                            {
                                BitArray messageArray = ByteToBit(message[bi]);
                                for (int j = 0; j < countBytes; j++)
                                {

                                    messageArray[bli++] = rgb[irgb][j];
                                    if (bli == 8)
                                    {
                                        bli = 0;
                                        message[bi] = BitToByte(messageArray);
                                        bi++;
                                        break;
                                    }

                                }

                                if (bi == message.Length)
                                {
                                    stop = true;
                                    break;
                                }
                            }

                            if (stop)
                            {
                                break;
                            }

                        }


                        strMessage = Encoding.Default.GetString(message);


                        #endregion
                        break;
                    }
                case 3:
                    {
                        #region 3 байта

                        Color[] colors = GetColorArrayFromBitmap(bPic, message.Length,countBytes);
                       
                        stop = false;
                        int bi = 0;
                        for (int i = 0; i < colors.Length; i++)
                        {
                            List<BitArray> rgb = new List<BitArray>();
                            rgb.Add(ByteToBit(colors[i].R));
                            rgb.Add(ByteToBit(colors[i].G));
                            rgb.Add(ByteToBit(colors[i].B));

                            foreach (BitArray VARIABLE in rgb)
                            {
                                
                                BitArray messageArray = ByteToBit(message[bi]);
                                messageArray[0] = VARIABLE[0];
                                messageArray[1] = VARIABLE[1];
                                messageArray[2] = VARIABLE[2];
                                messageArray[3] = VARIABLE[3];
                                messageArray[4] = VARIABLE[4];
                                messageArray[5] = VARIABLE[5];
                                messageArray[6] = VARIABLE[6];
                                messageArray[7] = VARIABLE[7];
                                message[bi++] = BitToByte(messageArray);
                                if (bi == message.Length)
                                {
                                    stop = true;
                                    break;
                                }
                            }
                            
                            if (stop)
                            {
                                break;
                            }

                        }
                        strMessage = Encoding.Default.GetString(message);



                        #endregion
                        break;
                    }
            }

           

            
            
           
       
            return strMessage;
        }

        public void Encode()
        {
            EncodeRGB();
        }

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
                    num += (byte)Math.Pow(2, i);
            return num;
        }

       /*Проверяет, зашифрован ли файл,  возвраещает true, если символ в первом пикслеле равен / иначе false */
        private bool isEncryption(Bitmap scr)
        {
            byte[] rez = new byte[1];
            Color color = scr.GetPixel(0, 0);
            BitArray colorArray = ByteToBit(color.R); //получаем байт цвета и преобразуем в массив бит
            BitArray messageArray = ByteToBit(color.R); ;//инициализируем результирующий массив бит
            messageArray[0] = colorArray[0];
            messageArray[1] = colorArray[1];

            colorArray = ByteToBit(color.G);//получаем байт цвета и преобразуем в массив бит
            messageArray[2] = colorArray[0];
            messageArray[3] = colorArray[1];
            messageArray[4] = colorArray[2];

            colorArray = ByteToBit(color.B);//получаем байт цвета и преобразуем в массив бит
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

                bitsCurColor = ByteToBit(pColor.G);//бит бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[2];
                bitsCurColor[1] = bitCount[3];
                bitsCurColor[2] = bitCount[4];
                byte nG = BitToByte(bitsCurColor);//новый цвет пиксея

                bitsCurColor = ByteToBit(pColor.B);//бит бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[5];
                bitsCurColor[1] = bitCount[6];
                bitsCurColor[2] = bitCount[7];
                byte nB = BitToByte(bitsCurColor);//новый цвет пиксея

                Color nColor = Color.FromArgb(nR, nG, nB); //новый цвет из полученных битов
                src.SetPixel(0, i + 1, nColor); //записали полученный цвет в картинку
            }
        }

        /*Читает количество символов для дешифрования из первых бит картинки*/
        public int ReadCountText(Bitmap src)
        {
            byte[] rez = new byte[4]; //массив на 3 элемента, т.е. максимум 999 символов шифруется
            for (int i = 0; i < 4; i++)
            {
                Color color = src.GetPixel(0, i + 1); //цвет 1, 2, 3 пикселей 
                BitArray colorArray = ByteToBit(color.R); //биты цвета
                BitArray bitCount = ByteToBit(color.R); ; //инициализация результирующего массива бит
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
    }
}
