using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class GenereazaPoster : Form
    {

        private Label lbllocalitate;
        private Label lblimagine;
        private ComboBox cmblocalitate;
        private ComboBox cmbimagine;
        private Button btnadauga;
        private Label lbllistaimagini;
        private ListBox lstbox;
        private Label lbltitlu;
        private TextBox txt;
        private Button btngenerare;
        private PictureBox pic;


        public GenereazaPoster()
        {
            InitializeComponent();

            this.Size = new Size(852, 517);

            this.lbllocalitate = new Label();
            this.Controls.Add(lbllocalitate);
            this.lbllocalitate.Location = new Point(87, 44);
            this.lbllocalitate.Size = new Size(58, 15);
            this.lbllocalitate.Text = "Localitate";

            this.lblimagine = new Label();
            this.Controls.Add(lblimagine);
            this.lblimagine.Location = new Point(87, 119);
            this.lblimagine.Size = new Size(58, 15);
            this.lblimagine.Text = "Imagine";

            this.lbllistaimagini = new Label();
            this.Controls.Add(lbllistaimagini);
            this.lbllistaimagini.Location = new Point(87, 243);
            this.lbllistaimagini.Size = new Size(74, 15);
            this.lbllistaimagini.Text = "Lista imagini";

            this.cmblocalitate = new ComboBox();
            this.Controls.Add(this.cmblocalitate);
            this.cmblocalitate.Location = new Point(87, 62);
            this.cmblocalitate.Size = new Size(265, 23);

            this.cmbimagine = new ComboBox();
            this.Controls.Add(this.cmbimagine);
            this.cmbimagine.Location = new Point(87, 137);
            this.cmbimagine.Size = new Size(265, 23);

            this.btnadauga = new Button();
            this.Controls.Add(this.btnadauga);
            this.btnadauga.Location = new Point(87, 179);
            this.btnadauga.Size = new Size(129, 45);
            this.btnadauga.Text = "Adauga";

            this.lstbox = new ListBox();
            this.Controls.Add(this.lstbox);
            this.lstbox.Location = new Point(87, 272);
            this.lstbox.Size = new Size(265, 94);

            this.lbltitlu = new Label();
            this.Controls.Add(lbltitlu);
            this.lbltitlu.Location = new Point(87, 383);
            this.lbltitlu.Size = new Size(30, 15);
            this.lbltitlu.Text = "Titlu";

            this.btngenerare = new Button();
            this.Controls.Add(this.btngenerare);
            this.btngenerare.Location = new Point(87, 420);
            this.btngenerare.Size = new Size(265, 46);
            this.btngenerare.Text = "Genereaza poster";

            this.txt = new TextBox();
            this.Controls.Add(this.txt);
            this.txt.Location = new Point(123, 380);
            this.txt.Size = new Size(229, 23);

            this.pic = new PictureBox();
            this.Controls.Add(this.pic);
            this.pic.Location = new Point(386, 44);
            this.pic.Size = new Size(425, 359);
            this.pic.Image = Image.FromFile(Application.StartupPath + @"Resurse\Imagini\Sibiu3.jpg");
            this.pic.SizeMode = PictureBoxSizeMode.StretchImage;




        }





        private void GenereazaPoster_Load(object sender, EventArgs e)
        {

        }
    }
}
