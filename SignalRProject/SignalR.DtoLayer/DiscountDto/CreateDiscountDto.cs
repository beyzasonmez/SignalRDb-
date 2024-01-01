using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.DiscountDto
{
    public class CreateDiscountDto
    {
        public string Title { get; set; }
        public string Amount { get; set; } //indirelecek miktar
        public string Description { get; set; } //açıklama
        public string ImageUrl { get; set; }
    }
}
