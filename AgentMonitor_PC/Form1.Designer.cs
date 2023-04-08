namespace AgentMonitor_PC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Правило 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Правило 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Правило 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Привла 4");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.agentMonitorDataSet = new AgentMonitor_PC.AgentMonitorDataSet();
            this.agentMonitorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCTableAdapter = new AgentMonitor_PC.AgentMonitorDataSetTableAdapters.PCTableAdapter();
            this.pCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agentMonitorDataSet1 = new AgentMonitor_PC.AgentMonitorDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agentMonitorDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pCBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pCBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPUTableAdapter = new AgentMonitor_PC.AgentMonitorDataSetTableAdapters.CPUTableAdapter();
            this.oSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSTableAdapter = new AgentMonitor_PC.AgentMonitorDataSetTableAdapters.OSTableAdapter();
            this.pCBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pCBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pCBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.localPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localPCTableAdapter = new AgentMonitor_PC.AgentMonitorDataSetTableAdapters.LocalPCTableAdapter();
            this.pCBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localPCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(913, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о ПК";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Правила мониторинга";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(23, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 393);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // agentMonitorDataSet
            // 
            this.agentMonitorDataSet.DataSetName = "AgentMonitorDataSet";
            this.agentMonitorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentMonitorDataSetBindingSource
            // 
            this.agentMonitorDataSetBindingSource.DataSource = this.agentMonitorDataSet;
            this.agentMonitorDataSetBindingSource.Position = 0;
            // 
            // pCBindingSource
            // 
            this.pCBindingSource.DataMember = "PC";
            this.pCBindingSource.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // pCTableAdapter
            // 
            this.pCTableAdapter.ClearBeforeFill = true;
            // 
            // pCBindingSource1
            // 
            this.pCBindingSource1.DataMember = "PC";
            this.pCBindingSource1.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // agentMonitorDataSet1
            // 
            this.agentMonitorDataSet1.DataSetName = "AgentMonitorDataSet";
            this.agentMonitorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rAMDataGridViewTextBoxColumn,
            this.rOMDataGridViewTextBoxColumn,
            this.invNumberDataGridViewTextBoxColumn,
            this.localPCIDDataGridViewTextBoxColumn,
            this.cPUIDDataGridViewTextBoxColumn,
            this.oSIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pCBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 551);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // agentMonitorDataSetBindingSource1
            // 
            this.agentMonitorDataSetBindingSource1.DataSource = this.agentMonitorDataSet;
            this.agentMonitorDataSetBindingSource1.Position = 0;
            // 
            // pCBindingSource2
            // 
            this.pCBindingSource2.DataMember = "PC";
            this.pCBindingSource2.DataSource = this.agentMonitorDataSetBindingSource1;
            // 
            // pCBindingSource3
            // 
            this.pCBindingSource3.DataMember = "PC";
            this.pCBindingSource3.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataMember = "CPU";
            this.cPUBindingSource.DataSource = this.agentMonitorDataSetBindingSource1;
            // 
            // cPUTableAdapter
            // 
            this.cPUTableAdapter.ClearBeforeFill = true;
            // 
            // oSBindingSource
            // 
            this.oSBindingSource.DataMember = "OS";
            this.oSBindingSource.DataSource = this.agentMonitorDataSetBindingSource1;
            // 
            // oSTableAdapter
            // 
            this.oSTableAdapter.ClearBeforeFill = true;
            // 
            // pCBindingSource4
            // 
            this.pCBindingSource4.DataMember = "PC";
            this.pCBindingSource4.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // pCBindingSource5
            // 
            this.pCBindingSource5.DataMember = "PC";
            this.pCBindingSource5.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // pCBindingSource6
            // 
            this.pCBindingSource6.DataMember = "PC";
            this.pCBindingSource6.DataSource = this.agentMonitorDataSetBindingSource1;
            // 
            // localPCBindingSource
            // 
            this.localPCBindingSource.DataMember = "LocalPC";
            this.localPCBindingSource.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // localPCTableAdapter
            // 
            this.localPCTableAdapter.ClearBeforeFill = true;
            // 
            // pCBindingSource7
            // 
            this.pCBindingSource7.DataMember = "PC";
            this.pCBindingSource7.DataSource = this.agentMonitorDataSetBindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rAMDataGridViewTextBoxColumn
            // 
            this.rAMDataGridViewTextBoxColumn.DataPropertyName = "RAM";
            this.rAMDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.rAMDataGridViewTextBoxColumn.Name = "rAMDataGridViewTextBoxColumn";
            // 
            // rOMDataGridViewTextBoxColumn
            // 
            this.rOMDataGridViewTextBoxColumn.DataPropertyName = "ROM";
            this.rOMDataGridViewTextBoxColumn.HeaderText = "ROM";
            this.rOMDataGridViewTextBoxColumn.Name = "rOMDataGridViewTextBoxColumn";
            // 
            // invNumberDataGridViewTextBoxColumn
            // 
            this.invNumberDataGridViewTextBoxColumn.DataPropertyName = "invNumber";
            this.invNumberDataGridViewTextBoxColumn.HeaderText = "invNumber";
            this.invNumberDataGridViewTextBoxColumn.Name = "invNumberDataGridViewTextBoxColumn";
            // 
            // localPCIDDataGridViewTextBoxColumn
            // 
            this.localPCIDDataGridViewTextBoxColumn.DataPropertyName = "LocalPCID";
            this.localPCIDDataGridViewTextBoxColumn.HeaderText = "LocalPCID";
            this.localPCIDDataGridViewTextBoxColumn.Name = "localPCIDDataGridViewTextBoxColumn";
            // 
            // cPUIDDataGridViewTextBoxColumn
            // 
            this.cPUIDDataGridViewTextBoxColumn.DataPropertyName = "CPUID";
            this.cPUIDDataGridViewTextBoxColumn.HeaderText = "CPUID";
            this.cPUIDDataGridViewTextBoxColumn.Name = "cPUIDDataGridViewTextBoxColumn";
            // 
            // oSIDDataGridViewTextBoxColumn
            // 
            this.oSIDDataGridViewTextBoxColumn.DataPropertyName = "OSID";
            this.oSIDDataGridViewTextBoxColumn.HeaderText = "OSID";
            this.oSIDDataGridViewTextBoxColumn.Name = "oSIDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agent Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMonitorDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.BindingSource agentMonitorDataSetBindingSource;
        private AgentMonitorDataSet agentMonitorDataSet;
        private System.Windows.Forms.BindingSource pCBindingSource;
        private AgentMonitorDataSetTableAdapters.PCTableAdapter pCTableAdapter;
        private System.Windows.Forms.BindingSource pCBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pCBindingSource2;
        private System.Windows.Forms.BindingSource agentMonitorDataSetBindingSource1;
        private AgentMonitorDataSet agentMonitorDataSet1;
        private System.Windows.Forms.BindingSource pCBindingSource3;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private AgentMonitorDataSetTableAdapters.CPUTableAdapter cPUTableAdapter;
        private System.Windows.Forms.BindingSource oSBindingSource;
        private AgentMonitorDataSetTableAdapters.OSTableAdapter oSTableAdapter;
        private System.Windows.Forms.BindingSource pCBindingSource5;
        private System.Windows.Forms.BindingSource pCBindingSource4;
        private System.Windows.Forms.BindingSource pCBindingSource6;
        private System.Windows.Forms.BindingSource localPCBindingSource;
        private AgentMonitorDataSetTableAdapters.LocalPCTableAdapter localPCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localPCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pCBindingSource7;
    }
}

