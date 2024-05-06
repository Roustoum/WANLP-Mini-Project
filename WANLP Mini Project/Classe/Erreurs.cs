namespace WANLP_Mini_Project.Classe
{
    public class Erreurs
    {
        public static List<Dictionary<string, string>> erreurs = new List<Dictionary<string, string>> {
            new Dictionary<string, string>{ {"0", "Erreur d'opération invalide" }, { "1", "خطأ عملية غير صالح" }, { "2", "Invalid operation error" } },
            new Dictionary<string, string>{ {"0", "La tâche a été annulée" }, { "1", "تم إلغاء المهمة" }, { "2", "The task was canceled" } },
            new Dictionary<string, string>{ {"0", "Erreur HTTP" }, { "1", "خطأ HTTP" }, { "2", "HTTP error" } },
            new Dictionary<string, string>{ {"0", "Modification faites avec succès" }, { "1", "تم التعديل بنجاح" }, { "2", "Modification made successfully" } },
            new Dictionary<string, string>{ {"0", "n'est pas un nombre à virgule flottante valide" }, { "1", "ليس رقم الفاصلة العائمة صالحًا" }, { "2", "is not a valid floating point number" } },
            new Dictionary<string, string>{ {"0", "est hors de la plage des valeurs double" }, { "1", "يقع خارج نطاق القيم المزدوجة" }, { "2", "is out of the double value range" } },
        };
    }
}
