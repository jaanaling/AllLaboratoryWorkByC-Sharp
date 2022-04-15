using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Windows.Media.Animation;

namespace WpfApp7
{
    public partial class ListBoxGalleryTemplate : ResourceDictionary
    {
        public ListBoxGalleryTemplate()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject dobj = VisualTreeHelper.GetParent(
                (ListBoxItem)((FrameworkElement)sender).TemplatedParent);

            while ((dobj as ListBox) == null)
            {
                dobj = VisualTreeHelper.GetParent(dobj);
            }

            if (dobj != null)
                (dobj as ListBox).SelectedIndex = -1;
        }

    }
}
