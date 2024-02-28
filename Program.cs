using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri
{
    // LUOKKAMÄÄRITYKSET
    // =================

    // Base class for devices, yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille
        class Device
    {
        // Kentät ja ominaisuudet
        // ----------------------
        
        // Luodaan kenttä (field) identity, esitellään (define) ja annetaan arvo (set initial value)
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
        public int AmountRam { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity =0;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }

        // Constructors 
        // ------------

        // konstruktori eli oliomuodostin ilman argumentteja
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

        // Other methods, muut metodit
        // ---------------------------

        // Yliluokan metodit
        public void ShowPurchaseInfo()
        {
            // Luetaan laitteen ostotiedot sen kentistä, huom! this
            Console.WriteLine();
            Console.WriteLine("Laitteen hankintatiedot");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Laitteen nimi: " +  this.identity);
            Console.WriteLine("Ostopäivä: " + this.dateBought);
            Console.WriteLine("Hankintahinta: " + this.price);
            Console.WriteLine("Takuu: " + this.warranty + " kk");
        }

        // Luetaan laitteen yleiset tekniset tiedot ominaisuuksista, huom iso alkukirjain
        public void ShowBasicTechnicalInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Laitteen tekniset tiedot");
            Console.WriteLine("--------------------- --");
            Console.WriteLine("Koneen nimi: " + Identity);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti: " + AmountRam);
            Console.WriteLine("Levytila: " + StorageCapacity);


        }

    }

    // Class for computers, inherits Device class. Tietokoneiden luokka, perii ominaisuuksia ja metodeja laiteluokasta Device.
    class Computer : Device
    {
       
        // Konstruktorit
        public Computer() : base()
            { }

        public Computer(string identity) : base(identity)
            { }


        // Muut metodit
        
    }    

    // Class for smartphones, inherits Device class. Älypuhelinten luokka, perii ominaisuuksia ja metodeja laiteluokasta Device.
    class SmartPhone : Device
    {
        string operatingSystem;
        public string OperatingSystem { get { return operatingSystem; } set { operatingSystem = value; } }

        // Constructors
        public SmartPhone() : base() 
            { }

        public SmartPhone(string identity) : base(identity) 
            { }
            
        // Other methods
    }

    // Class for Tablets, inherits Device class, Tablettien luokka, perii laiteluokan
    class Tablet : Device
    {
        // Fields, kentät ja ominaisuudet
        // ------------------------------
        string operatingSystem; 
        // Kenttä -> pieni alkukirjain, Ominaisuus -> iso alkukirjain
        public string OperatingSystem { get { return operatingSystem; } set { operatingSystem = value; } }
        bool stylusEnabled = false; 
        public bool StylusEnabled { get {  return stylusEnabled; } set {  stylusEnabled = value; } }

        // Konstruktorit
        // -------------

        public Tablet() : base() { }

        public Tablet(string identity) : base(identity) { }

        // Tablet-luokan erikoismetodit
        // ----------------------------
        public void TabletInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Tabletin erityistiedot");
            Console.WriteLine("------------------------");
            Console.WriteLine("Käyttöjärjestelmä: " + OperatingSystem);
            Console.WriteLine("Kynätuki: " + StylusEnabled);
        }

    }
   
    // Pääluokan ohjelma, josta tulee Program.exe
    // ===========================================
    internal class Program 
    { 
        // Ohjelman käynnistävä metodi
        // ---------------------------
        static void Main(string[] args) 
        {
            // Ikuinen silmukka pääohjelman käynnissä pitämiseen
            while (true)
            {
                Console.WriteLine("Minkä laitteen tiedot tallennetaan?");
                Console.Write("1 tietokone, 2 älypuhelin, 3 tabletti");
                string type = Console.ReadLine();

                // Luodaan Switch-Case -rakenne vaihtoehdoille
                switch (type)
                {
                    case "1":

                        // Kysytään käyttäjiltä tietokoneen tiedot
                        // ja luodaan uusi tietokoneolio
                        Console.Write("Nimi: ");
                        string computerIdentity = Console.ReadLine();
                        Computer computer = new Computer(computerIdentity);
                        Console.Write("Ostopäivä: ");
                        computer.DateBought = Console.ReadLine();
                        Console.Write("Hankintahinta: ");
                        string price = Console.ReadLine();

                        try 
                        {
                            computer.Price = double.Parse(price);
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("Virheellinen hintatieto, käytä desimaalipilkkua (,) + ex.Message");

                            break;
                        }

                        Console.Write("Takuun kesto kuukausina: ");
                        string warranty = Console.ReadLine();

                        try
                        {
                            computer.Warranty = int.Parse(warranty);  
                        }

                        catch (Exception ex) 
                        {
                            Console.WriteLine("Virheellinen takuutieto, vain kuukausien määrä kokonaislukuna" + ex.Message); 
                            
                            
                        }

                        
                        Console.Write("Prosessorin tyyppi: ");
                        computer.ProcessorType = Console.ReadLine();

                        Console.Write("Keskusmuistin määrä (GB): ");
                        string amountRAM = Console.ReadLine();

                        try 
                        {
                            computer.AmountRam = int.Parse(amountRAM);
                        }

                        catch (Exception ex) 
                        {
                            Console.WriteLine("Virheelinen muistin määrä, vain kokonaisluvut sallittu" + ex.Message);
                        }

                        Console.Write("Tallennuskapasiteetti (GB): ");
                        string storageCapasity = Console.ReadLine();

                        try 
                        {
                            computer.StorageCapacity = int.Parse(storageCapasity);
                        }
                        
                        catch (Exception ex)
                        {
                            Console.WriteLine("Virheellinen tallennustilan koko, vain kokonaisluvut sallittu" + ex.Message);
                            
                        }

                        // Näytetään olion tiedot metodien avulla
                        computer.ShowPurchaseInfo();
                        computer.ShowBasicTechnicalInfo();

                        break;


                    case "2":

                        Console.Write("Nimi: ");
                        string smartPhoneIdentity = Console.ReadLine();
                        SmartPhone smartPhone = new SmartPhone(smartPhoneIdentity);
                        break;




                    case "3":
                        Console.Write("Nimi: ");
                        string tabletIdentity = Console.ReadLine();
                        Tablet tablet = new Tablet(tabletIdentity);
                        break;

                    default:
                        Console.WriteLine("Virheellinen valinta, anna pelkkä numero");
                        break;
                }

                // Ohjelman sulkieminen: poistutaan ikuisesta silmukasta
                Console.WriteLine("Haluatko jatkaa K/e");
                string continueAnswer = Console.ReadLine();
                continueAnswer = continueAnswer.Trim();
                continueAnswer = continueAnswer.ToLower();
                if (continueAnswer == "e")
                {
                    break;
                }

            }

            // Pidetään ikkuna auki, kunnes käyttäjä painaa enteriä
            Console.ReadLine();
        }
    }
}         
                     
    

