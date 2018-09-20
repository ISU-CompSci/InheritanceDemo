using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo {
    class SuperHero : Person {
        private string _Power;
        private string _Alias;

        public SuperHero() {
            _FirstName = "Bob";
            LastName = "the Awesome";
        }

        public SuperHero(string fName, string lName)
            : base(fName, lName, new DateTime(2002, 2, 25)) {
            //FirstName = fName;
            //LastName = lName;
        }

        public string Power {
            get {
                return _Power;
            }
            set {
                _Power = value;
            }
        }

        public string Alias {
            get {
                return _Alias;
            }
            set {
                _Alias = value;
            }

        }

        public override string Call() {
            return "Whatz up!";
        }
    }
}
