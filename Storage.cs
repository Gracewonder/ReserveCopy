using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveCopy
{
    abstract class Storage
    {
        public double speed { get; set; }
        protected string _title { get; set; }
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        protected string _model { get; set; }
        public string model
        {
            get { return _model; }
            set { _model = value; }
        }
        public abstract double GetVolume();
        //public abstract int GetFreeVolume();
        public abstract void PrintInfo();
        public abstract void Copy(int filesCopy);
    }
}