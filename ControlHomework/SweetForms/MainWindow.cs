// Трофимов Илья. Группа 172ПИ. Вариант 44

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CommonWorkingLibrary;
using SweetLibrary;

namespace SweetForms
{
    public partial class MainWindow : Form
    {
        List<Sweets> listOfSweets = new List<Sweets>();
        string path;
        bool export, // булевая переменная если надо сделать экспорт
             import, // булевая переменная если надо сделать импорт
             blockHandler,
             closeAfterSave = false,
             isNeedToAsk = false; // флажок нужно ли спрашивать о сохранении перед закрытием файла или выходом из программы


        public MainWindow()
        {
            InitializeComponent();
            listBox1.DataSource = listOfSweets;

            #region Настройки формы
            textBox8.Visible = false;
            label9.Visible = false;

            Text = Literals.ProgramName;
            fileToolStripMenuItem.Text = Literals.Controls.File;
            editToolStripMenuItem.Text = Literals.Controls.Edit;
            helpToolStripMenuItem.Text = Literals.Controls.Help;
            newToolStripMenuItem.Text = Literals.Controls.Create;
            openToolStripMenuItem.Text = Literals.Controls.Open + "...";
            importToolStripMenuItem.Text = Literals.Controls.Import + "...";
            closeToolStripMenuItem.Text = Literals.Controls.Close;
            saveToolStripMenuItem.Text = Literals.Controls.Save;
            saveAsNewFileToolStripMenuItem.Text = Literals.Controls.SaveAs + "...";
            exportToolStripMenuItem.Text = Literals.Controls.Export + "...";
            exitToolStripMenuItem.Text = Literals.Controls.Exit;
            addToolStripMenuItem.Text = Literals.Controls.AddItem;
            iceCreamToolStripMenuItem.Text = Literals.Specific.IceCream;
            driedApricostToolStripMenuItem.ToolTipText = Literals.ToolTips.AddDriedApricots;
            removeToolStripMenuItem.Text = Literals.Controls.RemoveSelected;
            overdueToolStripMenuItem.Text = Literals.Controls.OverDue;
            groupBox1.Text = Literals.Controls.TitleList;
            groupBox2.Text = Literals.Controls.TitlePropertes;

            label1.Text = Literals.Specific.Name + ':';
            label2.Text = Literals.Specific.Country + ':';
            label3.Text = Literals.Specific.Cost + ':';
            label4.Text = Literals.Specific.MinTemperature + ':';
            label5.Text = Literals.Specific.MaxTemperature + ':';
            label6.Text = Literals.Specific.ShelfLife + ':';
            label7.Text = Literals.Specific.Calories + ':';
            label8.Text = Literals.Specific.Date + ':';

            newToolStripMenuItem.ToolTipText = Literals.ToolTips.Create;
            openToolStripMenuItem.ToolTipText = Literals.ToolTips.Open;
            importToolStripMenuItem.ToolTipText = Literals.ToolTips.Import;
            closeToolStripMenuItem.ToolTipText = Literals.ToolTips.Close;
            saveToolStripMenuItem.ToolTipText = Literals.ToolTips.Save;
            saveAsNewFileToolStripMenuItem.ToolTipText = Literals.ToolTips.SaveAs;
            exportToolStripMenuItem.ToolTipText = Literals.ToolTips.Export;
            exitToolStripMenuItem.ToolTipText = Literals.ToolTips.Exit;
            iceCreamToolStripMenuItem.ToolTipText = Literals.ToolTips.AddIceCream;
            driedApricostToolStripMenuItem.Text = Literals.Specific.DriedApricots;
            removeToolStripMenuItem.ToolTipText = Literals.ToolTips.RemoveSelected;

            openFileDialog1.Filter = Literals.Controls.Filter;
            saveFileDialog1.Filter = Literals.Controls.Filter;
            saveFileDialog1.FileName = Literals.Controls.NoName;

            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            #endregion
        }

