using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class Profile
    {
        private string surName;
        private string name;
        private string middleName;
        private string gender;
        private DateTime birthday;
        private string additionalInfo;

        public Profile(string surName, string name, string middleName, string gender, DateTime birthday, string additionalInfo)
        {
            this.surName = surName;
            this.name = name;
            this.middleName = middleName;
            this.gender = gender;
            this.birthday = birthday;
            this.additionalInfo = additionalInfo;
        }

        public override string ToString()
        {
            return "Фамилия:\t" + surName + "\n" +
                   "Имя:\t" + name + "\n" +
                   "Отчество:\t" + middleName + "\n" +
                   "Пол:\t" + gender + "\n" +
                   "Дата рождения:\t" + birthday.ToShortDateString() + "\n" +
                   "Доп. информация: " + additionalInfo;
        }

    }
}
