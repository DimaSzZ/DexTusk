using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task14Events
{
    internal class NPCTest: INotifyPropertyChanged
    {
        private string? _namecar;
        private string? _colorcar;
        public string? NameCar
        {
            get => _namecar;
            set
            {
                _namecar = value;
                OnPropertyChanged(nameof(NameCar));
            }
        }
        public string? ColorCar
        {
            get => _colorcar;
            set
            {
                _colorcar = value;
                OnPropertyChanged(nameof(ColorCar));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if(_colorcar != null)
            Console.WriteLine($"Цвет машины {ColorCar}");
        }
    }
}
