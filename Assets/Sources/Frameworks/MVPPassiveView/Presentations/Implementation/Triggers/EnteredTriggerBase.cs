using System;
using Sources.PresentationsInterfaces.Triggers;
using UnityEngine;

namespace Sources.Frameworks.MVPPassiveView.Presentations.Implementation.Triggers
{
    public class EnteredTriggerBase<T> : MonoBehaviour, IEnteredTrigger<T>
    {
        public event Action<T> Entered;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out T component))
                Entered?.Invoke(component);
        }
    }
}