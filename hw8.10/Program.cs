// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNumber_5
{
    class clsGraph
    {

        private int Vertices;

        private List<Int32>[] adj;

        public clsGraph(int v)
        {
            Vertices = v;
            adj = new List<Int32>[v];

            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }

        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        void BFS(int s)
        {
            bool[] visited = new bool[Vertices];

            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.WriteLine("next->" + s);

                foreach (Int32 next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }

            }
        }

        public void DFS(int s)
        {
            bool[] visited = new bool[Vertices];

            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.WriteLine("next->" + s);
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

        public void PrintAdjacecnyMatrix()
        {
            for (int i = 0; i < Vertices; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adj[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }

        internal class student
        {
            public string Name;
            public int Year;
            public string exam;
            public int ball;
        }

        internal class Program
        {
            static void viking(int[] first, int[] second)
            {
                int a = 0;
                int a1 = 0;
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == 5)
                    {
                        a = a + 1;
                    }
                    if (second[i] == 5)
                    {
                        a1 = a1 + 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                if (a == a1)
                {
                    Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
                }
                else
                {
                    Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
                }
            }
            public struct Citizens_3
            {
                public string name_3;
                public int id_3;
                public string problem_3;
                public int iq_3;
                public int character_3;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Задание 1");
                List<student> students = new List<student>
                {
                    new student {Name = "Мошкина Мария", Year = 2004  , exam = "Информатика" , ball = 249 },
                    new student {Name = "Лешина Юлия", Year = 2003 , exam = "Информатика" , ball = 200 },
                    new student {Name = "Елисеева Виктория", Year = 2003  , exam = "Информатика" , ball = 253 },
                    new student {Name = "Мирская Екатерина", Year = 2004  , exam = "Информатика" , ball = 190 },
                    new student {Name = "Козловская Карина", Year = 2004  , exam = "Физика" , ball = 298 },
                    new student {Name = "Есина Анастасия", Year = 2004  , exam = "Информатика" , ball = 294 },
                    new student {Name = "Флек Василий", Year = 2004  , exam = "Информатика" , ball = 194},
                    new student {Name = "Волженин Дамир", Year = 2004  , exam = "Английский" , ball = 293 },
                    new student {Name = "Носков Алексей", Year = 2004  , exam = "Информатика" , ball = 234},
                    new student {Name = "Шумахер Денис", Year = 2004  , exam = "Английский" , ball = 193 }
                };
                Console.WriteLine("Напишите Новый студент, если хотите добавить студента");
                Console.WriteLine("Напишите Удалить, если хотите удалить кого-то из списка");
                Console.WriteLine("Напишите Сортировать, если хотите отсортировать список по баллам");
                string s = Console.ReadLine();
                if (s == "Новый студент")
                {
                    Console.WriteLine("Введите имя и фамилию студента");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите его год рождения");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите экзамен, который сдавал студент");
                    string ex = Console.ReadLine();
                    Console.WriteLine("Введите сумму баллов за экзамены");
                    int bally = int.Parse(Console.ReadLine());
                    students.Add(new student { Name = name, Year = year, exam = ex, ball = bally });
                    students.ForEach(vallue => Console.WriteLine($" Имя: {vallue.Name}, Год рождения: {vallue.Year}, Экзамен: {vallue.exam}, Баллы: {vallue.ball} "));
                }
                else if (s == "Удалить")
                {
                    Console.WriteLine("Введите имя (Ф.И)");
                    string[] name = Console.ReadLine().Split(' ');
                    int a = students.FindIndex(student => student.Name == name[0]);
                    students.RemoveAt(a);
                    students.ForEach(vallue => Console.WriteLine($" Имя: {vallue.Name}, Год рождения: {vallue.Year}, Экзамен: {vallue.exam}, Баллы: {vallue.ball} "));
                }
                else if (s == "Сортировать")
                {
                    Console.WriteLine("Отсортированный список: ");
                    var sortedStud = students.OrderBy(x => x.ball);
                    foreach (var vallue in sortedStud)
                    {
                        Console.WriteLine($" Имя: {vallue.Name}, Год рождения: {vallue.Year}, Экзамен: {vallue.exam}, Баллы: {vallue.ball} ");
                    }
                }
                Console.ReadLine();

                Console.WriteLine("Задание 2");
                int[] first = { 5, 7, 8, 9, 2, 5, 7, 3, 8, 4, 9, 5, 7, 3 };
                int[] second = { 7, 4, 5, 2, 6, 8, 4, 5, 3, 6, 5, 2, 5, 7 };
                Console.WriteLine("Первая команда:");
                for (int i = 0; i < first.Length; i++)
                    Console.Write(first[i] + " ");
                Console.WriteLine();
                Console.WriteLine("Вторая команда:");
                for (int i = 0; i < second.Length; i++)
                    Console.Write(second[i] + " ");
                viking(first, second);
                Console.ReadLine();
                Console.WriteLine("Задание 3. ЖЭК");
                Citizens_3 Rick = new Citizens_3 { name_3 = "Ponch", id_3 = 1, problem_3 = "оплата", iq_3 = 1, character_3 = 10 };
                Citizens_3 Morty = new Citizens_3 { name_3 = "Konch", id_3 = 2, problem_3 = "отопление", iq_3 = 0, character_3 = 4 };
                Citizens_3 Deyneris = new Citizens_3 { name_3 = "Fufelshmerz", id_3 = 3, problem_3 = "завоевание мира", iq_3 = 1, character_3 = 6 };
                Citizens_3 Karchevsky = new Citizens_3 { name_3 = "Karchevsky", id_3 = 4, problem_3 = "провести пару онлайн", iq_3 = 1, character_3 = 2 };
                Citizens_3 Raskolnikov = new Citizens_3 { name_3 = "Buratino", id_3 = 5, problem_3 = "оплата", iq_3 = 0, character_3 = 1 };
                Stack<Citizens_3> Zina = new Stack<Citizens_3>(5);
                Zina.Push(Rick);
                Zina.Push(Morty);
                Zina.Push(Deyneris);
                Zina.Push(Karchevsky);
                Zina.Push(Raskolnikov);
                Dictionary<int, Citizens_3> Window1 = new Dictionary<int, Citizens_3>(); //отопление
                Dictionary<int, Citizens_3> Window2 = new Dictionary<int, Citizens_3>(); //оплата
                Dictionary<int, Citizens_3> Window3 = new Dictionary<int, Citizens_3>(); //другое

                if (Zina.Count > 0)
                {
                    Citizens_3 citizen = Zina.Pop();

                    switch (citizen.problem_3)
                    {
                        case "оплата":
                            Window2.Add(citizen.id_3, citizen);
                            break;
                        case "отопление":
                            Window1.Add(citizen.id_3, citizen);
                            break;
                        default:
                            Window3.Add(citizen.id_3, citizen);
                            break;
                    }

                }

                Console.WriteLine("Задание 4");
                clsGraph graph = new clsGraph(4);
                graph.AddEdge(0, 1);
                graph.AddEdge(0, 2);
                graph.AddEdge(1, 2);
                graph.AddEdge(2, 0);
                graph.AddEdge(2, 3);
                graph.AddEdge(3, 3);
                //Print adjacency matrix
                graph.PrintAdjacecnyMatrix();

                Console.WriteLine("BFS traversal starting from vertex 2:");
                graph.BFS(2);
                Console.WriteLine("DFS traversal starting from vertex 2:");
                graph.DFS(2);
                Console.ReadLine();
            }
        }
    }
}