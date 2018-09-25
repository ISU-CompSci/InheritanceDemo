using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InheritanceDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
       private SuperHero _SupOut = new SuperHero();
        private int[] numbers = new int[5];
        private Person[] supers = new Person[7];
        public MainWindow() {
            InitializeComponent();
            SuperHero sup = new SuperHero();
            sup.EyeColor = Person.Colors.Brown;
            SuperHero sup2 = new SuperHero();
            sup2.FirstName = "Super";
            sup2.LastName = "Man";
            //Person per = new Person();

            //per.EyeColor = Person.Colors.Black;

            tbSuperOut.Text = sup.FullName;
            tbSuperOut.Text += "\r\n" + sup2.FullName;
           // tbPersonOut.Text = per.FullName;
            
            
        }

        private void btnDoSomething_Click(object sender, RoutedEventArgs e) {

            SuperHero h = new SuperHero();
            h.Alias = "Marty";

            _SupOut = new SuperHero();

            numbers[0] = 5;
            supers[0] = new SuperHero("bob","jones");
            supers[1] = h;
            supers[2] = _SupOut;
            

            Person dude = h;
            SuperHero hero = (SuperHero)dude;

            Button btn = (Button)sender;


            int a = 6;
            double b = a;
            int c = (int)b;


           
            Villian v = new Villian();
            Person notDude = new Villian();

            supers[4] = v;

            int index = 0;
            foreach (Person p in supers) {
                if (p != null) {
                    //tbPersonOut.Text += index + ": "
                    //    + p.Yell()+ "|" + p.Call() + "\r\n";
                    tbPersonOut.Text += index + ": " + p.ToString() + "\r\n";
                } else {
                    tbPersonOut.Text += index + ": null\r\n";
                }
                index++;
            }

            tbSuperOut.Text = h.Yell() + "|" + h.Call() + "\r\n";
            tbSuperOut.Text += v.Yell() + "|" + v.Call() + "\r\n";


        }

        private void btnCopyStuff_Click(object sender, RoutedEventArgs e) {

            SuperHero spiderman = new SuperHero("Peter", "Parker");

            SuperHero theClone = spiderman.CloneMe();
            theClone = spiderman;
            theClone.FirstName = "Miles";
            spiderman.LastName = "Morales";

            tbSuperOut.Text = spiderman.FullName;
            tbPersonOut.Text = theClone.FullName;

        }
    }
}
