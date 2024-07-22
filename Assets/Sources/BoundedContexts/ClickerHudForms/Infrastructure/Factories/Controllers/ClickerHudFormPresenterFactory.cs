using Sources.BoundedContexts.ClickerHudForms.Controllers;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Interfaces;

namespace Sources.BoundedContexts.ClickerHudForms.Infrastructure.Factories.Controllers
{
    public class ClickerHudFormPresenterFactory
    {
        public ClickerHudFormPresenterFactory()
        {
            
        }
        
        public ClickerHudFormPresenter Create(IClickerHudForm view) =>
            new(view);
    }
}