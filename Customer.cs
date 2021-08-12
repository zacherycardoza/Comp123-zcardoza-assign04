using System;
using System.Collections.Generic;

public class Customer
{
    public String firstName;
    public String lastName;
    public int customerID { get; set; }
    private static int nextCustomerID = 62921;

    //default constructor
    public Customer()
    {
        firstName = "";
        lastName = "";
        customerID = 1;
        nextCustomerID += 1;
        customerID = nextCustomerID;

    }

    public Customer(String first, String last)
    {
        firstName = first;
        lastName = last;
        customerID = 1;
        nextCustomerID += 1;
        customerID = nextCustomerID;
    }
}

