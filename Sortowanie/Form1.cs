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
            checkBoxAnimacja.Checked = true;
            
            //labelWagaLewa.Visible = false;
            //labelWagaPrawa.Visible = false;

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
            /*
            string strLiczby = "Losowe liczby: ";
            for(int i = 0; i < (liczby.Length - 1); i++)
            {
                strLiczby += liczby[i].ToString() + " ,";
            }
            strLiczby += liczby[liczby.Length - 1].ToString();
            labelTablica.Text = strLiczby;*/


            //Wpisanie do datagrid
            var index = this.dataGridView1.Rows.Add();
            dataGridView1.ClearSelection();
            for (int i = 0;i< liczby.Length;i++)
            {
                dataGridView1.Rows[index].Cells[i].Value=liczby[i];
            }
        }

        //Wywolanie sortowania
        private void buttonWybor_Click(object sender, EventArgs e)
        {
            int temp=0;
            int interwal = trackBarInterwalAnimacji.Value*10;
            checkBoxAnimacja.Enabled = false;
            trackBarInterwalAnimacji.Enabled = false;
            buttonReset.Enabled=false;

            for (int i = 0; i < liczby.Length; i++)
            {
                          
                for (int j = i + 1; j < liczby.Length; j++)
                {
                    if(checkBoxAnimacja.Checked == true)
                    {
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;
                        dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Red;
                        dataGridView1.Refresh();

                        labelWagaLewa.Text = liczby[i].ToString();
                        labelWagaLewa.Refresh();

                        labelWagaPrawa.Text = liczby[j].ToString();
                        labelWagaPrawa.Refresh();
                    }
                    

                    if (liczby[i] > liczby[j])
                    { 
                        temp = liczby[i];        
                        liczby[i] = liczby[j];
                        liczby[j] = temp;

                        if (checkBoxAnimacja.Checked == true)
                        {
                            wprowadzDane(liczby);

                            pictureBoxWagaCenter.Image = Sortowanie.Properties.Resources.scale_lewa;
                            pictureBoxWagaCenter.Refresh();
                            System.Threading.Thread.Sleep(interwal);
                        }
                       
                    }

                    if(liczby[i] == liczby[j] && checkBoxAnimacja.Checked==true)
                    {
                        pictureBoxWagaCenter.Image = Sortowanie.Properties.Resources.scale;
                        pictureBoxWagaCenter.Refresh();
                        System.Threading.Thread.Sleep(interwal);
                    }
                    if (liczby[i] < liczby[j] && checkBoxAnimacja.Checked==true)
                    {
                        pictureBoxWagaCenter.Image = Sortowanie.Properties.Resources.scale_prawa;
                        pictureBoxWagaCenter.Refresh();
                        System.Threading.Thread.Sleep(interwal);
                    }

                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.White;
                    dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.White;
                    dataGridView1.Refresh();
                }
            }

            if (checkBoxAnimacja.Checked == false)
            {
                wprowadzDane(liczby);
            }

            labelWagaLewa.Visible = false;
            labelWagaPrawa.Visible = false;
            buttonReset.Enabled = true;
            pictureBoxWagaCenter.Image = Sortowanie.Properties.Resources.scale;
            pictureBoxWagaCenter.Refresh();
            System.Windows.Forms.MessageBox.Show("Sortowanie zakończone");

        }

        private void wprowadzDane(int[] L)
        {
            int n = L.Length;
            for(int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = liczby[i];
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelWagaLewa_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxWagaCenter_Click(object sender, EventArgs e)
        {

        }

        private void trackBarInterwalAnimacji_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(0);
            buttonGen.Enabled = true;
            buttonWybor.Enabled = false;
            checkBoxAnimacja.Checked = true;
            Array.Clear(liczby,0, liczby.Length);
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Program napisany jako projekt na zajęcia z C# przez:\nAdrian Kozłowski\nTomasz Tomaszewski\nSłupsk, luty 2022");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
