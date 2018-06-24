using System;

namespace GuitarHub
{
    public class clsOrders
    {
        //Accesses the properties of clsOrders
        public int order_id { get; set; }
        public DateTime order_date { get; set; }
        public decimal total_price { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public string customer_phone { get; set; }
        public string customer_email { get; set; }

        //Turns into string to show the selected order
        public override string ToString()
        {
            return order_id.ToString() + "\t" + customer_name;
        }

    }

    public class clsOrderItems
    {   
        //Accesses the properties of clsOrderItems
        public int orderitems_id { get; set; }
        public int order_id { get; set; }
        public int serial_no { get; set; }
        public decimal price { get; set; }

        //Turns into string to show the selected order
        public override string ToString()
        {
            return serial_no.ToString() + "\t" + price.ToString();
        }
    }

    public class clsGuitar
    {   
        //Accesses the properties of clsGuitar
        public int serial_no { get; set; }
        public string guitar_type { get; set; }
        public string style { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string tremolo { get; set; }
        public string pickup { get; set; }
        public string electric { get; set; }
        public string hollow { get; set; }

        //Returns a guitar form for either Acoustic or Electric
        public static clsGuitar NewGuitar(string prChoice)
        {
            return new clsGuitar() {guitar_type = prChoice};
        }

        //Turns into string to show the selected order
        public override string ToString()
        {
            return serial_no.ToString() + "\t" + guitar_type + "\t" + style + "\t" + quantity.ToString() + "\t" + price.ToString();
        }

    }

    public class clsGuitarTypes
    {
        //Accesses the properties of clsGuitarTypes
        public string guitar_type { get; set; }
        public string guitar_desc { get; set; }
    }
}
