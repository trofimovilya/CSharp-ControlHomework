namespace SweetForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iceCreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driedApricostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsNewFileToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.menuStrip1_AnyItemClicked);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.newToolStripMenuItem.Text = "Создать";
            this.newToolStripMenuItem.ToolTipText = "Создать новый список.";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.create_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.ToolTipText = "Открыть список из текстового файла.";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openOrImport_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.importToolStripMenuItem.Text = "Импортировать...";
            this.importToolStripMenuItem.ToolTipText = "Добавть данные из уже существующего текстового файла к текущему списку.";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.openOrImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.ToolTipText = "Закрыть текущий список.";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.close_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.ToolTipText = "Сохранить текущий список в текстовый файл.";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAsNewFileToolStripMenuItem
            // 
            this.saveAsNewFileToolStripMenuItem.Enabled = false;
            this.saveAsNewFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsNewFileToolStripMenuItem.Image")));
            this.saveAsNewFileToolStripMenuItem.Name = "saveAsNewFileToolStripMenuItem";
            this.saveAsNewFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsNewFileToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveAsNewFileToolStripMenuItem.Text = "Сохранить как...";
            this.saveAsNewFileToolStripMenuItem.ToolTipText = "Сохранить текущий список в новый файл.";
            this.saveAsNewFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsOrExport_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exportToolStripMenuItem.Text = "Экспортировать...";
            this.exportToolStripMenuItem.ToolTipText = "Добавить данные из текущего списка к уже существующему файлу.";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.saveAsOrExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(214, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.ToolTipText = "Выйти из программы.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.overdueToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            this.editToolStripMenuItem.Click += new System.EventHandler(this.menuStrip1_AnyItemClicked);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iceCreamToolStripMenuItem,
            this.driedApricostToolStripMenuItem});
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.addToolStripMenuItem.Text = "Добвать сладость";
            // 
            // iceCreamToolStripMenuItem
            // 
            this.iceCreamToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.iceCreamToolStripMenuItem.Name = "iceCreamToolStripMenuItem";
            this.iceCreamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.iceCreamToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.iceCreamToolStripMenuItem.Text = "Мороженое";
            this.iceCreamToolStripMenuItem.ToolTipText = "Добавить мороженное в текущий список.";
            this.iceCreamToolStripMenuItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // driedApricostToolStripMenuItem
            // 
            this.driedApricostToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.driedApricostToolStripMenuItem.Name = "driedApricostToolStripMenuItem";
            this.driedApricostToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.driedApricostToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.driedApricostToolStripMenuItem.Text = "Курага";
            this.driedApricostToolStripMenuItem.ToolTipText = "Добавить курагу в текущий список.";
            this.driedApricostToolStripMenuItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.removeToolStripMenuItem.Text = "Удалить выделенное";
            this.removeToolStripMenuItem.ToolTipText = "Удалить выделенные элементы из списка.";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // overdueToolStripMenuItem
            // 
            this.overdueToolStripMenuItem.Enabled = false;
            this.overdueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("overdueToolStripMenuItem.Image")));
            this.overdueToolStripMenuItem.Name = "overdueToolStripMenuItem";
            this.overdueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.overdueToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.overdueToolStripMenuItem.Text = "Удалить просроченные продукты";
            this.overdueToolStripMenuItem.Click += new System.EventHandler(this.overdueToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(255, 232);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список слдаостей";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(98, 19);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Страна производитель: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(141, 45);
            this.textBox2.MaxLength = 75;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            this.textBox2.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(293, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Свойства";
            this.groupBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Вкус/сорт:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(98, 227);
            this.textBox8.MaxLength = 200;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(163, 20);
            this.textBox8.TabIndex = 9;
            this.textBox8.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(211, 175);
            this.textBox7.MaxLength = 12;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 7;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            this.textBox7.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(211, 149);
            this.textBox6.MaxLength = 6;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            this.textBox6.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(211, 123);
            this.textBox5.MaxLength = 4;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            this.textBox5.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(211, 97);
            this.textBox4.MaxLength = 4;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            this.textBox4.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(211, 201);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата изготовления:  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Срок годности (мес.):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Калорийность  (ккал/100г):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Мин. температура хранения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Макс. температура хранения:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox3.Location = new System.Drawing.Point(211, 71);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
            this.textBox3.Leave += new System.EventHandler(this.textBoxes_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоимость (руб/кг):";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Sweets";
            this.saveFileDialog1.Filter = "Text file (*.txt)|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save As";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Open";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Control Home Work";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem iceCreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driedApricostToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ToolStripMenuItem overdueToolStripMenuItem;

    }
}

