using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerProductService;
using CustomerProductService.Models;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerDBContext _context;

        public CustomersController(CustomerDBContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // POSST: api/CreateCustomers
        [HttpPost("CreateCustomer")]
        public async Task<ActionResult<bool>> CreateCustomer([FromBody]Customer cust, string creditcardNum)
        {
            Customer c = new Customer()
            {
                CustomerName = cust.CustomerName,
                CustomerEmail = cust.CustomerEmail,
                CustomerPhone = cust.CustomerPhone,
                CustomerCity = cust.CustomerCity,
                CustomerPostalCode = cust.CustomerPostalCode,
                CustomerState = cust.CustomerState
            };
            var customer = await _context.Customers.AddAsync(c);
            var customerPaymentDetails = await _context.CustomerPaymentInfo.AddAsync(new CustomerPaymentInfo()
            {
                CustomerId = c.CustomerId,
                CustomerCardNum = creditcardNum

            });
            await _context.SaveChangesAsync();

            if (customer == null)
            {
                return NotFound();
            }

            return true;
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(Guid id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
