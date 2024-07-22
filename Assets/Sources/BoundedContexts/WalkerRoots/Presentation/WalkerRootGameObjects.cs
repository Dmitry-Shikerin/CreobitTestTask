using Sources.BoundedContexts.Finishes.Presentation.Views.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerRoots.Presentation
{
    public class WalkerRootGameObjects : MonoBehaviour
    {
        [SerializeField] private FinishView _finishView;
        
        public FinishView FinishView => _finishView;
    }
}