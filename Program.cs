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
        
        // Luodaan kenttää vastaava ominaisuus (property) Identity ja sille asetusmetodi set ja lukumetodi get.
        // Ne voi kirjoittaa joko yhdelle tai useammalle riville.
        public string Identity { get { return identity; } set { identity = value; } }

        string dateBought = "1.1.2000";
        public string DateBought { get { return dateBought; } set { dateBought = value; } }

        // Huomaa jälkiliite d (suffix)
        double price = 0.00d;
        public double Price { get { return price; } set { price = value; } }

        int warranty = 12;
        public int Warranty { get { return warranty; } set { warranty = value; } }

        string processorType = "N/A";
        public string ProcessorType { get { return processorType; } set { processorType = value; } }

        int amountRAM = 0;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity =0;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }


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
       
        // Konstruktorit
        public Computer() : base()
            { }

        public Computer(string identity) : base(identity)
            { }

        // Muut metodit
        public void ShowInfo()
            {
            Console.WriteLine("Koneen nimi: " + Identity);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti: " + AmountRAM);
            Console.WriteLine("Levytila: " + StorageCapacity);
            }
    }    
    // Class for computers, inherits Device class
    class SmartPhone : Device

    {
        // Fields

        // Properties

        // Constructors

        // Other methods
    }

    // Class for Tablets, inherits Device class, Tablettien luokka, perii laiteluokan
    class Tablet : Device
    {
        // Fields, kentät
        string operatingSystem;
        public string OperatingSystem { get { return operatingSystem; } set { operatingSystem = value; } }
        bool stylusEnabled = false;
        public bool StylusEnabled { get {  return stylusEnabled; } set {  stylusEnabled = value; } }
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

            // Asetetaan Prosessori-ominaisuuden arvo
            tietokone1.ProcessorType = "Intel I7";
            tietokone1.AmountRAM = 16;

            Console.WriteLine("Uuden tietokoneen nimi on: " + tietokone1.Identity + " ja siinä on " + tietokone1.ProcessorType + " -prosessori ja " + tietokone1.AmountRAM + " GB keskusmuistia");

            // Luodaan uusi nimetty tietokone toisella konstruktorilla
            Computer tietokone2 = new Computer("Elina läppäri");
            tietokone2.ProcessorType = "Intel Core i7 vPro";
            tietokone2.AmountRAM = 32;
            tietokone2.ShowInfo();

            // Pidetään ikkuna auki, kunnes käyttäjä painaa enteriä
            Console.ReadLine();
        }
    }
}         
                     
    

