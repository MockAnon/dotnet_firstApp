﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.core
{



    public class Restaurant
    {
        public int Id
        {
            get; set;
        }

        public string Name {
            get; set;
        }
        public string Location
        {
            get; set;
        }
        public Restaurant()
        {
        }
        public CuisineType Cuisine {
            get; set;
        }
}
