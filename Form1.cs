using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//await 
using System.Windows.Forms;

namespace MoveCar
{
    public partial class MoveCar : Form
    {
        public Random NewPoint = new Random();
        public MoveCar()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
           Point p = pbxCar1.Location;
                int move = NewPoint.Next(2, 50);
                while (p.X < pbxRaceTrack.Width-70)
                {
                    pbxCar1.Location = new Point(p.X, p.Y);
                    p.X += move;
                    await Task.Delay(1000);
                }
                
        }

        }
    }
