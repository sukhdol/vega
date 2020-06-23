﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using vega.Models;

namespace vega.Controllers.Resources
{
    public class VehicleResource
    {
        public VehicleResource()
        {
            Features = new Collection<FeatureResource>();
        }
        
        public int Id { get; set; }
        
        public bool IsRegistered { get; set; }
        
        public ContactResource Contact { get; set; }
        
        public DateTime LastUpdate { get; set; }

        public ModelResource Model { get; set; }

        public MakeResource Make { get; set; }
        public ICollection<FeatureResource> Features { get; set; }
    }
}