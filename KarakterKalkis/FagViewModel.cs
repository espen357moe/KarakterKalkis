using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KarakterKalkis
{
    public sealed class FagViewModel : INotifyPropertyChanged
    {
        private LovligKarakter _gjennomsnitt;
        public ObservableCollection<Fag> FagListe { get; }

        public PropertyChangedEventHandler UpdateHandler { get; }

        public FagViewModel()
        {
            UpdateHandler = (sender, e) => UpdateTotal();
            FagListe = new ObservableCollection<Fag>();
        }

        public LovligKarakter Gjennomsnitt
        {
            get { return _gjennomsnitt; }
            private set
            {
                _gjennomsnitt = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void UpdateTotal()
        {
            Gjennomsnitt = (LovligKarakter)FagListe.Select(x => (int) x.BokstavKarakter).Average();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