        private void ShowElements(bool b)
        {
            groupBox1.Visible = b;
            groupBox2.Visible = b;
            addToolStripMenuItem.Enabled = b;
            closeToolStripMenuItem.Enabled = b;
            overdueToolStripMenuItem.Enabled = b;
            saveToolStripMenuItem.Enabled = b;
            saveAsNewFileToolStripMenuItem.Enabled = b;
            importToolStripMenuItem.Enabled = b;
            exportToolStripMenuItem.Enabled = b;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (isNeedToAsk)
            {
                var q = MessageBox.Show(Literals.Controls.ClosingQuestion(path), Literals.ProgramName, MessageBoxButtons.YesNoCancel);

                if (q == DialogResult.Yes)
                    save_Click(sender, e);

                else if (q == DialogResult.Cancel)
                    return;
            }

            isNeedToAsk = false;
            path = null;
            Text = Literals.Controls.ProgramTitle(path);
            listOfSweets.Clear();
            Methods.RefreshListBox(listBox1, listOfSweets);
            ShowElements(true);
        }

        #region Open and import
        private void openOrImport_Click(object sender, EventArgs e)
        {
            if (sender == openToolStripMenuItem)
            {
                if (isNeedToAsk)
                {
                    var q = MessageBox.Show(Literals.Controls.ClosingQuestion(path), Literals.ProgramName, MessageBoxButtons.YesNoCancel);

                    if (q == DialogResult.Yes)
                        save_Click(sender, e);

                    else if (q == DialogResult.Cancel)
                        return;
                }

                import = false;
                openFileDialog1.Title = Literals.Controls.Open;
            }

            else if (sender == importToolStripMenuItem)
            {
                import = true;
                openFileDialog1.Title = Literals.Controls.Import;
            }

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (import)
                isNeedToAsk = true;

            else
            {
                isNeedToAsk = false;
                ShowElements(true);
                path = openFileDialog1.FileName;
                Text = Literals.Controls.ProgramTitle(path);
            }

            Methods.Open(openFileDialog1.FileName, listOfSweets, import);
            Methods.RefreshListBox(listBox1, listOfSweets);
        }
        #endregion

