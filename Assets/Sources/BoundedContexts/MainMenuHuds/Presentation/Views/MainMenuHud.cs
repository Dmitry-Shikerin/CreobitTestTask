using Sources.BoundedContexts.MainMenuForms.Presentation.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.MainMenuHuds.Presentation.Views
{
    public class MainMenuHud : MonoBehaviour
    {
        [SerializeField] private MainMenuForm _mainMenuForm;
        
        public MainMenuForm MainMenuForm => _mainMenuForm;
    }
}