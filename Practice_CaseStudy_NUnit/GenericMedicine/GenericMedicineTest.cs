using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMedicine
{
    [TestFixture]
    internal class GenericMedicineTest
    {
        private Program ObjMainProgram = null;
        private Medicine m = null;

        [SetUp]
        public void Init()
        {
            ObjMainProgram = new Program();

            //For Testing the Carton methods
            m = ObjMainProgram.CreateMedicineDetail("original_medicine_name1", "gen_name1", "compositionxyz", DateTime.Parse("11/12/2025"), 50);
        }

        [Test]
        [TestCase("original_medicine_name1", "gen_name1", "compositionxyz", "11/12/2022", 50)]
        [TestCase("original_medicine_name2", "gen_name2", "compositionabc", "05/07/2025", 80)]
        [TestCase("original_medicine_name3", "gen_name3", "composition245", "03/06/2030", 21.45)]
        public void MedicineObjectCreationTest(string originalMed, string genericMed, string composition, string expiryDate, double pricePerStrip)
        {
            Medicine m = ObjMainProgram.CreateMedicineDetail(originalMed, genericMed, composition, DateTime.Parse(expiryDate), pricePerStrip);
            Assert.That(m.Name, Is.EqualTo(originalMed));
            Assert.That(m.GenericMedicineName, Is.EqualTo(genericMed));
            Assert.That(m.Composition, Is.EqualTo(composition));
            Assert.That(m.ExpiryDate, Is.EqualTo(DateTime.Parse(expiryDate)));
            Assert.That(m.PricePerStrip, Is.EqualTo(pricePerStrip));
        }

        [Test]
        [TestCase("original_medicine_name1", "", "compositionxyz", "11/12/2022", 50)]
        [TestCase("original_medicine_name2", "gen_name2", "compositionabc", "05/07/2025", -80)]
        [TestCase("original_medicine_name3", "gen_name3", "composition245", "03/06/2013", 21.45)]
        public void MedicineExceptionsTest(string originalMed, string genericMed, string composition, string expiryDate, double pricePerStrip)
        {
            try
            {
                Medicine m = ObjMainProgram.CreateMedicineDetail(originalMed, genericMed, composition, DateTime.Parse(expiryDate), pricePerStrip);
            }
            catch (Exception ex)
            {
                Assert.Pass(ex.Message.ToString());
            }
        }

        [Test]
        [TestCase(21, "11/12/2022", "addrs1")]
        [TestCase(15, "11/12/2023", "addrs2")]
        [TestCase(53, "11/12/2021", "addrs3")]
        public void CartonObjectCreationTest(int medicineStripCount, string launchDate, string retailerAddress)
        {
            CartonDetail c = ObjMainProgram.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, this.m);
            Assert.That(c.MedicineStripCount, Is.EqualTo(medicineStripCount));
            Assert.That(c.LaunchDate, Is.EqualTo(DateTime.Parse(launchDate)));
            Assert.That(c.RetailerAddress, Is.EqualTo(retailerAddress));
            Assert.That(c.Medicine, Is.EqualTo(this.m));
        }

        [Test]
        [TestCase(-21, "11/12/2022", "addrs1")]
        [TestCase(15, "11/12/2020", "addrs2")]
        public void CartonExceptionsTest(int medicineStripCount, string launchDate, string retailerAddress)
        {
            try
            {
                CartonDetail c = ObjMainProgram.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, this.m);
            }
            catch (Exception ex)
            {
                Assert.Pass(ex.Message.ToString());
            }
        }

        [Test]
        [TestCase(15, "11/12/2021", "addrs2")]
        public void NullMedicineObjectTest(int medicineStripCount, string launchDate, string retailerAddress)
        {
            CartonDetail c = ObjMainProgram.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, null);
            Assert.That(c, Is.EqualTo(null));
        }
    }
}