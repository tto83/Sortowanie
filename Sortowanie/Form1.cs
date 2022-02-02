using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        int[] liczby = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonGen.Enabled = true;
            buttonWybor.Enabled = false;
            
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            buttonGen.Enabled = false;
            buttonWybor.Enabled = true;
            

            //Losowanie liczb
            Random los = new Random();
            for(int i=0; i<liczby.Length; i++)
            {
                liczby[i] = los.Next(1,100);
            }

            //Wyswietlanie liczb
            string strLiczby = "Losowe liczby: ";
            for(int i = 0; i < (liczby.Length - 1); i++)
            {
                strLiczby += liczby[i].ToString() + " ,";
            }
            strLiczby += liczby[liczby.Length - 1].ToString();
            labelTablica.Text = strLiczby;


            //Wpisanie do datagrid
            var index = this.dataGridView1.Rows.Add();
            for (int i = 0;i< liczby.Length;i++)
            {
                dataGridView1.Rows[index].Cells[i].Value=liczby[i];
            }
        }

        //Wywolanie sortowania
        private void buttonWybor_Click(object sender, EventArgs e)
        {
            int temp;
            for(int i = 0; i < liczby.Length; i++)
            {
                for(int j=i+1;j<liczby.Length; j++)
                {
                    if (liczby[j]<=liczby[i])
                    {
                        temp = liczby[i];
                        liczby[i]=liczby[j];
                        liczby[j]=temp;
                    }
                }
            }

            //Wyswietlanie liczb
            /*
            string strLiczby = "Losowe liczby: ";
            for (int i = 0; i < (liczby.Length - 1); i++)
            {
                strLiczby += liczby[i].ToString() + " ,";
            }
            strLiczby += liczby[liczby.Length - 1].ToString();
            labelTablica.Text = strLiczby;
            */
            for (int i = 0; i < liczby.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = liczby[i];
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            /*
            var index = this.dataGridView1.Rows.Add();
            //Wpisanie do datagrid
            for (int i = 0; i < liczby.Length; i++)
            {
                dataGridView1.Rows[index].Cells[i].Value = 0;
            }
            */
        }
    }
}
