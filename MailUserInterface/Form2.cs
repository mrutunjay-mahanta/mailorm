using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MailUserInterface
{
    internal class Form2 : Form
    {
        public Form2()
        {
            Panel p = new Panel();
            p.Size = new Size(700,500);
            //p.Dock = DockStyle.Fill;
           // p.BackColor = Color.Aqua;

            Label lb1 = new Label();
            lb1.Text = "EMAIL DETAILS";
            lb1.Width = 300;
            lb1.Location = new Point(30, 5);
            this.Controls.Add(lb1);

            Label lb2 = new Label();
            lb2.Text = "Sender Email";
            lb2.Location = new Point(30, 50);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb2);
            TextBox tb1 = new TextBox();
            tb1.Location = new Point(150,50);
            tb1.Size = new Size(120, 30);
            this.Controls.Add (tb1);

            Label lb3 = new Label();
            lb3.Text = "Sender Password";
            lb3.Location = new Point(30, 80);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb3);
            TextBox tb2 = new TextBox();
            tb2.Location = new Point(150, 80);
            tb2.Size = new Size(120, 30);
            this.Controls.Add(tb2);

            Label lb4 = new Label();
            lb4.Text = "SMPT Server";
            lb4.Location = new Point(30, 110);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb4);
            TextBox tb3 = new TextBox();
            tb3.Location = new Point(150, 110);
            tb3.Size = new Size(120, 30);
            this.Controls.Add(tb3);

            Label lb5 = new Label();
            lb5.Text = "Server Port No";
            lb5.Location = new Point(30, 140);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb5);
            TextBox tb4 = new TextBox();
            tb4.Location = new Point(150, 140);
            tb4.Size = new Size(120, 30);
            this.Controls.Add(tb4);

            CheckBox ck1 = new CheckBox();
            ck1.Location = new Point(150, 170);
            ck1.Text = "SSL";
            this.Controls.Add(ck1);

            Label lb6 = new Label();
            lb6.Text = "Recipient Email";
            lb6.Location = new Point(30, 200);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb6);
            TextBox tb5 = new TextBox();
            tb5.Location = new Point(150, 200);
            tb5.Size = new Size(120, 30);
            this.Controls.Add(tb5);

            Label lb7 = new Label();
            lb7.Text = "Subject";
            lb7.Location = new Point(30, 230);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb7);
            TextBox tb6 = new TextBox();
            tb6.Location = new Point(150, 230);
            tb6.Size = new Size(120, 30);
            this.Controls.Add(tb6);


            Label lb8 = new Label();
            lb8.Text = "Browse File";
            lb8.Location = new Point(30, 260);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb8);
            Button btnBrowse = new Button();
            btnBrowse.Text = "Browse";
            btnBrowse.Location = new Point(150,260);
            btnBrowse.Size = new Size(120, 30);
            this.Controls.Add(btnBrowse);

            Button btnSend = new Button();
            btnSend.Text = "Send Email";
            btnSend.Location = new Point(300,260);
            btnSend.Size = new Size(300,30);
            this.Controls.Add(btnSend); 
            

            Label lb9 = new Label();
            lb9.Text = "Body";
            lb9.Location = new Point(300, 50);
            //lb1.Size = new Size(150, 40);
            this.Controls.Add(lb9);
            TextBox tb7 = new TextBox();
            tb7.Multiline = true;
            tb7.Size = new Size(300,180);
            tb7.Location = new Point(300, 70);
            this.Controls.Add(tb7);

            

            this.Controls.Add(p);
        }
    }
}
