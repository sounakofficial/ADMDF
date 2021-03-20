using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternImpl
{
    public abstract class PackageBuilder
    {
        public abstract void BuildSweet();

        public abstract void BuildSavory();

        public abstract Package GetPackage();
    }
}