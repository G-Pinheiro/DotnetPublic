using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargoShipLoader;

namespace CargoShipGUI
{
    public partial class CargoShip : Form
    {
        Ship ship = new Ship();   

        public CargoShip()
        {
            InitializeComponent();
        }

        private void CargoShip_Load(object sender, EventArgs e)
        {
            progressBar2.Style = ProgressBarStyle.Continuous;
        }

        private void newBoat_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }

        private void updateUI()
        {
            // set all the controls to match the ship properties
            progressBar2.Maximum = ship.Capacity;

            if (ship.getShipLoad() <= ship.Capacity)
            {
                progressBar2.Value = ship.getShipLoad();
            }

            label_shipLabel.Text = ship.ToString();

            // motorcycles
            label_cycleCount.Text = ship.CycleCount.ToString();

            // cars
            label_carCount.Text = ship.CarCount.ToString();

            // trucks
            label_truckCount.Text = ship.TruckCount.ToString();

            // train cars
            label_trainCount.Text = ship.TruckCount.ToString();

            if (ship.overUnder() == 0)
            {
                progressBar2.ForeColor = Color.Green;
            }
            else if (ship.overUnder() > 0)
            {
                progressBar2.ForeColor = Color.Yellow;
            }
            else if (ship.overUnder() < 0)
            {
                progressBar2.ForeColor = Color.Red;
            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            updateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            updateUI();
        }
    }
}
