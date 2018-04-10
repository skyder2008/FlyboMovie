﻿using FlyboMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyboMovie.Data.Repository.Implement
{
    public class MovieRepository : RecordRepositoryBase<int, Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}