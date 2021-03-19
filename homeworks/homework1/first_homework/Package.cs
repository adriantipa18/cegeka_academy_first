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

        public Package()
        {

        }
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

        public string getName()
        {
            return this.name;
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
                sb.Append('\n');

            }
            return sb.ToString();
        }

        public void createCustom()
        {
            Console.Write("Set a name for your package:");
            this.name = Console.ReadLine();
            while (true)
            {
                Console.Write("Motor:");
                double motorId;
                if (!double.TryParse(Console.ReadLine(), out motorId))
                {
                    Console.WriteLine("Try again(example 2.2, 3.0):");
                }
                else
                {
                    this.motor = motorId;
                    break;
                }
                
            }
            while (true)
            {
                Console.Write("Motor:");
                int hp;
                if (!int.TryParse(Console.ReadLine(), out hp))
                {
                    Console.WriteLine("Try again(example 2.2, 3.0):");
                }
                else
                {
                    this.horsePower = hp;
                    break;
                }

            }
            Console.Write("Set a type for your car:");
            this.type = Console.ReadLine();
            Console.Write("Ambiental Lights(yes/no):");
            String answer;
            answer = Console.ReadLine();
            if (answer.Equals("no"))
            {
                this.hasLights = false;
            }
            else
            {
                this.hasLights = true;
            }

            Console.Write("Electri Windows(yes/no):");
            answer = Console.ReadLine();
            if (answer.Equals("no"))
            {
                this.hasElecticWindows = false;
            }
            else
            {
                this.hasElecticWindows = true;
            }
            
            Console.Write("Navigation(yes/no):");
            answer = Console.ReadLine();
            if (answer.Equals("no"))
            {
                this.hasNavigation = false;
            }
            else
            {
                this.hasNavigation = true;
            }

        }

    }
}
