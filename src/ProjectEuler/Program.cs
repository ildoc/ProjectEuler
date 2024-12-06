using Common.Abstracts;
using ProjectEuler.Extensions;
using System.Reflection;

var showOnly = new List<int>
{
    8
};

var problems = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => t.IsClass && !t.IsAbstract && typeof(Problem).IsAssignableFrom(t))
    .OrderBy(x => x.Name);

foreach (var problem in problems.FilteredByShowOnly(showOnly))
{
    var p = (Problem)Activator.CreateInstance(problem);
    p?.PrintSolution();
}

Console.ReadLine();