using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_homework
{
    class Package
    {
        private string name { get; set; }
        private double motor { get; set; }
        private int horsePower { get; set; }
        private string type { get; set; }//manual, automatic
        private bool hasLights { get; set; }
        private bool hasElecticWindows { get; set; }
        private bool hasNavigation { get; set; }

        public Package(string name, double motor, int horsePower, string type, bool hasLights, bool hasElectricWindows, bool hasNavigation)
        {
            this.name = name;
            this.motor = motor;
            this.horsePower = horsePower;
            this.type = type;
            this.hasLights = hasLights;
            this.hasElecticWindows = hasLights;
            this.hasNavigation = hasNavigation;
        }

        public string getInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append('\n');
            sb.Append("Motor: ");
            sb.Append(motor.ToString());
            sb.Append(" HP\n");
            sb.Append("HorsePower: ");
            sb.Append(horsePower.ToString());
            sb.Append('\n');
            sb.Append("Type: ");
            sb.Append(type);
            sb.Append('\n');
            if (hasLights)
            {
                sb.Append("Option: Ambiental Lights");

                sb.Append('\n');
            }
            if (hasElecticWindows)
            {
                sb.Append("Option: Electric Windows");
                sb.Append('\n');
            }
            if (hasNavigation)
            {
                sb.Append("Option: Navigation");

            }
            return sb.ToString();
        }

    }
}
