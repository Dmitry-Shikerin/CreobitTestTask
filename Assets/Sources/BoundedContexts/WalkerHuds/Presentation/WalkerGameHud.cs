using Sources.BoundedContexts.Timers.Presentation.Implementation;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Implementation;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerHuds.Presentation
{
    public class WalkerGameHud : MonoBehaviour
    {
        [Header("Score")]
        [SerializeField] private WalkerScoreView _walkerScoreView;
        [Header("Forms")]
        [SerializeField] private WalkerHudForm _walkerHudForm;
        [SerializeField] private FinishForm _finishForm;
        [SerializeField] private StartForm _startForm;
        
        public WalkerScoreView WalkerScoreView => _walkerScoreView;
        
        public WalkerHudForm WalkerHudForm => _walkerHudForm;
        public FinishForm FinishForm => _finishForm;
        public StartForm StartForm => _startForm;
    }
}