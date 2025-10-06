class Person
    {
        private string name = "Undefined";
        private int age = 1;

        public int Age {
            get => age;
            set {
                if (value < 1 || value > 120)
                    Console.WriteLine("Недопустимый возраст");
                else age = value;
            }
        }
        public string Name {
            get => name;
            set { name = value; }
        }
    }
