namespace WANLP_Mini_Project.ViewModels
{
    public partial class ParamètreModel : ObservableObject
    {
        public ResourceInclude Francais { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Strings/Francais.axaml")) { Source = new Uri("avares://WANLP Mini Project/Strings/Francais.axaml") };
        public ResourceInclude Arabe { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Strings/Arabe.axaml")) { Source = new Uri("avares://WANLP Mini Project/Strings/Arabe.axaml") };
        public ResourceInclude Englait { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Strings/Langlais.axaml")) { Source = new Uri("avares://WANLP Mini Project/Strings/Langlais.axaml") };

        public ResourceInclude Sombre { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Sombre.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Sombre.axaml") };
        public ResourceInclude Lumier { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Lumier.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Lumier.axaml") };

        public ResourceInclude Theme_1 { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Theme_1.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Theme_1.axaml") };
        public ResourceInclude Theme_2 { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Theme_2.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Theme_2.axaml") };
        public ResourceInclude Theme_3 { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Theme_3.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Theme_3.axaml") };
        public ResourceInclude Theme_4 { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Theme_4.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Theme_4.axaml") };
        public ResourceInclude Theme_5 { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Theme_5.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Theme_5.axaml") };
        public ResourceInclude Theme_6 { set; get; } = new ResourceInclude(new Uri("avares://WANLP Mini Project/Themes/Theme_6.axaml")) { Source = new Uri("avares://WANLP Mini Project/Themes/Theme_6.axaml") };



        public ParamètreModel()
        {
            Application.Current!.Resources.MergedDictionaries.Add(Francais);
            Application.Current!.Resources.MergedDictionaries.Add(Sombre);
            Application.Current!.Resources.MergedDictionaries.Add(Theme_1);
            
        }

        [ObservableProperty]
        private string _backend_serveur = "http://127.0.0.1:3000/";

        [ObservableProperty]
        private bool _bare = false;

        [ObservableProperty]
        private bool _parametrebare = false;

        [ObservableProperty]
        private string _offline_nlp_serveur = "http://127.0.0.1:5000/";

        [RelayCommand]
        private void changer_bare()
        {
            GeneralClasse.MainViewModel.windows_stylerCommand.Execute(null);
            Bare = GeneralClasse.MainViewModel.Windows;
            Debug.WriteLine(Bare);
        }

        [ObservableProperty]
        private bool _sombre_Lumier = false;
        public void changer_Sombre_Lumier()
        {
            Sombre_Lumier = !Sombre_Lumier;
            if (!Sombre_Lumier)
            {
                Application.Current!.Resources.MergedDictionaries.Add(Sombre);
                Application.Current!.Resources.MergedDictionaries.Remove(Lumier);
            }
            else
            {
                Application.Current!.Resources.MergedDictionaries.Add(Lumier);
                Application.Current!.Resources.MergedDictionaries.Remove(Sombre);
            }
        }

        public int theme = 1;

        [RelayCommand]
        private void changer_Theme(object parametre)
        {
            int parametr = Convert.ToInt32(parametre);
            if (theme != parametr)
            {
                Application.Current!.Resources.MergedDictionaries.Remove(Theme_1);
                Application.Current!.Resources.MergedDictionaries.Remove(Theme_2);
                Application.Current!.Resources.MergedDictionaries.Remove(Theme_3);
                Application.Current!.Resources.MergedDictionaries.Remove(Theme_4);
                Application.Current!.Resources.MergedDictionaries.Remove(Theme_5);
                Application.Current!.Resources.MergedDictionaries.Remove(Theme_6);
                theme = parametr;
                switch (theme)
                {
                    case 1:
                        Application.Current!.Resources.MergedDictionaries.Add(Theme_1);
                        break;
                    case 2:
                        Application.Current!.Resources.MergedDictionaries.Add(Theme_2);
                        break;
                    case 3:
                        Application.Current!.Resources.MergedDictionaries.Add(Theme_3);
                        break;
                    case 4:
                        Application.Current!.Resources.MergedDictionaries.Add(Theme_4);
                        break;
                    case 5:
                        Application.Current!.Resources.MergedDictionaries.Add(Theme_5);
                        break;
                    case 6:
                        Application.Current!.Resources.MergedDictionaries.Add(Theme_6);
                        break;
                }
            }
        }

        public int language = 0;

        [RelayCommand]
        private void changer_langue(object parametre)
        {
            int lang = Convert.ToInt32(parametre);
            if (language != lang)
            {
                Application.Current!.Resources.MergedDictionaries.Remove(Englait);
                Application.Current!.Resources.MergedDictionaries.Remove(Arabe);
                Application.Current!.Resources.MergedDictionaries.Remove(Francais);
                language = lang;
                switch (language)
                {
                    case 0:
                        Application.Current!.Resources.MergedDictionaries.Add(Francais);
                        break;
                    case 1:
                        Application.Current!.Resources.MergedDictionaries.Add(Arabe);
                        break;
                    case 2:
                        Application.Current!.Resources.MergedDictionaries.Add(Englait);
                        break;
                }
            }
        }
    }
}
