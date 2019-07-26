/****************************************************
    文件：PositionSystem.cs
	作者：CaptainYun
    日期：2019/7/25 17:57:17
	功能：位置变化系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;

namespace InterationExample {
    public class PositionSystem : ReactiveSystem<GameEntity> {
        public PositionSystem(Contexts contexts) : base(contexts.game) {

        }

        protected override bool Filter(GameEntity entity) {
            return entity.hasInterationExamplePosition && entity.hasInterationExampleView;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
            return context.CreateCollector(GameMatcher.InterationExamplePosition);
        }

        protected override void Execute(List<GameEntity> entities) {
            foreach (GameEntity entity in entities) {
                entity.interationExampleView.viewTrans.position = entity.interationExamplePosition.position;
            }
        }
    }
}