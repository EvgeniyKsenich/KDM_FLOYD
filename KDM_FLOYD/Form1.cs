using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KDM_FLOYD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // dataGridView1.Rows
            for (int i = 0; i < 4; i++) { dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value= (i+1).ToString();
            }
        }
        int size = 4;
        string[,] MAS;
        string[,] MS;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            size++;
            dataGridView1.Columns.Add(new DataGridViewColumn() { HeaderText = size.ToString(), CellTemplate = new DataGridViewTextBoxCell(), Width=50  });
            dataGridView1.Rows.Add();
            dataGridView1.Rows[size-1].HeaderCell.Value = size.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(size>1)
            {
                dataGridView1.Columns.RemoveAt(size-1);
                dataGridView1.Rows.RemoveAt(size-1);
                size--;
            }
        }

        private void GetMas()
        {
            MAS = new string[size,size];
            for (int i=0;i< size;i++)
            {
                for(int o=0;o< size; o++)
                {
                    
                    
                        MAS[i, o] = dataGridView1.Rows[i].Cells[o].Value.ToString(); 
                    
                }
            }
        }

        public void CLEAR_1()
        {
            for (int i = dataGridView2.Rows.Count-1; i >= 0; i--)
            {
                    dataGridView2.Rows.RemoveAt(i);
            }
            for (int i = dataGridView2.Columns.Count - 1; i >= 0; i--)
            {
                dataGridView2.Columns.RemoveAt(i);
            }
        }

        private void OUT_2()
        {
            for (int i = 0; i < size; i++)
                dataGridView3.Columns.Add(new DataGridViewColumn() { HeaderText = (i + 1).ToString(), CellTemplate = new DataGridViewTextBoxCell(), Width = 50 });

            for (int i = 0; i < size; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int i = 0; i < size; i++)
            {
                for (int o = 0; o < size; o++)
                {
                    dataGridView3.Rows[i].Cells[o].Value = MS[i, o];
                    //DataGridViewTextBoxCell txtxCell = (DataGridViewTextBoxCell)dataGridView2.Rows[i].Cells[o];
                    //txtxCell.Value ="";
                }
            }

        }

        private void OUT_1()
        {
            for (int i = 0; i < size; i++)
                dataGridView2.Columns.Add(new DataGridViewColumn() { HeaderText = (i + 1).ToString(), CellTemplate = new DataGridViewTextBoxCell(), Width = 50 });

            for (int i = 0; i < size; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int i = 0; i < size; i++)
            {
                for (int o = 0; o < size; o++)
                {
                    dataGridView2.Rows[i].Cells[o].Value = MAS[i,o];
                    //DataGridViewTextBoxCell txtxCell = (DataGridViewTextBoxCell)dataGridView2.Rows[i].Cells[o];
                    //txtxCell.Value ="";
                }
            }

            //string[] array = new string[size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int o = 0; o < size; o++)
            //    {
            //        array[o] ="1";
            //    }
            //    dataGridView2.Rows.Add(array);
            //}
        }

        private void MSs()
        {
            MS = new string[size, size];
            int lic = 0;
            for(int o=0;o< size;o++)
            {
                lic++;
                for(int i=0;i< size;i++)
                {
                    if (i != o) MS[i, o] = lic.ToString();
                    else
                        MS[i, o] = "-";
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //size = 7;
            CLEAR_1();
            bool ch1 = false;
            bool ch2 = false;

            
            MAS = new string[size, size];
            GetMas();

            MSs();


            //MAS[0, 0] = "-";
            //MAS[0, 1] = "5";
            //MAS[0, 2] = "3";
            //MAS[0, 3] = ".";
            //MAS[0, 4] = ".";
            //MAS[0, 5] = ".";
            //MAS[0, 6] = ".";

            //MAS[1, 0] = "5";
            //MAS[1, 1] = "-";
            //MAS[1, 2] = "1";
            //MAS[1, 3] = "5";
            //MAS[1, 4] = "2";
            //MAS[1, 5] = ".";
            //MAS[1, 6] = ".";

            //MAS[2, 0] = "3";
            //MAS[2, 1] = "1";
            //MAS[2, 2] = "-";
            //MAS[2, 3] = "7";
            //MAS[2, 4] = ".";
            //MAS[2, 5] = ".";
            //MAS[2, 6] = "12";

            //MAS[3, 0] = ".";
            //MAS[3, 1] = "5";
            //MAS[3, 2] = "7";
            //MAS[3, 3] = "-";
            //MAS[3, 4] = "3";
            //MAS[3, 5] = ".";
            //MAS[3, 6] = "3";

            //MAS[4, 0] = ".";
            //MAS[4, 1] = "2";
            //MAS[4, 2] = ".";
            //MAS[4, 3] = "3";
            //MAS[4, 4] = "-";
            //MAS[4, 5] = "1";
            //MAS[4, 6] = ".";

            //MAS[5, 0] = ".";
            //MAS[5, 1] = ".";
            //MAS[5, 2] = ".";
            //MAS[5, 3] = "1";
            //MAS[5,4] = "1";
            //MAS[5, 5] = "-";
            //MAS[5, 6] = ".";

            //MAS[6, 0] = ".";
            //MAS[6, 1] = ".";
            //MAS[6, 2] = "12";
            //MAS[6, 3] = "3";
            //MAS[6, 4] = ".";
            //MAS[6, 5] = "4";
            //MAS[6, 6] = "-";


            //MAS[0, 0] = "-";
            //MAS[0, 1] = "40";
            //MAS[0, 2] = ".";
            //MAS[0, 3] = "30";
            //MAS[0, 4] = "100";

            //MAS[1, 0] = "40";
            //MAS[1, 1] = "-";
            //MAS[1, 2] = "50";
            //MAS[1, 3] = ".";
            //MAS[1, 4] = ".";

            //MAS[2, 0] = ".";
            //MAS[2, 1] = "50";
            //MAS[2, 2] = "-";
            //MAS[2, 3] = ".";
            //MAS[2, 4] = "10";

            //MAS[3, 0] = "30";
            //MAS[3, 1] = ".";
            //MAS[3, 2] = "30";
            //MAS[3, 3] = "-";
            //MAS[3, 4] = "20";

            //MAS[4, 0] = "100";
            //MAS[4, 1] = ".";
            //MAS[4, 2] = "10";
            //MAS[4, 3] = ".";
            //MAS[4, 4] = "-";
            string a1 = "";
            double zc = 0;
                for (int k = 1; k < size + 1; k++)
                {
                    a1 += more(MAS);
                    a1 += more(MS);
                    a1 += (k).ToString() + Environment.NewLine;
                    for (int i = 0; i < size; i++)
                    {
                        for (int o = 0; o < size; o++)
                        {
                            ch1 = false;
                            ch2 = false;
                            if (i != o && o != k - 1)
                            {
                                if (MAS[i, o] != ".")
                                {
                                    if (MAS[i, k - 1] != "." && MAS[i, k - 1] != "-") ch1 = true;
                                    if (MAS[k - 1, o] != "." && MAS[k - 1, o] != "-") ch2 = true;
                                    if (ch1 && ch2)
                                    {
                                        zc = (double.Parse(MAS[i, k - 1]) + double.Parse(MAS[k - 1, o]));
                                        if (double.Parse(MAS[i, o]) > zc)
                                        {
                                            MAS[i, o] = (zc).ToString();
                                            MS[i, o] = k.ToString();
                                            a1 += "d" + (i + 1) + (o + 1) + " = d" + i + (k) + "+ d" + (k ) + o + "= " + MAS[i, k - 1] + "+" + MAS[k - 1, o] + "=" + zc + Environment.NewLine;
                                        }
                                    }
                                }
                            ch1 = false;
                            ch2 = false;
                            if (MAS[i, o] == ".")
                                {
                                    if (MAS[i, k - 1] != "." && MAS[i, k - 1] != "-") ch1 = true;
                                    if (MAS[k - 1, o] != "." && MAS[k - 1, o] != "-") ch2 = true;
                                    if (ch1 && ch2)
                                    {
                                    zc = (double.Parse(MAS[i, k - 1]) + double.Parse(MAS[k - 1, o]));
                                        MAS[i, o] = zc.ToString();
                                        a1 += "d" + (i + 1) + (o + 1) + " = d" + i + (k) + "+ d" + (k) + o + "= " + MAS[i, k - 1] + "+" + MAS[k - 1, o] + "=" + zc + Environment.NewLine;
                                        MS[i, o] = k.ToString();
                                    }
                                }
                            if (MAS[i, o] != ".")
                            {
                                if (MAS[i, k - 1] != "." && MAS[i, k - 1] != "-") ch1 = true;
                                if (MAS[k - 1, o] != "." && MAS[k - 1, o] != "-") ch2 = true;
                                if (ch1 && ch2)
                                {
                                    zc = (double.Parse(MAS[i, k - 1]) + double.Parse(MAS[k - 1, o]));
                                    if (double.Parse(MAS[i, o]) > zc)
                                    {
                                        MAS[i, o] = (zc).ToString();
                                        MS[i, o] = k.ToString();
                                        a1 += "d" + (i + 1) + (o + 1) + " = d" + i + (k) + "+ d" + (k) + o + "= " + MAS[i, k - 1] + "+" + MAS[k - 1, o] + "=" + zc + Environment.NewLine;
                                    }
                                }
                            }
                            ch1 = false;
                            ch2 = false;


                        }
                        }
                    }

                }
            //for (int k = 1; k < size + 1; k++)
            //{
            //    a1 += more(MAS);
            //    a1 += more(MS);
            //    a1 += (k).ToString() + Environment.NewLine;
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int o = 0; o < size; o++)
            //        {
            //            ch1 = false;
            //            ch2 = false;
            //            if (i != o && o != k - 1)
            //            {
            //                if (MAS[i, k - 1] != "." && MAS[i, k - 1] != "-") ch1 = true;
            //                if (MAS[k - 1, o] != "." && MAS[k - 1, o] != "-") ch2 = true;
            //                if (ch1 && ch2)
            //                {
            //                    zc = (double.Parse(MAS[i, k - 1]) + double.Parse(MAS[k - 1, o]));
            //                    if (double.Parse(MAS[i, o]) > zc)
            //                    {
            //                        MAS[i, o] = (zc + 1).ToString();
            //                        MS[i, o] = k.ToString();
            //                        a1 += "d" + (i + 1) + (o + 1) + " = d" + i + (k) + "+ d" + (k) + o + "= " + MAS[i, k - 1] + "+" + MAS[k - 1, o] + "=" + zc + Environment.NewLine;
            //                    }
            //                }
            //            }
            //        }
            //   .. }
            //}


                        //for (int k = 1; k < size + 1; k++)
                        //{
                        //    a1 += (k).ToString() + Environment.NewLine;
                        //    for (int i = 0; i < size; i++)
                        //    {
                        //        for (int o = 0; o < size; o++)
                        //        {
                        //            ch1 = false;
                        //            ch2 = false;
                        //            if (i != o && o != k-1)
                        //            {
                        //                if (MAS[i, k - 1] != "." && MAS[i, k - 1] != "-") ch1 = true;
                        //                if (MAS[k - 1, o] != "." && MAS[k - 1, o] != "-") ch2 = true;
                        //                if (ch1 && ch2)
                        //                {
                        //                    zc = (double.Parse(MAS[i, k - 1]) + double.Parse(MAS[k - 1, o]));
                        //                    if (double.Parse(MAS[i, o]) > zc)
                        //                    {
                        //                        MAS[i, o] = zc.ToString();
                        //                        MS[i, o] = k.ToString();
                        //                        a1 += "d" + (i + 1) + (o + 1) + " = d" + i + (k - 1) + "+ d" + (k - 1) + o + "= " + MAS[i, k - 1] + "+" + MAS[k - 1, o] + "=" + zc + Environment.NewLine;
                        //                    }
                        //                }

                        //            }
                        //        }
                        //    }
                        //}

                        OUT_1();
            OUT_2();
            textBox_out.Text = a1;
        }


        private string more(string[,] MAS1)
        {
            string f="";
            for (int i = 0; i < size; i++)
            {
                for (int o = 0; o < size; o++)
                {
                    f += MAS1[i, o] + " ";
                }
                f += Environment.NewLine;
            }
            f += Environment.NewLine;
            return f;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_out_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
