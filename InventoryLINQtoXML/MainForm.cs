using System;
using System.Windows.Forms;

namespace InventoryLINQtoXML
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Відобразити поточний XML-документ складу в компоненті TextBox.
            txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Додати новий елемент до документа.
            LinqToXmlObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text);
            // Відобразити поточний XML-документ складу в компоненті TextBox.
            txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
            txtMake.Text = txtColor.Text = txtPetName.Text = String.Empty;
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            LinqToXmlObjectModel.LookUpColorsForMake(txtMakeLookup.Text);
        }
    }
}
