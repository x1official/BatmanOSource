using batman;
using System;
using System.IO;
using System.Windows.Forms;
using EasyExploits;

namespace x1sploit
{
    public partial class MainUI : Form
    {
        
        EasyExploits.Module module = new EasyExploits.Module();
        public MainUI()
        {
            InitializeComponent();
            
            
            
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {



        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button8_Click(object sender, EventArgs e)
        {

           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void autoattach_Tick(object sender, EventArgs e)
        {


            {

                {

                }

                {

                }
            }
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetText", new string[] { "" });
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            module.ExecuteScript(script);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
                
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            
                
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox3_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox3_CheckedChanged_3(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}






