namespace WANLP_Mini_Project.Classe
{
    public class Conversation
    {
        private string? _role;
        [JsonProperty("role")]
        public string? role
        {
            get { return _role; }
            set
            {
                est_bot = value == "assistant";
                _role = value;
            }
        }

        [JsonIgnore]
        public bool est_bot { get; set; } = false;

        [JsonProperty("contenu")]
        public string? logs { get; set; }

        [JsonProperty("phrases")]
        public ObservableCollection<Phrase>? phrases { get; set; }
    }

    public class Phrase
    {
        [JsonProperty("text")]
        public string? text { get; set; }

        [JsonProperty("est_coherent")]
        public bool est_coherent { get; set; }

        [JsonProperty("suggestion")]
        public ObservableCollection<string>? suggestion { get; set; }
    }
}
