﻿using Movies.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Repositories
{
    internal class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movies;
        public Task<bool> CreateAsync(Movie movie)
        {
            _movies.Add(movie);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteByIdAsync(Guid id)
        {
            var removedCount = _movies.RemoveAll(x => x.Id == id);
            var movieRemoved = removedCount > 0;
            return Task.FromResult(movieRemoved);
        }

        public Task<IEnumerable<Movie>> GetAllAsync()
        {
            return Task.FromResult(_movies.AsEnumerable());
        }

        public Task<Movie?> GetByIdAsync(Guid id)
        {
            var movie = _movies.SingleOrDefault(x => x.Id == id);
            return Task.FromResult(movie);
        }

        public Task<bool> UpdateAsync(Movie movie)
        {
            var MatchingMovie = _movies.FindIndex(x => x.Id == movie.Id);
            if (MatchingMovie != -1)
            {
                _movies[MatchingMovie] = movie;
                return Task.FromResult(true);
            }
            else
                return Task.FromResult(false);

        }
    }
}
