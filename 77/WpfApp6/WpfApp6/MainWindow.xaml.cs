using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTextEditor;
namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // настройка обработчиков для наших пользовательских команд
            CommandBinding cmdBindingExit = new CommandBinding(WpfTextEditorCommands.ExitCommand);
            cmdBindingExit.Executed += new ExecutedRoutedEventHandler(cmdBindingExit_Executed);

            CommandBinding cmdBindingWordWrap = new CommandBinding(WpfTextEditorCommands.WordWrapCommand);
            cmdBindingWordWrap.Executed += new ExecutedRoutedEventHandler(cmdBindingWordWrap_Executed);

            this.CommandBindings.Add(cmdBindingExit);
            this.CommandBindings.Add(cmdBindingWordWrap);

        }

        private void cmdBindingExit_Executed(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cmdBindingWordWrap_Executed(object sender, RoutedEventArgs e)
        {
            textBox.TextWrapping = ((textBox.TextWrapping == TextWrapping.NoWrap) ? TextWrapping.Wrap : TextWrapping.NoWrap);
        }
    }
}
