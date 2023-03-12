using System;
using System.IO;
using System.Xml;

namespace Read_With_XmlDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            string ruta = @"C:\Users\Victo\OneDrive\Escritorio\Proyectos 2022\Trabajar con XML NET\Leyendo XmlDocumento\Read_With_XmlDocument\Read_With_XmlDocument\Resources\concesionario.xml";

            // Si existe el fichero xml lo cargo
            if (File.Exists(ruta))
            {
                doc.Load(ruta);

                //doc.Load("concesionario.xml");
                //DocumentElement es el padre de todos
                foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
                {
                    //Cormprobamos si tiene hijos
                    if (n1.HasChildNodes)
                    {
                        foreach(XmlNode n2 in n1.ChildNodes)
                        {
                            //Sacamos los datos de un atributo
                            string matricula = n2.Attributes["matricula"].Value;
                            Console.WriteLine("Matricula: " + matricula);

                            foreach(XmlNode n3 in n2.ChildNodes)
                            {
                                //n3.Name seria la etiqueta marca
                                //n3.InnerText seria el valor que tiene 
                                //<marca>AUDI</marca>
                                Console.WriteLine(n3.Name + " " + n3.InnerText);
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
