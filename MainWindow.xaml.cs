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

namespace EquitiesProject
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

        private void StockContribution_Click(object sender, RoutedEventArgs e)
        {
            StockContribution StockContributionObject = new StockContribution();
            StockContributionObject.Show();
        }

        private void Allocation_Click(object sender, RoutedEventArgs e)
        {
            DiversifiedPortfolio DiversifiedPortfolioObject = new DiversifiedPortfolio();
            DiversifiedPortfolioObject.Show();
        }

        private void StockContribution1_Click(object sender, RoutedEventArgs e)
        {
            StockContributionRateofReturn StockContributionRateofReturnObject = new StockContributionRateofReturn();
            StockContributionRateofReturnObject.Show();
        }
    }
}
