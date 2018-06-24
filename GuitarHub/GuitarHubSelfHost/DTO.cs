using System;

namespace GuitarHubSelfHost
{
    public class clsOrders
    {
        public int order_id { get; set; }
        public DateTime order_date { get; set; }
        public decimal total_price { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string customer_phone { get; set; }
        public string customer_email { get; set; }
    }

    public class clsOrderItems
    {
        public int orderitems_id { get; set; }
        public int order_id { get; set; }
        public int serial_no { get; set; }
        public decimal price { get; set; }
    }

    public class clsGuitar
    {
        public int serial_no { get; set; }
        public string guitar_type { get; set; }
        public string style { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string tremolo { get; set; }
        public string pickup { get; set; }
        public string electric { get; set; }
        public string hollow { get; set; }
    }

    public class clsGuitarTypes
    {
        public string guitar_type { get; set; }
        public string guitar_desc { get; set; }
    }
}
