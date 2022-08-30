[Table("Список операций детали")]
    public class Action : INotifyPropertyChanged
    {
        private string nameaction;

        private int idДетали;

        public event PropertyChangedEventHandler PropertyChanged;

        [Column("Операция")]
        public string NameAction
        {
            get { return nameaction; }
            set
            {
                nameaction = value;
                OnPropertyChanged("Name Action");
            }


        }

        [Column("idДетали")]
        public int IdДетали
        {
            get { return idДетали; }
            set
            {
                idДетали = value;
                OnPropertyChanged("idДетали");
            }


        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
