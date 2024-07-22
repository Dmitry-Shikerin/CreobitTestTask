using UnityEngine;

namespace Sources.BoundedContexts.Timers.Domain
{
    public class WalkerScore
    {
        public float CurrentScore { get; set; }
        public float BestScore { get; set; }

        public void CompareScore()
        {
            if (CurrentScore < BestScore)
                BestScore = CurrentScore;

            if (Mathf.Approximately(BestScore, 0))
                BestScore = CurrentScore;
        }
    }
}