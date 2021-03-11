using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;

namespace GeneralMedTest
{
    [TestFixture]
    public class MedTests
    {
        private Program _program;
        private Medicine m;

        [SetUp]
        public void SetUp()
        {
            _program = new Program();
            m = _program.CreateMedicineDetail("abc", "abc", "abc", DateTime.Parse("2021-04-08"), 1);
        }

        // NUnit test cases for Create Medicine detail
        [Test]
        [TestCase("abc", "abc", "abc", "2021-04-08", 1)]
        public void CreateMedicineDetail_WhenCalled_ReturnMedicine(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = _program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(result, Is.TypeOf<Medicine>());
        }

        [Test]
        [TestCase("abc", null, "abc", "2021-04-08", 1)]
        [TestCase("abc", "", "abc", "2021-04-08", 1)]
        public void CreateMedicineDetail_MedicineNameIsNullOrEmpty_RaiseExcception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => _program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase("abc", "abc", "abc", "2021-04-08", 0)]
        [TestCase("abc", "abc", "abc", "2021-04-08", -1)]
        public void CreateMedicineDetail_PricePerStripIsLessThanOrEqualZero_RaiseExcception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => _program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [Test]
        [TestCase("abc", "abc", "abc", "2021-02-08", 1)]
        public void CreateMedicineDetail_ExpiryDateLessThanCurrentDate_RaiseExcception(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => _program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        // NUnit test cases for Carton detail
        [Test]
        [TestCase(1, "2021-04-08", "abc")]
        public void CreateCartonDetail_WhenCalled_ReturnCartonDetail(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var result = _program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);

            Assert.That(result, Is.TypeOf<CartonDetail>());
        }

        [Test]
        [TestCase(0, "2021-04-08", "abc")]
        [TestCase(-1, "2021-04-08", "abc")]
        public void CreateCartonDetail_MedicineStripCountIsLessOrEqualZero_RaiseException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Assert.Throws<Exception>(() => _program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
        }

        [Test]
        [TestCase(1, "2020-04-08", "abc")]
        public void CreateCartonDetail_LaunchDateLessThanCurrentDate_RaiseException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Assert.Throws<Exception>(() => _program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
        }

        [Test]
        [TestCase(1, "2021-04-08", "abc", null)]
        public void CreateCartonDetail_IfMedicineIsNull_ReturnNull(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine medicine)
        {
            var result = _program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}