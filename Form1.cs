using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emrehanbysal;

namespace keyevent
{
    public partial class Form1 : Form
    {
        globalKeyboardHook klavyeDinleyicisi = new globalKeyboardHook();
        public Form1()
        {
         
            InitializeComponent();
            DinlenecekTuslariAyarla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }
        public void DinlenecekTuslariAyarla()
        {
            // hangi tuşları dinlemek istiyorsak burada ekliyoruz                
            klavyeDinleyicisi.HookedKeys.Add(Keys.Delete);
       

            //basıldığında ilk burası çalışır
            klavyeDinleyicisi.KeyDown += new KeyEventHandler(islem1);
            //basıldıktan sonra ikinci olarak burası çalışır
            klavyeDinleyicisi.KeyUp += new KeyEventHandler(islem2);
        }
        void islem1(object sender, KeyEventArgs e)
        {         
            
            if(i != 1)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
          
        }

        void islem2(object sender, KeyEventArgs e)
        {
            e.Handled = true;
           
        }

        int i = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Text = "Delete Deactive";
                i = 1;
            }
            else
            {               
                checkBox1.Text = "Delete active";
                i = 0;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
         
        

        }
    }
}
