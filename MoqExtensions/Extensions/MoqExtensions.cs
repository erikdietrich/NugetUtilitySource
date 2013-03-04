using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Moq;
using Moq.Language.Flow;

namespace NugetUtilitySource.MoqExtensions.Extensions
{
    public static class MoqExtensions
    {
        public static void ReturnsInOrder<T, TResult>(this ISetup<T, TResult> setup, params TResult[] results) where T : class
        {
            setup.Returns(new Queue<TResult>(results).Dequeue);
        }

        public static ISetup<T, TResult> Setup<T, TResult>(this T mock, Expression<Func<T, TResult>> expression) where T : class
        {
            return Mock.Get(mock).Setup(expression);
        }

        public static ISetup<T> Setup<T>(this T mock, Expression<Action<T>> expression) where T : class
        {
            return Mock.Get(mock).Setup(expression);
        }

        public static void Verify<T, TResult>(this T mock, Expression<Func<T, TResult>> expression) where T : class
        {
            Mock.Get(mock).Verify(expression);
        }

        public static void Verify<T>(this T mock, Expression<Action<T>> expression, Times times) where T : class
        {
            Mock.Get(mock).Verify(expression, times);
        }

        public static void Verify<T>(this T mock, Expression<Action<T>> expression) where T : class
        {
            Mock.Get(mock).Verify(expression);
        }

        public static void Verify<T, TResult>(this T mock, Expression<Func<T, TResult>> expression, Times times) where T : class
        {
            Mock.Get(mock).Verify(expression, times);
        }

        public static IEnumerable<T> ToEnumerable<T>(this T item)
        {
            yield return item;
        }

        public static IEnumerable<T> ToEnumerable<T>(this T item, int count)
        {
            for (int index = 0; index < count; index++)
                yield return item;
        }
    }
}
