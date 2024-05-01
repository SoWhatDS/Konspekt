

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LinqTest
{
    internal sealed class ExampleLinq 
    {
        private sealed class User
        {
            public string FirstName { get; }
            public string LastName { get; }
            public int Age { get; set; }

            public User(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }

        private sealed class People
        {
            public string FirstName { get; }
            public string LastName { get; }
            public string Country { get; set; }

            public People(string firstName,string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }

        private readonly User[] _users;
        private readonly int[] _numbers;

        public ExampleLinq()
        {
            _users = new[]
            {
new User("Dmitry","Sergeev") { Age = 18},
new User("Ivan","Petrov") { Age = 22},
new User("Ilya","Afanasyev"){ Age = 25},
new User("Lera","Muratova") { Age = 17},
new User("Lena","Petrova") { Age=33}
            };

            _numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        }

        //фильтрация объектов
        public void Filtration()
        {
            IEnumerable<int> evens = from i in _numbers
                                     where i % 2 == 0 && i > 10
                                     select i;
            IEnumerable<int> evens1 = _numbers.Where(i => i % 2 == 0 && i > 10);

            foreach (int i in evens)
            {
                Debug.Log(i);
            }
            
        }
        //выборка сложных объектов
        public void SelectingComplexObjects()
        {
            var selectedUsers = from user in _users
                                where user.Age > 28
                                select user;

            var selectedUsers1 = _users.Where(u => u.Age > 28).ToList();

            foreach (User user in selectedUsers)
            {
                Debug.Log($"{user.FirstName} - {user.Age}");
            }
        }
        //проекция
        public void Projection()
        {
            var names = _users.Select(u => u.FirstName);

            foreach (string user in names)
            {
                Debug.Log(user);
            }
        }

        //переменные в запросах и оператор let
        public void ExampleLet()
        {
            var people = from u in _users
                         let age = u.Age <= 18 ? u.Age + (18 - u.Age) : u.Age
                         select new User(u.FirstName, u.LastName) { Age = age };

            foreach (var user in _users)
            {
                Debug.Log($"{user.FirstName} - {user.Age}");
            }
        }

        //сортировка
        public void Sorting()
        {
            var sortedUsers = from u in _users
                              orderby u.Age // asceding (сортировка по возрастанию) и desceding (сортировка по убыванию)
                              select u;
            var result = _users.OrderBy(u => u.FirstName).ThenBy(u => u.Age).ThenBy(u => u.FirstName.Length); //ThenByDesceding (для сортировки по убыванию)

            foreach (User u in sortedUsers)
            {
                Debug.Log($"{u.FirstName} - {u.Age}");
            }
        }

        //работа с множествами
        public void WorkingWithSets()
        {
            string[] peopleFromAstrakhan = { "Igor", "Roman", "Dmitry","Alex" };
            string[] peopleFromMinsk = { "Ilya", "Vitalik", "Denis","Alex" };

            //разность множества
            var result = peopleFromAstrakhan.Except(peopleFromMinsk);
            //перечисление множества
            var result1 = peopleFromAstrakhan.Intersect(peopleFromMinsk);
            //объединение множества
            var result2 = peopleFromAstrakhan.Union(peopleFromMinsk);
            //удаление дубликатов
            var result3 = peopleFromAstrakhan.Concat(peopleFromMinsk.Distinct());

            foreach (var name in result)
            {
                Debug.Log(name);
            }
        }

        //агрегатные операции
        public void ExampleAverage()
        {
            int min1 = _numbers.Min();
            int min2 = _users.Min(n => n.Age); //минимальный возраст

            int max1 = _numbers.Max();
            int max2 = _users.Max(n => n.Age); //максимальный возраст

            double avr1 = _numbers.Average();
            double avr2 = _users.Average(n => n.Age); //средний возраст
        }

        //методы Skip и Take
        public void ExampleSkipAndTake()
        {
            var result = _numbers.Take(3); // три первых элемента
            var result1 = _numbers.Skip(3); //все элементы, кроме первых трёх

            foreach (var t in _users.TakeWhile(x=>x.FirstName.StartsWith("I")))
            {
                Debug.Log(t);
            }

            foreach (var t in _users.SkipWhile(x=>x.FirstName.StartsWith("I")))
            {
                Debug.Log(t);
            }
        }

        //группировка
        public void ExampleGrouping()
        {
            var groups = from user in _users
                         group user by user.LastName;

            foreach (IGrouping<string,User> g in groups)
            {
                Debug.Log(g.Key);

                foreach (var t in g)
                {
                    Debug.Log(t.FirstName);
                }
            }

            var groups1 = _users.GroupBy(p => p.LastName).Select(g => new { LastName = g.Key, Count = g.Count() });

            var groups2 = _users.GroupBy(p => p.LastName).Select(g => new { LastName = g.Key, Count = g.Count(), Name = g.Select(p => p) });

            foreach (var g in groups2)
            {
                Debug.Log(g.LastName);
                Debug.Log(g.Count);

                foreach (var t in g.Name)
                {
                    Debug.Log(t.FirstName);
                }
            }
        }

        //методы All и Any
        public void ExampleAllAndAny()
        {
            bool result = _users.All(u => u.Age > 20);
            Debug.Log(result ? "У всех пользователей возраст больше 20" : "Есть пользователь с возрастом меньше 20");

            bool result1 = _users.Any(u => u.Age < 20);
            Debug.Log(result ? "Есть пользователь с возрастом меньше 20" : "У всех пользователей возраст больше 20");
        }

        //методы Join
        public void ExampleJoin()
        {
            User[] users = { new User("Dmitry", "Sergeev") { Age = 31},
            new User("Ivan","Petrov") { Age = 22 },
            new User("Ilya","Afanasyev"){ Age = 18} };

            People[] peoples = { new People("Lera", "Muratova") { Country = "Astrakhan" },
            new People("Sveta","Petrova"){Country = "Moscow" },
            new People("Lena","Ivanova"){ Country = "Minsk"} };

            var resultJoin = from pl in users
                             join t in peoples on pl.LastName equals t.LastName
                             select new { Name = pl.FirstName, Team = pl.LastName, Country = t.Country };

            foreach (var item in resultJoin)
            {
                Debug.Log($"{item.Name} - {item.Team} ({item.Country})" );
            }

            resultJoin = users.Join(peoples,
                p => p.LastName,
                t => t.LastName,
                (p, t) => new { Name = p.FirstName, Team = p.LastName, Country = t.Country });

            var resultGroupJoin = peoples.GroupJoin(users,
                t => t.LastName,
                pl => pl.LastName,
                (team,pls) => new
                {
                  Name = team.LastName,
                  Country = team.Country,
                  Players = pls.Select(p => p.FirstName)
                });

            foreach (var team in resultGroupJoin)
            {
                Debug.Log(team.Name);

                foreach (string player in team.Players)
                {
                    Debug.Log(player);
                }
            }

            var resultZip = users.Zip(peoples,
                (player, team) => new
                {
                    Name = player.FirstName,
                    LastName = team.LastName,
                    Country = team.Country
                });
        }

    }
}
