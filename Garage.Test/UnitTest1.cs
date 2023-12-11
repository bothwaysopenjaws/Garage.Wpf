using Garage.DbLib.Models;
using Garage.Wpf.ViewModels;
using System.Collections.ObjectModel;
using System.Configuration;

namespace Garage.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ConnectionStringSettings connectionStringSettings = new()
            {
                Name = "SQLServerConnection",
                ConnectionString = "Server=localhost;Database=Garage;Trusted_Connection=True;TrustServerCertificate=True;"

            };
        }

        [Test]
        public void Test1()
        {

            ViewModelBrandView viewModelBrandView = new ViewModelBrandView();
            ObservableCollection<Brand> list = viewModelBrandView.GenerateData();
            
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 6);
            
            Assert.Pass();
        }
    }
}