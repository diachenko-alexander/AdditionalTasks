using System;

namespace AdditionalTaskSerialise
{
    class User
    {
        private readonly Guid id;
        private string name;
        private string surname;

        public Guid Id { get { return id; } }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get { return surname; }
            set {surname = value; }
        }

        public User(string name, string surname)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.surname = surname;
        }

        public override string ToString()
        {
            return string.Format($"{Id} {Name} {Surname}");
        }
    }
}
