﻿namespace CustomerManager.ViewModel
{
    using CustomerManager.Common;
    using CustomerManager.DataModel;
    using WebApi.Models;

    public class NewCustomerViewModel : BindableBase
    {
        public NewCustomerViewModel()
        {
            this.Customer = new CustomerViewModel();
        }

        public CustomerViewModel Customer { get; set; }

        public void CreateCustomer()
        {
            CustomersWebApiClient.CreateCustomer(new Customer
            {
                Name = this.Customer.Name,
                Phone = this.Customer.Phone,
                Address = this.Customer.Address,
                Email = this.Customer.Email,
                Company = this.Customer.Company,
                Title = this.Customer.Title,
                Image = this.Customer.ImagePath
            });
        }
    }
}
