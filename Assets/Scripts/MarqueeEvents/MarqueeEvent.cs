using Object = UnityEngine.Object;

namespace MarqueeEvents
{
    public class MarqueeEvent
    {
        public string eventText;
        private readonly float amount;

        public MarqueeEvent(Colors color)
        {
            var companyName = MarqueeEventTexts.GetRandomName(color);
            var marqueeEvent = MarqueeEventTexts.RandomEvent(companyName, color);
            amount = marqueeEvent.amount;
            var affectCompany = marqueeEvent.affectCompany;
            if (affectCompany)
            {
                AffectCompanyByName(companyName);
            }
            else
            {
                AffectCompanyByColor(color);
            }
            eventText = marqueeEvent.text;
        }


        private void AffectCompanyByColor(Colors color)
        {
            var gameObjects = Object.FindObjectsOfType<CompanyCard>();
            foreach (var gameObject in gameObjects)
            {
                if (gameObject.GetComponent<CompanyCard>().color == color)
                {
                    gameObject.GetComponent<CompanyCardData>().deltaModifiers.Add(new DeltaModifier(amount));
                }
            }
        }

        private void AffectCompanyByName(string name)
        {
            var gameObjects = Object.FindObjectsOfType<CompanyCard>();
            foreach (var gameObject in gameObjects)
            {
                if (gameObject.GetComponent<CompanyCard>().companyName.FullName() == name)
                {
                    gameObject.GetComponent<CompanyCardData>().deltaModifiers.Add(new DeltaModifier(amount));
                }
            }
        }
    }
}