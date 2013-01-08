using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyPad
{
    public partial class Form1 : Form
    {
        public ControllerX x360 = new ControllerX();
        public ushort[] vibracjeSila = { 0, 0 };
        public int[] sliders = { 0, 0, 0, 0, 0, 0 };
        public bool[] buttons = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("lol");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x360.Vibration(0, 0);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {

            var state = x360.State();
            buttons = x360.ButtonStateBool();

            //string[] przyciskiNazwy = { "A", "B", "X", "Y", "DPadUp", "DPadDown", "DPadLeft", "DPadRight", "LeftShoulder", "RightShoulder", "Back", "Start", "LeftThumb", "RightThumb" };
            string[] przyciskiNazwy = { "A", "B", "X", "Y", "Up", "Down", "Left", "Right", "LS", "RS", "Back", "Start", "L", "R" };

            int[] sliders = { state.Gamepad.LeftThumbX, state.Gamepad.LeftThumbY, state.Gamepad.RightThumbX, state.Gamepad.RightThumbY, state.Gamepad.LeftTrigger, state.Gamepad.RightTrigger };
            this.sliders = sliders;
            padPicture.Refresh();

            label1.Text = "Battery type: " + x360.StateBat()[0];
            label2.Text = "Battery level: " + x360.StateBat()[1];


            //improwizowane przyciski
            PressedButtons.Text = "";
            for (int i = 0; i < buttons.Length;i++)
                if (buttons[i] == true) PressedButtons.Text += przyciskiNazwy[i] + ", ";
            if (this.sliders[4] >= 250) PressedButtons.Text += "LT, ";
            if (this.sliders[5] >= 250) PressedButtons.Text += "RT, ";
        }

        private void rMotorSlider_Scroll(object sender, EventArgs e)
        {
            vibracjeSila[0] = Convert.ToUInt16(rMotorSlider.Value);
            x360.Vibration(vibracjeSila[0], vibracjeSila[1]);
            rMotorLabel.Text ="R: " + ((rMotorSlider.Value * 100) / 65535).ToString() + "%";
        }

        private void lMotorSlider_Scroll(object sender, EventArgs e)
        {
            vibracjeSila[1] = Convert.ToUInt16(lMotorSlider.Value);
            x360.Vibration(vibracjeSila[0], vibracjeSila[1]);
            lMotorLabel.Text = "L: " + ((lMotorSlider.Value * 100) / 65535).ToString() + "%";
        }

        private void padPicture_Paint(object sender, PaintEventArgs e)
        {
            Brush[] brush = {Brushes.Red, Brushes.Green };
            Brush lb, rb, ls, rs = brush[0];


            int lsliderX = (sliders[0] * 29) / 32768;
            int lsliderY = -(sliders[1] * 29) / 32768;
            int rsliderX = (sliders[2] * 29) / 32768;
            int rsliderY = -(sliders[3] * 29) / 32768;

            if (buttons[12] == true) lb = brush[1]; else lb = brush[0];
            if (buttons[13] == true) rb = brush[1]; else rb = brush[0];
            if (sliders[4] >= 250) ls = brush[1]; else ls = brush[0];
            if (sliders[5] >= 250) rs = brush[1]; else rs = brush[0];

            Graphics graphics = e.Graphics;
            graphics.FillEllipse(lb, 107 + lsliderX, 125 + lsliderY, 20, 20);
            graphics.FillEllipse(rb, 305 + rsliderX, 206 + rsliderY, 20, 20);


            SolidBrush[] brushf = {new SolidBrush(Color.FromArgb(255,27,27,27)), new SolidBrush(Color.FromArgb(255,27,27,27)), new SolidBrush(Color.FromArgb(255,27,27,27)), new SolidBrush(Color.FromArgb(255,27,27,27)), new SolidBrush(Color.FromArgb(255,27,27,27))};

            if (buttons[3] == true) brushf[0].Color = Color.Green; else brushf[0].Color = Color.FromArgb(255, 239, 189, 23);
            graphics.FillEllipse(brushf[0], 372, 83, 30, 30);

            graphics.FillRectangle(ls, 90, 50, sliders[4] / 3, 10);
            graphics.FillRectangle(rs, 330, 50, sliders[5] / 3, 10);
        }
    }
}
