using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Utilities
{
    public static class Listutilities
    {
        //EmptyList<User>()
        public static List<T> EmptyList<T>()
        {
            return new List<T>();
        }
        //list<user> userlist = new List<user>();
        //bool flag = userlist.NotNullOrEmpty()
        public static  bool NotNullOrEmpty<T> (this IList<T> list)
         
        {
            return list is not null && list.Any();
        }
        //if(userlist.IsNullOrEmpty())

        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list.NotNullOrEmpty() is false;
        }
        public static bool NotContains<T>(this IList<T> list, T item)
        {
            return list.Contains(item) is false;
        }
        public static bool ContainsDublicates<T,TType>(this IList<T> list, Func<T, TType> expression)
        {
            return list.GroupBy(expression).Any(x => x.Count() > 1);
        }
    }
}
