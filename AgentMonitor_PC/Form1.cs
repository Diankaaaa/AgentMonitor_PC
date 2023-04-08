using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentMonitor_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentMonitorDataSet.LocalPC". При необходимости она может быть перемещена или удалена.
            this.localPCTableAdapter.Fill(this.agentMonitorDataSet.LocalPC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentMonitorDataSet.OS". При необходимости она может быть перемещена или удалена.
            this.oSTableAdapter.Fill(this.agentMonitorDataSet.OS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentMonitorDataSet.CPU". При необходимости она может быть перемещена или удалена.
            this.cPUTableAdapter.Fill(this.agentMonitorDataSet.CPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentMonitorDataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.agentMonitorDataSet.PC);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
