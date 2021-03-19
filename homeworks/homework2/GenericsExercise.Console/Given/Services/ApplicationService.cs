using GenericsExercise.Console.Given.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console.Given.Services
{
    class ApplicationService<T>: IApplicationServices<T> where T : IEntity
    {
        Persistence conn;

        public ApplicationService()
        {
            conn = new Persistence();
        }

        public string getUsers()
        {
            try
            {
                var response = conn.GetAllAsync<T>();
                return response.Result.ToString();
            }
            catch(InvalidOperationException e)
            {
                return "No items of this type exists!";
            }
            catch(Exception e)
            {
                return "Something went wrong, please try again later!";
                System.Console.WriteLine("Exception: " + e);
            }
        }

        public string insertUser(T user)
        {
            try
            {
                conn.InsertAsync<T>(user);
                return "User inserated!";
            }
            catch (ArgumentException e)
            {
                return "Id should be a valid string, 10 charachters max, should not contain % !";
            }
            catch (InvalidOperationException e)
            {
                return "Limit of data reached for this type!";
            }
            catch (Exception e)
            {
                return "Something went wrong, please try again later!";
                System.Console.WriteLine("Exception: " + e);
            }
        }

    }
}
