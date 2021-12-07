using System;
using System.Windows.Forms;
using PoprijonokApp.Models;
using PoprijonokApp.Forms;
using System.Linq;
using System.Collections.Generic;

namespace PoprijonokApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly ModelDatabase _database = new ModelDatabase();

        private List<Agent> _tempAgents = new List<Agent>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти из приложения?",
            //    "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            DialogResult dialogResult = DialogResult.Yes;

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DeleteSelectedAgent(object sender, EventArgs e)
        {
            Agent agent = (Agent)agentBindingSource.Current;

            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить агента {agent.Title}?\n\nОтменить данное действие будет невозможно!",
                "Удаление агента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult != DialogResult.Yes) { return; }

            _database.Agents.Remove(agent);

            try
            {
                _database.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            agentBindingSource.DataSource = _database.Agents.ToList();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = _database.AgentTypes.ToList();
            agentBindingSource.DataSource = _database.Agents.ToList();

            foreach(AgentType type in _database.AgentTypes.ToList())
            {
                filterComboBox.Items.Add(type.Title);
            }
            filterComboBox.SelectedIndex = 0;
        }

        private void AddNewAgent(object sender, EventArgs e)
        {
            AddChangeAgentForm form = new AddChangeAgentForm
            {
                Database = this._database,
                AgentIDforSale = _database.Agents.Count() + 1
            };

            DialogResult dialogResult = form.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                agentBindingSource.DataSource = _database.Agents.ToList();
            }
        }

        private void ChangeSelectedAgent(object sender, EventArgs e)
        {
            AddChangeAgentForm form = new AddChangeAgentForm
            {
                Database = this._database,
                Agent = (Agent)agentBindingSource.Current
            };

            DialogResult dialogResult = form.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                agentBindingSource.DataSource = _database.Agents.ToList();
            }
        }

        private void FindText(object sender, EventArgs e)
        {
            filterComboBox.SelectedIndex = 0;

            if (findTextBox.Text == "")
            {
                agentBindingSource.DataSource = _database.Agents.ToList();
            }
            else
            {
                _tempAgents = new List<Agent>();

                foreach (Agent agent in _database.Agents.ToList())
                {
                    if (agent.Title.Contains(findTextBox.Text))
                    {
                        _tempAgents.Add(agent);
                    }
                }

                agentBindingSource.DataSource = _tempAgents;
            }
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            if(filterComboBox.SelectedIndex == 0 && _tempAgents.Count == 0)
            {
                agentBindingSource.DataSource = _database.Agents.ToList();
                return;
            }

            if (filterComboBox.SelectedIndex == 0 && _tempAgents.Count > 0)
            {
                agentBindingSource.DataSource = _tempAgents;
                return;
            }

            List<Agent> temp = new List<Agent>();

            if(_tempAgents.Count > 0)
            {
                foreach (Agent agent in _tempAgents)
                {
                    if (agent.AgentTypeID == filterComboBox.SelectedIndex)
                    {
                        temp.Add(agent);
                    }
                }
            }
            else
            {
                foreach (Agent agent in _database.Agents.ToList())
                {
                    if (agent.AgentTypeID == filterComboBox.SelectedIndex)
                    {
                        temp.Add(agent);
                    }
                }
            }

            agentBindingSource.DataSource = temp;
        }
    }
}
