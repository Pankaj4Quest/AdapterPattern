using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterPattern
{
    internal class LegacyEmployeeManager
    {
        public List<Employee> _employees;

        public LegacyEmployeeManager()
        {
            _employees = new List<Employee>()
                {
                    new Employee(100,"Pankaj","Verma"),
                    new Employee(101,"Rahul","Gupta"),
                    new Employee(102,"Sanket","Sharma"),
                    new Employee(103,"Srinivas","Swamy")
                };

        }
        public string GetAllEmployees()
        {
            var emptyNameSpaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.OmitXmlDeclaration = true;

            XmlSerializer serializer = new XmlSerializer(_employees.GetType());

            // Serialize the list to an XML string
            using (StringWriter stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, xmlSettings))
                {
                    serializer.Serialize(xmlWriter, _employees, emptyNameSpaces);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
