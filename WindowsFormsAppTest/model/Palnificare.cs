using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppTest
{
    public class Palnificare
    {
        private int id;
        private int idlocalitate;
        private string frecventa;
        private DateTime datastart;
        private DateTime datafinalizare;
        private int ziua;

        public Palnificare()
        {


        }

        public Palnificare(int id, int idlocalitate, string frecventa, DateTime datastart, DateTime datafinalizare, int ziua)
        {
            this.id = id;
            this.idlocalitate = idlocalitate;
            this.frecventa = frecventa;
            this.datastart = datastart;
            this.datafinalizare = datafinalizare;
            this.ziua = ziua;

        }

        public Palnificare(string prop)
        {
            string[] a = prop.Split(" * ");

            this.id = int.Parse(a[0]);
            this.idlocalitate = int.Parse(a[1]);
            this.frecventa = a[2];
            this.datastart = DateTime.Parse(a[3]);
            this.datafinalizare = DateTime.Parse(a[4]);
            this.ziua = int.Parse(a[5]);

        }

        public string descriere()
        {
            string text = "";

            text += this.id + ",";
            text+=idlocalitate + ",";
            text += this.frecventa + ",";
            text += this.datastart + ",";
            text += this.datafinalizare + ",";
            text += this.ziua + "\n";

            return text;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Idlocalitate
        {
            get { return this.idlocalitate; }
            set { this.idlocalitate = value; }
        }

        public string Frecventa
        {
            get { return this.frecventa; }
            set { this.frecventa = value; }
        }

        public DateTime Datastart
        {
            get { return this.datastart; }
            set { this.datastart = value; }
        }

        public DateTime Datafinalizare
        {
            get { return this.datafinalizare; }
            set { this.datafinalizare = value; }
        }

        public int Ziua
        {
            get { return this.ziua; }
            set { this.ziua = value; }
        }

        public string save()
        {
            string text = "";

            text += this.id + ",";
            text += idlocalitate + " * ";
            text += this.frecventa + " * ";
            text += this.datastart + " * ";
            text += this.datafinalizare + " * ";
            text += this.ziua;

            return text;
        }





    }
}
