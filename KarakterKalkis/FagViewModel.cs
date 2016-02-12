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
        private float _gjennomsnitt;
        public ObservableCollection<Fag> FagListe { get; }

        public PropertyChangedEventHandler UpdateHandler { get; }

        public FagViewModel()
        {
            UpdateHandler = (sender, e) => UpdateTotal();
            FagListe = new ObservableCollection<Fag>();
        }

        public float Gjennomsnitt
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
            Gjennomsnitt = FagListe.Select(x => (float) x.BokstavKarakter).Average();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
