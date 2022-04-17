using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidrary.AppDataFiel
{
    public class ClassInsert : Insert, IEnumerable
    {
        public new int id_insert { get; set; }
        public new int id_reader { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string addres { get; set; }
        public string phone { get; set; }
        public DateTime dates_of_issue { get; set; }
        public new int id_book { get; set; }
        public string name_book { get; set; }
        public new System.DateTime return_date { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static explicit operator ClassInsert(List<Insert> v)
        {
            throw new NotImplementedException();
        }
    }
}
