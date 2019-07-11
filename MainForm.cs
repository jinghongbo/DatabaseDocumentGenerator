using DatabaseDocumentGenerator.Connections;
using DatabaseDocumentGenerator.Engines;
using DatabaseDocumentGenerator.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDocumentGenerator
{
    public partial class MainForm : Form
    {
        public IConnection Connection { get; set; }
        public IEngine Engine { get; set; }
        public ITemplate Template { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxConnectionType.DataSource = Assembly.GetEntryAssembly().GetTypes()
                .Where(t => typeof(IConnection).IsAssignableFrom(t) && t.IsClass).ToList();
            comboBoxConnectionType.DisplayMember = "Name";

            comboBoxGenerationEngineType.DataSource = Assembly.GetEntryAssembly().GetTypes()
                .Where(t => typeof(IEngine).IsAssignableFrom(t) && t.IsClass).ToList();
            comboBoxGenerationEngineType.DisplayMember = "Name";

            comboBoxGenerationTemplateType.DataSource = Assembly.GetEntryAssembly().GetTypes()
                .Where(t => typeof(ITemplate).IsAssignableFrom(t) && t.IsClass).ToList();
            comboBoxGenerationTemplateType.DisplayMember = "Name";



        }

        private void Generate(object sender, EventArgs e)
        {

        }

        private void Connection_Selected(object sender, EventArgs e)
        {
            var type = this.comboBoxConnectionType.SelectedItem as Type;
            if (type != null && typeof(IConnection).IsAssignableFrom(type))
            {
                Connection = Activator.CreateInstance(type) as IConnection;
            }
        }

        private void Engine_Selected(object sender, EventArgs e)
        {
            var type = this.comboBoxGenerationEngineType.SelectedItem as Type;
            if (type != null && typeof(IEngine).IsAssignableFrom(type))
            {
                Engine = Activator.CreateInstance(type) as IEngine;
            }
        }

        private void Template_Selected(object sender, EventArgs e)
        {
            var type = this.comboBoxGenerationTemplateType.SelectedItem as Type;
            if (type != null && typeof(ITemplate).IsAssignableFrom(type))
            {
                Template = Activator.CreateInstance(type) as ITemplate;
            }
        }
    }
}
