using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlimDX.DirectInput;
using SlimDX.XInput;

namespace JoyPad
{
    public class ControllerU
    {
        public DirectInput directInput;
        public Guid joystickGuid;
        public Joystick joystick;

        public ControllerU()
        {
            // Initialize DirectInput
            this.directInput = new DirectInput();

            // Find a Joystick Guid
            this.joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(SlimDX.DirectInput.DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                this.joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (this.joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(SlimDX.DirectInput.DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    this.joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (this.joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            // Instantiate the joystick
            this.joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

            // Query all suported ForceFeedback effects
            var allEffects = this.joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            this.joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            this.joystick.Acquire();
        }

        public void test()
        {
            int ile = 3;
            // Poll events from joystick
            while (ile > 2)
            {
                this.joystick.Poll();
                var datas = joystick.GetBufferedData();
                bool[] tea = this.joystick.GetCurrentState().GetButtons();
                int[] teb = { this.joystick.GetCurrentState().X, this.joystick.GetCurrentState().Y, this.joystick.GetCurrentState().Z };
                string[] Przyciski = { "A", "B", "X", "Y", "LB", "RB", "back", "start", "L", "R" };
                string[] przyciski = new string[10];
            }
        }

        public bool[] Buttons()
        {
            this.joystick.Poll();
            bool[] buttons = this.joystick.GetCurrentState().GetButtons();
            return buttons;
        }
    }

    public class ControllerX
    {
        private UserIndex userIndex;
        private SlimDX.XInput.Controller joystick;
        private Vibration vibration;
        public bool _vibration
        {
            get
            {
                if (vibration.LeftMotorSpeed == 0 || vibration.RightMotorSpeed == 0) return false;
                else return true;
            }
            set { }
        }

        public ControllerX()
        {
            this.userIndex = new UserIndex();

            //trzeba dać wyjątki gdy nie podłączony żaden pad :D
//            foreach (var deviceInstance in SlimDX.XInput.get.GetDevices(SlimDX.DirectInput.DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
//                this.joystickGuid = deviceInstance.InstanceGuid;

            this.joystick = new SlimDX.XInput.Controller(userIndex);
            this.vibration = new Vibration();
        }

        public void Vibration(ushort rSpeed, ushort lSpeed)
        {
            this.vibration.RightMotorSpeed = rSpeed;
            this.vibration.LeftMotorSpeed = lSpeed;
            this.joystick.SetVibration(vibration);
        }

        public SlimDX.XInput.State State()
        {
            return this.joystick.GetState();
        }

        public string[] StateBat()
        {
            BatteryDeviceType battery = new BatteryDeviceType();
            string[] Battery = new string[2];
            Battery[0] = this.joystick.GetBatteryInformation(battery).Type.ToString();
            Battery[1] = this.joystick.GetBatteryInformation(battery).Level.ToString();
            
            return Battery;
        }

        public bool[] ButtonStateBool()
        {
            bool[] Buttons = new bool[14];
            string[] buttonNames = { "A", "B", "X", "Y", "DPadUp", "DPadDown", "DPadLeft", "DPadRight", "LeftShoulder", "RightShoulder", "Back", "Start", "LeftThumb", "RightThumb" };

            string[] buttonStateStrings = this.joystick.GetState().Gamepad.Buttons.ToString().Split(new string[] { ", " }, StringSplitOptions.None);

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < buttonStateStrings.Length; j++)
                {
                    if (buttonStateStrings[j] == buttonNames[i])
                        Buttons[i] = true;
                }
            }
            return Buttons;
        }
    }
}
