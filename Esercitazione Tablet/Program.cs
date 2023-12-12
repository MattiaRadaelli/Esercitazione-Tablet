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
                Console.WriteLine($"La marca del {i}° tablet è {ar[i]._marca}");
                Console.WriteLine($"La velocità del {i}° tablet è {ar[i]._velocita} (espressa in GHz)");
                Console.WriteLine($"La dimensione del {i}° tablet è {ar[i]._dimensione} (espresso in pollici)");
                Console.WriteLine($"La durata della {i}° batteria è {ar[i]._durata} (espresso in mAh)");
            }          
        }
        public void punteggio(Tablet[] ar)
        {
            int punteggiosingolo = 0;
            int punteggiototale = 0;
            int punteggiomin = 0;
            int punteggiomax = 0;
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                punteggiosingolo = 0;
                punteggiosingolo += 10 * ar[i]._velocita;
                punteggiosingolo += ar[i]._dimensione;
                punteggiosingolo += ar[i]._durata/1000;
                punteggiototale += punteggiosingolo;
                if (punteggiomin > punteggiosingolo)
                {
                    punteggiomin = punteggiosingolo;
                }
                if (punteggiomax < punteggiosingolo)
                {
                    punteggiomax = punteggiosingolo;
                }
                Console.WriteLine($"Il punteggio del {i}° tablet è {punteggiosingolo}");
            }
            Console.WriteLine($"\nIl punteggio minimo dei tablet è {punteggiomin}");
            Console.WriteLine($"Il punteggio massimo dei tablet è {punteggiomax}");
            Console.WriteLine($"\nIl punteggio totale dei tablet è {punteggiototale}");
            Console.WriteLine($"la media del punteggio dei tablet è {punteggiototale/5}");
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
            AA.punteggio(Tablet);
        }        
    }
}
