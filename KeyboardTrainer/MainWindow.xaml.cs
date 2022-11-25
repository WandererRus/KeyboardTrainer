using System.Windows;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string textForTask = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            speed.Text= "0";
            fails.Text= "0";            
        }

        private void difficult_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelDifficult.Text= ((int)difficult.Value).ToString();
            taskText.Text= TextGenerator.GetTextByDiffLvl((int)difficult.Value);
        }

    }
}