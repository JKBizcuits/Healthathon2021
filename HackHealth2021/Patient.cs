using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HackHealth2021
{
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TestResult { get; set; }
        public string ComputedResult { get; set; }
    }
}
