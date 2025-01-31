﻿using Microsoft.AspNetCore.Mvc;
using Movies.Api.Mapping;
using Movies.Application.Models;
using Movies.Application.Repositories;
using Movies.Contract.Request;

namespace Movies.Api.Controllers;

[ApiController]
[Route("api")]
public class MoviesController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MoviesController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpPost("movies")]
    public async Task<IActionResult> Create([FromBody] CreateMovieRequest request)
    {

        var movie = request.MapToMovie();
        var Result = await _movieRepository.CreateAsync(movie);
        var Resp = new Movie();//TODO change this
        return Created($"/api/movies/{movie.Id}", Resp);
    }
}
