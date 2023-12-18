using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom_9
{
    internal class timkiem
    {
        private int _id;
        private string _Title;
        private DateTime _date;

        public timkiem(int id, string title, DateTime date)
        {
            _id = id;
            _Title = title;
            _date = date;
        }
        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Title
        {
            get { return this._Title; }
            set { this._Title = value; }
        }
        public DateTime Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        internal static List<timkiem> FindAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}

