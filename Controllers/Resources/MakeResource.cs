using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Controllers.Resources
{
    public class MakeResource : KeyValuePairResource
    {
        public MakeResource()
        {
            Models = new Collection<KeyValuePairResource>();
        }

        public ICollection<KeyValuePairResource> Models { get; set; }
    }
}