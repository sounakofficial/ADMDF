using MyFoodSupply;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSupplyTest
{
    [TestFixture]
    public class FoodTest
    {
        private Program p = null;
        private FoodDetail fd = null;

        [SetUp]
        public void Init()
        {
            p = new Program();
            fd = p.CreateFoodDetail("pizza", 1, DateTime.Parse("11/12/2025"), 52);
        }

        [Test]
        [TestCase("pizza", 1, "11/12/2021", 52)]
        [TestCase("burger", 2, "09/05/2023", 89)]
        [TestCase("sushi", 3, "07/10/2022", 120.55)]
        public void CreateFoodDetail_WhenCalled_ReturnFoodDetail(string name, int dishType, string expiryDate, double price)
        {
            FoodDetail f = p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price);
            var category = (FoodDetail.Category)dishType;
            Assert.That(f.Name, Is.EqualTo(name));
            Assert.That(f.DishType, Is.EqualTo(category));
            Assert.That(f.ExpiryDate, Is.EqualTo(DateTime.Parse(expiryDate)));
            Assert.That(f.Price, Is.EqualTo(price));
        }

        [Test]
        [TestCase("", 1, "11/12/2021", 52)]
        [TestCase(null, 1, "11/12/2021", 52)]
        public void CreateFoodDetail_FoodNameIsNullOrEmpty_RaiseException(string name, int dishType, string expiryDate, double price)
        {
            var a = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
        }

        [Test]
        [TestCase("burger", 2, "09/05/2021", -89)]
        [TestCase("sushi", 3, "07/10/2023", 0)]
        public void CreateFoodDetail_PriceLessThanZero_RaiseException(string name, int dishType, string expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
        }

        [Test]
        [TestCase("burger", 2, "09/05/2020", 89)]
        [TestCase("sushi", 3, "07/10/2020", 120.55)]
        public void CreateFoodDetail_ExpiryDateLessThanCurrentDate_RaiseException(string name, int dishType, string expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
        }

        [Test]
        [TestCase(12, "09/05/2021", "abc", 10.50)]
        [TestCase(17, "09/05/2021", "xyz", 15.99)]
        public void CreateSupplyDetail_WhenCalled_ReturnSupplyDetail(int foodItemCount, string requestDate, string sellerName, double packingCharge)
        {
            SupplyDetail s = p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fd);
            Assert.That(s, Is.TypeOf<SupplyDetail>());
        }

        [Test]
        [TestCase(0, "09/05/2021", "abc", 10.50)]
        [TestCase(-1, "09/05/2021", "abc", 10.50)]
        public void CreateSupplyDetail_FoodItemCountLessThanZero_RaiseException(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fd));
        }

        [Test]
        [TestCase(10, "09/05/2020", "abc", 10.50)]
        [TestCase(10, "09/05/2017", "abc", 10.50)]
        public void CreateSupplyDetail_RequestDateLessThanCurrentDate_RaiseException(int foodItemCount, string requestDate, string sellerName, double packingCharge)
        {
            Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fd));
        }

        [Test]
        [TestCase(10, "09/05/2021", "abc", 10.50, null)]
        public void CreateSupplyDetail_NullFoodDetail_RaiseException(int foodItemCount, string requestDate, string sellerName, double packingCharge, FoodDetail foodItem)
        {
            var result = p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, foodItem);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}