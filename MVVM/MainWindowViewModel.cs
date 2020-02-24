using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_panorama.MVVM
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string[] _WorkMode;

        public string[] WorkMode
        {
            get => _WorkMode;
            set
            {
                _WorkMode = value;
                RaisePropertyChanged(nameof(WorkMode));
            }
        }

        private int _selectedWorkMode;

        public int SelectedWorkMode
        {
            get => _selectedWorkMode;
            set
            {

                _selectedWorkMode = value;
                RaisePropertyChanged(nameof(SelectedWorkMode));
            }
        }
        //Обработчик нажатия
        public DelegateCommand ClickCommand { get; set; }
        //начало настройки доступа кнопок
        private bool _IsOpenFilesEnabled;
        public bool IsOpenFilesEnabled
        {
            get => _IsOpenFilesEnabled;
            set
            {
                _IsOpenFilesEnabled = value;
                RaisePropertyChanged(nameof(IsOpenFilesEnabled));
            }
        }

        private bool _IsRunEnabled;
        public bool IsRunEnabled
        {
            get => _IsRunEnabled;
            set
            {
                _IsRunEnabled = value;
                RaisePropertyChanged(nameof(IsRunEnabled));
            }
        }

        private bool _IsBackStepEnabled;
        public bool IsBackStepEnabled
        {
            get => _IsBackStepEnabled;
            set
            {
                _IsBackStepEnabled = value;
                RaisePropertyChanged(nameof(IsBackStepEnabled));
            }
        }

        private bool _IsStepEnabled;
        public bool IsStepEnabled
        {
            get => _IsStepEnabled;
            set
            {
                _IsStepEnabled = value;
                RaisePropertyChanged(nameof(IsStepEnabled));
            }
        }

        private bool _IsSaveEnabled;
        public bool IsSaveEnabled
        {
            get => _IsSaveEnabled;
            set
            {
                _IsSaveEnabled = value;
                RaisePropertyChanged(nameof(IsSaveEnabled));
            }
        }
        //конец настройки доступа кнопок

        //главная функция
        public MainWindowViewModel()
        {
            ClickCommand = new DelegateCommand(ClickCommandExecute);
        }
        //Обработчик выбора
        private void ClickCommandExecute(object parameter)
        {
            switch ((string)parameter)
            {
                case "OpenFiles":
                    //Тут будет функция открытия файлов
                    break;
                case "Run":
                    //Тут будет функция объединения
                    break;
                case "BackStep":
                    //шаг назад обработки
                    break;
                case "Step":
                    //шаг вперед обработки
                    break;
                case "Save":
                    //Сохранить файл
                    break;
                case "Settings":
                    //настройки
                    break;
                case "Info":
                    //О программе
                    break;
            }
        }

    }
}
