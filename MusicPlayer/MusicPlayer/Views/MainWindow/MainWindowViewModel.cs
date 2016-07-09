using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using MusicPlayer.Extensions;

namespace MusicPlayer.Views.MainWindow
{
    public class MainWindowViewModel : Screen
    {
        private string _textBody;
        private int _counter;
        private string _textBox;

        public string TextBody
        {
            get { return this._textBody; }
            set
            {
                _textBody = value;
                NotifyOfPropertyChange(() => TextBody);
            }
        }

        public string TextBox
        {
            get { return this._textBox; }
            set
            {
                _textBox = value;
                NotifyOfPropertyChange(() => TextBox);
            }
        }


        public MainWindowViewModel()
        {
            this.DisplayName = "The best Music Player ever!";
            this.TextBody = "textbody";
        }

        public void ChangeMessage(int parameter)
        {
            if (this.TextBox.IsNumber())
                this.TextBody = $"test{_counter += Convert.ToInt32(TextBox)}";

        }

    }
}
