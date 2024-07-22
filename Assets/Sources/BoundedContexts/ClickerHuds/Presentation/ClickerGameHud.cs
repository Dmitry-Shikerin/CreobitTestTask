using Sources.BoundedContexts.ClickerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.ClickerScores.Domain;
using Sources.BoundedContexts.ClickerScores.Presentations.Implementation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sources.BoundedContexts.ClickerHuds.Presentation
{
    public class ClickerGameHud : MonoBehaviour
    {
        [Header("Score")]
        [SerializeField] private ClickScoreView _clickScoreView;
        
        [Header("Forms")]
        [SerializeField] private ClickerHudForm _clickerHudForm;
        
        public ClickScoreView ClickScoreView => _clickScoreView;
        
        public ClickerHudForm ClickerHudForm => _clickerHudForm;
    }
}