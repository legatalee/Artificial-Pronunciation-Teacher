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

namespace Recorder

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                ((Grid)sender).Opacity = 0.8;
            }
            catch (Exception)
            {
                ((Grid)sender).Opacity = 0.8;
            }
        }

        private void _MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                ((Grid)sender).Opacity = 1;
            }
            catch (Exception)
            {
                ((Grid)sender).Opacity = 1;
            }
        }

        private void _MousePressed(object sender, MouseEventArgs e)
        {
            if (((Grid)sender).Name == "StudyPronunciation")
            {
                StudyPronunciationGrid.Visibility = Visibility.Visible;
                ChooseLanguage.Visibility = Visibility.Hidden;
            }
            else
            {
                StudyPronunciationGrid.Visibility = Visibility.Hidden;
                ChooseLanguage.Visibility = Visibility.Visible;
            }
        }

        private void _ChooseFile(object sender, MouseEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                ChosenFile.Text = "Selected File : " + filename;
            }
        }
    }
}
