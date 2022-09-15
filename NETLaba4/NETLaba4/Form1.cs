using System;
using System.Windows.Forms;

namespace NETLaba4
{
	public partial class Form1 : Form
	{
		Form2 f;
		public Form1()
		{
			InitializeComponent();
		}

		private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void свернутьВТрейToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				Hide();
		}
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void сведенияОПреподавателяхToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if ((this.ActiveMdiChild == null || this.ActiveMdiChild.Text != "Сведения о преподавателях") && MdiChildren.Length != 2)
			{
				f = new Form2();
				f.MdiParent = this;
				f.LayoutMdi(MdiLayout.Cascade);
				f.Text = "Сведения о преподавателях";
				f.Show();
			}
			else {
				if (MdiChildren[0].Text == "Сведения о преподавателях")
					MdiChildren[0].Focus();
				else
					MdiChildren[1].Focus();
			}
		}

		private void сведенияОСтудентахToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if ((this.ActiveMdiChild == null || this.ActiveMdiChild.Text != "Сведения о студентах") && MdiChildren.Length != 2)
			{
				f = new Form2();
				f.MdiParent = this;
				f.LayoutMdi(MdiLayout.Cascade);
				f.Text = "Сведения о студентах";
				f.Show();
			}
			else
			{
				if (MdiChildren[0].Text == "Сведения о студентах")
					MdiChildren[0].Focus();
				else
					MdiChildren[1].Focus();
			}
		}

		private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
		}
	}
}
