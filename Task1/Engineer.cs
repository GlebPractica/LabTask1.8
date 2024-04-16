using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Engineer : IEmployee
    {
        public string Name { get; set; }

        public string Work() => $"Инженер {Name} разрабатывает проект согласно заказу.";

        public string AddName(string name)
        {
            Name = name;
            return $"Инженер {Name} был успешно добавлен.";
        }

        public override string ToString()
        {
            return $"Инженер {Name}";
        }
    }
}
