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
	public partial class Comments : Form
	{
		private readonly Pic _pic;

		public Comments(Pic pic)
		{
			_pic = pic;
			InitializeComponent();
			//use pic.Hash для доступа к базе
		}

	}
}
