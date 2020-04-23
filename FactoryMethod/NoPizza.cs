using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class NoPizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
