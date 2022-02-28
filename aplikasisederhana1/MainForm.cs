/*
 * Created by SharpDevelop.
 * User: TUF
 * Date: 3/1/2022
 * Time: 1:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aplikasisederhana1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.Items.Add("A");
			comboBox1.Items.Add("B");
			comboBox1.Items.Add("C");
			
			comboBox1.SelectedIndex=0;
		}
		void Button1Click(object sender, EventArgs e)
		{
			string Nama=textBox1.Text;
			int NIM=int.Parse(textBox2.Text);
			string KOM=comboBox1.SelectedItem.ToString();
			string batas="    ||    ";
			
			listBox1.Items.Add(Nama+batas+NIM+batas+KOM);
			
			textBox1.Clear();
			textBox2.Clear();
		}
	}
}
