using System;

namespace Lesson26
{
    [Serializable]
    public class Group
    {
        [NonSerialized]
        private static readonly Random rnd = new Random(DateTime.Now.Millisecond);

        private int privateint;

        public int Number { get; set; }
        public string Name { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа " + rnd;
        }

        public Group(int number, string name)
        {
            // Проверка входных данных

            Number = number;
            Name = name;
        }

        public void SetPrivet(int i)
        {
            privateint = i;
        }

        public int GetPrivet()
        {
            return privateint;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
