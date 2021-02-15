﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiuTools.Controls
{
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent(); dateNavigator1.DateTime = DateTime.Now;
            dateNavigator1.CalendarIndent = 10;
        }
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            dateNavigator1.CalcBestSize();
        }
    }
}
