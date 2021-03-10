using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_homework
{
    class Car
    {
        private string brand { get; set; } 
        private string model { get; set; }
        private Package package { get; set; }
        
        public Car(string brand, string model, Package package)
        {
            this.brand = brand;
            this.model = model;
            this.package = package;
        }

        public string getInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Brand: ");
            sb.Append(brand);
            sb.Append('\n');
            sb.Append("Model: ");
            sb.Append(model);
            sb.Append('\n');
            sb.Append("Package: ");
            sb.Append(package.getInfo());
            return sb.ToString();
        }

}
}
