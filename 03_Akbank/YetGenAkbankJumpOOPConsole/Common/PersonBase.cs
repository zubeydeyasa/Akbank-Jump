using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJumpOOPConsole.Enums;

namespace YetGenAkbankJumpOOPConsole.Common
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int No { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}