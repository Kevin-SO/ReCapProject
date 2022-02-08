using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDAL;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDAL = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDAL.Add(customer);
            return new SuccessResult("Customer added");

        }

        public IResult Delete(Customer customer)
        {
            _customerDAL.Delete(customer);
            return new SuccessResult("Customer deleted");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDAL.GetAll(), "Customers Listed");
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDAL.Get(u => u.UserId == id),"Customer listed");
        }

        public IResult Update(Customer customer)
        {
            _customerDAL.Update(customer);
            return new SuccessResult("Customer updated");
        }
    }
}
