namespace WANLP_Mini_Project.Classe
{
    public class GeneralClasse
    {
        public static ParamètreModel ParamètreModel { get; set; }
        public static MainViewModel MainViewModel { get; set; }
        public static AAModel AAModel { get; set; }
        public static ObservableCollection<Conversation> conversations { get; set; } = new ObservableCollection<Conversation>();
    }
}
