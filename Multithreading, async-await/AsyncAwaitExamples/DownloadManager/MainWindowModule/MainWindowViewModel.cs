using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using DownloadManager.Helpers;
using DownloadServiceLib;

namespace DownloadManager.MainWindowModule
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private CancellationTokenSource _cancellationTokenSource;

        private string _sourceAddress;
        public string SourceAddress
        {
            get => _sourceAddress;
            set {
                _sourceAddress = value;
                OnPropertyChanged();
            }
        }

        private string _content;
        public string Content
        {
            get => _content;
            set {
                _content = value;
                OnPropertyChanged();
            }
        }

        private bool _isDownloadingInProgress;
        public bool IsDownloadingInProgress
        {
            get => _isDownloadingInProgress;
            set {
                _isDownloadingInProgress = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _cancelCommand;
        public RelayCommand CancelCommand => _cancelCommand ?? (_cancelCommand = new RelayCommand(obj => _cancellationTokenSource?.Cancel()));

        private RelayCommand _downloadCommand;
        public RelayCommand DownloadCommand => _downloadCommand ?? (_downloadCommand = new RelayCommand(this.DownloadCommandAction));

        private RelayCommand _downloadSyncCommand;
        public RelayCommand DownloadSyncCommand => _downloadSyncCommand ?? (_downloadSyncCommand = new RelayCommand(this.DownloadSyncCommandAction));

        public void DownloadCommandAction(object obj)
        {
            //TODO: make this method not to block the UI thread while I/O operation

            IsDownloadingInProgress = true;
            _cancellationTokenSource = new CancellationTokenSource();
            this.Content = "Loading...";

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            this.Content = DownloadService.Download(this.SourceAddress);

            stopWatch.Stop();
            var elapsed = stopWatch.Elapsed;
            var elapsedTime = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds / 10:00}";
            IsDownloadingInProgress = false;

            MessageBox.Show($"Operation has been completed. Elapsed time: {elapsedTime}", "Done.", MessageBoxButton.OK);
        }

        public void DownloadSyncCommandAction(object obj)
        {
            IsDownloadingInProgress = true;
            this.Content = "Loading...";

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            this.Content = DownloadService.Download(this.SourceAddress);

            stopWatch.Stop();
            var elapsed = stopWatch.Elapsed;
            var elapsedTime = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds / 10:00}";
            IsDownloadingInProgress = false;

            MessageBox.Show($"Operation has been completed. Elapsed time: {elapsedTime}", "Done.", MessageBoxButton.OK);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}