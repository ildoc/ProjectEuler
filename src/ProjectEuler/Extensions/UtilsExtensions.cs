namespace ProjectEuler.Extensions
{
    internal static class UtilsExtensions
    {
        internal static IEnumerable<Type> FilteredByShowOnly(this IEnumerable<Type> list, IEnumerable<int> showOnly)
        {
            if (!showOnly.Any()) { return list; }

            return list.Where(x => showOnly.Any(y => x.Name.EndsWith($"_{y:D3}")));
        }
    }
}
