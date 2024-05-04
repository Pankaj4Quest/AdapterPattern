using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdapterPattern
{
    [Serializable]
    [XmlRoot("RootNode")]
    public class Employee
    {
        public Employee()
        {
                
        }
        public Employee(int Id, string FName, string LName)
        {
            this.Id = Id;
            this.FirstName = FName;
            this.LastName = LName;
        }

        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public string FirstName { get; set; }

        [XmlAttribute]
        public string LastName { get; set; }

    }
}
