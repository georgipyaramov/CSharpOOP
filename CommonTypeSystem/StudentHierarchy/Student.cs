namespace StudentHierarchy
{
    using StudentHierarchy.Enumarations;
    using System;
    using System.Linq;
    using System.Text;
    public class Student: ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int socialSecurityNumber;
        private string permanentAddress;
        private string mobilePhoneEMail;
        private University universyti;
        private Faculty faculty;
        private Specialty speciality;
        public Student()
        {
        }
        public Student(string initialFirstName, string initialMiddleName, string initialLastName)
        {
            this.FirstName = initialFirstName;
            this.MiddleName = initialMiddleName;
            this.LastName = initialLastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name canot be null");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get 
            { 
                return this.middleName; 
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name canot be null");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get 
            { 
                return this.lastName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name canot be null");
                }
                this.lastName = value;
            }
        }

        public int SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }
            set
            {
                this.socialSecurityNumber = value;
            }
        }

        public string MobilePhoneEMail
        {
            get
            {
                return this.mobilePhoneEMail;
            }
            set
            {
                this.mobilePhoneEMail = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                this.permanentAddress = value;
            }
        }

        public University Universyti
        {
            get
            {
                return this.universyti;
            }
            set
            {
                this.universyti = value;
            }
        }

        public Specialty Speciality
        {
            get
            {
                return this.speciality;
            }
            set
            {
                this.speciality = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (this.FirstName != student.FirstName)
            {
                return false;
            }
            if (this.MiddleName != student.MiddleName)
            {
                return false;
            }
            if (this.LastName != student.LastName)
            {
                return false;
            }
            if (this.PermanentAddress != student.PermanentAddress)
            {
                return false;
            }
            if (this.SocialSecurityNumber != student.SocialSecurityNumber)
            {
                return false;
            }
            if (this.MobilePhoneEMail != student.MobilePhoneEMail)
            {
                return false;
            }
            if (this.Universyti != student.Universyti)
            {
                return false;
            }
            if (this.Faculty != student.Faculty)
            {
                return false;
            }
            if (this.Speciality != student.Speciality)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.FirstName);
            result.AppendLine(this.MiddleName);
            result.AppendLine(this.LastName);
            result.AppendLine(this.SocialSecurityNumber.ToString());
            result.AppendLine(this.PermanentAddress);
            result.AppendLine(this.Universyti.ToString());
            result.AppendLine(this.Faculty.ToString());
            result.AppendLine(this.Speciality.ToString());
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return
                this.firstName.GetHashCode() ^ this.middleName.GetHashCode()
                & this.LastName.GetHashCode() ^ this.PermanentAddress.GetHashCode();
        }

        public static bool operator== (Student obj1, object obj2)
        {
            if (obj1.Equals(obj2))
	        {
		        return true;
	        }
            return false;
        }

        public static bool operator !=(Student obj1, object obj2)
        {
            if (!obj1.Equals(obj2))
	        {
		        return true;
	        }
            return false;
        }

        public object Clone()
        {
            var clonedObject = new Student();
            clonedObject.FirstName = this.FirstName;
            clonedObject.MiddleName = this.MiddleName;
            clonedObject.LastName = this.LastName;
            clonedObject.SocialSecurityNumber = this.SocialSecurityNumber;
            clonedObject.PermanentAddress = this.PermanentAddress;
            clonedObject.MobilePhoneEMail = this.MobilePhoneEMail;
            clonedObject.Universyti = this.Universyti;
            clonedObject.Faculty = this.Faculty;
            clonedObject.Speciality = this.Speciality;
            return clonedObject;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 1)
            {
                return 1;
            }
            if (this.FirstName.CompareTo(other.FirstName) == -1)
            {
                return -1;
            }
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                if (this.MiddleName.CompareTo(other.MiddleName) == 1)
                {
                    return 1;
                }
                if (this.MiddleName.CompareTo(other.MiddleName) == -1)
                {
                    return -1;
                }
                if (this.MiddleName.CompareTo(other.MiddleName) == 0)
                {
                    if (this.LastName.CompareTo(other.LastName) == 1)
                    {
                        return 1;
                    }
                    if (this.LastName.CompareTo(other.LastName) == -1)
                    {
                        return -1;
                    }
                    if (this.LastName.CompareTo(other.LastName) == 0)
                    {
                        if (this.SocialSecurityNumber > other.SocialSecurityNumber)
                        {
                            return 1;
                        }
                        if (this.SocialSecurityNumber < other.SocialSecurityNumber)
                        {
                            return -1;
                        }                        
                    }
                }
            }
            return 0;
        }
    }
}
