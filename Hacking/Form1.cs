using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InputedText_TextChanged(object sender, EventArgs e)
        {
            var strIn = InputedText.Text;
            var p = Numbers.GetNextPrimeAfter(1);
            var g = Numbers.GetPRoot(p);
            var x = Numbers.Rand(1, p - 1);
            Crypt(p, g, x, strIn);
            var strOut = CryptedText.Text;
            Decrypt(p, x, strOut);
        }

        private void Crypt(int p, int g, int x, string strIn) //Шифрование
        {
            var y = Numbers.Power(g, x, p);
            
            CryptedText.Text = "";
            txtBPublicKey.Text = $"Открытый ключ (p,g,y) = ( {p}, {g}, {y})";
            txtBSecretKey.Text = $"Закрытый ключ x = {x}";

            var sb = new StringBuilder();
            
            foreach (var t in strIn)
            {
                var m = Convert.ToInt32(t);
                if (m <= 0) continue;
                
                var k = Numbers.Rand(1, p - 1);
                var a = Numbers.Power(g, k, p);
                var b = Numbers.Mul(Numbers.Power(y, k, p), m, p);
                
                sb.Append($"{a} {b} ");
            }
            
            CryptedText.Text = sb.ToString();
        }

        private void Decrypt(int p, int x, string strIn)
        {
            DecryptedText.Text = "";
            if (strIn.Length > 0)
            {
                var sb = new StringBuilder();
                var crypted = strIn.Trim().Split(' ').Select(int.Parse).ToArray();

                for (var i = 0; i < crypted.Length - 1; i += 2)
                {
                    var a = crypted[i];
                    var b = crypted[i + 1];

                    if ((a == 0) || (b == 0)) continue;

                    var deM = Numbers.Mul(b, Numbers.Power(a, p - 1 - x, p),p); // m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p - трудно было  найти нормальную формулу, в ней вся загвоздка
                    Console.WriteLine(deM);
                    sb.Append(Convert.ToChar(deM));
                }

                DecryptedText.Text = sb.ToString();
                return;
            }

            DecryptedText.Text = "";
        }
    }
}