using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

namespace GuitarHubSelfHost
{
   public class GuitarHubController : ApiController
    {
        public List<clsGuitar> GetGuitars()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM guitar", null);
            List<clsGuitar> lcNames = new List<clsGuitar>();
            foreach (DataRow dr in lcResult.Rows)
            {
                clsGuitar lcGuitar = new clsGuitar();
                lcGuitar.serial_no = (int)dr["serial_no"];
                lcGuitar.guitar_type = (string)dr["guitar_type"];
                lcGuitar.style = (string)dr["style"];
                lcGuitar.price = (decimal)dr["price"];
                lcGuitar.quantity = (int)dr["quantity"];
                lcGuitar.tremolo = (string)dr["tremolo"].ToString();
                lcGuitar.pickup = (string)dr["pickup"].ToString();
                lcGuitar.electric = dr["electric"].ToString();
                lcGuitar.hollow = dr["hollow"].ToString();
                lcNames.Add(lcGuitar);
            }
            return lcNames;
        }

        public List<clsOrders> GetOrders()
        {

        DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM orders", null);
            List<clsOrders> lcNames = new List<clsOrders>();
            foreach (DataRow dr in lcResult.Rows)
            {
                clsOrders lcOrders = new clsOrders();
                lcOrders.order_id = (int)dr["order_id"];
                lcOrders.order_date = (DateTime)dr["order_date"];
                lcOrders.total_price = (decimal)dr["total_price"];
                lcOrders.customer_name = (string)dr["customer_name"];
                lcOrders.customer_address = (string)dr["customer_address"];
                lcOrders.customer_phone = (string)dr["customer_phone"];
                lcOrders.customer_email = (string)dr["customer_email"];
                lcNames.Add(lcOrders);
            }
            return lcNames;
        }

        public List<clsOrderItems> GetOrder(int prID)
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM orderitems WHERE order_id=" + prID, null);
            List<clsOrderItems> lcNames = new List<clsOrderItems>();
            foreach (DataRow dr in lcResult.Rows)
            {
                clsOrderItems lcOrders = new clsOrderItems();
                lcOrders.orderitems_id = (int)dr["orderitems_id"];
                lcOrders.order_id = (int)dr["order_id"];
                lcOrders.serial_no = (int)dr["serial_no"];
                lcOrders.price = (decimal)dr["price"];
                lcNames.Add(lcOrders);
            }
            return lcNames;
        }


        public string PutGuitar(clsGuitar prGuitar)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "UPDATE guitar SET price = @price, quantity = @quantity, tremolo = @tremolo, pickup = @pickup, electric = @electric, hollow = @hollow WHERE serial_no = @serial_no",
        prepareGuitarParameters(prGuitar));
                if (lcRecCount == 1)
                    return "One guitar updated";
                else
                    return "Unexpected guitar update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        public string DeleteProduct(int serial_no)
        {   // delete
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "DELETE FROM guitar WHERE serial_no='" + serial_no + "'", null);
                if (lcRecCount == 1)
                    return "One product deleted";
                else
                    return "Unexpected product delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteOrder(int order_id)
        {   // delete
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "DELETE FROM orders WHERE order_id='" + order_id + "'", null);
                if (lcRecCount == 1)
                    return "One order deleted";
                else
                    return "Unexpected order delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PostGuitar(clsGuitar prGuitar)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "Insert Into guitar Values(@serial_no, @guitar_type, @style, @price, @quantity, @tremolo, @pickup, @electric, @hollow)",
        prepareGuitarParameters(prGuitar));
                if (lcRecCount == 1)
                    return "One guitar inserted";
                else
                    return "Unexpected guitar insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareGuitarParameters(clsGuitar prGuitar)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(9);
            par.Add("serial_no", prGuitar.serial_no.ToString());
            par.Add("guitar_type", prGuitar.guitar_type);
            par.Add("style", prGuitar.style);
            par.Add("price", prGuitar.price.ToString());
            par.Add("quantity", prGuitar.quantity.ToString());
            par.Add("tremolo", prGuitar.tremolo);
            par.Add("pickup", prGuitar.pickup);
            par.Add("electric", prGuitar.electric);
            par.Add("hollow", prGuitar.hollow);
            return par;
        }


    }
}
