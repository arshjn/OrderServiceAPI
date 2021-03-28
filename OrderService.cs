using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesAssignment4
{
    public class OrderService
    {
        public static List<Order> orders;
        public static List<OrderInfo> infos;

        public OrderService()
        {

            orders = new List<Order>();
            infos = new List<OrderInfo>();
            //Creating 2 sample orders
            Order order1 = new Order();
            order1.OrderID = 3;
            order1.CustomerID = 5;
            order1.OrderDate = new DateTime(2020, 1, 1);
            order1.ShippingPrice = 12.99m;
            order1.TrackingNumber = null;
            
            var orderDetail1 = new OrderDetail();
            orderDetail1.OrderDetailId = 9;
            orderDetail1.OrderId = 3;
            orderDetail1.ProductId = 4;
            orderDetail1.Products = new Product(4, "Shirts", "", 12.00m);
            orderDetail1.Quantity = 2;
            orderDetail1.Price = 10;

            order1.OrderDetails.Add(orderDetail1);

            var orderDetail2 = new OrderDetail();
            orderDetail2.OrderDetailId = 10;
            orderDetail2.OrderId = 3;
            orderDetail2.ProductId = 3;
            orderDetail2.Products = new Product(3, "Pants", "", 12.00m);
            orderDetail2.Quantity = 5;
            orderDetail2.Price =20;

            order1.OrderDetails.Add(orderDetail2);

            order1.Customer.CustomerId = 5;
            order1.Customer.FirstName = "Jane";
            order1.Customer.LastName = "Doe";
            order1.Customer.Email = "jane@doe.com";
            order1.Customer.ShippingAddressId = 1005;
            order1.Customer.ShippingAddress.AddressId = 1005;
            order1.Customer.ShippingAddress.Street1 = "12 main st";
            order1.Customer.ShippingAddress.Street2 = "apt 111";
            order1.Customer.ShippingAddress.City = "DAvie";
            order1.Customer.ShippingAddress.State = "FL";
            order1.Customer.ShippingAddress.Zip = 33314;

            order1.Customer.BillingAddressId = 1006;
            order1.Customer.BillingAddress.AddressId = 1006;
            order1.Customer.BillingAddress.Street1 = "PO Box 123456";
            order1.Customer.BillingAddress.City = "Davie";
            order1.Customer.BillingAddress.State = "FL";
            order1.Customer.BillingAddress.Zip = 33329;

            orders.Add(order1);

            Order order2 = new Order();
            order2.OrderID = 4;
            order2.CustomerID = 5;
            order2.OrderDate = new DateTime(2020, 1, 1);
            order2.ShippingPrice = 12.99m;
            order2.TrackingNumber = null;

            var orderDetail3 = new OrderDetail();
            orderDetail3.OrderDetailId = 9;
            orderDetail3.OrderId = 4;
            orderDetail3.ProductId = 4;
            orderDetail3.Products = new Product(4, "Shirts", "", 12.00m);
            orderDetail3.Quantity = 2;
            orderDetail3.Price = 10;

            order2.OrderDetails.Add(orderDetail3);

            var orderDetail4 = new OrderDetail();
            orderDetail4.OrderDetailId = 10;
            orderDetail4.OrderId = 4;
            orderDetail4.ProductId = 3;
            orderDetail4.Products = new Product(3, "Pants", "", 12.00m);
            orderDetail4.Quantity = 5;
            orderDetail4.Price = 20;

            order2.OrderDetails.Add(orderDetail4);

            order2.Customer.CustomerId = 5;
            order2.Customer.FirstName = "Jane";
            order2.Customer.LastName = "Doe";
            order2.Customer.Email = "jane@doe.com";
            order2.Customer.ShippingAddressId = 1005;
            order2.Customer.ShippingAddress.AddressId = 1005;
            order2.Customer.ShippingAddress.Street1 = "12 main st";
            order2.Customer.ShippingAddress.Street2 = "apt 111";
            order2.Customer.ShippingAddress.City = "DAvie";
            order2.Customer.ShippingAddress.State = "FL";
            order2.Customer.ShippingAddress.Zip = 33314;

            order2.Customer.BillingAddressId = 1006;
            order2.Customer.BillingAddress.AddressId = 1006;
            order2.Customer.BillingAddress.Street1 = "PO Box 123456";
            order2.Customer.BillingAddress.City = "Davie";
            order2.Customer.BillingAddress.State = "FL";
            order2.Customer.BillingAddress.Zip = 33329;

            orders.Add(order2);

            foreach (Order order in orders)
            {
                OrderInfo orderInfo = new OrderInfo(order.OrderID, order.Customer.FirstName + order.Customer.LastName, order.OrderDate);
                infos.Add(orderInfo);
            }
        }


        public List<OrderInfo> GetOrders()
        {
            return infos;
        }

        public Order GetOrder(int id)
        {
            foreach (Order order in orders)
            {
                if (order.OrderID == id)
                    return order;
            }
            return null;
        }

        public string UpdateTrackingNumber(string trackingNumber, int orderID)
        {
            foreach (Order order in orders)
            {
                if (order.OrderID == orderID)
                {
                    order.TrackingNumber = trackingNumber;
                    return "Tracking Number Updated: " + trackingNumber;
                }
            }
            return null;
        }

    }
}