using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Clase
{
    public class School
    {
        public List<Teacher> Teachers { get; set; }
        public List<Estudent> Students { get; set; }

        public School()
        {
            Teachers = new List<Teacher>();
            Students = new List<Estudent>();
        }
    }
}
