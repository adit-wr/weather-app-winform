namespace AppWeather
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.minTemperatureLabel = new System.Windows.Forms.Label();
            this.WindSpeedL = new System.Windows.Forms.Label();
            this.pressureL = new System.Windows.Forms.Label();
            this.temperatureL = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateLabel.Location = new System.Drawing.Point(590, 34);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(123, 38);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "tanggal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(658, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedLabel.Location = new System.Drawing.Point(389, 202);
            this.WindSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(0, 38);
            this.WindSpeedLabel.TabIndex = 14;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureLabel.Location = new System.Drawing.Point(389, 149);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(0, 38);
            this.pressureLabel.TabIndex = 13;
            // 
            // minTemperatureLabel
            // 
            this.minTemperatureLabel.AutoSize = true;
            this.minTemperatureLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemperatureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minTemperatureLabel.Location = new System.Drawing.Point(390, 48);
            this.minTemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minTemperatureLabel.Name = "minTemperatureLabel";
            this.minTemperatureLabel.Size = new System.Drawing.Size(0, 38);
            this.minTemperatureLabel.TabIndex = 12;
            this.minTemperatureLabel.Click += new System.EventHandler(this.minTemperatureLabel_Click);
            // 
            // WindSpeedL
            // 
            this.WindSpeedL.AutoSize = true;
            this.WindSpeedL.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedL.Location = new System.Drawing.Point(31, 202);
            this.WindSpeedL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedL.Name = "WindSpeedL";
            this.WindSpeedL.Size = new System.Drawing.Size(262, 38);
            this.WindSpeedL.TabIndex = 11;
            this.WindSpeedL.Text = "Kecepatan Angin";
            // 
            // pressureL
            // 
            this.pressureL.AutoSize = true;
            this.pressureL.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureL.Location = new System.Drawing.Point(31, 149);
            this.pressureL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureL.Name = "pressureL";
            this.pressureL.Size = new System.Drawing.Size(140, 38);
            this.pressureL.TabIndex = 10;
            this.pressureL.Text = "Tekanan";
            // 
            // temperatureL
            // 
            this.temperatureL.AutoSize = true;
            this.temperatureL.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperatureL.Location = new System.Drawing.Point(32, 48);
            this.temperatureL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureL.Name = "temperatureL";
            this.temperatureL.Size = new System.Drawing.Size(157, 38);
            this.temperatureL.TabIndex = 9;
            this.temperatureL.Text = "Suhu Min";
            this.temperatureL.Click += new System.EventHandler(this.temperatureL_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionLabel.Location = new System.Drawing.Point(590, 257);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(153, 38);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Deskripsi";
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maxTempLabel.Location = new System.Drawing.Point(389, 95);
            this.maxTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(0, 38);
            this.maxTempLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Suhu Max";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.humidityLabel.Location = new System.Drawing.Point(389, 253);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(0, 38);
            this.humidityLabel.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(31, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kelembapan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(936, 342);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxTempLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.minTemperatureLabel);
            this.Controls.Add(this.WindSpeedL);
            this.Controls.Add(this.pressureL);
            this.Controls.Add(this.temperatureL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label minTemperatureLabel;
        private System.Windows.Forms.Label WindSpeedL;
        private System.Windows.Forms.Label pressureL;
        private System.Windows.Forms.Label temperatureL;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label label3;
    }
}