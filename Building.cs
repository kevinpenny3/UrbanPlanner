using System;

namespace planner
{

    public class Building
    {

        // private fields
        private string _designer = "Kevin Penny";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public string Description
        {
            get
            {
                return $@"
                {_address}
                --------------
                Designed by {_designer}
                Constructed on {_dateConstructed}
                Own by {_owner}
                {Volume} cubic meters of space";
            }
        }
        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

    }
}