using System;
using System.IO;
using System.Windows.Forms;

namespace Hoi4Charmaker

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Name_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void GFX_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ideology_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tag_TextChanged(object sender, EventArgs e)
        {

        }



        private void bake_Click(object sender, EventArgs e)
        {
            string name = Name_TXT.Text;
            string gfx = GFX_TXT.Text;
            string ideology = Ideology_TXT.Text;   // Take all textbox info
            string tag = Tag.Text;
            string exp = expireDate.Text;


            if (name == "" || gfx == "" || ideology == "" || tag == ""|| exp=="")
            {

                Error_ctrl.Text = "Error Not all arguments were filled!";


            }
            else {
            //path
            string appPath = Application.StartupPath;
            // filename

                string Filez = textBox1.Text + ".txt";

                string appPath2 = Application.StartupPath + Filez;

                File.WriteAllText(appPath2, "characters={ \r\n" + "name=\"" + name + "\" \r\n" + "portraits={\r\ncivilian={\r\nlarge=\"" + gfx + "\"}\r\n}" + "\r\n\ncountry_leader={\r\nideology=\"" + ideology + "\"\r\nexpire=\""+ exp + "\"}" + "\r\n}" + "\r\n #made using woody's leader wizard \r\n #version 1.0");

                Error_ctrl.Text = "File Created Successfully";

            

            }


        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}