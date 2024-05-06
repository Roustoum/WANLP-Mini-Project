namespace WANLP_Mini_Project.Views;

public partial class Paramètre : UserControl
{
    public Paramètre()
    {
        InitializeComponent();
        DataContext = GeneralClasse.ParamètreModel;
    }

    private void Changerthemeicon(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        GeneralClasse.ParamètreModel.changer_Sombre_Lumier();
    }

    private void Backendserveur_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        GeneralClasse.ParamètreModel.Backend_serveur = backend_serveur.Text!;
    }

    private void vrserveur_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        //((MainViewModel)DataContext!).Vr_serveur = vr_serveur.Text!;
    }

    private void nplserveur_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        GeneralClasse.ParamètreModel.Offline_nlp_serveur = nlp_serveur.Text!;
    }

    private void tts_serveur_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        //((MainViewModel)DataContext!).Offline_text_a_parole = tts_serveur.Text!;
    }

    public void mise_a_jour()
    {
        //nom_utilisateur.Text = ((MainViewModel)DataContext!).Utilisateur_fai.nom_utilisateur;
        //mot_de_passe.Text = ((MainViewModel)DataContext!).Utilisateur_fai.mot_de_passe;
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        //if (!(String.IsNullOrEmpty(nom_utilisateur.Text) || String.IsNullOrWhiteSpace(nom_utilisateur.Text) || String.IsNullOrWhiteSpace(mot_de_passe.Text) || String.IsNullOrEmpty(mot_de_passe.Text)))
        //{
        //    if (nom_utilisateur.Text != "admin" && mot_de_passe.Text != "admin")
        //    {
        //string fullUrl = ((MainViewModel)DataContext!).Backend_serveur + "modification_profile?" + JsonConvertisseur.Convertire_Obj_Json(new { nom_utilisateur = ((MainViewModel)DataContext!).Utilisateur_fai.nom_utilisateur , mot_de_passe = ((MainViewModel)DataContext!).Utilisateur_fai.mot_de_passe,nouveau_nom_utilisateur = nom_utilisateur.Text , nouveau_mot_de_passe=mot_de_passe.Text });
        //string? result = await Envoyeur_de_requetes.Envoyer_GET(fullUrl, this.DataContext);
        //if (result != null)
        //{
        //    Utilisateur a = JsonConvert.DeserializeObject<Utilisateur>(result)!;
        //    if (a.code == 0)
        //    {
        //        ((MainViewModel)DataContext!).Utilisateur_fai.nom_utilisateur = nom_utilisateur.Text;
        //        ((MainViewModel)DataContext!).Utilisateur_fai.mot_de_passe = mot_de_passe.Text;
        //        ((MainViewModel)DataContext!).Information = true;
        //        ((MainViewModel)DataContext!).Succee = true;
        //        ((MainViewModel)DataContext!).Message_erreur = Erreurs.erreurs[3][((MainViewModel)DataContext!).language.ToString()];
        //    }
        //    else
        //    {
        //        string er = "";
        //        ((MainViewModel)DataContext!).Information = true;
        //        ((MainViewModel)DataContext!).Alert = true;
        //        foreach (string y in a.errors!)
        //        {
        //            er += y + "\n";
        //        }
        //        ((MainViewModel)DataContext!).Message_erreur = er;
        //    }
        //    Debug.WriteLine(result);
        //}
        //    }
        //}
    }
}