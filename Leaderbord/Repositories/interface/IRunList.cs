using System;
using System.Collections.Generic;
using Leaderbord.Models;

namespace Leaderbord.Repositories
{
    public interface IRunList
    {
        Run GetRun(Guid id);
        IEnumerable<Run> GetRuns();
        void CreateRun(Run run);
    }
}