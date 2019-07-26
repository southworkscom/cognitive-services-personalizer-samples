using Microsoft.Azure.CognitiveServices.Personalizer.Models;
using PersonalizerTravelAgencyDemo.Models;
using System.Collections.Generic;

namespace PersonalizerTravelAgencyDemo.Services
{
    public interface IPersonalizerService
    {
        RankResponse GetRecommendations(IList<object> context, bool useTextAnalytics = false);
        IList<Article> GetRankedArticles(IList<object> context, bool useTextAnalytics = false);
        void Reward(Reward reward);
    }
}