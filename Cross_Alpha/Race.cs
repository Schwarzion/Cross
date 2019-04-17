using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace Cross_Alpha
{

    public partial class Race : Form
    {
        private int count = 0;
        private int rank = 1;
        private int x = 0;
        private String rfid = "";
        private Tools function;
        private BackgroundWorker bw;
        private Stopwatch watch = new Stopwatch();
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public Race()
        {
            InitializeComponent();
            timer.Tick += Timer1_Tick;
            function = new Tools();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time_elapsed.Text = watch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            watch.Stop();
            timer.Stop();
            race_type.Enabled = true;
            this.KeyPreview = false;
            bw.CancelAsync();
            rfid = "";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (race_type.SelectedIndex > -1)
            {
                watch.Restart();
                timer.Start();
                this.KeyPreview = true;
                bw = new BackgroundWorker();
                bw.WorkerSupportsCancellation = true;

                bw.DoWork += new DoWorkEventHandler((state, args) =>
                {
                    do
                    {
                        if (bw.CancellationPending)
                        {
                            this.KeyPreview = false;
                            break;
                        }
                    } while (true);
                });
                bw.RunWorkerAsync();
            }
            else
                MessageBox.Show("Veuillez choisir un type de course");
        }

        private void race_type_DropDown(object sender, EventArgs e)
        {
            race_type.Items.Clear();
            List<string> race = function.Get_race_types();
            for (int i = 0; i < race.Count; i++)
                this.race_type.Items.Add(race[i]);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            name_1.Text = "1ère place : "; name_2.Text = "2ème place : "; name_3.Text = "3ème place : ";
            time_1.Text = ""; time_2.Text = ""; time_3.Text = "";
            rank_show.Text = "";
            time_elapsed.Text = "00:00:00.00";
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Race_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (count == 4)
            {
                rank_show.Text = "";
                count = 0;
            }
            char return_key = e.KeyChar;
            if (!(e.KeyChar == (char)13))
                rfid = rfid + return_key.ToString();
            if (rfid.Length == 8)
            {
                function.Add_data(rfid, watch.Elapsed.ToString(@"hh\:mm\:ss\.fff"), rank, race_type.Text); 
                if (x < 3)
                {
                    switch (x)
                    {
                        case 0:
                            name_1.Text = "1ère place : " + function.Get_complete_name(rfid);
                            time_1.Text = watch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
                            x++;
                            Debug.Print("X= "+x.ToString());
                            break;
                        case 1:
                            name_2.Text = "2ème place : " + function.Get_complete_name(rfid);
                            time_2.Text = watch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
                            x++;
                            Debug.Print("X= " + x.ToString());
                            break;
                        case 2:
                            name_3.Text = "3ème place : " + function.Get_complete_name(rfid);
                            time_3.Text = watch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
                            x++;
                            Debug.Print("X= " + x.ToString());
                            break;
                    }
                    
                }
                rank_show.Text += function.Get_complete_name(rfid)+" | Temps : "+ watch.Elapsed.ToString(@"hh\:mm\:ss\.fff") + " | Rang : " +rank+Environment.NewLine;
                rank++;
                MessageBox.Show(rank.ToString());
                rfid = "";
            }
        }

        private void Race_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

            race_type.Enabled = false;
        }
    }
}
