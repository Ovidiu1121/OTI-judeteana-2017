using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class VizualiozareExcursie : Form
    {
        private Label lblinceput;
        private Label lblfinalizare;
        private DateTimePicker dateinceput;
        private DateTimePicker datefinalizare;
        private Button btngenerare;
        private TabControl tabcontrol;
        private DataGridView datagridview;



        public VizualiozareExcursie()
        {
            InitializeComponent();


            this.Size = new Size(968, 588);

            this.lblinceput = new Label();
            this.Controls.Add(this.lblinceput);
            this.lblinceput.Location = new Point(35, 23);
            this.lblinceput.Size = new Size(93, 15);
            this.lblinceput.Text = "Inceput excursie";

            this.lblfinalizare = new Label();
            this.Controls.Add(this.lblfinalizare);
            this.lblfinalizare.Location = new Point(267, 23);
            this.lblfinalizare.Size = new Size(93, 15);
            this.lblfinalizare.Text = "Inceput excursie";

            this.dateinceput = new DateTimePicker();
            this.Controls.Add(this.dateinceput);
            this.dateinceput.Location = new Point(35, 43);

            this.datefinalizare = new DateTimePicker();
            this.Controls.Add(this.datefinalizare);
            this.datefinalizare.Location = new Point(267, 41);

            this.btngenerare = new Button();
            this.Controls.Add(this.btngenerare);
            this.btngenerare.Location = new Point(604, 23);
            this.btngenerare.Size = new Size(209, 43);
            this.btngenerare.Text = "Generare excursie";

            this.tabcontrol = new TabControl();
            this.Controls.Add(this.tabcontrol);
            this.tabcontrol.Location = new Point(0, 81);
            this.tabcontrol.Size = new Size(954, 473);

            TabPage tab1 = new TabPage("Planificari");
            TabPage tab2 = new TabPage("Perioade de vizitare");
            TabPage tab3 = new TabPage("Vizualizare Itinerariu");
            TabPage tab4 = new TabPage("Vizualizare Imagini");
            this.tabcontrol.Controls.Add(tab1);
            this.tabcontrol.Controls.Add(tab2);
            this.tabcontrol.Controls.Add(tab3);
            this.tabcontrol.Controls.Add(tab4);

            this.datagridview = new DataGridView();
            tab1.Controls.Add(this.datagridview);
            this.datagridview.Location = new Point(0, 0);
            this.datagridview.Size = new Size(954, 445);




        }

        public void populate()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Nume", typeof(string));
            dt.Columns.Add("Data start", typeof(string));
            dt.Columns.Add("Data stop", typeof(string));
            dt.Columns.Add("Frecventa", typeof(string));
            dt.Columns.Add("Ziua", typeof(int));



        }





        private void VizualiozareExcursie_Load(object sender, EventArgs e)
        {

        }
    }
}
