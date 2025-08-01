using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Utilities
{
    public class BtnCustom : RadioButton
    {
        static BtnCustom()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BtnCustom), new FrameworkPropertyMetadata(typeof(BtnCustom)));
        }
    }
}
