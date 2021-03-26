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
            order1.orderID = 3;
            order1.customerID = 5;
            order1.orderDate = new DateTime(2020, 1, 1);
            order1.shippingPrice = 12.99m;
            order1.trackingNumber = null;
            
            var orderDetail1 = new OrderDetail();
            orderDetail1.orderDetailId = 9;
            orderDetail1.orderId = 3;
            orderDetail1.productId = 4;
            orderDetail1.products = new Product(4, "Shirts", "", 12.00m);
            orderDetail1.quantity = 2;
            orderDetail1.price = 10;

            order1.orderDetails.Add(orderDetail1);

            var orderDetail2 = new OrderDetail();
            orderDetail2.orderDetailId = 10;
            orderDetail2.orderId = 3;
            orderDetail2.productId = 3;
            orderDetail2.products = new Product(3, "Pants", "", 12.00m);
            orderDetail2.quantity = 5;
            orderDetail2.price =20;

            order1.orderDetails.Add(orderDetail2);

            order1.customer.customerId = 5;
            order1.customer.firstName = "Jane";
            order1.customer.lastName = "Doe";
            order1.customer.email = "jane@doe.com";
            order1.customer.shippingAddressId = 1005;
            order1.customer.shippingAddress.addressId = 1005;
            order1.customer.shippingAddress.street1 = "12 main st";
            order1.customer.shippingAddress.street2 = "apt 111";
            order1.customer.shippingAddress.city = "DAvie";
            order1.customer.shippingAddress.state = "FL";
            order1.customer.shippingAddress.zip = 33314;

            order1.customer.billingAddressId = 1006;
            order1.customer.billingAddress.addressId = 1006;
            order1.customer.billingAddress.street1 = "PO Box 123456";
            order1.customer.billingAddress.city = "Davie";
            order1.customer.billingAddress.state = "FL";
            order1.customer.billingAddress.zip = 33329;

            orders.Add(order1);

            Order order2 = new Order();
            order2.orderID = 4;
            order2.customerID = 5;
            order2.orderDate = new DateTime(2020, 1, 1);
            order2.shippingPrice = 12.99m;
            order2.trackingNumber = null;

            var orderDetail3 = new OrderDetail();
            orderDetail3.orderDetailId = 9;
            orderDetail3.orderId = 4;
            orderDetail3.productId = 4;
            orderDetail3.products = new Product(4, "Shirts", "", 12.00m);
            orderDetail3.quantity = 2;
            orderDetail3.price = 10;

            order2.orderDetails.Add(orderDetail3);

            var orderDetail4 = new OrderDetail();
            orderDetail4.orderDetailId = 10;
            orderDetail4.orderId = 4;
            orderDetail4.productId = 3;
            orderDetail4.products = new Product(3, "Pants", "", 12.00m);
            orderDetail4.quantity = 5;
            orderDetail4.price = 20;

            order2.orderDetails.Add(orderDetail4);

            order2.customer.customerId = 5;
            order2.customer.firstName = "Jane";
            order2.customer.lastName = "Doe";
            order2.customer.email = "jane@doe.com";
            order2.customer.shippingAddressId = 1005;
            order2.customer.shippingAddress.addressId = 1005;
            order2.customer.shippingAddress.street1 = "12 main st";
            order2.customer.shippingAddress.street2 = "apt 111";
            order2.customer.shippingAddress.city = "DAvie";
            order2.customer.shippingAddress.state = "FL";
            order2.customer.shippingAddress.zip = 33314;

            order2.customer.billingAddressId = 1006;
            order2.customer.billingAddress.addressId = 1006;
            order2.customer.billingAddress.street1 = "PO Box 123456";
            order2.customer.billingAddress.city = "Davie";
            order2.customer.billingAddress.state = "FL";
            order2.customer.billingAddress.zip = 33329;

            orders.Add(order2);

            foreach (Order order in orders)
            {
                OrderInfo orderInfo = new OrderInfo(order.orderID, order.customer.firstName + order.customer.lastName, order.orderDate);
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
                if (order.orderID == id)
                    return order;
            }
            return null;
        }

        public string UpdateTrackingNumber(string trackingNumber, int orderID)
        {
            foreach (Order order in orders)
            {
                if (order.orderID == orderID)
                {
                    order.trackingNumber = Convert.ToInt32(trackingNumber);
                    return "Tracking Number Updated";
                }
            }
            return null;
        }

    }
}