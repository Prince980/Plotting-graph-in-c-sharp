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
using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            canvas.MouseMove += Canvas_MouseMove;
            
            

        }



        public void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the position of the mouse cursor.
            Point mousePos = e.GetPosition(canvas);

            // Update the text block with the mouse position.
            mousePosTextBlock.Text = string.Format("Mouse Position: X={0}, Y={1}", mousePos.X, mousePos.Y);

            // Define the data
            double[,] data = new double[,]
                {
                     { mousePos.X, mousePos.Y},
                };
            // Create a new Line object
            Line line = new Line();
            Line line2 = new Line();

            // Set the start and end points of the line
            line.X1 = 630;
            line.Y1 = mousePos.Y;
            line.X2 = mousePos.X;
            line.Y2 = mousePos.Y;
            line2.X1 = mousePos.X;
            line2.Y1 = 315;
            line2.X2 = mousePos.X;
            line2.Y2 = mousePos.Y;


            // Set the stroke and thickness of the line
            line.Stroke = Brushes.Blue;
            line.StrokeThickness = 2;
            line2.Stroke = Brushes.Red;
            line2.StrokeThickness = 2;

            // Add the line to a Canvas object

            canvas.Children.Clear();
            canvas.Children.Add(line);
            canvas.Children.Add(line2);
           
        }

        private void MainWindow_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
   
}


    


