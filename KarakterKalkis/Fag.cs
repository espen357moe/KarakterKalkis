using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KarakterKalkis
{
    public enum LovligKarakter
    {
        A = 5,
        B = 4,
        C = 3,
        D = 2,
        E = 1,
        F = 0
    };

    public sealed class Fag : INotifyPropertyChanged //Et fag består av et vekttall som er enten 7.5 eller 15, og en bokstavkarakter som korresponderer med en heltallsverdi
    {        
        private LovligKarakter _karakter;
        private float _vekttall;

        public LovligKarakter BokstavKarakter
        {
            get { return _karakter; }
            set
            {
                if(!Enum.IsDefined(typeof(LovligKarakter), value))
                    throw new ArgumentException("Verdien er ikke en lovlig karakter.", nameof(value));

                _karakter = value;
                OnPropertyChanged();
            }        
        }

        public float Vekttall
        {
            get { return _vekttall; }
            set
            {
                _vekttall = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
