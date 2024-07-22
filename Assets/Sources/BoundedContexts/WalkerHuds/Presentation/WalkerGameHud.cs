using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerHuds.Presentation
{
    public class WalkerGameHud : MonoBehaviour
    {
        [SerializeField] private WalkerHudForm _walkerHudForm;
        
        public WalkerHudForm WalkerHudForm => _walkerHudForm;
    }
}