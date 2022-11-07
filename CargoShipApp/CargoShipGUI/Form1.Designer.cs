namespace CargoShipGUI
{
    partial class CargoShip
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.newBoat = new System.Windows.Forms.Button();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.label_trainCount = new System.Windows.Forms.Label();
            this.label_descTrucks = new System.Windows.Forms.Label();
            this.label_descCars = new System.Windows.Forms.Label();
            this.label_descTrainCount = new System.Windows.Forms.Label();
            this.label_descMotorCycles = new System.Windows.Forms.Label();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CargoShipGUI.Properties.Resources.cargoship;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(561, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(121, 67);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(412, 66);
            this.progressBar2.TabIndex = 1;
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(13, 269);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(262, 45);
            this.track_motorCycles.TabIndex = 2;
            this.track_motorCycles.Scroll += new System.EventHandler(this.track_motorCycles_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(13, 372);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(262, 45);
            this.track_cars.TabIndex = 3;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(311, 268);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(262, 45);
            this.track_trucks.TabIndex = 4;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(311, 372);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(262, 45);
            this.track_trainCars.TabIndex = 5;
            this.track_trainCars.Scroll += new System.EventHandler(this.track_trainCars_Scroll);
            // 
            // newBoat
            // 
            this.newBoat.Location = new System.Drawing.Point(12, 472);
            this.newBoat.Name = "newBoat";
            this.newBoat.Size = new System.Drawing.Size(96, 23);
            this.newBoat.TabIndex = 6;
            this.newBoat.Text = "New Boat";
            this.newBoat.UseVisualStyleBackColor = true;
            this.newBoat.Click += new System.EventHandler(this.newBoat_Click);
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(16, 235);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(35, 13);
            this.label_cycleCount.TabIndex = 7;
            this.label_cycleCount.Text = "label1";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Location = new System.Drawing.Point(317, 235);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(35, 13);
            this.label_truckCount.TabIndex = 8;
            this.label_truckCount.Text = "label2";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Location = new System.Drawing.Point(16, 346);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(35, 13);
            this.label_carCount.TabIndex = 9;
            this.label_carCount.Text = "label3";
            // 
            // label_trainCount
            // 
            this.label_trainCount.AutoSize = true;
            this.label_trainCount.Location = new System.Drawing.Point(317, 346);
            this.label_trainCount.Name = "label_trainCount";
            this.label_trainCount.Size = new System.Drawing.Size(35, 13);
            this.label_trainCount.TabIndex = 10;
            this.label_trainCount.Text = "label4";
            // 
            // label_descTrucks
            // 
            this.label_descTrucks.AutoSize = true;
            this.label_descTrucks.Location = new System.Drawing.Point(317, 316);
            this.label_descTrucks.Name = "label_descTrucks";
            this.label_descTrucks.Size = new System.Drawing.Size(86, 13);
            this.label_descTrucks.TabIndex = 12;
            this.label_descTrucks.Text = "Trucks (11 units)";
            // 
            // label_descCars
            // 
            this.label_descCars.AutoSize = true;
            this.label_descCars.Location = new System.Drawing.Point(16, 415);
            this.label_descCars.Name = "label_descCars";
            this.label_descCars.Size = new System.Drawing.Size(68, 13);
            this.label_descCars.TabIndex = 13;
            this.label_descCars.Text = "Cars (5 units)";
            // 
            // label_descTrainCount
            // 
            this.label_descTrainCount.AutoSize = true;
            this.label_descTrainCount.Location = new System.Drawing.Point(317, 415);
            this.label_descTrainCount.Name = "label_descTrainCount";
            this.label_descTrainCount.Size = new System.Drawing.Size(101, 13);
            this.label_descTrainCount.TabIndex = 14;
            this.label_descTrainCount.Text = "Train Cars (17 units)";
            // 
            // label_descMotorCycles
            // 
            this.label_descMotorCycles.AutoSize = true;
            this.label_descMotorCycles.Location = new System.Drawing.Point(19, 315);
            this.label_descMotorCycles.Name = "label_descMotorCycles";
            this.label_descMotorCycles.Size = new System.Drawing.Size(108, 13);
            this.label_descMotorCycles.TabIndex = 15;
            this.label_descMotorCycles.Text = "Motor Cycles (3 units)";
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(73, 146);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(35, 13);
            this.label_shipLabel.TabIndex = 16;
            this.label_shipLabel.Text = "label1";
            // 
            // CargoShip
            // 
            this.ClientSize = new System.Drawing.Size(585, 507);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.label_descMotorCycles);
            this.Controls.Add(this.label_descTrainCount);
            this.Controls.Add(this.label_descCars);
            this.Controls.Add(this.label_descTrucks);
            this.Controls.Add(this.label_trainCount);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.newBoat);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CargoShip";
            this.Text = "Cargo Ship";
            this.Load += new System.EventHandler(this.CargoShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /*
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label_trainCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;*/
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.Button newBoat;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label_trainCount;
        private System.Windows.Forms.Label label_descTrucks;
        private System.Windows.Forms.Label label_descCars;
        private System.Windows.Forms.Label label_descTrainCount;
        private System.Windows.Forms.Label label_descMotorCycles;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

