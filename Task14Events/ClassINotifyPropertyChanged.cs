using System.ComponentModel;
using System.Runtime.CompilerServices;
using Task14Events.Annotations;

namespace Task14Events
{
    internal class ClassINotifyPropertyChanged: INotifyPropertyChanged
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

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Console.WriteLine("Свойство изменилось");
        }
    }
}
