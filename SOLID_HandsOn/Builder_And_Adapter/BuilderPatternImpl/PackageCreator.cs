using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternImpl
{
    public class PackageCreator
    {
        private PackageBuilder _builder;

        public PackageCreator(PackageBuilder builder)
        {
            _builder = builder;
        }

        public void CreatePackage()
        {
            _builder.BuildSavory();
            _builder.BuildSweet();
        }

        public Package GetPackage()
        {
            return _builder.GetPackage();
        }
    }
}