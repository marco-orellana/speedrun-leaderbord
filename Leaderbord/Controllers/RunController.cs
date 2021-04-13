using Leaderbord.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using Leaderboard.Dtos;
using Leaderboard.Extension_methods;
using Leaderbord.Dtos.Dtos_Create;
using Leaderbord.Models;

namespace Leaderbord.Controllers
{
    [ApiController]
    [Route("Runs")]
    public class RunController : ControllerBase
    {
        private readonly IRunList repository;

        public RunController(IRunList provider)
        {
            repository = provider;
        }

        [HttpGet]
        public IEnumerable<RunDto> GetRuns()
        {
            var runs = repository.GetRuns().Select(run => run.AsDto());
            return runs;
        }

        [HttpGet("{id}")]
        public ActionResult<RunDto> GetRun(Guid id)
        {
            var run = repository.GetRun(id);
            if (run == null)
            {
                return NotFound();
            }
            return run.AsDto();
        }

        [HttpPost]
        public ActionResult<RunDto> CreateRun(CreateRunDto runDto)
        {
            Run run = new()
            {
                Id = Guid.NewGuid(),
                game = runDto.game,
                user = runDto.user,
                category = runDto.category,
                hours = runDto.hours,
                minutes = runDto.minutes,
                seconds = runDto.seconds,
                creationDate = DateTimeOffset.UtcNow
            };

            repository.CreateRun(run);
            return CreatedAtAction(nameof(GetRun), new {id = run.Id}, run.AsDto());
        }
    }
}