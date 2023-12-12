using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Esercitazione_Tablet
{
    class Tablet
    {
        protected string _marca { get; set; }
        protected int _velocita { get; set; }
        protected int _dimensione { get; set; }
        protected int _durata { get; set; }

        public Tablet()
        {
        }
        public Tablet (string marca, int velocita, int dimensione, int durata) 
        { 
            _marca = marca;
            _dimensione = dimensione;
            _durata = durata;
            _velocita = velocita;
        }
        public void leggiDati( Tablet[] ar )
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Inserici la marca del tablet");
                string marca = Console.ReadLine();
                Console.WriteLine("Inserici la velocità del tablet (espressa in GHz)");
                int velocita = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserici la dimensione del tablet (espresso in pollici)");
                int dimensione = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserici la durata della batteria (espresso in mAh)");
                int durata = int.Parse(Console.ReadLine());
                ar[i] = new Tablet (marca, velocita, dimensione, durata);
                Console.Clear();
            }
        }
        public void stampaDati( Tablet[] ar )
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"La marca del tablet è {ar[i]._marca}");
                Console.WriteLine($"La velocità del tablet è  {ar[i]._velocita} (espressa in GHz)");
                Console.WriteLine($"La dimensione del tablet è {ar[i]._dimensione} (espresso in pollici)");
                Console.WriteLine($"La durata della batteria è  {ar[i]._durata} (espresso in mAh)");
            }          
        }
    }
    internal class Program
    {             
         static void Main(string[] args)
         {
            Tablet AA = new Tablet();
            Tablet[] Tablet = new Tablet[5];
            AA.leggiDati(Tablet);
            AA.stampaDati(Tablet);
         }        
    }
}
