using System;
using System.Collections.Generic;
using Leaderbord.Models;
using System.Linq;

namespace Leaderbord.Repositories
{
    public class RunList : IRunList
    {
        public readonly List<Run> runs = new List<Run>();

        public void CreateRun(Run run)
        {
            runs.Add(run);
        }

        public Run GetRun(Guid id)
        {
            return runs.Where(run => run.Id == id).SingleOrDefault();
        }

        public IEnumerable<Run> GetRuns()
        {
            return runs;
        }
    }
}