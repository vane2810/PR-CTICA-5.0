using System;
using System.Collections.Generic;
using System.Text;

namespace PRÁCTICA_5._0
{
    class Students
    {
        private string _firstname;
        private string _lastname;
        private double _grade1;
        private double _grade2;
        private double _grade3;

        public Students(string firstname, string lastname, double grade1, double grade2, double grade3)
        {

            this._firstname = firstname;
            this._lastname = lastname;
            this._grade1 = grade1;
            this._grade2 = grade2;
            this._grade3 = grade3;

        }

        public string ReturnInfo() => _firstname + " " + _lastname;
        public double ReturnGrades() => (_grade1 * .3) + (_grade2 * .3) + (_grade3 * .4);
    }
}

