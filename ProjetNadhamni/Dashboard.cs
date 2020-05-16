﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        Profile pf = new Profile();
        SqlConnection con = new SqlConnection();

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {

            try
            {

                con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                con.Open();
                if (Home.NewUser == false)
                {

                    SqlCommand cmd = new SqlCommand("select * from Tasks where UserName = '" + Home.FK + "'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ViewTasks.Rows.Add(dr[0], dr[2], dr[1], dr[4], dr[5], dr[7], dr[8], dr[6], dr[9]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_dashboard.Top;
            PnlPassage.Height = btn_dashboard.Height;


        }



        private void btn_tasks_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_taskDash.Top;
            PnlPassage.Height = btn_taskDash.Height;
            pnlDashboard.Visible = false;
            this.Hide();
            Tasks tsk = new Tasks();
            tsk.Show();

        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_statDash.Top;
            PnlPassage.Height = btn_statDash.Height;
            this.Hide();
            Statistics stc = new Statistics();
            stc.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_settingsDash.Top;
            PnlPassage.Height = btn_settingsDash.Height;
        }

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_profileDash.Top;
            PnlPassage.Height = btn_profileDash.Height;
            Profile pf = new Profile();
            this.Hide();
            pf.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            PnlPassage.Top = btn_settingsDash.Top;
            PnlPassage.Height = btn_settingsDash.Height;
            this.Hide();
            Settings set = new Settings();
            set.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_saveNote_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearNote_Click(object sender, EventArgs e)
        {
            rb_notes.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
