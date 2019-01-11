using System;
using System.Collections.Generic;

namespace GenericsDrill
{

    public class Employee<T>
    {

        public List<T> Things { get; set; }

        public string Items { get; set; }

        public int Numbers { get; set; }

    }




}