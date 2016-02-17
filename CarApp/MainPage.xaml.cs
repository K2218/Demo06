using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Trucksbutton_Click(object sender, RoutedEventArgs e)
        {
            string trucksString = TrucksText.Text;
            int trucks = int.Parse(trucksString);
            //ADD one truck
            trucks++;
            //Show new value
            TrucksText.Text = trucks.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string carsString = CarsText.Text;
            int cars = int.Parse(carsString);
            cars++;
            TrucksText.Text = cars.ToString();
        }

        private void CarsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
