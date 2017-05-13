
namespace C_sharp_lab_7
{
    class Person
    {
        private string fam;
        private string status;
        private float salary;
        private int age;

        public string Fam      //read, write-once
        {
            //set { if (fam == "") fam = value; }
            get { return fam; }
        }
        public string Status   //read-only
        {
            set { if(status == "") status = value; }
            get { return status; }
        }
        public float Salary    //write-only
        {
            set { salary = value; }
        }
        public int Age         //read, write
        {
            set { age = value; }
            get { return age; }
        }
        public string health;  //not-read, not-write


        public Person(string fam, string status)
        {
            this.fam = fam;
            this.status = status;
        } 

        public void setHealth(string val)
        {
            health = val;
        }

        public string getHealth()
        {
            return health;
        }
        /*  Не допускается компилятором
        public float getSalary()
        {
            return salary;
        }
        */
    }
}

