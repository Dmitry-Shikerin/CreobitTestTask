using PresentationInterfaces.Views.Forms.Common;
using Sources.Frameworks.MVPPassiveView.Controllers.Interfaces.Presenters;
using Sources.Frameworks.MVPPassiveView.Presentations.Implementation.Views;

namespace Presentation.Views.Forms.Common
{
    public class FormBase<T> : PresentableView<T>, IFormView
        where T : IPresenter
    {
    }
}