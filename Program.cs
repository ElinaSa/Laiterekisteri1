using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri
{
    // Base class for devices, yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille
    class Device
    {
        // Fields, luodaan kenttä (field) identity, esitellään (define) ja annetaan arvo (set initial value)
        // ------
        string identity = "Uusi laite"; 
        
        // Luodaan kenttää vastaava ominaisuus (property) Identity ja sille asetusmetodi set ja lukumetodi get. Ne voi kirjoittaa joko yhdelle tai useammalle siriville
        public string Identity { get { return identity; } set { identity = value; } }

        string dateBought = "1.1.2000";
        public string DateBought { get { return dateBought; } set { dateBought = value; } }

        // Huomaa jälkiliite d (suffix)
        double price = 0.00d;
        public double Price { get { return price; } set { price = value; } }

        int warranty = 12;
        public int Warranty { get { return warranty; } set { warranty = value; } }

        // Properties
        // ----------
           
              
        // Constructors
        // ------------
        // Kostruktori eli oliomuodostin (constructor) ilman argumentteja    
        public Device()
        {

        }
        // A constructor with one argument, konstruktori nimi-argumentilla, tässä tapauksessa identiteetti
        public Device(string identity)
        {
            this.identity = identity;
        }

        // Another constructor with all arguments, konstrutori kaikilla argumenteilla
        public Device(string identity, string dateBought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBought = dateBought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other methods
        // -------------
    }

    // Class for computers, inherits Device class
    // Tietokoneiden luokka, perii ominaisuuksia ja metodeja laiteluokasta Device
    class Computer : Device
    {
        // Fields, kentät ja Properties, ominaisuudet
        string processorType;
        public string ProcessorType { get { return processorType; } set { processorType = value; } }

        int amountRAM;       
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }
                
        // Konstruktorit
        public Computer() : base()
        { }
    }    
    // Class for computers, inherits Device class
    class SmartPhone : Device

    {
        // Fields

        // Properties

        // Constructors

        // Other methods
    }

    // Class for computers, inherits Device class
    class Tablet : Device
    {
        // Fields

        // Properties

        // Constructors

        // Other methods
    }
   
    // Pääluokan ohjelma, josta tulee Program.exe
    internal class Program 
    { 
        static void Main(string[] args) 
        {
            // Ohjelman varsinaiset toiminnot tapahtuvat täällä
            // Ohjelma kysyy käyttäjältä tietoja laitteista ja vastaamalla kysymyksiin tiedot tallennetaan muuttujiin.

            // Luodaan uusi laite Device-luokasta

            Device laite = new Device("Eka kone");
            Console.WriteLine("Laitteen nimi on: " + laite.Identity);
            Console.WriteLine("Ostopäivä oli: " + laite.DateBought);

            // Luodaan uusi tietokone, joka perii laiteluokan (Device) ominaisuudet ja metodit

            Computer tietokone1 = new Computer();
            Console.WriteLine("Uuden tietokoneen nimi on: " + tietokone1.Identity);
            
            // Pidetään ikkuna auki, kunnes käyttäjä painaa enteriä
            Console.ReadLine();
        }
    }
}         
                     
    

