using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WhatsTheDiameter
{
    public partial class Form1 : Form
    {
        private List<Circle> circles;
        public Form1()
        {
            InitializeComponent();

            this.circles = new List<Circle>();
        }

        private void NewCircle_Click(object sender, EventArgs e)
        {
            var circle = new Circle(Convert.ToDouble(CircleInput.Text));
            this.circles.Add(circle);
            this.RedrawCircleCollection();
            string msg;
            msg = "Radius:" + circle.getRadius() + " Diamter:" + circle.getDiameter() + " Area:" + circle.getArea();
            MessageBox.Show(msg);
        }

        private void RedrawCircleCollection()
        {
            CircleCollection.Items.Clear();
            foreach (var circle in this.circles)
            {
                CircleCollection.Items.Add(circle.ToString());
            }
        }
        private void ShowArray_Click(object sender, EventArgs e)
        {
            String msg;
            msg = "Radius  Diameter   Area\n";
            msg += "--------------------\n";
            foreach (var c in this.circles)
            {
                msg += string.Format("{0}      {1}      {2}\n", c.getRadius(), c.getDiameter(), c.getArea());
            }
            MessageBox.Show(msg);
        }

        private void SetRadius_Click(object sender, EventArgs e)
        {
            double newrad = Convert.ToDouble(CircleInput.Text);
            var c = circles[CircleCollection.SelectedIndex];
            c.setRadius(newrad);
            string msg;
            msg = "Radius:" + c.getRadius() + " Diamter:" + c.getDiameter() + " Area:" + c.getArea();
            MessageBox.Show(msg);
            RedrawCircleCollection();
        }

        private void CircleCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = circles[CircleCollection.SelectedIndex];
            string msg;
            msg = "Radius:" + c.getRadius() + " Diamter:" + c.getDiameter() + " Area:" + c.getArea();
            MessageBox.Show(msg);

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            this.circles.Sort();
            RedrawCircleCollection();
        }
    }
}
