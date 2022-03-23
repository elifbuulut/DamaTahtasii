using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[8, 8]; //8 satır 8 sutundan oluşacak bir buton dizisi tanımla =64 adet
                                                 //[64] değil de [8,8] sebebi rahat ulaşabilmek;
                                                 //0. boyut(satır) ve 1.boyut (sutun) bu şekilde ayrı ayrı ulaşılır.

            int _top = 0;
            int _left = 0;// Butonları ilk ekledigimizde üst üste geliyor o yüzden 50 birim başlangıç noktasından boşluk bırakmak için bu değişken
                          // leri tanımlandı
            for (int i = 0; i < button.GetUpperBound(0); i++) // i =>> 0. boyutun en büyük alabilecegi değerden küçük =7
                                                              // O. boyutun en büyük alabileceği değer=7
                                                              // i < button.GetUpperBound(0)= i<8   !!!
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)// i =>> 1. boyutun en büyük alabilecegi değerden küçük.
                                                                 // 1. boyutun en büyük alabileceği değer=7
                {
                    //butonları oluştur 
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    button[i, j].Left = _left;    //  button i ve j nin başlangıçta ki left konumu 0 ;;;;;;button[i, j].Left = 0;
                    button[i, j].Top = _top;        //  button i ve j nin başlangıçta ki top konumu 0 ;;;;;;button[i,j].Top = 0;
                    _left += button[i, j].Width;   // _left= left +50 




                    //----------RENK ------------
                    //0,2,4,6,8..... ==>> siyah renkte  ==>>> i+j başlangıç değeri =0          ->   i+j ++
                    //1,3,5,7,9.....==>> beyaz renkte  ==>>>> i+j ilk döngüden sonra=1         ->   i+j ++   .....
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;

                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(button[i, j]); // forma kontrolleri ekle 
                }

                //ikinci satıra geçtiğinde leftin yine 0 dan, soldan başlaması gerekiyor. o yüzden left i sıfırla 
                _left = 0;
                _top += 50;   // 8 satır ve sutundan oluşacak butonlar ilk satır için gerçekleşti, bir alt satıra geçerken üstten 50 birim boşluk bırak  

            }



        }
    }
}
