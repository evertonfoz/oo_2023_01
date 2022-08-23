namespace Aula01.Domain
{
    internal class Student
    {
        #region Props Full
        private int _studentID;

        public int StudentID
        {
            get { return _studentID; }
            private set {
                _studentID = value;
            }
        }

        private string _uuidID;

        public string UuidID
        {
            get { return _uuidID; }
            private set { _uuidID = value; }
        }

        #endregion

        #region Constructors
        public Student() {
            Random rnd = new();
            StudentID = rnd.Next(10, 20);
            Guid newGuid = Guid.NewGuid();
            UuidID = newGuid.ToString();
        }
        #endregion

        //#region C# Properties
        //public int StudentID
        //{
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException();
        //        }
        //    }
        //}
        //#endregion


        #region Fields
        //private int _studentID;
        public string AcademicRegister;
        public string Name;
        #endregion

        //#region Properties
        //public int StudentID()
        //{
        //    return _studentID;
        //}
        //#endregion

        //#region Methods
        //public bool RegisterStudentID(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return false;
        //    }
        //    _studentID = id;
        //    return true;
        //}
        //#endregion
    }
}
