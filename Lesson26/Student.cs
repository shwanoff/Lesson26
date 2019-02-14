using System;
using System.Runtime.Serialization;

namespace Lesson26
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        public Group Group { get; set; }

        public Student(string name, int age)
        {
            // Проверка входных параметров.

            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
