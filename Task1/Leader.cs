using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Leader : IEmployee
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Руководитель {Name}";
        }

        public string AddName(string name)
        {
            Name = name;
            return $"Руководитель {Name} был успешно добавлен.";
        }

        public string Work() => $"Работа руководителя заключается в анализе работы инженеров, а также проверка их проектов.";
    }
}
