using Computers.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Computers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private static readonly List<Computer> allComputers = new List<Computer> {
            new Computer("69.162.81.155", new List<Tag>
            { 
                new Tag("Vulnerable", "red"),
                new Tag("Desktop", "blue")
            }),
            new Computer("192.199.248.75", new List<Tag>
            {
                new Tag("Vulnerable", "red"),
                new Tag("Laptop", "yellow") 
            }),
            new Computer("162.254.206.227", new List<Tag> 
            {
                new Tag("Laptop", "yellow"),
                new Tag("Patched", "green") 
            }),
            new Computer("162.254.206.227", new List<Tag>
            {
                new Tag("Decommissioned", "black")
            })
        };

        [HttpGet]
        public IEnumerable<Computer> GetByTags([FromQuery] string tags)
        {
            if (string.IsNullOrWhiteSpace(tags))
            {
                return allComputers;
            }

            throw new NotImplementedException("This needs finishing up.");
        }

        [HttpGet("{ip}")]
        public IEnumerable<Computer> GetByIp(string ip)
        {
            return allComputers;
        }
    }
}
