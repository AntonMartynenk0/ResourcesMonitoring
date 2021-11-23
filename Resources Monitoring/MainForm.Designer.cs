
namespace Resources_Monitoring
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCpu = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCpuName = new System.Windows.Forms.Label();
            this.dataGridViewCpuLoad = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCpuVirtualisation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCpuProc = new System.Windows.Forms.Label();
            this.labelCpuCores = new System.Windows.Forms.Label();
            this.labelCpuSockets = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCpuClockSpeed = new System.Windows.Forms.Label();
            this.labelCpuLoad = new System.Windows.Forms.Label();
            this.chartCPULoad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageRam = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelRamName = new System.Windows.Forms.Label();
            this.labelRamFormFactor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelRamClockSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelRamCountOfSockets = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelRamLoadCapacity = new System.Windows.Forms.Label();
            this.labelRamLoad = new System.Windows.Forms.Label();
            this.dataGridViewRamLoad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRamLoad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelPauseResume = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonPauseResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonChangeColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelSetSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSetLogFileSize = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.tabPageCpu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCpuLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPULoad)).BeginInit();
            this.tabPageRam.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRamLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRamLoad)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCpu);
            this.tabControl.Controls.Add(this.tabPageRam);
            this.tabControl.Location = new System.Drawing.Point(22, 30);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1164, 655);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCpu
            // 
            this.tabPageCpu.Controls.Add(this.panel2);
            this.tabPageCpu.Controls.Add(this.dataGridViewCpuLoad);
            this.tabPageCpu.Controls.Add(this.labelCpuVirtualisation);
            this.tabPageCpu.Controls.Add(this.label11);
            this.tabPageCpu.Controls.Add(this.labelCpuProc);
            this.tabPageCpu.Controls.Add(this.labelCpuCores);
            this.tabPageCpu.Controls.Add(this.labelCpuSockets);
            this.tabPageCpu.Controls.Add(this.label7);
            this.tabPageCpu.Controls.Add(this.label6);
            this.tabPageCpu.Controls.Add(this.label4);
            this.tabPageCpu.Controls.Add(this.label1);
            this.tabPageCpu.Controls.Add(this.label5);
            this.tabPageCpu.Controls.Add(this.labelCpuClockSpeed);
            this.tabPageCpu.Controls.Add(this.labelCpuLoad);
            this.tabPageCpu.Controls.Add(this.chartCPULoad);
            this.tabPageCpu.Location = new System.Drawing.Point(4, 29);
            this.tabPageCpu.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageCpu.Name = "tabPageCpu";
            this.tabPageCpu.Padding = new System.Windows.Forms.Padding(5);
            this.tabPageCpu.Size = new System.Drawing.Size(1156, 622);
            this.tabPageCpu.TabIndex = 0;
            this.tabPageCpu.Text = "ЦП";
            this.tabPageCpu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelCpuName);
            this.panel2.Location = new System.Drawing.Point(8, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 94);
            this.panel2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЦП";
            // 
            // labelCpuName
            // 
            this.labelCpuName.AutoSize = true;
            this.labelCpuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCpuName.Location = new System.Drawing.Point(69, 0);
            this.labelCpuName.Name = "labelCpuName";
            this.labelCpuName.Size = new System.Drawing.Size(312, 31);
            this.labelCpuName.TabIndex = 3;
            this.labelCpuName.Text = "Название процессора";
            // 
            // dataGridViewCpuLoad
            // 
            this.dataGridViewCpuLoad.AllowUserToAddRows = false;
            this.dataGridViewCpuLoad.AllowUserToDeleteRows = false;
            this.dataGridViewCpuLoad.AllowUserToResizeColumns = false;
            this.dataGridViewCpuLoad.AllowUserToResizeRows = false;
            this.dataGridViewCpuLoad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCpuLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCpuLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnValue,
            this.ColumnDate});
            this.dataGridViewCpuLoad.Location = new System.Drawing.Point(872, 8);
            this.dataGridViewCpuLoad.Name = "dataGridViewCpuLoad";
            this.dataGridViewCpuLoad.RowHeadersVisible = false;
            this.dataGridViewCpuLoad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewCpuLoad.Size = new System.Drawing.Size(276, 606);
            this.dataGridViewCpuLoad.TabIndex = 22;
            // 
            // ColumnNum
            // 
            this.ColumnNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNum.Frozen = true;
            this.ColumnNum.HeaderText = "№";
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.ReadOnly = true;
            this.ColumnNum.Width = 49;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnValue.Frozen = true;
            this.ColumnValue.HeaderText = "Load";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Width = 70;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnDate.Frozen = true;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 69;
            // 
            // labelCpuVirtualisation
            // 
            this.labelCpuVirtualisation.AutoSize = true;
            this.labelCpuVirtualisation.Location = new System.Drawing.Point(218, 597);
            this.labelCpuVirtualisation.Name = "labelCpuVirtualisation";
            this.labelCpuVirtualisation.Size = new System.Drawing.Size(162, 20);
            this.labelCpuVirtualisation.TabIndex = 20;
            this.labelCpuVirtualisation.Text = "labelCpuVirtualisation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 597);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Виртуализация";
            // 
            // labelCpuProc
            // 
            this.labelCpuProc.AutoSize = true;
            this.labelCpuProc.Location = new System.Drawing.Point(218, 577);
            this.labelCpuProc.Name = "labelCpuProc";
            this.labelCpuProc.Size = new System.Drawing.Size(103, 20);
            this.labelCpuProc.TabIndex = 15;
            this.labelCpuProc.Text = "labelCpuProc";
            // 
            // labelCpuCores
            // 
            this.labelCpuCores.AutoSize = true;
            this.labelCpuCores.Location = new System.Drawing.Point(218, 557);
            this.labelCpuCores.Name = "labelCpuCores";
            this.labelCpuCores.Size = new System.Drawing.Size(113, 20);
            this.labelCpuCores.TabIndex = 14;
            this.labelCpuCores.Text = "labelCpuCores";
            // 
            // labelCpuSockets
            // 
            this.labelCpuSockets.AutoSize = true;
            this.labelCpuSockets.Location = new System.Drawing.Point(218, 537);
            this.labelCpuSockets.Name = "labelCpuSockets";
            this.labelCpuSockets.Size = new System.Drawing.Size(129, 20);
            this.labelCpuSockets.TabIndex = 13;
            this.labelCpuSockets.Text = "labelCpuSockets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Логических процессоров:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ядра:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сокет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Базовая скорость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Используется:";
            // 
            // labelCpuClockSpeed
            // 
            this.labelCpuClockSpeed.AutoSize = true;
            this.labelCpuClockSpeed.Location = new System.Drawing.Point(218, 517);
            this.labelCpuClockSpeed.Name = "labelCpuClockSpeed";
            this.labelCpuClockSpeed.Size = new System.Drawing.Size(157, 20);
            this.labelCpuClockSpeed.TabIndex = 4;
            this.labelCpuClockSpeed.Text = "labelCpuClockSpeed";
            // 
            // labelCpuLoad
            // 
            this.labelCpuLoad.AutoSize = true;
            this.labelCpuLoad.Location = new System.Drawing.Point(218, 497);
            this.labelCpuLoad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCpuLoad.Name = "labelCpuLoad";
            this.labelCpuLoad.Size = new System.Drawing.Size(107, 20);
            this.labelCpuLoad.TabIndex = 1;
            this.labelCpuLoad.Text = "labelCpuLoad";
            // 
            // chartCPULoad
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCPULoad.ChartAreas.Add(chartArea1);
            this.chartCPULoad.Location = new System.Drawing.Point(-37, -5);
            this.chartCPULoad.Margin = new System.Windows.Forms.Padding(5);
            this.chartCPULoad.Name = "chartCPULoad";
            this.chartCPULoad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPULoad.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartCPULoad.Series.Add(series1);
            this.chartCPULoad.Size = new System.Drawing.Size(928, 397);
            this.chartCPULoad.TabIndex = 0;
            this.chartCPULoad.Text = "chart1";
            // 
            // tabPageRam
            // 
            this.tabPageRam.Controls.Add(this.panel1);
            this.tabPageRam.Controls.Add(this.labelRamFormFactor);
            this.tabPageRam.Controls.Add(this.label13);
            this.tabPageRam.Controls.Add(this.labelRamClockSpeed);
            this.tabPageRam.Controls.Add(this.label9);
            this.tabPageRam.Controls.Add(this.labelRamCountOfSockets);
            this.tabPageRam.Controls.Add(this.label8);
            this.tabPageRam.Controls.Add(this.label24);
            this.tabPageRam.Controls.Add(this.labelRamLoadCapacity);
            this.tabPageRam.Controls.Add(this.labelRamLoad);
            this.tabPageRam.Controls.Add(this.dataGridViewRamLoad);
            this.tabPageRam.Controls.Add(this.chartRamLoad);
            this.tabPageRam.Location = new System.Drawing.Point(4, 29);
            this.tabPageRam.Margin = new System.Windows.Forms.Padding(5);
            this.tabPageRam.Name = "tabPageRam";
            this.tabPageRam.Padding = new System.Windows.Forms.Padding(5);
            this.tabPageRam.Size = new System.Drawing.Size(1156, 622);
            this.tabPageRam.TabIndex = 1;
            this.tabPageRam.Text = "ОЗУ";
            this.tabPageRam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labelRamName);
            this.panel1.Location = new System.Drawing.Point(8, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 114);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 31);
            this.label12.TabIndex = 30;
            this.label12.Text = "ОЗУ";
            // 
            // labelRamName
            // 
            this.labelRamName.AutoSize = true;
            this.labelRamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRamName.Location = new System.Drawing.Point(85, 0);
            this.labelRamName.Name = "labelRamName";
            this.labelRamName.Size = new System.Drawing.Size(250, 31);
            this.labelRamName.TabIndex = 31;
            this.labelRamName.Text = "Название памяти";
            // 
            // labelRamFormFactor
            // 
            this.labelRamFormFactor.AutoSize = true;
            this.labelRamFormFactor.Location = new System.Drawing.Point(214, 597);
            this.labelRamFormFactor.Name = "labelRamFormFactor";
            this.labelRamFormFactor.Size = new System.Drawing.Size(159, 20);
            this.labelRamFormFactor.TabIndex = 54;
            this.labelRamFormFactor.Text = "labelRamFormFactor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 597);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Форм-фактор:";
            // 
            // labelRamClockSpeed
            // 
            this.labelRamClockSpeed.AutoSize = true;
            this.labelRamClockSpeed.Location = new System.Drawing.Point(214, 557);
            this.labelRamClockSpeed.Name = "labelRamClockSpeed";
            this.labelRamClockSpeed.Size = new System.Drawing.Size(162, 20);
            this.labelRamClockSpeed.TabIndex = 52;
            this.labelRamClockSpeed.Text = "labelRamClockSpeed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Скорость:";
            // 
            // labelRamCountOfSockets
            // 
            this.labelRamCountOfSockets.AutoSize = true;
            this.labelRamCountOfSockets.Location = new System.Drawing.Point(214, 577);
            this.labelRamCountOfSockets.Name = "labelRamCountOfSockets";
            this.labelRamCountOfSockets.Size = new System.Drawing.Size(194, 20);
            this.labelRamCountOfSockets.TabIndex = 50;
            this.labelRamCountOfSockets.Text = "labelRamCountOfSockets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Использовано гнезд:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 517);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 20);
            this.label24.TabIndex = 34;
            this.label24.Text = "Используется:";
            // 
            // labelRamLoadCapacity
            // 
            this.labelRamLoadCapacity.AutoSize = true;
            this.labelRamLoadCapacity.Location = new System.Drawing.Point(214, 537);
            this.labelRamLoadCapacity.Name = "labelRamLoadCapacity";
            this.labelRamLoadCapacity.Size = new System.Drawing.Size(173, 20);
            this.labelRamLoadCapacity.TabIndex = 33;
            this.labelRamLoadCapacity.Text = "labelRamLoadCapacity";
            // 
            // labelRamLoad
            // 
            this.labelRamLoad.AutoSize = true;
            this.labelRamLoad.Location = new System.Drawing.Point(214, 517);
            this.labelRamLoad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRamLoad.Name = "labelRamLoad";
            this.labelRamLoad.Size = new System.Drawing.Size(112, 20);
            this.labelRamLoad.TabIndex = 32;
            this.labelRamLoad.Text = "labelRamLoad";
            // 
            // dataGridViewRamLoad
            // 
            this.dataGridViewRamLoad.AllowUserToAddRows = false;
            this.dataGridViewRamLoad.AllowUserToDeleteRows = false;
            this.dataGridViewRamLoad.AllowUserToResizeColumns = false;
            this.dataGridViewRamLoad.AllowUserToResizeRows = false;
            this.dataGridViewRamLoad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRamLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRamLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewRamLoad.Location = new System.Drawing.Point(872, 8);
            this.dataGridViewRamLoad.Name = "dataGridViewRamLoad";
            this.dataGridViewRamLoad.RowHeadersVisible = false;
            this.dataGridViewRamLoad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewRamLoad.Size = new System.Drawing.Size(276, 606);
            this.dataGridViewRamLoad.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Load";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // chartRamLoad
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRamLoad.ChartAreas.Add(chartArea2);
            this.chartRamLoad.Location = new System.Drawing.Point(-37, -5);
            this.chartRamLoad.Margin = new System.Windows.Forms.Padding(5);
            this.chartRamLoad.Name = "chartRamLoad";
            this.chartRamLoad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRamLoad.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartRamLoad.Series.Add(series2);
            this.chartRamLoad.Size = new System.Drawing.Size(928, 397);
            this.chartRamLoad.TabIndex = 28;
            this.chartRamLoad.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelPauseResume,
            this.toolStripButtonPauseResume,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripButtonChangeColor,
            this.toolStripSeparator2,
            this.toolStripLabelSetSize,
            this.toolStripButtonSetLogFileSize});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabelPauseResume
            // 
            this.toolStripLabelPauseResume.Name = "toolStripLabelPauseResume";
            this.toolStripLabelPauseResume.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabelPauseResume.Text = "Pause";
            this.toolStripLabelPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            // 
            // toolStripButtonPauseResume
            // 
            this.toolStripButtonPauseResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPauseResume.Image = global::Resources_Monitoring.Properties.Resources.pause;
            this.toolStripButtonPauseResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPauseResume.Name = "toolStripButtonPauseResume";
            this.toolStripButtonPauseResume.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPauseResume.Text = "toolStripButton1";
            this.toolStripButtonPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "Color";
            this.toolStripLabel2.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // toolStripButtonChangeColor
            // 
            this.toolStripButtonChangeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChangeColor.Image = global::Resources_Monitoring.Properties.Resources.color;
            this.toolStripButtonChangeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangeColor.Name = "toolStripButtonChangeColor";
            this.toolStripButtonChangeColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonChangeColor.Text = "toolStripButton2";
            this.toolStripButtonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelSetSize
            // 
            this.toolStripLabelSetSize.Name = "toolStripLabelSetSize";
            this.toolStripLabelSetSize.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabelSetSize.Text = "Log File Size";
            this.toolStripLabelSetSize.Click += new System.EventHandler(this.toolStripButtonSetLogFileSize_Click);
            // 
            // toolStripButtonSetLogFileSize
            // 
            this.toolStripButtonSetLogFileSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetLogFileSize.Image = global::Resources_Monitoring.Properties.Resources.settings;
            this.toolStripButtonSetLogFileSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetLogFileSize.Name = "toolStripButtonSetLogFileSize";
            this.toolStripButtonSetLogFileSize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSetLogFileSize.Text = "toolStripButton3";
            this.toolStripButtonSetLogFileSize.Click += new System.EventHandler(this.toolStripButtonSetLogFileSize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 690);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageCpu.ResumeLayout(false);
            this.tabPageCpu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCpuLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPULoad)).EndInit();
            this.tabPageRam.ResumeLayout(false);
            this.tabPageRam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRamLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRamLoad)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCpu;
        private System.Windows.Forms.TabPage tabPageRam;
        private System.Windows.Forms.Label labelCpuLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPULoad;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCpuName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCpuClockSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCpuProc;
        private System.Windows.Forms.Label labelCpuCores;
        private System.Windows.Forms.Label labelCpuSockets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCpuVirtualisation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.DataGridView dataGridViewCpuLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRamLoad;
        private System.Windows.Forms.DataGridView dataGridViewRamLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelRamLoadCapacity;
        private System.Windows.Forms.Label labelRamLoad;
        private System.Windows.Forms.Label labelRamName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelRamCountOfSockets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRamClockSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelRamFormFactor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonPauseResume;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangeColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetLogFileSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPauseResume;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSetSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

