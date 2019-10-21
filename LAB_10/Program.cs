using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace LAB_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First Task

            //ArrayList list = new ArrayList();
            //list.Add(12);
            //list.Add(21);
            //list.Add(34);
            //list.Add(123);
            //list.Add(1);
            //list.Add("String");
            //list.Add(new Classes.Student("Max", "Primakov", 18, "BSTU", "IT"));
            //list.Remove(21);
            //Console.WriteLine($"Количество элементов: {list.Count}");
            //foreach (var item in list)
            //    Console.WriteLine(item);
            //Console.WriteLine($"Индекс найденного элемента: {list.BinarySearch(34)}");

            #endregion First Task

            #region Second Task

            //SortedSet<int> set = new SortedSet<int>();
            //set.Add(23);
            //set.Add(12);
            //set.Add(4);
            //set.Add(222);
            //set.Add(666);

            //foreach (var item in set)
            //    Console.WriteLine(item);

            //int n = 2;
            //for (int i = 0; i < n; i++)
            //{
            //    set.Remove(set.First());
            //}

            //set.Add(112);
            //set.Add(43);

            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //int j = 0;
            //foreach(var item in set)
            //{
            //    dictionary.Add(j, item);
            //    j++;
            //}

            //foreach (var item in dictionary)
            //    Console.WriteLine(item);

            //Console.WriteLine(dictionary.ContainsValue(43));

            #endregion Second Task

            #region Third Task

            //SortedSet<Classes.Student> set = new SortedSet<Classes.Student>();
            //set.Add(new Classes.Student("Max", "Primakov", 18, "BSTU", "IT"));
            //set.Add(new Classes.Student("Pasha", "Salimon", 19, "BSTU", "IT"));
            //set.Add(new Classes.Student("Danil", "Selitskiy", 20, "BSTU", "IT"));
            //set.Add(new Classes.Student("Anton", "Borisov", 24, "BSTU", "IT"));
            //set.Add(new Classes.Student("Mihail", "Gorodilov", 21, "BSTU", "IT"));

            //foreach (var item in set)
            //    Console.WriteLine(item.ToString());

            //int n = 2;
            //for (int i = 0; i < n; i++)
            //{
            //    set.Remove(set.First());
            //}

            //set.Add(new Classes.Student("Katya", "Krupoderova", 17, "BNTU", "FRE"));
            //set.Add(new Classes.Student("Masha", "Pandora", 24, "BSU", "YUT"));

            //Dictionary<int, Classes.Student> dictionary = new Dictionary<int, Classes.Student>();
            //int j = 0;
            //foreach (var item in set)
            //{
            //    dictionary.Add(j, item);
            //    j++;
            //}

            //foreach (var item in dictionary)
            //    Console.WriteLine(item);

            #endregion Third Task

            #region Fourth Task

            ObservableCollection<Classes.Student> collection = new ObservableCollection<Classes.Student>();
            collection.CollectionChanged += Student_CollectionChanged;

            Classes.Student man = new Classes.Student("Max", "Primakov", 18, "BSTU", "IT");

            collection.Add(man);
            collection.Remove(man);

            #endregion Fourth Task

        }

        private static void Student_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Classes.Student newUser = e.NewItems[0] as Classes.Student;
                    Console.WriteLine($"Добавлен новый объект:\n {newUser.ToString()}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Classes.Student oldUser = e.OldItems[0] as Classes.Student;
                    Console.WriteLine($"Удален объект:\n {oldUser.ToString()}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Classes.Student replacedUser = e.OldItems[0] as Classes.Student;
                    Classes.Student replacingUser = e.NewItems[0] as Classes.Student;
                    Console.WriteLine($"Объект {replacedUser.ToString()}\n заменен объектом {replacingUser.ToString()}");
                    break;
            }
        }
    }
}
