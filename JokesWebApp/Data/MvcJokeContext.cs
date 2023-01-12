using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWebApp.Models;

    public class MvcJokeContext : DbContext
    {
        public MvcJokeContext (DbContextOptions<MvcJokeContext> options)
            : base(options)
        {
        }

        public DbSet<JokesWebApp.Models.Joke> Joke { get; set; } = default!;
    }
