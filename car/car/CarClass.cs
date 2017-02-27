using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class CarClass // halutaan publiciksi - on näykyvissä sovelluksessa myös muualla
    {
        private readonly string _brand; // ei sitten mene sekaisin metodeissa samannimisen muuttujan kanssa, yrityksissä valitaan
        private double _speed;
        // constructor 

        public CarClass(string brand)
        {
            _brand = brand;
            _speed = 0; // ei kannata tuoda parametriksi, voidaan pistää construktorin sisään defaulttina nollaksi
        }
        // vaihtoehtoinen oletuskonstruktori
        // car () {}

        // tehdään brand muuttujasta property eli ... alt ja insert

            // construktorin jälkeen tulee ---metodit, sitten publikit ja sitten privatet
        public string Brand 
        {
            get { return _brand + " Blaah"; }
            // set { brand = value; } //koska auton merkki ei enää muutu, niin tän voi ottaa pois
        }

        public double Speed { get; private set;
            // set { _speed = value; } // pois -> nyt vain acceleraten kautta voi muuttaa nopeutta
        }

        public void Accelerate(double acceleration)
        {
            Speed = Speed + acceleration;
        }

        public void Break()
        {
            Speed = Speed * .9;
        }

        // ylikirjoitetaan defaulttimetodi tostring täällä car luokassa
        public override string ToString()
        {
            // return base.ToString(); // tekee näin defaulttina
            //return "Brand: " + _brand +", "+ " Speed " + Speed; // suoraan muuttujan kautta, jos mentäis propertyn kautta niin tulostuisi siellä lisättä "blaah"
            // jos haluaa logittaa tai tulostaa tietoja muuttujasta niin kannattaa käyttää tostringin ylikirjoitusta
            return Print();
        }

        private string Print() // voi kutsua vain täällä
        {
            return "Brand: " + _brand + ", " + " Speed " + Speed;
        }
    }
}
