using System;
using System.Drawing;
using System.Windows.Forms;

namespace Resources_Monitoring
{
    public partial class MainForm : Form
    {
        private bool start_stop;
        private int i = 1;

        private LogControl logControl = new LogControl();
        private Serialize serialize = new Serialize();
        private StateSettings state = new StateSettings();
        InfoCpu infoCpu = new InfoCpu();
        InfoRam infoRam = new InfoRam();
        LogData logDataCpu = new LogData();
        LogData logDataRam = new LogData();

        public MainForm()
        {
            InitializeComponent();
            state = state.restoreSettings();
            
            labelCpuName.Text = infoCpu.getСpuName();
            labelCpuClockSpeed.Text = infoCpu.getCpuClockSpeed();
            labelCpuCores.Text = infoCpu.getCpuCores();
            labelCpuSockets.Text = infoCpu.getCpuSocket();
            labelCpuProc.Text = infoCpu.getCpuLogicProcesses();
            labelCpuVirtualisation.Text = infoCpu.getCpuVirtualisation();

            labelRamName.Text = infoRam.getRamName();
            labelRamCountOfSockets.Text = infoRam.getRamCountOfSockets();
            labelRamClockSpeed.Text = infoRam.getRamClockSpeed();
            labelRamFormFactor.Text = infoRam.getRamFormFactor();
        }

        //обновление таблицы DataGridView
        private void updateDataGrid(LogData logItem, DataGridView dg)
        {
            dg.Rows.Add();
            dg.Rows[dg.Rows.Count - 1].Cells[0].Value = i;
            dg.Rows[dg.Rows.Count - 1].Cells[1].Value = logItem.value;
            dg.Rows[dg.Rows.Count - 1].Cells[2].Value = logItem.date;
        }

        private void updateChart(LogData logItem, System.Windows.Forms.DataVisualization.Charting.Chart chart, System.Windows.Forms.Label label)
        {
            chart.Series["Series1"].Points.AddXY(i, logItem.value);
            label.Text = logItem.value.ToString() + '%';
            if (i > chart.ChartAreas[0].AxisX.ScaleView.Size)//начать скролл при выходе за границу
                chart.ChartAreas[0].AxisX.ScaleView.Scroll(i + 1);//скролл
        }

        //таймер
        private void timer1_Tick(object sender, EventArgs e)//тик таймера
        {
            LogData logDataCpu = logControl.getCpuLoad();
            LogData logDataRam = logControl.getRamLoad();
            updateChart(logDataCpu, chartCPULoad, labelCpuLoad);
            updateChart(logDataRam, chartRamLoad, labelRamLoad);
            updateDataGrid(logDataCpu, dataGridViewCpuLoad);
            updateDataGrid(logDataRam, dataGridViewRamLoad);
            labelRamLoadCapacity.Text = (Math.Round((infoRam.getRamCapacity() * logDataRam.value / 100000000000), 2) + "/" + Math.Round(infoRam.getRamCapacity() / 1000000000, 2) + "Гб.").ToString();
            serialize.deleteLogs(logControl);
            i++;
        }

        private void Form1_Load(object sender, EventArgs e)//загрузка формы
        {
            settingViewOfChart(chartRamLoad);
            settingViewOfChart(chartCPULoad);
            timer.Start();
            start_stop = true;
        }

        //настройка chart`ов
        private void settingViewOfChart(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series["Series1"].Color = Color.FromArgb(200, Color.FromArgb(state.getColor()));
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;//скрол над цифрами
            chart.ChartAreas[0].AxisX.ScaleView.Size = 60;//размер скрола
            chart.ChartAreas[0].AxisY.ScaleView.Size = 100;//размер скрола
            chart.ChartAreas[0].AxisY.Interval = 25;
            chart.ChartAreas[0].AxisX.Interval = 5;
            chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.ResetZoom;//только полоса
            chart.ChartAreas[0].AxisX.ScrollBar.BackColor = Color.White; //цвета
            chart.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.FromArgb(state.getColor()); //цвета
            chart.ChartAreas[0].AxisX.ScaleView.Scroll(chartCPULoad.ChartAreas[0].AxisX.Maximum);
        }

        private void buttonPauseResume_Click(object sender, EventArgs e)
        {
            toolStripButtonPauseResume.CheckOnClick = true;
            if (start_stop == true)
            {
                timer.Stop();
                start_stop = false;
                toolStripButtonPauseResume.Image = global::Resources_Monitoring.Properties.Resources.play;
                toolStripLabelPauseResume.Text = "Resume";
            }
            else
            {
                timer.Start();
                start_stop = true;
                toolStripLabelPauseResume.Text = "Pause";
                toolStripButtonPauseResume.Image = global::Resources_Monitoring.Properties.Resources.pause;
            }
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                chartCPULoad.Series["Series1"].Color = Color.FromArgb(200, colorDialog.Color);
                chartRamLoad.Series["Series1"].Color = Color.FromArgb(200, colorDialog.Color);
                
                chartCPULoad.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.FromArgb(200, colorDialog.Color); //цвета
                chartRamLoad.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.FromArgb(200, colorDialog.Color); //цвета
                
                state.setColor((colorDialog.Color).ToArgb());
                state.saveSettings();
            }
        }

        private void toolStripButtonSetLogFileSize_Click(object sender, EventArgs e)
        {
            FormSetLogFileSize formSetLogFileSize = new FormSetLogFileSize(state);
            formSetLogFileSize.ShowDialog();
            state.setFileSize(formSetLogFileSize.state.getFileSize());
        }

        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Програма предназначена для мониторинга производительности компонентов компьютера.\n\nВыполнил студент группы 535А ХАИ\nМартыненко Антон Александрович\nПочта: \nunpopularfrpg798@gmail.com",
                "О програме", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}