using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2, x3, y3, x0, y0;
            x1 = Convert.ToInt32(Ax.Text);
            y1 = Convert.ToInt32(Ay.Text);
            x2 = Convert.ToInt32(Bx.Text);
            y2 = Convert.ToInt32(By.Text);
            x3 = Convert.ToInt32(Cx.Text);
            y3 = Convert.ToInt32(Cy.Text);
            x0 = Convert.ToInt32(Zx.Text);
            y0 = Convert.ToInt32(Zy.Text);
            int s1 = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            int s2 = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            int s3 = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);
            if((s1 >= 0 && s2 >= 0 && s3 >= 0) || (s1 <= 0 && s2 <= 0 && s3 <= 0))
            {
                if (s1 == 0 || s2 == 0 || s3 == 0)
                {
                    MessageBox.Show("Лежит в стороне треугольника");
                } else MessageBox.Show("Лежит внутри треугольника");
            }
            else MessageBox.Show("Не лежит в треугольнике");

            //Если они одинакового знака, то точка внутри треугольника
            //Если что-то из этого -ноль, то точка лежит на стороне
            //Иначе точка вне треугольника.
        }
    }
}
