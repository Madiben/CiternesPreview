using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citernes
{
    public partial class Form1 : Form
    {
        float taux = 0, tx = 0;
        int vol=0,en=0;
        int cap=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment vider la citerne", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBoxQuan.Text = "";
                labelvolume.Text = "0 L";
                labeltaux.Text = "0.0 %";
                progressBar1.Value = 0;

            }
            else
            {
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxQuan.Text == "")
            {
                MessageBox.Show("Il faut saisir une valeur : ", "Erreur de saisi" , MessageBoxButtons.OK);
            }
            else
            {
                if(radioButton1.Checked==true)
                {
                    cap = 2000;
                    if (taux != 100)
                    {
                        vol = vol + Convert.ToInt32(textBoxQuan.Text);
                        if (vol <= cap)
                        {
                            en = vol;
                            labelvolume.Text = Convert.ToString(vol) + "L";
                            taux = vol * 100 / cap;
                            
                            if (taux <= 100)
                            {
                                tx = taux;
                                labeltaux.Text = taux + "%";
                                progressBar1.Value = Convert.ToInt32(taux);
                            }else
                            {
                                labeltaux.Text = Convert.ToDouble(tx) + "%";
                                progressBar1.Value = Convert.ToInt32(tx);
                            }
                        }
                        else
                        {
                            vol = en;
                            MessageBox.Show("la citerne est Contient Seul " + cap + " L Si Vous Plait Entrer Un Valeur Acceptable: ", "Erreur de saisi", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {

                    cap = 3000;
                    
                        vol = vol + Convert.ToInt32(textBoxQuan.Text);
                        if (vol <= cap)
                        {
                            en = vol;
                            labelvolume.Text = Convert.ToString(vol) + "L";
                            taux = vol * 100 / cap;
                            if (taux <= 100)
                            {
                                tx = taux;
                                labeltaux.Text = taux + "%";
                                progressBar1.Value = Convert.ToInt32(taux);
                            }
                            else
                            {
                                labeltaux.Text = Convert.ToString(tx) + "%";
                                progressBar1.Value = Convert.ToInt32(tx);
                            }
                        }
                        else
                        {
                            vol =en;
                            MessageBox.Show("la citerne est Contient Seul " + cap + " L Si Vous Plait Entrer Un Valeur Acceptable: ", "Erreur de saisi", MessageBoxButtons.OK);
                        }
                    

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxQuan.Text == "")
            {
                MessageBox.Show("Il faut saisir une valeur : ", "Erreur de saisi", MessageBoxButtons.OK);
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    cap = 2000;

                    if (vol <= cap)
                    {
                        vol = vol - Convert.ToInt32(textBoxQuan.Text);
                        if (vol > 0)
                        {
                            labelvolume.Text = Convert.ToString(vol) + "L";
                            taux = vol * 100 / cap;
                            if (taux > 0)
                            {
                                labeltaux.Text = Convert.ToString(taux) + "%";
                                progressBar1.Value = Convert.ToInt32(taux);
                            }
                            else
                            {
                                labeltaux.Text = Convert.ToString(0) + "%";
                                progressBar1.Value = Convert.ToInt32(0);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("la citerne est Contient Seul " + cap + " L Si Vous Plait Entrer Un Valeur Acceptable: ", "Erreur de saisi", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    cap = 3000;

                    if (vol <= cap)
                    {
                        vol = vol - Convert.ToInt32(textBoxQuan.Text);
                        if (vol > 0)
                        {
                            labelvolume.Text = Convert.ToString(vol) + "L";
                            taux = vol * 100 / cap;
                            if (taux > 0)
                            {
                                labeltaux.Text = Convert.ToString(taux) + "%";
                                progressBar1.Value = Convert.ToInt32(taux);
                            }
                            else
                            {
                                labeltaux.Text = Convert.ToString(0) + "%";
                                progressBar1.Value = Convert.ToInt32(0);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("la citerne est Contient Seul " + cap + " L Si Vous Plait Entrer Un Valeur Acceptable: ", "Erreur de saisi", MessageBoxButtons.OK);
                    }

                }
            }
        }
    }
}
