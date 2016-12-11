using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deikstr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
        }

        string[,] MAS;
        string[] matr_o;
        int[] tm;
        int[] matr_q;
        int size = 4;
        int fr = 2;
        int to = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            size++;
            dataGridView1.Columns.Add(new DataGridViewColumn() { HeaderText = size.ToString(), CellTemplate = new DataGridViewTextBoxCell(), Width = 50 });
            dataGridView1.Rows.Add();
            dataGridView1.Rows[size - 1].HeaderCell.Value = size.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (size > 1)
            {
                dataGridView1.Columns.RemoveAt(size - 1);
                dataGridView1.Rows.RemoveAt(size - 1);
                size--;
            }
        }

        private void GetMas()
        {
            MAS = new string[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int o = 0; o < size; o++)
                {


                    MAS[i, o] = dataGridView1.Rows[i].Cells[o].Value.ToString();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = 0;
            double prev = 0;
            int lic = 0;
            size = 5;
            MAS = new string[size, size];
            //GetMas();

            MAS[0, 0] = "-";
            MAS[0, 1] = "40";
            MAS[0, 2] = ".";
            MAS[0, 3] = "30";
            MAS[0, 4] = "100";

            MAS[1, 0] = "40";
            MAS[1, 1] = "-";
            MAS[1, 2] = "50";
            MAS[1, 3] = ".";
            MAS[1, 4] = ".";

            MAS[2, 0] = ".";
            MAS[2, 1] = "50";
            MAS[2, 2] = "-";
            MAS[2, 3] = ".";
            MAS[2, 4] = "10";

            MAS[3, 0] = "30";
            MAS[3, 1] = ".";
            MAS[3, 2] = "30";
            MAS[3, 3] = "-";
            MAS[3, 4] = "20";

            MAS[4, 0] = "100";
            MAS[4, 1] = ".";
            MAS[4, 2] = "10";
            MAS[4, 3] = ".";
            MAS[4, 4] = "-";
            size = 5;

            int stan = fr;
            matr_o = new string[size];
            matr_q = new int[size];
            tm = new int[size];
            for (int i = 0; i < size; i++) tm[i] = 0;
            tm[fr - 1] = 1;
            for(int i=0;i< size;i++)
            {
                if (i == fr) matr_o[i] = "0";
                else matr_o[i] = ".";
            }
            while (true)
            {
                for (int i = 0; i < size; i++)
                {
                    if (MAS[p, i] != "." && matr_q[i] == 0 && i!=p)
                    {

                    }
                }
                p++;
            }
            //for(int k=1;k< size+1;k++)
            //{
            //    lic = 0;
            //   for(int o=0;o< size;o++)
            //    { 
            //        if(MAS[k-1,o]!="." && MAS[k - 1, o] != "-")
            //        {
            //            if (matr_o[o] == ".") {
            //                matr_o[o] = MAS[k - 1, o];
            //                if(lic==0) prev = double.Parse(MAS[k - 1, o]);
            //                else
            //                     if (double.Parse(MAS[k - 1, o]) < prev) { prev = double.Parse(MAS[k - 1, o]); }
            //                matr_q[o] = k;
            //                lic++;
            //            }
            //            else
            //            if (double.Parse(matr_o[o]) > double.Parse(MAS[k - 1, o]))
            //            {
            //                matr_o[o] = MAS[k - 1, o];
            //                matr_q[o] = k;
            //                if (lic == 0) prev = double.Parse(MAS[k - 1, o]);
            //                else
            //                     if (double.Parse(MAS[k - 1, o]) < prev) { prev = double.Parse(MAS[k - 1, o]); }
            //                lic++;
            //            }
            //        }
            //    }

            //   for(int i=0;i< size;i++)
            //    {
            //        if(matr_o[i]!=".")if (double.Parse(matr_o[i]) == prev) matr_q[i] = 1;
            //    }


            //}
            textBox_out.Text = matr_o[to-1].ToString();
        }
    }
}
