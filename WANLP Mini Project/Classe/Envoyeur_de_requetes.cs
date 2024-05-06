namespace WANLP_Mini_Project.Classe
{
    public class Envoyeur_de_requetes
    {
        public static async Task<string?> Envoyer_GET(string Url,object model)
        {
            string result = "";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(Url);
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();
                        return result;
                    }
                    else
                    {
                        result = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine(result);
                        return null;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine($"Erreur d'opération invalide : {ex.Message}");
                ((MainViewModel)model).Information = true;
                ((MainViewModel)model).Erreur = true;
                ((MainViewModel)model).Message_erreur = Erreurs.erreurs[0][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
                return null;
            }
            catch (TaskCanceledException ex)
            {
                Debug.WriteLine($"La tâche a été annulée : {ex.Message}");
                ((MainViewModel)model).Information = true;
                ((MainViewModel)model).Erreur = true;
                ((MainViewModel)model).Message_erreur = Erreurs.erreurs[1][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
                return null;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"Erreur HTTP : {ex.Message}");
                ((MainViewModel)model).Information = true;
                ((MainViewModel)model).Erreur = true;
                ((MainViewModel)model).Message_erreur = Erreurs.erreurs[2][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
                return null;
            }
        }

        public static async Task<byte[]?> Envoyer_GET_audio(string Url, object model)
        {
            byte[] result;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(Url);
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsByteArrayAsync();
                        return result;
                    }
                    else
                    {
                        result = await response.Content.ReadAsByteArrayAsync();
                        Debug.WriteLine(result);
                        return null;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine($"Erreur d'opération invalide : {ex.Message}");
                ((MainViewModel)model).Information = true;
                ((MainViewModel)model).Erreur = true;
                ((MainViewModel)model).Message_erreur = Erreurs.erreurs[0][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
                return null;
            }
            catch (TaskCanceledException ex)
            {
                Debug.WriteLine($"La tâche a été annulée : {ex.Message}");
                ((MainViewModel)model).Information = true;
                ((MainViewModel)model).Erreur = true;
                ((MainViewModel)model).Message_erreur = Erreurs.erreurs[1][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
                return null;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine($"Erreur HTTP : {ex.Message}");
                ((MainViewModel)model).Information = true;
                ((MainViewModel)model).Erreur = true;
                ((MainViewModel)model).Message_erreur = Erreurs.erreurs[2][GeneralClasse.ParamètreModel.language.ToString()] + "\n" + ex.Message;
                return null;
            }
        }
    }
}
