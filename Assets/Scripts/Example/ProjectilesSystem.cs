using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ProjectilesSystem : BaseSystem<GameData>
    {
        private readonly TableSet _simulation;
        private int _lastTickUpdate;

        public ProjectilesSystem(TableSet simulation)
        {
            _simulation = simulation;
        }
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            if(_lastTickUpdate>=data.Tick)
                return;
            _lastTickUpdate = data.Tick;
            var clearEmptyEntities = false;
            var count = _simulation.Projectile.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                var projectile = _simulation.Projectile.CmpAt(i);
                var id = _simulation.Projectile.IdAt(i);
                var entity = _simulation[id];
                if (projectile.DestroyTick > _lastTickUpdate)
                {
                    var transform = entity.Transform;
                    var movement = entity.Movement;
                    transform.Position += new Vector3(movement.Movement.x, 0, movement.Movement.y);
                    continue;
                }
                entity.DeleteAll();
                clearEmptyEntities = true;
            }
            if(clearEmptyEntities)
                _simulation.DeleteEmptyEntities();
        }
    }
}