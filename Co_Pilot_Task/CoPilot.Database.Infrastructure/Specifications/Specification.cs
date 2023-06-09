﻿using System.Linq.Expressions;

namespace CoPilot.Database.Infrastructure.Specifications
{
    public abstract class Specification<T> where T : class
    {
        public abstract Expression<Func<T, bool>> Expression { get; }

        public static Expression<Func<T, bool>> True()
        {
            return input => true;
        }

        public static Expression<Func<T, bool>> False()
        {
            return input => false;
        }

        public static Specification<T> operator &(Specification<T> spec1, Specification<T> spec2) => new AndSpecification<T>(spec1, spec2);

        public static Specification<T> operator |(Specification<T> spec1, Specification<T> spec2) => new OrSpecification<T>(spec1, spec2);
    }
}
