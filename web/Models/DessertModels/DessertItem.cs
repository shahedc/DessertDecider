using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static web.Utils.DessertUtils;

namespace web.Models.DessertModels
{
    public class DessertItem
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DessertPoints Points { get; set; }
    }
}
