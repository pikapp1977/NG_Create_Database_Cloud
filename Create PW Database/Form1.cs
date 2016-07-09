using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Create_PW_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NextGenDBName_TextChanged(object sender, EventArgs e)
        {
            string nextgendbname;
            nextgendbname = NextGenDBName.Text;
        }

        private void DatabaseSetName_TextChanged(object sender, EventArgs e)
        {
            string databasesetname;
            databasesetname = DatabaseSetName.Text;
        }

        private void DPMSDBIdentifier_TextChanged(object sender, EventArgs e)
        {
            string dpmsdbidentifier;
            dpmsdbidentifier = DPMSDBIdentifier.Text;
        }

        private void pmsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dpmstype;
            dpmstype = pmsType.Text;
            //MessageBox.Show(dpmstype);
        }

        private void ServerName_TextChanged(object sender, EventArgs e)
        {
            string servername;
            servername = ServerName.Text;
        }

        private void InstanceName_TextChanged(object sender, EventArgs e)
        {
            string instancename;
            instancename = InstanceName.Text;
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            string user;
            user = User.Text;
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            string pass;
            pass = Pass.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pmsType.Text))
                MessageBox.Show("You must select a DPMS Type!");
            
            if (NextGenDBName.Text.Length == 0)
                MessageBox.Show("You must specify a database name!");

            if (DatabaseSetName.Text.Length == 0)
                MessageBox.Show("You must specify a database set name!");

            if (DPMSDBIdentifier.Text.Length == 0)
                MessageBox.Show("You must specify a DPMS database identifier!");

            if (ServerName.Text.Length == 0)
                MessageBox.Show("You must specify a server name!");

            if (User.Text.Length == 0)
                MessageBox.Show("You must specify a server sa username!");

            if (Pass.Text.Length == 0)
                MessageBox.Show("You must specify a server sa password!");

                else
                    //CREATE DATABASE FOR PWOFFICE
                    if (pmsType.Text == "PWOffice")
                    //MessageBox.Show ("PWOffice");
                    {
                    //Create DB Stuff for PWOffice in cloud
                    ProcessStartInfo createPWDatabase = new ProcessStartInfo("C:\\Program Files (x86)\\Carestream\\Carestream PWOffice eServices Suite\\Tools\\CreateDatabase.exe");
                    //Process.Start(createPWDatabase); //do I really need this?
                    createPWDatabase.Arguments = " /NextGenDBName=" + NextGenDBName.Text + " /user=" + User.Text + " /pass=" + Pass.Text + " /server=" + ServerName.Text + @"\" + InstanceName.Text + " /Auth=mixed" + " /DatabaseSetName=" + DatabaseSetName.Text + " /DPMSDBIdentifier=" + DPMSDBIdentifier.Text + " /DPMSType=4";
                    Process.Start(createPWDatabase);
                    }
                
                else

                    //CREATE DATABASE FOR SOFTDENT
                    if (pmsType.Text == "SoftDent")
                    //MessageBox.Show ("SoftDent");
                    {
                    //Create DB Stuff for SoftDent in cloud
                    ProcessStartInfo createPWDatabase = new ProcessStartInfo("C:\\Program Files (x86)\\Carestream\\Carestream SoftDent Application Suite\\Tools\\CreateDatabase.exe");
                    //Process.Start(createPWDatabase); //do I really need this?
                    createPWDatabase.Arguments = " /NextGenDBName=" + NextGenDBName.Text + " /user=" + User.Text + " /pass=" + Pass.Text + " /server=" + ServerName.Text + @"\" + InstanceName.Text + " /Auth=mixed" + " /DatabaseSetName=" + DatabaseSetName.Text + " /DPMSDBIdentifier=" + DPMSDBIdentifier.Text + " /DPMSType=1";
                    Process.Start(createPWDatabase);
                    }
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






    }
}
