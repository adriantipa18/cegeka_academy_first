using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console.Given.Interfaces
{
    interface IApplicationServices<T> where T : IEntity
    {
        string getUsers();
        string insertUser(T user);
    }
}
