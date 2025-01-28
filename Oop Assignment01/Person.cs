using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Assignment01
{
    internal struct Person
    {
        #region Attributes
        private string name;

        private int age;

        #endregion

        #region Properities
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        #endregion

        #region Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        #endregion

        #region Getters & Setters
        public string GetName() => name;
        public void SetName(string name) => this.name = name;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        #endregion

        public override string ToString()
        {
            return $"Name: {name}\nAge: {age}";
        }

    }
}
