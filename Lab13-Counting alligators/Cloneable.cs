﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_alligators
{
    interface Cloneable:Countable
    {
        string getName();
        Cloneable cloneAnimal(Cloneable animal);
        void setCloneName(string name);

    }
}
