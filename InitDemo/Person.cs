namespace InitDemo
{
    class Person
    {
        private readonly int _age;

        public int Age
        {
            get
            {
                return _age;
            }

            init
            {
                _age = value;
            }
        }

       // public int Age { get; init; }

        public Person(int age)
        {
            Age = age;
        }

        public Person()
        {

        }
  
        public void SomeFunc()
        {
          //  Age = 50;
        }
    }
}
