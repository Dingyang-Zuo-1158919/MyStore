using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class BasketDTO
    {
        public int Id { get; set; }
        public string BuyerId { set; get; }
        public List<BasketItemDto> Items { get; set; }
        public string PaymentIntentId { get; set; }
        public string ClientSecret { get; set; }


    }
}