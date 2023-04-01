using System.Linq.Expressions;

namespace CoPilot.Database.Infrastructure.Specifications
{
    public class TrueSpecification<T> : Specification<T>
        where T : class
    {
        public override Expression<Func<T, bool>> Expression => True();
    }
}
