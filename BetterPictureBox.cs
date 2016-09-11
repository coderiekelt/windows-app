﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrappyListenMoe
{
	class BetterPictureBox : PictureBox
	{
		protected override void OnPaint(PaintEventArgs pe)
		{
			pe.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			base.OnPaint(pe);
		}
	}
}