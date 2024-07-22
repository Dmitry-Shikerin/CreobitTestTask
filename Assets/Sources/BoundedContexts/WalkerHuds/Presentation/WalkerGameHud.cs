using Sources.BoundedContexts.WalkerFinishForms.Presentation.Implementation;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerHuds.Presentation
{
    public class WalkerGameHud : MonoBehaviour
    {
        [SerializeField] private WalkerHudForm _walkerHudForm;
        [SerializeField] private FinishForm _finishForm;
        
        public WalkerHudForm WalkerHudForm => _walkerHudForm;
        public FinishForm FinishForm => _finishForm;
    }
}