using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace kakutei
{

	public partial class Form1 : Form
	{
		private Excel.Application _app;
		private Speecher _speech = new Speecher();

		public Form1()
		{
			InitializeComponent();
		}

		private void textBoxDate_TextChanged(object sender, EventArgs e)
		{
			string text = textBoxDate.Text;
			_speech.SpeechLastChar(text);

			if (text.Length >= 4)
			{
				textBoxYen.Focus();
				textBoxYen.SelectAll();
			}
		}

		private void textBoxDate_Enter(object sender, EventArgs e)
		{
			textBoxDate.Select();
		}

		private void textBoxYen_TextChanged(object sender, EventArgs e)
		{
			_speech.SpeechLastChar(textBoxYen.Text);
		}

		private void textBoxYen_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			string date = textBoxDate.Text;
			string yen  = textBoxYen.Text;
			_speech.Speech(yen + "円");

			// append record
			Excel.Worksheet sheet  = (Excel.Worksheet)_app.ActiveSheet;
			Excel.Range     bottom = sheet.Range["A65536"].End[Excel.XlDirection.xlUp];

			int    bottomID = int.Parse(bottom.Value.ToString()); // 1列目にIDがある必要がある
			int    emptyRow = bottom.Row + 1;

			Excel.Range r = sheet.Cells[emptyRow, 1];
			r.Value = bottomID + 1;
			r = sheet.Cells[emptyRow, 2];
			r.Value = date.Substring(0, 2);
			r = sheet.Cells[emptyRow, 3];
			r.Value = date.Substring(2);
			r = sheet.Cells[emptyRow, 4];
			r.Value = yen;

			_app.Goto(r);

			textBoxDate.Focus();
			textBoxDate.SelectAll();
		}

		private void textBoxYen_Enter(object sender, EventArgs e)
		{
			textBoxYen.SelectAll();
		}

		private void label1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All;
		}

		private void label1_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			string xlsFile = fileList[0];

			_app = new Excel.Application();
			_app.Workbooks.Open(xlsFile);
			_app.Visible = true;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_speech.Dispose();
			if (_app != null)
				_app.Quit();
		}
	}
}
