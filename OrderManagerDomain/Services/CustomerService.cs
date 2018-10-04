using OrderManager.Domain.Contracts.Repositories;
using OrderManager.Domain.Contracts.Services;
using OrderManager.Domain.DTOs;
using OrderManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository CustomerRepository { get; }

        public CustomerService(ICustomerRepository customerRepository) => this.CustomerRepository = customerRepository;


        public List<Customer> GetList() => CustomerRepository.GetList();

        public void Insert(Customer customer) => CustomerRepository.Insert(customer);
        public void Insert(IEnumerable<Customer> customers) => CustomerRepository.Insert(customers);

        public void Update(Customer customer) => CustomerRepository.Update(customer);
        public void Update(IEnumerable<Customer> customers) => CustomerRepository.Update(customers);

        public void Delete(Customer customer) => CustomerRepository.Delete(customer);
        public void Delete(IEnumerable<Customer> customers) => CustomerRepository.Delete(customers);

        public List<Customer> GetFilterBatch(FilterOrder filter) => CustomerRepository.GetFilterBatch(filter);

    }
}
