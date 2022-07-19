using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }
    }
}
