namespace WANLP_Mini_Project.Views;

public partial class massage_view : UserControl
{
    public massage_view()
    {
        InitializeComponent();
        mise_a_jour_chat();
    }
    bool cap = false;
    CaptureAudioService C = new CaptureAudioService(0);

    public void mise_a_jour_chat()
    {
        message_listbox.ItemsSource = GeneralClasse.conversations;
    }

    private async void Envoyeur_message(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (!(String.IsNullOrEmpty(message.Text) || String.IsNullOrWhiteSpace(message.Text)))
        {
            Conversation a = new Conversation { role = "user", logs = message.Text };

            GeneralClasse.conversations.Add(a);
            string fullUrl = GeneralClasse.ParamètreModel.Offline_nlp_serveur + "coherance?" + JsonConvertisseur.Convertire_Obj_Json(new { message = message.Text });
            message.Text = "";
            string? result = await Envoyeur_de_requetes.Envoyer_GET(fullUrl, GeneralClasse.MainViewModel);
            if (result != null)
            {
                Conversation message_jidi = JsonConvert.DeserializeObject<Conversation>(result)!;
                if (message_jidi != null)
                {
                    GeneralClasse.conversations.Add(message_jidi);
                }
            }
        }
    }

    private void Capture_microphone(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (!cap)
        {
            C.DataAvailable += (buffer, length) =>
            {
                Dispatcher.UIThread.InvokeAsync(() =>
                {
                    //test.Text = CaptureAudioService.audio_capture.Count.ToString();
                });
            };
            C.Start();
            ((MainViewModel)DataContext!).Microphone_path = "M19,11C19,12.19 18.66,13.3 18.1,14.28L16.87,13.05C17.14,12.43 17.3,11.74 17.3,11H19M15,11.16L9,5.18V5A3,3 0 0,1 12,2A3,3 0 0,1 15,5V11L15,11.16M4.27,3L21,19.73L19.73,21L15.54,16.81C14.77,17.27 13.91,17.58 13,17.72V21H11V17.72C7.72,17.23 5,14.41 5,11H6.7C6.7,14 9.24,16.1 12,16.1C12.81,16.1 13.6,15.91 14.31,15.58L12.65,13.92L12,14A3,3 0 0,1 9,11V10.28L3,4.27L4.27,3Z";
            ((MainViewModel)DataContext!).Captureaudio = true;
        }
        else
        {
            C.Stop();
            ((MainViewModel)DataContext!).Captureaudio = false;
            ((MainViewModel)DataContext!).Microphone_path = "M12,2A3,3 0 0,1 15,5V11A3,3 0 0,1 12,14A3,3 0 0,1 9,11V5A3,3 0 0,1 12,2M19,11C19,14.53 16.39,17.44 13,17.93V21H11V17.93C7.61,17.44 5,14.53 5,11H7A5,5 0 0,0 12,16A5,5 0 0,0 17,11H19Z";
            envoyer_audio();
        }
        cap = !cap;
    }

    private async void envoyer_audio()
    {
        string result = "";
        string base64String = Convert.ToBase64String(CaptureAudioService.audio_capture.ToArray());
        CaptureAudioService.audio_capture.Clear();
        CaptureAudioService.audio_capture = null;
        CaptureAudioService.audio_capture = new List<byte>();
        var data = new { a = base64String };

        string jsonContent = "{\"a\":\"" + base64String + "\"}";

        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        string fullUrl = GeneralClasse.ParamètreModel.Offline_nlp_serveur+"audio";
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(fullUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    if (result.Length >= 2)
                    {
                        if(message.Text != null && message.Text.Length >0)
                            message.Text +=" "+result.Substring(1, result.Length - 2);
                        else
                            message.Text += result.Substring(1, result.Length - 2);
                    }
                }
                else
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
        }
        catch (InvalidOperationException ex)
        {
            Debug.WriteLine($"Erreur d'opération invalide : {ex.Message}");
        }
        catch (TaskCanceledException ex)
        {
            Debug.WriteLine($"La tâche a été annulée : {ex.Message}");
        }
        catch (HttpRequestException ex)
        {
            Debug.WriteLine($"Erreur HTTP : {ex.Message}");
        }
    }
}