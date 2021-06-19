using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liver
{
	public partial class Lenta : Form
	{
		private readonly Pic[] _pics;

		public Lenta(Pic[] pics)
		{
			_pics = pics;
			InitializeComponent();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.DataSource = new[] { "Горизонтальное", "Вертикальное" };
		}

		private void SaveLenta_Click(object sender, EventArgs e)
		{
            var d = new SaveFileDialog
            {
                FileName = "Лента.jpg"
            };
            if (d.ShowDialog() == DialogResult.OK)
            {
				var constr = (int)numericUpDown1.Value;
				var orient = comboBox1.SelectedValue.Equals("Горизонтальное");
				var size = orient ? new Size(Int32.MaxValue, constr) : new Size(constr, Int32.MaxValue);
				var rec = new Rectangle(Point.Empty, size);
				var bounds = _pics.Select(a => a.FitBounds(rec)).ToArray();
				var bmp = new Bitmap(orient ? bounds.Sum(a => a.Width) : constr,orient ? constr : bounds.Sum(a => a.Height));
				var g = Graphics.FromImage(bmp);
				for (int i = 0; i < _pics.Length; i++)
				{
					var img = _pics[i];
					var bnds = bounds[i];
					if (orient)
					{
						bnds.X = bounds.Take(i).Sum(a => a.Width);
					}
					else
					{
						bnds.Y = bounds.Take(i).Sum(a => a.Height);
					}
					g.DrawImage(img.Image, bnds);
				}
				bmp.Save(d.FileName);
				Close();
            }
		}
	}
}
