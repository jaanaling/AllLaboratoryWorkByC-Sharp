using System;
using System.Collections.Generic;
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
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Timers;
using System.Windows.Threading;
using Microsoft.Win32;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(int hWnd,int hWndInsertAfter,int X,int Y,int cx,int cy,uint uFlags);
        
        public const int HWND_BOTTOM = 0x1;
        public const uint SWP_NOSIZE = 0x1;
        public const uint SWP_NOMOVE = 0x2;
        public const uint SWP_SHOWWINDOW = 0x40;


        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr window, int index, int value);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr window, int index);

    

        Point old;
        public MainWindow()
        {
            InitializeComponent();

        }
        private IntPtr Handle
        {
            get
            {
                return new WindowInteropHelper(this).Handle;
            }
        }
        private void ShoveToBackground()
        {
            SetWindowPos((int)this.Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
        }      


        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
         old = e.GetPosition(null);
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point cur = e.GetPosition(null);
                this.Left += cur.X - old.X;
                this.Top += cur.Y - old.Y;
            }

        }

       

        private void form_Activated(object sender, EventArgs e)
        {
            ShoveToBackground();
        }

       
    }
}
