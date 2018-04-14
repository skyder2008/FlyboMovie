﻿using FlyboMovie.Common;
using FlyboMovie.Dtos;
using FlyboMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyboMovie.Services
{
    public interface IMovieService : IDataService<Movie, MovieDto, int>
    {
        IList<MovieLiteDto> GetLatestMovies();
        IList<MovieLiteDto> GetHotestMovies();
        IList<MovieLiteDto> Search(string keywords);
    }
}
