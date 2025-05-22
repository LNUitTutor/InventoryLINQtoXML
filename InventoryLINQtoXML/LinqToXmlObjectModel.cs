using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryLINQtoXML
{
    class LinqToXmlObjectModel
    {
        public static XDocument GetXmlInventory()
        {
            try
            {
                XDocument inventoryDoc = XDocument.Load("Inventory.xml");
                return inventoryDoc;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void InsertNewElement(string make, string color, string petName)
        {
            // Завантажити поточний документ.
            XDocument inventoryDoc = XDocument.Load("Inventory.xml");
            // Згенерувати випадкове число для ідентифікатора.
            Random r = new Random();
            // Створити новий об'єкт XElement на основі вхідних параметрів.
            XElement newElement = new XElement("Car",
                new XAttribute("ID", r.Next(50000)),
                new XElement("Color", color),
                new XElement("Make", make),
                new XElement("PetName", petName));
            // Додати до об'єкта XDocument в пам'яті.
            inventoryDoc.Descendants("Inventory").First().Add(newElement);
            // Зберегти зміни на диску.
            inventoryDoc.Save("Inventory.xml");
        }
        public static void LookUpColorsForMake(string make)
        {
            // Завантажити поточний документ.
            XDocument inventoryDoc = XDocument.Load("Inventory.xml");
            // Знайти кольори заданого виробника.
            var makeInfo = from car in inventoryDoc.Descendants("Car")
                           where (string)car.Element("Make") == make
                           select car.Element("Color").Value;
            // Побудувати рядок, який містить кожен знайдений колір.
            string data = string.Empty;
            foreach (var item in makeInfo.Distinct())
            {
                data += string.Format("- {0}\n", item);
            }
            // Показати кольори.
            MessageBox.Show(data, string.Format("{0} colors:", make));
        }
    }
}
