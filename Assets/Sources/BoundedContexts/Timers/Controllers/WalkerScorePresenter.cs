using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Sources.BoundedContexts.Timers.Domain;
using Sources.BoundedContexts.Timers.Presentation.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.Timers.Controllers
{
    public class WalkerScorePresenter : PresenterBase
    {
        private readonly WalkerScore _walkerScore;
        private readonly IWalkerScoreView _view;

        private CancellationTokenSource _cancellationToken;

        public WalkerScorePresenter(
            WalkerScore walkerScore, 
            IWalkerScoreView view)
        {
            _walkerScore = walkerScore ?? throw new ArgumentNullException(nameof(walkerScore));
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public override void Initialize()
        {
            _cancellationToken = new CancellationTokenSource();
        }
        
        public override void Destroy()
        {
            _cancellationToken.Cancel();
        }

        public async void StartTimer()
        {
            try
            {
                _cancellationToken = new CancellationTokenSource();
                
                while (_cancellationToken.IsCancellationRequested == false)
                {
                    _walkerScore.CurrentScore += Time.deltaTime;
                    
                    await UniTask.Yield(_cancellationToken.Token);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        public void StopTimer()
        {
            _cancellationToken.Cancel();
            _walkerScore.CompareScore();
            _view.BestScoreText.SetText(_walkerScore.BestScore.ToString());
            _view.CurrentScoreText.SetText(_walkerScore.CurrentScore.ToString());
        }
    }
}