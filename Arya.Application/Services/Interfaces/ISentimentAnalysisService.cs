using Arya.Domain.Entities;

namespace Arya.Application.Services.Interfaces
{
    public interface ISentimentAnalysisService
    {
        SentimentPrediction Predict(string text);
    }
}