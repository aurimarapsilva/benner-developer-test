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
