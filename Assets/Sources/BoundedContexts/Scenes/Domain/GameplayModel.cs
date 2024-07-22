using Sources.Frameworks.GameServices.Volumes.Domain.Models.Implementation;

namespace Sources.BoundedContexts.Scenes.Domain
{
    public class GameplayModel
    {
        public GameplayModel(
            Volume volume)
        {
            Volume = volume;
        }

        public Volume Volume { get; }
    }
}