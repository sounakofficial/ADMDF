using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternImpl
{
    public class AdultPackageBuilder : PackageBuilder
    {
        private Package _package = new Package();

        public override void BuildSavory()
        {
            _package.savory = 2;
        }

        public override void BuildSweet()
        {
            _package.sweets = 2;
        }

        public override Package GetPackage()
        {
            return _package;
        }
    }
}