
namespace ComplexSystemInfo
{
    partial class ComplexSystemInfoForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplexSystemInfoForm));
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.SystemInfoPage = new MetroFramework.Controls.MetroTabPage();
            this.GPU_Label2 = new System.Windows.Forms.Label();
            this.GPU_Label1 = new System.Windows.Forms.Label();
            this.HDD_Label2 = new System.Windows.Forms.Label();
            this.HDD_Label = new System.Windows.Forms.Label();
            this.RamLabel2 = new System.Windows.Forms.Label();
            this.RamLabel = new System.Windows.Forms.Label();
            this.ProcLabel2 = new System.Windows.Forms.Label();
            this.ProcLabel = new System.Windows.Forms.Label();
            this.LoadPage = new MetroFramework.Controls.MetroTabPage();
            this.RAM_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HDD_Cap2 = new System.Windows.Forms.Label();
            this.HDD_Cap1 = new System.Windows.Forms.Label();
            this.RAM_Load_2 = new System.Windows.Forms.Label();
            this.RAM_Load_1 = new System.Windows.Forms.Label();
            this.PROC_Load_2 = new System.Windows.Forms.Label();
            this.PROC_Load_1 = new System.Windows.Forms.Label();
            this.TaskManagerPage = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.завершитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьДеревоПроцессовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Update = new System.Windows.Forms.ToolStripButton();
            this.Stop = new System.Windows.Forms.ToolStripButton();
            this.StopTree = new System.Windows.Forms.ToolStripButton();
            this.AutoUpdateButton = new System.Windows.Forms.ToolStripButton();
            this.ViewPage = new MetroFramework.Controls.MetroTabPage();
            this.macCB = new MetroFramework.Controls.MetroComboBox();
            this.Update_Resourses_Timer = new System.Windows.Forms.Timer(this.components);
            this.Update_TaskManager = new System.Windows.Forms.Timer(this.components);
            this.ViewGPULabel_2 = new System.Windows.Forms.Label();
            this.ViewGPULabel_1 = new System.Windows.Forms.Label();
            this.ViewHDDLabel_2 = new System.Windows.Forms.Label();
            this.ViewHDDLabel_1 = new System.Windows.Forms.Label();
            this.ViewRamLabel_2 = new System.Windows.Forms.Label();
            this.ViewRamLabel_1 = new System.Windows.Forms.Label();
            this.ViewProcLabel_2 = new System.Windows.Forms.Label();
            this.ViewProcLabel_1 = new System.Windows.Forms.Label();
            this.metroTabControl.SuspendLayout();
            this.SystemInfoPage.SuspendLayout();
            this.LoadPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_Chart)).BeginInit();
            this.TaskManagerPage.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ViewPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl.Controls.Add(this.SystemInfoPage);
            this.metroTabControl.Controls.Add(this.LoadPage);
            this.metroTabControl.Controls.Add(this.TaskManagerPage);
            this.metroTabControl.Controls.Add(this.ViewPage);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Multiline = true;
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 3;
            this.metroTabControl.Size = new System.Drawing.Size(784, 511);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            // 
            // SystemInfoPage
            // 
            this.SystemInfoPage.AutoScroll = true;
            this.SystemInfoPage.BackColor = System.Drawing.Color.Transparent;
            this.SystemInfoPage.Controls.Add(this.GPU_Label2);
            this.SystemInfoPage.Controls.Add(this.GPU_Label1);
            this.SystemInfoPage.Controls.Add(this.HDD_Label2);
            this.SystemInfoPage.Controls.Add(this.HDD_Label);
            this.SystemInfoPage.Controls.Add(this.RamLabel2);
            this.SystemInfoPage.Controls.Add(this.RamLabel);
            this.SystemInfoPage.Controls.Add(this.ProcLabel2);
            this.SystemInfoPage.Controls.Add(this.ProcLabel);
            this.SystemInfoPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SystemInfoPage.HorizontalScrollbar = true;
            this.SystemInfoPage.HorizontalScrollbarBarColor = true;
            this.SystemInfoPage.HorizontalScrollbarHighlightOnWheel = false;
            this.SystemInfoPage.HorizontalScrollbarSize = 10;
            this.SystemInfoPage.Location = new System.Drawing.Point(4, 41);
            this.SystemInfoPage.Name = "SystemInfoPage";
            this.SystemInfoPage.Size = new System.Drawing.Size(776, 466);
            this.SystemInfoPage.Style = MetroFramework.MetroColorStyle.Black;
            this.SystemInfoPage.TabIndex = 0;
            this.SystemInfoPage.Text = "Информация о системе";
            this.SystemInfoPage.VerticalScrollbar = true;
            this.SystemInfoPage.VerticalScrollbarBarColor = true;
            this.SystemInfoPage.VerticalScrollbarHighlightOnWheel = false;
            this.SystemInfoPage.VerticalScrollbarSize = 10;
            // 
            // GPU_Label2
            // 
            this.GPU_Label2.AutoSize = true;
            this.GPU_Label2.BackColor = System.Drawing.Color.Transparent;
            this.GPU_Label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPU_Label2.ForeColor = System.Drawing.Color.Black;
            this.GPU_Label2.Location = new System.Drawing.Point(8, 217);
            this.GPU_Label2.Name = "GPU_Label2";
            this.GPU_Label2.Size = new System.Drawing.Size(84, 17);
            this.GPU_Label2.TabIndex = 9;
            this.GPU_Label2.Text = "GPU_LABEL";
            // 
            // GPU_Label1
            // 
            this.GPU_Label1.AutoSize = true;
            this.GPU_Label1.BackColor = System.Drawing.Color.Transparent;
            this.GPU_Label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPU_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.GPU_Label1.Location = new System.Drawing.Point(8, 183);
            this.GPU_Label1.Name = "GPU_Label1";
            this.GPU_Label1.Size = new System.Drawing.Size(89, 17);
            this.GPU_Label1.TabIndex = 8;
            this.GPU_Label1.Text = "Видеокарта";
            // 
            // HDD_Label2
            // 
            this.HDD_Label2.AutoSize = true;
            this.HDD_Label2.BackColor = System.Drawing.Color.Transparent;
            this.HDD_Label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDD_Label2.ForeColor = System.Drawing.Color.Black;
            this.HDD_Label2.Location = new System.Drawing.Point(8, 152);
            this.HDD_Label2.Name = "HDD_Label2";
            this.HDD_Label2.Size = new System.Drawing.Size(84, 17);
            this.HDD_Label2.TabIndex = 7;
            this.HDD_Label2.Text = "HDD_LABEL";
            // 
            // HDD_Label
            // 
            this.HDD_Label.AutoSize = true;
            this.HDD_Label.BackColor = System.Drawing.Color.Transparent;
            this.HDD_Label.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDD_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.HDD_Label.Location = new System.Drawing.Point(8, 120);
            this.HDD_Label.Name = "HDD_Label";
            this.HDD_Label.Size = new System.Drawing.Size(103, 17);
            this.HDD_Label.TabIndex = 6;
            this.HDD_Label.Text = "Жесткий диск";
            // 
            // RamLabel2
            // 
            this.RamLabel2.AutoSize = true;
            this.RamLabel2.BackColor = System.Drawing.Color.Transparent;
            this.RamLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RamLabel2.ForeColor = System.Drawing.Color.Black;
            this.RamLabel2.Location = new System.Drawing.Point(8, 90);
            this.RamLabel2.Name = "RamLabel2";
            this.RamLabel2.Size = new System.Drawing.Size(86, 17);
            this.RamLabel2.TabIndex = 5;
            this.RamLabel2.Text = "RAM_LABEL";
            // 
            // RamLabel
            // 
            this.RamLabel.AutoSize = true;
            this.RamLabel.BackColor = System.Drawing.Color.Transparent;
            this.RamLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.RamLabel.Location = new System.Drawing.Point(8, 64);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(150, 17);
            this.RamLabel.TabIndex = 4;
            this.RamLabel.Text = "Оперативная память";
            // 
            // ProcLabel2
            // 
            this.ProcLabel2.AutoSize = true;
            this.ProcLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcLabel2.ForeColor = System.Drawing.Color.Black;
            this.ProcLabel2.Location = new System.Drawing.Point(8, 36);
            this.ProcLabel2.Name = "ProcLabel2";
            this.ProcLabel2.Size = new System.Drawing.Size(93, 17);
            this.ProcLabel2.TabIndex = 3;
            this.ProcLabel2.Text = "PROC_LABEL";
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.ProcLabel.Location = new System.Drawing.Point(8, 8);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(81, 17);
            this.ProcLabel.TabIndex = 2;
            this.ProcLabel.Text = "Процессор";
            // 
            // LoadPage
            // 
            this.LoadPage.Controls.Add(this.RAM_Chart);
            this.LoadPage.Controls.Add(this.HDD_Cap2);
            this.LoadPage.Controls.Add(this.HDD_Cap1);
            this.LoadPage.Controls.Add(this.RAM_Load_2);
            this.LoadPage.Controls.Add(this.RAM_Load_1);
            this.LoadPage.Controls.Add(this.PROC_Load_2);
            this.LoadPage.Controls.Add(this.PROC_Load_1);
            this.LoadPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadPage.HorizontalScrollbarBarColor = true;
            this.LoadPage.HorizontalScrollbarHighlightOnWheel = false;
            this.LoadPage.HorizontalScrollbarSize = 10;
            this.LoadPage.Location = new System.Drawing.Point(4, 41);
            this.LoadPage.Name = "LoadPage";
            this.LoadPage.Size = new System.Drawing.Size(775, 467);
            this.LoadPage.TabIndex = 1;
            this.LoadPage.Text = "Ресурсы ПК";
            this.LoadPage.VerticalScrollbarBarColor = true;
            this.LoadPage.VerticalScrollbarHighlightOnWheel = false;
            this.LoadPage.VerticalScrollbarSize = 10;
            // 
            // RAM_Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.RAM_Chart.ChartAreas.Add(chartArea2);
            this.RAM_Chart.Location = new System.Drawing.Point(340, 8);
            this.RAM_Chart.Name = "RAM_Chart";
            this.RAM_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.RAM_Chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.RAM_Chart.Series.Add(series2);
            this.RAM_Chart.Size = new System.Drawing.Size(256, 256);
            this.RAM_Chart.TabIndex = 9;
            this.RAM_Chart.Text = "chart1";
            // 
            // HDD_Cap2
            // 
            this.HDD_Cap2.AutoSize = true;
            this.HDD_Cap2.BackColor = System.Drawing.Color.Transparent;
            this.HDD_Cap2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDD_Cap2.ForeColor = System.Drawing.Color.Black;
            this.HDD_Cap2.Location = new System.Drawing.Point(8, 167);
            this.HDD_Cap2.Name = "HDD_Cap2";
            this.HDD_Cap2.Size = new System.Drawing.Size(118, 17);
            this.HDD_Cap2.TabIndex = 8;
            this.HDD_Cap2.Text = "HDD_CAPABILITY";
            // 
            // HDD_Cap1
            // 
            this.HDD_Cap1.AutoSize = true;
            this.HDD_Cap1.BackColor = System.Drawing.Color.Transparent;
            this.HDD_Cap1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDD_Cap1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.HDD_Cap1.Location = new System.Drawing.Point(8, 137);
            this.HDD_Cap1.Name = "HDD_Cap1";
            this.HDD_Cap1.Size = new System.Drawing.Size(116, 17);
            this.HDD_Cap1.TabIndex = 7;
            this.HDD_Cap1.Text = "Ёмкость дисков";
            // 
            // RAM_Load_2
            // 
            this.RAM_Load_2.AutoSize = true;
            this.RAM_Load_2.BackColor = System.Drawing.Color.Transparent;
            this.RAM_Load_2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_Load_2.ForeColor = System.Drawing.Color.Black;
            this.RAM_Load_2.Location = new System.Drawing.Point(8, 103);
            this.RAM_Load_2.Name = "RAM_Load_2";
            this.RAM_Load_2.Size = new System.Drawing.Size(128, 17);
            this.RAM_Load_2.TabIndex = 6;
            this.RAM_Load_2.Text = "RAM_LOAD_LABEL";
            // 
            // RAM_Load_1
            // 
            this.RAM_Load_1.AutoSize = true;
            this.RAM_Load_1.BackColor = System.Drawing.Color.Transparent;
            this.RAM_Load_1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_Load_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.RAM_Load_1.Location = new System.Drawing.Point(8, 70);
            this.RAM_Load_1.Name = "RAM_Load_1";
            this.RAM_Load_1.Size = new System.Drawing.Size(91, 17);
            this.RAM_Load_1.TabIndex = 5;
            this.RAM_Load_1.Text = "Память ОЗУ";
            // 
            // PROC_Load_2
            // 
            this.PROC_Load_2.AutoSize = true;
            this.PROC_Load_2.BackColor = System.Drawing.Color.Transparent;
            this.PROC_Load_2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PROC_Load_2.ForeColor = System.Drawing.Color.Black;
            this.PROC_Load_2.Location = new System.Drawing.Point(8, 41);
            this.PROC_Load_2.Name = "PROC_Load_2";
            this.PROC_Load_2.Size = new System.Drawing.Size(135, 17);
            this.PROC_Load_2.TabIndex = 4;
            this.PROC_Load_2.Text = "PROC_LOAD_LABEL";
            // 
            // PROC_Load_1
            // 
            this.PROC_Load_1.AutoSize = true;
            this.PROC_Load_1.BackColor = System.Drawing.Color.Transparent;
            this.PROC_Load_1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PROC_Load_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.PROC_Load_1.Location = new System.Drawing.Point(8, 11);
            this.PROC_Load_1.Name = "PROC_Load_1";
            this.PROC_Load_1.Size = new System.Drawing.Size(163, 17);
            this.PROC_Load_1.TabIndex = 3;
            this.PROC_Load_1.Text = "Нагрузка на процессор";
            // 
            // TaskManagerPage
            // 
            this.TaskManagerPage.Controls.Add(this.metroListView1);
            this.TaskManagerPage.Controls.Add(this.toolStrip1);
            this.TaskManagerPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskManagerPage.HorizontalScrollbarBarColor = true;
            this.TaskManagerPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TaskManagerPage.HorizontalScrollbarSize = 10;
            this.TaskManagerPage.Location = new System.Drawing.Point(4, 41);
            this.TaskManagerPage.Name = "TaskManagerPage";
            this.TaskManagerPage.Size = new System.Drawing.Size(776, 466);
            this.TaskManagerPage.TabIndex = 2;
            this.TaskManagerPage.Text = "Диспетчер Задач";
            this.TaskManagerPage.VerticalScrollbarBarColor = true;
            this.TaskManagerPage.VerticalScrollbarHighlightOnWheel = false;
            this.TaskManagerPage.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.Memory});
            this.metroListView1.ContextMenuStrip = this.metroContextMenu1;
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 25);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(776, 441);
            this.metroListView1.TabIndex = 4;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            this.metroListView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.metroListView1_ColumnClick);
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Название процесса";
            this.ProcessName.Width = 539;
            // 
            // Memory
            // 
            this.Memory.Text = "Память (Мегабайт)";
            this.Memory.Width = 200;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьToolStripMenuItem,
            this.завершитьДеревоПроцессовToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(239, 48);
            // 
            // завершитьToolStripMenuItem
            // 
            this.завершитьToolStripMenuItem.Name = "завершитьToolStripMenuItem";
            this.завершитьToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.завершитьToolStripMenuItem.Text = "Завершить";
            this.завершитьToolStripMenuItem.Click += new System.EventHandler(this.завершитьToolStripMenuItem_Click);
            // 
            // завершитьДеревоПроцессовToolStripMenuItem
            // 
            this.завершитьДеревоПроцессовToolStripMenuItem.Name = "завершитьДеревоПроцессовToolStripMenuItem";
            this.завершитьДеревоПроцессовToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.завершитьДеревоПроцессовToolStripMenuItem.Text = "Завершить дерево процессов";
            this.завершитьДеревоПроцессовToolStripMenuItem.Click += new System.EventHandler(this.завершитьДеревоПроцессовToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Update,
            this.Stop,
            this.StopTree,
            this.AutoUpdateButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton1.Text = "Запустить задачу";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Update
            // 
            this.Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(65, 22);
            this.Update.Text = "Обновить";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Stop
            // 
            this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(72, 22);
            this.Stop.Text = "Завершить";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // StopTree
            // 
            this.StopTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopTree.Image = ((System.Drawing.Image)(resources.GetObject("StopTree.Image")));
            this.StopTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopTree.Name = "StopTree";
            this.StopTree.Size = new System.Drawing.Size(175, 22);
            this.StopTree.Text = "Завершить дерево процессов";
            this.StopTree.Click += new System.EventHandler(this.StopTree_Click);
            // 
            // AutoUpdateButton
            // 
            this.AutoUpdateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AutoUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("AutoUpdateButton.Image")));
            this.AutoUpdateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoUpdateButton.Name = "AutoUpdateButton";
            this.AutoUpdateButton.Size = new System.Drawing.Size(138, 22);
            this.AutoUpdateButton.Text = "Автообновление: выкл";
            this.AutoUpdateButton.ToolTipText = "Автообновление: выкл";
            this.AutoUpdateButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ViewPage
            // 
            this.ViewPage.Controls.Add(this.ViewGPULabel_2);
            this.ViewPage.Controls.Add(this.ViewGPULabel_1);
            this.ViewPage.Controls.Add(this.ViewHDDLabel_2);
            this.ViewPage.Controls.Add(this.ViewHDDLabel_1);
            this.ViewPage.Controls.Add(this.ViewRamLabel_2);
            this.ViewPage.Controls.Add(this.ViewRamLabel_1);
            this.ViewPage.Controls.Add(this.ViewProcLabel_2);
            this.ViewPage.Controls.Add(this.ViewProcLabel_1);
            this.ViewPage.Controls.Add(this.macCB);
            this.ViewPage.HorizontalScrollbarBarColor = true;
            this.ViewPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ViewPage.HorizontalScrollbarSize = 10;
            this.ViewPage.Location = new System.Drawing.Point(4, 41);
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.Size = new System.Drawing.Size(776, 466);
            this.ViewPage.TabIndex = 3;
            this.ViewPage.Text = "Обзор";
            this.ViewPage.VerticalScrollbarBarColor = true;
            this.ViewPage.VerticalScrollbarHighlightOnWheel = false;
            this.ViewPage.VerticalScrollbarSize = 10;
            // 
            // macCB
            // 
            this.macCB.FormattingEnabled = true;
            this.macCB.ItemHeight = 23;
            this.macCB.Location = new System.Drawing.Point(8, 3);
            this.macCB.Name = "macCB";
            this.macCB.Size = new System.Drawing.Size(132, 29);
            this.macCB.TabIndex = 2;
            this.macCB.UseSelectable = true;
            this.macCB.SelectedIndexChanged += new System.EventHandler(this.macCB_SelectedIndexChanged);
            // 
            // Update_Resourses_Timer
            // 
            this.Update_Resourses_Timer.Enabled = true;
            this.Update_Resourses_Timer.Interval = 2000;
            this.Update_Resourses_Timer.Tick += new System.EventHandler(this.Update_Timer_Tick);
            // 
            // Update_TaskManager
            // 
            this.Update_TaskManager.Interval = 6000;
            this.Update_TaskManager.Tick += new System.EventHandler(this.Update_TaskManager_Tick);
            // 
            // ViewGPULabel_2
            // 
            this.ViewGPULabel_2.AutoSize = true;
            this.ViewGPULabel_2.BackColor = System.Drawing.Color.Transparent;
            this.ViewGPULabel_2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewGPULabel_2.ForeColor = System.Drawing.Color.Black;
            this.ViewGPULabel_2.Location = new System.Drawing.Point(5, 257);
            this.ViewGPULabel_2.Name = "ViewGPULabel_2";
            this.ViewGPULabel_2.Size = new System.Drawing.Size(84, 17);
            this.ViewGPULabel_2.TabIndex = 17;
            this.ViewGPULabel_2.Text = "GPU_LABEL";
            // 
            // ViewGPULabel_1
            // 
            this.ViewGPULabel_1.AutoSize = true;
            this.ViewGPULabel_1.BackColor = System.Drawing.Color.Transparent;
            this.ViewGPULabel_1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewGPULabel_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.ViewGPULabel_1.Location = new System.Drawing.Point(5, 223);
            this.ViewGPULabel_1.Name = "ViewGPULabel_1";
            this.ViewGPULabel_1.Size = new System.Drawing.Size(89, 17);
            this.ViewGPULabel_1.TabIndex = 16;
            this.ViewGPULabel_1.Text = "Видеокарта";
            // 
            // ViewHDDLabel_2
            // 
            this.ViewHDDLabel_2.AutoSize = true;
            this.ViewHDDLabel_2.BackColor = System.Drawing.Color.Transparent;
            this.ViewHDDLabel_2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewHDDLabel_2.ForeColor = System.Drawing.Color.Black;
            this.ViewHDDLabel_2.Location = new System.Drawing.Point(5, 192);
            this.ViewHDDLabel_2.Name = "ViewHDDLabel_2";
            this.ViewHDDLabel_2.Size = new System.Drawing.Size(84, 17);
            this.ViewHDDLabel_2.TabIndex = 15;
            this.ViewHDDLabel_2.Text = "HDD_LABEL";
            // 
            // ViewHDDLabel_1
            // 
            this.ViewHDDLabel_1.AutoSize = true;
            this.ViewHDDLabel_1.BackColor = System.Drawing.Color.Transparent;
            this.ViewHDDLabel_1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewHDDLabel_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.ViewHDDLabel_1.Location = new System.Drawing.Point(5, 160);
            this.ViewHDDLabel_1.Name = "ViewHDDLabel_1";
            this.ViewHDDLabel_1.Size = new System.Drawing.Size(103, 17);
            this.ViewHDDLabel_1.TabIndex = 14;
            this.ViewHDDLabel_1.Text = "Жесткий диск";
            // 
            // ViewRamLabel_2
            // 
            this.ViewRamLabel_2.AutoSize = true;
            this.ViewRamLabel_2.BackColor = System.Drawing.Color.Transparent;
            this.ViewRamLabel_2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewRamLabel_2.ForeColor = System.Drawing.Color.Black;
            this.ViewRamLabel_2.Location = new System.Drawing.Point(5, 130);
            this.ViewRamLabel_2.Name = "ViewRamLabel_2";
            this.ViewRamLabel_2.Size = new System.Drawing.Size(86, 17);
            this.ViewRamLabel_2.TabIndex = 13;
            this.ViewRamLabel_2.Text = "RAM_LABEL";
            // 
            // ViewRamLabel_1
            // 
            this.ViewRamLabel_1.AutoSize = true;
            this.ViewRamLabel_1.BackColor = System.Drawing.Color.Transparent;
            this.ViewRamLabel_1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewRamLabel_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.ViewRamLabel_1.Location = new System.Drawing.Point(5, 104);
            this.ViewRamLabel_1.Name = "ViewRamLabel_1";
            this.ViewRamLabel_1.Size = new System.Drawing.Size(150, 17);
            this.ViewRamLabel_1.TabIndex = 12;
            this.ViewRamLabel_1.Text = "Оперативная память";
            // 
            // ViewProcLabel_2
            // 
            this.ViewProcLabel_2.AutoSize = true;
            this.ViewProcLabel_2.BackColor = System.Drawing.Color.Transparent;
            this.ViewProcLabel_2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewProcLabel_2.ForeColor = System.Drawing.Color.Black;
            this.ViewProcLabel_2.Location = new System.Drawing.Point(5, 76);
            this.ViewProcLabel_2.Name = "ViewProcLabel_2";
            this.ViewProcLabel_2.Size = new System.Drawing.Size(93, 17);
            this.ViewProcLabel_2.TabIndex = 11;
            this.ViewProcLabel_2.Text = "PROC_LABEL";
            // 
            // ViewProcLabel_1
            // 
            this.ViewProcLabel_1.AutoSize = true;
            this.ViewProcLabel_1.BackColor = System.Drawing.Color.Transparent;
            this.ViewProcLabel_1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewProcLabel_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.ViewProcLabel_1.Location = new System.Drawing.Point(5, 48);
            this.ViewProcLabel_1.Name = "ViewProcLabel_1";
            this.ViewProcLabel_1.Size = new System.Drawing.Size(81, 17);
            this.ViewProcLabel_1.TabIndex = 10;
            this.ViewProcLabel_1.Text = "Процессор";
            // 
            // ComplexSystemInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.metroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "ComplexSystemInfoForm";
            this.Text = "Complex System Information";
            this.Load += new System.EventHandler(this.ComplexSystemInfoForm_Load);
            this.metroTabControl.ResumeLayout(false);
            this.SystemInfoPage.ResumeLayout(false);
            this.SystemInfoPage.PerformLayout();
            this.LoadPage.ResumeLayout(false);
            this.LoadPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_Chart)).EndInit();
            this.TaskManagerPage.ResumeLayout(false);
            this.TaskManagerPage.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ViewPage.ResumeLayout(false);
            this.ViewPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage SystemInfoPage;
        private MetroFramework.Controls.MetroTabPage LoadPage;
        private MetroFramework.Controls.MetroTabPage TaskManagerPage;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.Label ProcLabel2;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.Label RamLabel2;
        private System.Windows.Forms.Label HDD_Label;
        private System.Windows.Forms.Label HDD_Label2;
    private System.Windows.Forms.Label GPU_Label2;
    private System.Windows.Forms.Label GPU_Label1;
        private System.Windows.Forms.Label PROC_Load_1;
        private System.Windows.Forms.Label PROC_Load_2;
        private System.Windows.Forms.Timer Update_Resourses_Timer;
        private System.Windows.Forms.Label RAM_Load_2;
        private System.Windows.Forms.Label RAM_Load_1;
        private System.Windows.Forms.Label HDD_Cap2;
        private System.Windows.Forms.Label HDD_Cap1;
        private System.Windows.Forms.DataVisualization.Charting.Chart RAM_Chart;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private  System.Windows.Forms.ToolStripButton Update;
        private System.Windows.Forms.ToolStripButton Stop;
        private System.Windows.Forms.ToolStripButton StopTree;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader Memory;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem завершитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьДеревоПроцессовToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer Update_TaskManager;
        private System.Windows.Forms.ToolStripButton AutoUpdateButton;
        private MetroFramework.Controls.MetroTabPage ViewPage;
        private MetroFramework.Controls.MetroComboBox macCB;
        private System.Windows.Forms.Label ViewGPULabel_2;
        private System.Windows.Forms.Label ViewGPULabel_1;
        private System.Windows.Forms.Label ViewHDDLabel_2;
        private System.Windows.Forms.Label ViewHDDLabel_1;
        private System.Windows.Forms.Label ViewRamLabel_2;
        private System.Windows.Forms.Label ViewRamLabel_1;
        private System.Windows.Forms.Label ViewProcLabel_2;
        private System.Windows.Forms.Label ViewProcLabel_1;
    }
}

