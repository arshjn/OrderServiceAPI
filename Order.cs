using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesAssignment4
{
    public class Order
    {
        public int orderID;
        public int customerID;
        public DateTime orderDate;
        public decimal shippingPrice;
        public int? trackingNumber;
        public List<OrderDetail> orderDetails = new List<OrderDetail>();
        public Customer customer = new Customer();
    }

    public class OrderInfo
    {
        public int orderID;
        public string customerName;
        public DateTime OrderDate;

        public OrderInfo(int id, string name, DateTime date)
        {
            orderID = id;
            customerName = name;
            OrderDate = date;
        }
    }

    public class Address
    {

        public int addressId;

        public string street1;

        public string street2;

        public string city;

        public string state;

        public int zip;
    }


    public class OrderDetail
    {

        public int orderDetailId;

        public int orderId;

        public int productId;

        public Product products;

        public int quantity;

        public decimal price;
    }

    public class Product
    {

        public int productId;

        public string name;

        public string description;

        public decimal price;

        public Product(int pid, string n, string d, decimal p)
        {
            productId = pid;
            name = n;
            description = d;
            price = p;
        }

    }

    public class Customer
    {

        public int customerId;

        public string firstName;

        public string lastName;

        public string email;

        public int shippingAddressId;

        public Address shippingAddress = new Address();

        public int billingAddressId;

        public Address billingAddress = new Address();

    }
}