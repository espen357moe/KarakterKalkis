using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterKalkis
{
    class FagViewModel
    {
        public ObservableCollection<Fag> FagListe = new ObservableCollection<Fag>();
        
        public void addFag()
        {
            FagListe.Add(new Fag());
        }
        
        public void removeFag()
        {
            var indexOfLastElement = (FagListe.Count)-1;
            FagListe.RemoveAt(indexOfLastElement);           
        }
    }
}
