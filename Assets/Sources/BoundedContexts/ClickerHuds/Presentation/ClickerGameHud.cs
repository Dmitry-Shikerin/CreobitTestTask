using Sources.BoundedContexts.ClickerHudForms.Presentation.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.ClickerHuds.Presentation
{
    public class ClickerGameHud : MonoBehaviour
    {
        [SerializeField] private ClickerHudForm _clickerHudForm;
        
        public ClickerHudForm ClickerHudForm => _clickerHudForm;
    }
}