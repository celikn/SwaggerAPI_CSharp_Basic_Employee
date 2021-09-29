using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using swaggerCore.Data;


namespace swaggerCore.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        // GET: api/GetCoordinates
        [HttpGet("Coord")]
        public IEnumerable<GeographicCoordinates> GetCoord()
        {
            return GetCoordinates();
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return GetEmployees();
        }
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return GetEmployees().Find(e => e.Id == id);
        }
        // POST: api/Employee
        [HttpPost]
        [Produces("application/json")]
        public Employee Post([FromBody] Employee employee)
        {
            // Logic to create new Employee
            return new Employee();
        }
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            // Logic to update an Employee
        }
        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            }
        };
        }

        private List<GeographicCoordinates> GetCoordinates()
        {
            return new List<GeographicCoordinates>()
        {
            new GeographicCoordinates()
            {
                Lat = 39.9494,
                Lng = 37.9499494
               
            },
            new GeographicCoordinates()
            {

                Lat = 40.94940,
                Lng = 37.848494
            }
        };
        }


    }

}
