using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DoorLock_Library.Data.Models;
using DoorLock_Library.APIConnection;

namespace DoorLock_Admin
{
    public partial class Form1 : Form
    {

        private PublicApiConnectionHelper ApiConnection;

        public Form1()
        {
            InitializeComponent();

            this.ApiConnection = new PublicApiConnectionHelper();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void OpenDoor_Button_Click(object sender, EventArgs e)
        {
            DoorLock_Model tempoData = new DoorLock_Model();

            tempoData._DoorState = true;

            bool resluts = await this.ApiConnection.UpdateDoorState(tempoData);

            if(resluts == false)
            {
                MessageBox.Show("Door Failed to open : Please check your internet connection");
            }
        }

        private async void CloseDoor_Button_Click(object sender, EventArgs e)
        {
            DoorLock_Model tempoData = new DoorLock_Model();

            tempoData._DoorState = false;

            bool resluts = await this.ApiConnection.UpdateDoorState(tempoData);

            if (resluts == false)
            {
                MessageBox.Show("Door Failed to open : Please check your internet connection");
            }
        }

        private async void DataFetcher_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                DoorLock_Model tempoData = await this.ApiConnection.GetDoorState();

                if (tempoData != null)
                {

                    if (tempoData._DoorState == true)
                    {

                        this.DoorStateDisplay_Label.Text = "Door is -->> Opened";

                    }
                    else
                    {
                        this.DoorStateDisplay_Label.Text = "Door is -->> Closed";
                    }
                }
                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