        #region Save, Save As and Export
        private void save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(path))
            {
                saveFileDialog1.Title = Literals.Controls.SaveAs;
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.OverwritePrompt = true;
                export = false;
                saveFileDialog1.ShowDialog();
            }
            else
            {
                Methods.Save(path, listOfSweets, false);
                isNeedToAsk = false;
                if (closeAfterSave)
                    Application.Exit();
            }
        }

        private void saveAsOrExport_Click(object sender, EventArgs e)
        {
            if (sender == exportToolStripMenuItem)
            {
                saveFileDialog1.Title = Literals.Controls.Export;
                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.OverwritePrompt = false;
                export = true;
            }

            else
            {
                saveFileDialog1.Title = Literals.Controls.SaveAs;
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.OverwritePrompt = true;
                export = false;
            }

            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Methods.Save(saveFileDialog1.FileName, listOfSweets, export);

            if (!export)
            {
                isNeedToAsk = false;
                path = saveFileDialog1.FileName;
                Text = Literals.Controls.ProgramTitle(path);
            }

            if (closeAfterSave)
                Close();
        }
        #endregion

        private void close_Click(object sender, EventArgs e)
        {
            if (isNeedToAsk)
            {
                var q = MessageBox.Show(Literals.Controls.ClosingQuestion(path), Literals.ProgramName, MessageBoxButtons.YesNoCancel);

                if (q == DialogResult.Yes)
                    save_Click(sender, e);

                else if (q == DialogResult.Cancel)
                    return;
            }

            isNeedToAsk = false;
            path = null;
            Text = Literals.ProgramName;
            listOfSweets.Clear();
            Methods.RefreshListBox(listBox1, listOfSweets);
            ShowElements(false);
        }

        #region Exit
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Focus();

            if (blockHandler)
            {
                e.Cancel = true;
                return;
            }

            if (isNeedToAsk)
            {
                var q = MessageBox.Show(Literals.Controls.ClosingQuestion(path), Literals.ProgramName, MessageBoxButtons.YesNoCancel);

                if (q == DialogResult.Yes)
                {
                    closeAfterSave = true;
                    save_Click(sender, e);
                    e.Cancel = true;
                }
                else if (q == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
        #endregion

        private void addItem_Click(object sender, EventArgs e)
        {
            if (sender == iceCreamToolStripMenuItem)
                listOfSweets.Add(new IceCream());

            else if (sender == driedApricostToolStripMenuItem)
                listOfSweets.Add(new DriedApricots());

            isNeedToAsk = true;
            Methods.RefreshListBox(listBox1, listOfSweets);
        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                listOfSweets.RemoveAt(listBox1.SelectedIndices[i]);

            isNeedToAsk = listOfSweets.Count == 0 && String.IsNullOrWhiteSpace(path) ? false : true;
            Methods.RefreshListBox(listBox1, listOfSweets);
        }

        private void menuStrip1_AnyItemClicked(object sender, EventArgs e)
        {
            listBox1.Focus();
        }

        // Блокируем некорректные символы
        private void KeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (sender == textBox2)
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-');

            else if (sender == textBox3)
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '\b');

            else if (sender == textBox4 || sender == textBox5)
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\b');

            else if (sender == textBox6)
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b');

            else if (sender == textBox7)
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '/');
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blockHandler) return;
            textBox8.Clear();

            // Разрешаем юзать кнопку remove если выделенно хоть что-нибудь
            removeToolStripMenuItem.Enabled = listBox1.SelectedIndex != -1 ? true : false;

            if (listBox1.SelectedIndices.Count == 1) // Выполняется если выделен только 1 пункт
            {
                groupBox2.Enabled = true;
                label9.Visible = true;
                textBox8.Visible = true;
                var selectedItem = listOfSweets[listBox1.SelectedIndex];

                // Выводим на текстбоксы значения свойств выделенного элемента при условии что эти значения не являются нулевыми

                if (selectedItem is IceCream)
                {
                    if (!String.IsNullOrWhiteSpace(((IceCream)selectedItem).Taste))
                        textBox8.Text = ((IceCream)selectedItem).Taste;
                    label9.Text = Literals.Specific.Taste + ':';
                }
                else if (selectedItem is DriedApricots)
                {
                    if (!String.IsNullOrWhiteSpace(((DriedApricots)selectedItem).Sort))
                        textBox8.Text = ((DriedApricots)selectedItem).Sort;
                    label9.Text = Literals.Specific.Sort + ':';
                }
                else textBox8.Clear();

                if (!String.IsNullOrWhiteSpace(selectedItem.Name)) { textBox1.Text = selectedItem.Name; }
                else textBox1.Clear();

                if (!String.IsNullOrWhiteSpace(selectedItem.Country)) { textBox2.Text = selectedItem.Country; }
                else textBox2.Clear();

                if (selectedItem.Cost > 0) { textBox3.Text = selectedItem.Cost.ToString("f2"); }
                else textBox3.Clear();

                if (selectedItem.MinTemperature != -101) { textBox4.Text = selectedItem.MinTemperature.ToString(); }
                else textBox4.Clear();

                if (selectedItem.MaxTemperature != 101) { textBox5.Text = selectedItem.MaxTemperature.ToString(); }
                else textBox5.Clear();

                if (selectedItem.Calories != -1) { textBox6.Text = selectedItem.Calories.ToString(); }
                else textBox6.Clear();

                if (selectedItem is IceCream && !String.IsNullOrWhiteSpace(((IceCream)selectedItem).Date))
                    textBox7.Text = ((IceCream)selectedItem).Date;
                else if (selectedItem is DriedApricots && !String.IsNullOrWhiteSpace(((DriedApricots)selectedItem).Date))
                    textBox7.Text = ((DriedApricots)selectedItem).Date;
                else textBox7.Clear();



                numericUpDown3.Value = selectedItem.ShelfLife;
            }

            else // Выполняется если не выделенно ничего или выделенно более одного пункта
            {
                // Чистим текстбоксы
                groupBox2.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox8.Visible = false;
                label9.Visible = false;
                numericUpDown3.Value = 0;            
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && textBox1.Modified == true)
            {
                blockHandler = true;
                int i = listBox1.SelectedIndex;
                listOfSweets[listBox1.SelectedIndex].Name = textBox1.Text.Trim();
                Methods.RefreshListBox(listBox1, listOfSweets);
                listBox1.SelectedIndex = i;
                textBox1.Focus();
                isNeedToAsk = true;
                blockHandler = false;
            }
        }

        // Вызывается при потере фокуса во всех текстбоксах кроме 1-го
        private void textBoxes_Leave(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && ((TextBox)sender).Modified == true)
            {
                var selectedItem = listOfSweets[listBox1.SelectedIndex];
                isNeedToAsk = true;
                blockHandler = false;

                // Если текстбокс пустой, то назначаем свойствам нулевые значения
                if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
                {
                    if (sender == textBox2)
                        selectedItem.Country = String.Empty;

                    else if (sender == textBox3)
                        selectedItem.Cost = 0;

                    else if (sender == textBox4)
                        selectedItem.MinTemperature = -101;

                    else if (sender == textBox5)
                        selectedItem.MaxTemperature = 101;

                    else if (sender == textBox6)
                        selectedItem.Calories = -1;

                    else if (sender == textBox7)
                    {
                        if (selectedItem is IceCream)
                            ((IceCream)selectedItem).Date = String.Empty;

                        else if (selectedItem is DriedApricots)
                            ((DriedApricots)selectedItem).Date = String.Empty;
                    }

                    else if (sender == textBox8)
                    {
                        if (selectedItem is IceCream)
                            ((IceCream)selectedItem).Taste = String.Empty;

                        else if (selectedItem is DriedApricots)
                            ((DriedApricots)selectedItem).Sort = String.Empty;
                    }
                }

                else
                {
                    //Если текстбокс не пустой, то пытаемся присвойить значения свойствам
                    try
                    {
                        if (sender == textBox2)
                            selectedItem.Country = textBox2.Text.Trim();

                        else if (sender == textBox3)
                            selectedItem.Cost = double.Parse(textBox3.Text);

                        else if (sender == textBox4)
                        {
                            int tempCheck = int.Parse(textBox4.Text);
                            selectedItem.MinTemperature = tempCheck > -101 ? tempCheck : -102;
                        }

                        else if (sender == textBox5)
                        {
                            int tempCheck = int.Parse(textBox5.Text);
                            selectedItem.MaxTemperature = tempCheck < 101 ? tempCheck : 102;
                        }

                        else if (sender == textBox6)
                        {
                            int tempCheck = int.Parse(textBox6.Text);
                            selectedItem.Calories = tempCheck > -1 ? tempCheck : -2;
                        }

                        else if (sender == textBox7)
                        {
                            if (selectedItem is IceCream)
                                ((IceCream)selectedItem).Date = textBox7.Text;

                            else if (selectedItem is DriedApricots)
                                ((DriedApricots)selectedItem).Date = textBox7.Text;
                        }

                        else if (sender == textBox8)
                        {
                            if (selectedItem is IceCream)
                                ((IceCream)selectedItem)    .Taste = textBox8.Text;

                            else if (selectedItem is DriedApricots)
                                ((DriedApricots)selectedItem).Sort = textBox8.Text;
                        }
                    }

                    catch (Exception ex)
                    {
                        blockHandler = true;
                        fileToolStripMenuItem.DropDown.Close();
                        editToolStripMenuItem.DropDown.Close();
                        helpToolStripMenuItem.DropDown.Close();

                        var q = MessageBox.Show(ex.Message, Literals.Controls.Error, MessageBoxButtons.OK);
                        if (q == DialogResult.OK)
                            ((TextBox)sender).Focus();
                    }
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1)
            {
                listOfSweets[listBox1.SelectedIndex].ShelfLife = (uint)numericUpDown3.Value;
                isNeedToAsk = true;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Literals.About, Literals.ProgramName);
        }

        private void overdueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = listOfSweets.Count - 1; i >= 0; i--)
                if (listOfSweets[i].IsOverdue)
                    listOfSweets.RemoveAt(i);

            isNeedToAsk = listOfSweets.Count == 0 && String.IsNullOrWhiteSpace(path) ? false : true;
            Methods.RefreshListBox(listBox1, listOfSweets);
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            overdueToolStripMenuItem.Enabled = listOfSweets.Count < 1 ? false : true;
        }
    }
}
