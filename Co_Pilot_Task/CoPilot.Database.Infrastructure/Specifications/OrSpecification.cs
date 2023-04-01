using System.Linq.Expressions;

namespace CoPilot.Database.Infrastructure.Specifications
{
    public class OrSpecification<T> : Specification<T> where T : class
    {
        private readonly Specification<T> _spec1;
        private readonly Specification<T> _spec2;

        public OrSpecification(Specification<T> spec1, Specification<T> spec2)
        {
            _spec1 = spec1;
            _spec2 = spec2;
        }

        public override Expression<Func<T, bool>> Expression =>
            System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(
                System.Linq.Expressions.Expression.OrElse(_spec1.Expression, _spec2.Expression));
    }
}
