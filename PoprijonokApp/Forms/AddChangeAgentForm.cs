using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PoprijonokApp.Models;

namespace PoprijonokApp.Forms
{
    public partial class AddChangeAgentForm : Form
    {
        public ModelDatabase Database { get; set; }

        public int AgentIDforSale;

        public Agent Agent { get; set; } = null;

        private string _imagePath = null;

        public AddChangeAgentForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = Database.AgentTypes.ToList();

            if(Agent == null)
            {
                contextLabel.Text = "Добавление агента";
            }
            else
            {
                AgentIDforSale = Agent.ID;

                List<ProductSale> sales = new List<ProductSale>(); 

                foreach(ProductSale sale in Database.ProductSales.ToList())
                {
                    if(sale.AgentID == Agent.ID)
                    {
                        sales.Add(sale);
                    }
                }

                productSaleBindingSource.DataSource = sales;

                productBindingSource.DataSource = Database.Products.ToList();

                contextLabel.Text = "Изменение агента";

                titleTextBox.Text = Agent.Title;
                agentTypeIDComboBox.SelectedIndex = Agent.AgentTypeID - 1;
                addressTextBox.Text = Agent.Address;
                iNNTextBox.Text = Agent.INN;
                kPPTextBox.Text = Agent.KPP;
                directorNameTextBox.Text = Agent.DirectorName;
                phoneTextBox.Text = Agent.Phone;
                emailTextBox.Text = Agent.Email;

                if(Agent.Logo == "")
                {
                    logoPictureBox.Image = new Bitmap($@"{Environment.CurrentDirectory}\Resources\default.png");
                }
                else
                {
                    logoPictureBox.Image = new Bitmap($@"{Environment.CurrentDirectory}\Resources\{Agent.Logo}");
                }

                
                priorityTextBox.Text = Agent.Priority.ToString();
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Save(object sender, EventArgs e)
        {
            if(FormValidated() != true) { return; }

            if (Agent == null)
            {
                AddNewAgent();
            }
            else
            {
                SaveAgentChanges();
            }

            try
            {
                Database.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool FormValidated()
        {
            // Check for null values
            if (titleTextBox.Text == "" ||
                agentTypeIDComboBox.SelectedIndex == -1 ||
                iNNTextBox.Text == "" ||
                phoneTextBox.Text == "" ||
                priorityTextBox.Text == "")
            {
                MessageBox.Show("Заполните поля, отмеченные звёздочкой!");
                return false;
            }

            // Checking phone number, inn and kpp length
            if (iNNTextBox.Text.Length < 12)
            {
                MessageBox.Show("Длина ИНН должна быть 12 символов!");
                return false;
            }

            if (kPPTextBox.Text.Length < 9)
            {
                MessageBox.Show("Длина КПП должна быть 9 символов!");
                return false;
            }

            if (phoneTextBox.Text.Length < 10)
            {
                MessageBox.Show("Длина номера телефона должна быть 10 символов!");
                return false;
            }

            // Checking the name of the director for the content of numbers
            foreach (char ch in directorNameTextBox.Text)
            {
                if (char.IsDigit(ch))
                {
                    MessageBox.Show("Имя директора содержит цифры!");
                    return false;
                }
            }

            // Checking for letters in phone number and priority
            List<TextBox> numberTextBoxes = new List<TextBox>
            {
                phoneTextBox,
                priorityTextBox
            };

            foreach (TextBox tb0 in numberTextBoxes)
            {
                if (ContainsSymbolOrLetter(tb0.Text))
                {
                    MessageBox.Show("Поля номера и приоритета не должны содержать букв или символов!");
                    return false;
                }
            }

            return true;
        }

        private bool ContainsSymbolOrLetter(string text)
        {
            foreach(char ch in text)
            {
                if(char.IsLetter(ch) || char.IsSymbol(ch))
                {
                    return true;
                }
            }

            return false;
        }

        private void AddNewAgent()
        {
            Agent agent = new Agent
            {
                Title = titleTextBox.Text,
                AgentTypeID = agentTypeIDComboBox.SelectedIndex + 1,
                Address = addressTextBox.Text,
                INN = iNNTextBox.Text,
                KPP = kPPTextBox.Text,
                DirectorName = directorNameTextBox.Text,
                Phone = phoneTextBox.Text,
                Email = emailTextBox.Text,
                Priority = Convert.ToInt32(priorityTextBox.Text)
            };

            if(_imagePath != null)
            {
                agent.Logo = _imagePath;
            }
            else
            {
                agent.Logo = "default.png";
            }

            Database.Agents.Add(agent);
        }

        private void SaveAgentChanges()
        {
            Agent.Title = titleTextBox.Text;
            Agent.AgentTypeID = agentTypeIDComboBox.SelectedIndex + 1;
            Agent.Address = addressTextBox.Text;
            Agent.INN = iNNTextBox.Text;
            Agent.KPP = kPPTextBox.Text;
            Agent.DirectorName = directorNameTextBox.Text;
            Agent.Phone = phoneTextBox.Text;
            Agent.Email = emailTextBox.Text;
            Agent.Priority = Convert.ToInt32(priorityTextBox.Text);

            if (_imagePath != null)
            {
                Agent.Logo = _imagePath;
            }
            else
            {
                Agent.Logo = "default.png";
            }
        }

        private void ChangeAgentLogo(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png, *.jpg, *.bmp) | *.png;*.jpg;*.bmp;",
                Title = "Выберите логотип агента",
                InitialDirectory = $@"C:\Users\{Environment.UserName}\"
            };

            DialogResult dialogResult = fileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                _imagePath = fileDialog.FileName;

                logoPictureBox.Image = new Bitmap(_imagePath);
            }
        }

        private void AddSale(object sender, EventArgs e)
        {
            if(productCountTextBox.Text == "")
            {
                MessageBox.Show("Введите кол-во проданного товара!");
                return;
            }


            bool canBeParsed = int.TryParse(productCountTextBox.Text, out int count);

            if (!canBeParsed)
            {
                MessageBox.Show("Кол-во должно состоять из цифр!");
                return;
            }

            ProductSale sale = new ProductSale();

            sale.AgentID = AgentIDforSale;
            sale.ProductID = productIDComboBox.SelectedIndex + 1;
            sale.SaleDate = dateTimePickerSale.Value;
            sale.ProductCount = count;
        }
    }
}
