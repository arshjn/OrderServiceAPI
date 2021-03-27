using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesAssignment4
{
    public class Order
    {
        private int orderID;
        private int customerID;
        private DateTime orderDate;
        private decimal shippingPrice;
        private string? trackingNumber;
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        private Customer customer = new Customer();

        public int OrderID { get => orderID; set => orderID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public decimal ShippingPrice { get => shippingPrice; set => shippingPrice = value; }
        public string? TrackingNumber { get => trackingNumber; set => trackingNumber = value; }
        public List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }
        public Customer Customer { get => customer; set => customer = value; }
    }

    public class OrderInfo
    {
        private int orderID;
        private string customerName;
        private DateTime orderDate;

        public int OrderID { get => orderID; set => orderID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }

        public OrderInfo(int id, string name, DateTime date)
        {
            OrderID = id;
            CustomerName = name;
            OrderDate = date;
        }
    }

    public class Address
    {

        private int addressId;

        private string street1;

        private string street2;

        private string city;

        private string state;

        private int zip;

        public int AddressId { get => addressId; set => addressId = value; }
        public string Street1 { get => street1; set => street1 = value; }
        public string Street2 { get => street2; set => street2 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Zip { get => zip; set => zip = value; }
    }


    public class OrderDetail
    {

        private int orderDetailId;

        private int orderId;

        private int productId;

        private Product products;

        private int quantity;

        private decimal price;

        public int OrderDetailId { get => orderDetailId; set => orderDetailId = value; }
        public int OrderId { get => orderId; set => orderId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public Product Products { get => products; set => products = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
    }

    public class Product
    {

        private int productId;

        private string name;

        private string description;

        private decimal price;

        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }

        public Product(int pid, string n, string d, decimal p)
        {
            ProductId = pid;
            Name = n;
            Description = d;
            Price = p;
        }

    }

    public class Customer
    {

        private int customerId;

        private string firstName;

        private string lastName;

        private string email;

        private int shippingAddressId;

        private Address shippingAddress = new Address();

        private int billingAddressId;

        private Address billingAddress = new Address();

        public int CustomerId { get => customerId; set => customerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int ShippingAddressId { get => shippingAddressId; set => shippingAddressId = value; }
        public int BillingAddressId { get => billingAddressId; set => billingAddressId = value; }
        public Address ShippingAddress { get => shippingAddress; set => shippingAddress = value; }
        public Address BillingAddress { get => billingAddress; set => billingAddress = value; }
    }
}