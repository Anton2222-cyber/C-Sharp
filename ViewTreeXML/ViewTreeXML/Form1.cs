using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ViewTreeXML
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product("Молоко", 40, "Україна"));
            products.Add(new Product("Ковбаса", 90, "М'ясний завод"));
            products.Add(new Product("Сік", 35, "Садочок"));
            products.Add(new Product("Сік", 50, "Sandora"));
            SaveXML();
            ReadXML();
        }
        public void SaveXML()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter("products.xml", System.Text.Encoding.Unicode);

            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("Products");
            for (int i = 0; i < products.Count; i++)
            {
                xmlTextWriter.WriteStartElement("Product");
                xmlTextWriter.WriteElementString("Name", products[i].Name);
                xmlTextWriter.WriteElementString("Price", products[i].Cost.ToString());
                xmlTextWriter.WriteElementString("Manufacturer", products[i].Manufacturer);
                xmlTextWriter.WriteEndElement();

            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.Close();
        }
        public void ReadXML()
        {
            products = new List<Product>();
           XmlDocument xml = new XmlDocument();
            xml.Load("products.xml");
            XmlNodeList nodes = xml.GetElementsByTagName("Product");
            foreach (XmlNode node in nodes)
            {
                products.Add(new Product(node["Name"].InnerText, Convert.ToSingle(node["Price"].InnerText), node["Manufacturer"].InnerText));
            }
           
            for (int i=0;i<products.Count;i++)
            {
                treeView1.Nodes.Add("Product");
                treeView1.Nodes[i].Nodes.Add(products[i].Name);
                treeView1.Nodes[i].Nodes.Add(products[i].Cost.ToString());
                treeView1.Nodes[i].Nodes.Add(products[i].Manufacturer);
            }
        }
    }
    class Product
    {
        string name;
        float cost;
        string manufacturer;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Manufacturer
        {
            set { manufacturer = value; }
            get { return manufacturer; }
        }
        public float Cost
        {
            set { cost = value; }
            get { return cost; }
        }
        public Product(string name, float cost, string manufacturer)
        {
            this.name = name;
            this.cost = cost;
            this.manufacturer = manufacturer;
        }
        public override string ToString()
        {
            return name + " " + cost + "$ Виробник: " + manufacturer;
        }
    }
}
    

