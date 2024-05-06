using System.Reflection;

namespace WANLP_Mini_Project.ViewModels
{
    public partial class AAModel : ObservableObject
    {
        [ObservableProperty]
        private bool _local = true;

        [ObservableProperty]
        private bool _appartement = false;

        [ObservableProperty]
        private bool _villa = false;

        [ObservableProperty]
        private bool _vendre = true;

        [ObservableProperty]
        private bool _louer = false;

        [ObservableProperty]
        private string _type_appartement = "F1";

        [ObservableProperty]
        private int _etages = 0;

        [ObservableProperty]
        private int _nbretages = 0;

        [ObservableProperty]
        private int _facades = 1;

        [ObservableProperty]
        private string _surface ="";

        [ObservableProperty]
        private string _surface_const = "";

        public AAModel()
        {

        }

        [RelayCommand]
        private void predire_prix()
        {
            try
            {
                if(Surface != "")
                {
                    double num = double.Parse(Surface);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Surface n'est pas un entier valide.");
                GeneralClasse.MainViewModel.Information = true;
                GeneralClasse.MainViewModel.Erreur = true;
                GeneralClasse.MainViewModel.Message_erreur = "Surface "+ Erreurs.erreurs[4][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Surface est hors de la plage des valeurs entières.");
                GeneralClasse.MainViewModel.Information = true;
                GeneralClasse.MainViewModel.Erreur = true;
                GeneralClasse.MainViewModel.Message_erreur = "Surface " + Erreurs.erreurs[4][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
            }

            try
            {
                if (Surface_const != "")
                {
                    double num = double.Parse(Surface_const);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Surface Construite n'est pas un entier valide.");
                GeneralClasse.MainViewModel.Information = true;
                GeneralClasse.MainViewModel.Erreur = true;
                GeneralClasse.MainViewModel.Message_erreur = "Surface Construite " + Erreurs.erreurs[4][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Surface Construite est hors de la plage des valeurs entières.");
                GeneralClasse.MainViewModel.Information = true;
                GeneralClasse.MainViewModel.Erreur = true;
                GeneralClasse.MainViewModel.Message_erreur = "Surface Construite " + Erreurs.erreurs[4][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
            }

        }

        [RelayCommand]
        private void plus_facade()
        {
            if(Facades + 1 <= 4)
                Facades++;
        }

        [RelayCommand]
        private void moin_facade()
        {
            if (Facades - 1 >= 1)
                Facades--;
        }

        [RelayCommand]
        private void plus_nbretages()
        {
            Nbretages++;
        }

        [RelayCommand]
        private void moin_nbretages()
        {
            if (Nbretages - 1 >= 0)
                Nbretages--;
        }

        [RelayCommand]
        private void plus_etages()
        {
            Etages++;
        }

        [RelayCommand]
        private void moin_etages()
        {
            if(Etages -1 >= 0)
                Etages--;
        }

        private int num_appartement = 1;

        [RelayCommand]
        private void plus_appartement()
        {
            if (num_appartement + 1 < 10)
                Type_appartement = "F" + ++num_appartement;
        }

        [RelayCommand]
        private void moin_appartement()
        {
            if(num_appartement -1 > 0)
                Type_appartement = "F" + --num_appartement;
        }

        [RelayCommand]
        private void vendre_selectioner()
        {
            Vendre = true;
            Louer = false;
        }

        [RelayCommand]
        private void louer_selectioner()
        {
            Vendre = false;
            Louer = true;
        }

        [RelayCommand]
        private void local_selectioner()
        {
            Local = true;
            Appartement = false;
            Villa = false;
            co = 0;
        }

        [RelayCommand]
        private void appartement_selectioner()
        {
            Local = false;
            Appartement = true;
            Villa = false;
            co = 1;
        }

        [RelayCommand]
        private void villa_selectioner()
        {
            Local = false;
            Appartement = false;
            Villa = true;
            co = 2;
        }

        private int co = 0;
        [RelayCommand]
        private void droite_toucher()
        {
            co = (co + 1) % 3;
            Local = co == 0;
            Appartement = co == 1;
            Villa = co == 2;
        }

        [RelayCommand]
        private void gauche_toucher()
        {
            co = (co + 2) % 3;
            Local = co == 0;
            Appartement = co == 1;
            Villa = co == 2;
        }
    }
}
