using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WordPad_XP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                FontList.Items.Add(font.Name);
            }
            FontList.SelectedItem = "Arial";

            FontSizeList.Items.Add(8);
            FontSizeList.Items.Add(9);
            FontSizeList.Items.Add(10);
            FontSizeList.Items.Add(11);
            FontSizeList.Items.Add(12);
            FontSizeList.Items.Add(14);
            FontSizeList.Items.Add(16);
            FontSizeList.Items.Add(18);
            FontSizeList.Items.Add(20);
            FontSizeList.Items.Add(22);
            FontSizeList.Items.Add(24);
            FontSizeList.Items.Add(26);
            FontSizeList.Items.Add(28);
            FontSizeList.Items.Add(36);
            FontSizeList.Items.Add(48);
            FontSizeList.Items.Add(72);
            FontSizeList.SelectedItem = 10;

            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);

            saveFileDialog1.Filter = "Rtf файлы (*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            openFileDialog1.Filter = "Rtf файлы (*.rtf)|*.rtf|Все файлы(*.*)|*.*";
        }
        Font cursorFont = new Font("Arial", 10, FontStyle.Regular);
        string filename = "Документ";
        bool fileLocation = false;
        bool panelIntrumentovBool = true;
        bool panelFormatirovaniaBool = true;
        bool exit = true;


        private void Selected_FontList(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            string s = tscb.Text;
            int selectStart = richTextBox1.SelectionStart;
            int selectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(selectStart, 1);
            cursorFont = richTextBox1.SelectionFont;
            richTextBox1.Select(selectStart, selectLength);
            richTextBox1.SelectionFont = new Font(s, cursorFont.Size, cursorFont.Style);
        }



        private void Selected_FontSizeList(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            string s = tscb.Text;
            int selectStart = richTextBox1.SelectionStart;
            int selectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(selectStart, 1);
            cursorFont = richTextBox1.SelectionFont;
            richTextBox1.Select(selectStart, selectLength);
            richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, Convert.ToInt32(s), cursorFont.Style);
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length != 0)
            {
                clearButton.Enabled = true;
            }
            else
            {
                clearButton.Enabled = false;
            }
        }


        private void BoldButton_Click(object sender, EventArgs e)
        {
            int selectStart = richTextBox1.SelectionStart;
            int selectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(selectStart, 1);
            cursorFont = richTextBox1.SelectionFont;
            richTextBox1.Select(selectStart, selectLength);

            if (!cursorFont.Bold)//если не жирный
            {
                if (cursorFont.Italic && cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (cursorFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold | FontStyle.Italic);
                }
                else if (cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold | FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold);
                }
            }
            else //если жирный
            {
                if (cursorFont.Italic && cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic | FontStyle.Underline);
                }
                else if (cursorFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic);
                }
                else if (cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Regular);
                }
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            int selectStart = richTextBox1.SelectionStart;
            int selectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(selectStart, 1);
            cursorFont = richTextBox1.SelectionFont;
            richTextBox1.Select(selectStart, selectLength);

            if (!cursorFont.Italic) //если не курсив
            {
                if (cursorFont.Bold && cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                }
                else if (cursorFont.Bold)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic | FontStyle.Bold);
                }
                else if (cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic);
                }
            }
            else //если курсив
            {
                if (cursorFont.Bold && cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold | FontStyle.Underline);
                }
                else if (cursorFont.Bold)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold);
                }
                else if (cursorFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Regular);
                }
            }
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            int selectStart = richTextBox1.SelectionStart;
            int selectLength = richTextBox1.SelectionLength;
            richTextBox1.Select(selectStart, 1);
            cursorFont = richTextBox1.SelectionFont;
            richTextBox1.Select(selectStart, selectLength);

            if (!cursorFont.Underline) //если не подчёркнутый
            {
                if (cursorFont.Bold && cursorFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                }
                else if (cursorFont.Bold)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Underline | FontStyle.Bold);
                }
                else if (cursorFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Underline | FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Underline);
                }
            }
            else //если подчёркнутый
            {
                if (cursorFont.Bold && cursorFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold | FontStyle.Italic);
                }
                else if (cursorFont.Bold)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Bold);
                }
                else if (cursorFont.Italic)
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(cursorFont.FontFamily, cursorFont.Size, FontStyle.Regular);
                }
            }
        }

        private void Color_Selected(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            switch (tsmi.Name)
            {
                case ("black"): richTextBox1.SelectionColor = Color.Black; break;
                case ("blue"): richTextBox1.SelectionColor = Color.Blue; break;
                case ("green"): richTextBox1.SelectionColor = Color.Green; break;
                case ("yellow"): richTextBox1.SelectionColor = Color.Yellow; break;
                case ("red"): richTextBox1.SelectionColor = Color.Red; break;
                case ("purple"): richTextBox1.SelectionColor = Color.Purple; break;
                case ("gray"): richTextBox1.SelectionColor = Color.Gray; break;
                case ("white"): richTextBox1.SelectionColor = Color.White; break;
            }
        }

        private void selectionAlignment(object sender, EventArgs e)
        {
            ToolStripButton tsmi = (ToolStripButton)sender;
            switch (tsmi.Name)
            {
                case ("leftEdge"): richTextBox1.SelectionAlignment = HorizontalAlignment.Left; break;
                case ("сentered"): richTextBox1.SelectionAlignment = HorizontalAlignment.Center; break;
                case ("rightEdge"): richTextBox1.SelectionAlignment = HorizontalAlignment.Right; break;

            }
        }

        private void bulletPoints_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionBullet) richTextBox1.SelectionBullet = false;
            else richTextBox1.SelectionBullet = true;
        }

        //----------------------файл------------------------
        private void createFile(object sender, EventArgs e)
        {
            string k = "Документ";
            if (fileLocation) k = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1);

            DialogResult dialogResult = MessageBox.Show("Сохранить изменения в файле \"" + k + "\"?", "WordPad", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                saveFile(sender, e);
                richTextBox1.Text = "";
                richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
                Font cursorFont = new Font("Arial", 10, FontStyle.Regular);
                FontList.SelectedItem = "Arial";
                FontSizeList.SelectedItem = 10;
                this.Text = "Документ - WordPadXP";
                fileLocation = false;
                filename = "Документ";
            }
            else if (dialogResult == DialogResult.No)
            {
                richTextBox1.Text = "";
                richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
                Font cursorFont = new Font("Arial", 10, FontStyle.Regular);
                FontList.SelectedItem = "Arial";
                FontSizeList.SelectedItem = 10;
                this.Text = "Документ - WordPadXP";
                fileLocation = false;
                filename = "Документ";
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void openFile(object sender, EventArgs e)
        {
            string k = "Документ";
            if (fileLocation) k = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1);

            DialogResult dialogResult = MessageBox.Show("Сохранить изменения в файле \"" + k + "\"?", "WordPad", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                saveFile(sender, e);
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename);
                this.Text = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1) + "-WordPadXP";
                fileLocation = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename);
                this.Text = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1) + "-WordPadXP";
                fileLocation = true;
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void saveFile(object sender, EventArgs e)
        {
            if (!fileLocation)
            {
                saveFileDialog1.FileName = "Документ";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                filename = saveFileDialog1.FileName;
            }
            // сохраняем текст в файл
            richTextBox1.SaveFile(filename);
            this.Text = filename + "-WordPadXP";
            this.Text = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1) + "-WordPadXP";
            fileLocation = true;
        }

        private void saveFileAs(object sender, EventArgs e)
        {
            if (!fileLocation)
            {
                saveFileDialog1.FileName = "Документ";
            }
            else
            {
                saveFileDialog1.FileName = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1);
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            richTextBox1.SaveFile(filename);
            this.Text = filename + "-WordPadXP";
            this.Text = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1) + "-WordPadXP";
            fileLocation = true;
        }

        private void print(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.AllowSomePages = true;
            pd.ShowHelp = true;

            if(pd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("наверно печать завершена, я не уверен)");
            }
        }

        private void showPrint(object sender, EventArgs e)
        {

        }

        //-------------Правка---------------------
        private void FindText(object sender, EventArgs e)
        {

        }

        private void Cut(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Copy(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void paste(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cencel(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void undo(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void clear(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void selectAll(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        //---------------------Вид--------------------
        private void panelIntrumentovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelIntrumentovBool)
            {
                panelIntrumentovToolStripMenuItem.Checked = false;
                panelIntrumentovBool = false;
                toolStrip1.Visible = false;
                if (panelFormatirovaniaBool)
                {
                    richTextBox1.Location = toolStrip2.Location;
                    toolStrip2.Location = toolStrip1.Location;
                }
                else
                {
                    richTextBox1.Location = toolStrip1.Location;
                }
            }
            else
            {
                panelIntrumentovToolStripMenuItem.Checked = true;
                panelIntrumentovBool = true;
                toolStrip1.Visible = true;
                if (panelFormatirovaniaBool)
                {
                    toolStrip2.Location = new Point(0, toolStrip1.Location.Y + toolStrip1.Height);
                    richTextBox1.Location = new Point(0, toolStrip2.Location.Y + toolStrip2.Height);
                }
                else
                {
                    richTextBox1.Location = new Point(0, toolStrip1.Location.Y + toolStrip1.Height);
                }
            }
        }

        private void panelformatirovaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip2.Visible)
            {
                panelformatirovaniaToolStripMenuItem.Checked = false;
                panelFormatirovaniaBool = false;
                toolStrip2.Visible = false;
                richTextBox1.Location = toolStrip2.Location;
            }
            else
            {
                panelformatirovaniaToolStripMenuItem.Checked = true;
                panelFormatirovaniaBool = true;
                toolStrip2.Visible = true;
                richTextBox1.Location = new Point(0, toolStrip2.Location.Y + toolStrip2.Height);
            }
        }

        private void dateAndTime(object sender, EventArgs e)
        {
            dateAndTimeForm datf = new dateAndTimeForm();
            if (datf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectedText = datfResult.a;
            }
        }

        private void fontWindow_Button_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                e.Cancel = true;
                string k = "Документ";
                if (fileLocation) k = filename.Remove(0, filename.LastIndexOf(@"\")).Remove(0, 1);

                DialogResult dialogResult = MessageBox.Show("Сохранить изменения в файле \"" + k + "\"?", "WordPad", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    saveFile(sender, e);
                    exit = false;
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    exit = false;
                    this.Close();
                }
                else if (dialogResult == DialogResult.Cancel)
                {

                }
            }
        }

        private void oProgrammeButton_Click(object sender, EventArgs e)
        {
            oProgramme op = new oProgramme();
            op.Show();
        }



        //добавить вопрос о сохранении в открытие, закрытие, создание нового документа и мб что-то ещё
    }
    public static class datfResult
    {
        public static string a = "";
    }
}
