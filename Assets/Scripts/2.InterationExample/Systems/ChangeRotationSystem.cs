/****************************************************
    文件：ChangeRotationSystem.cs
	作者：CaptainYun
    日期：2019/7/25 21:14:58
	功能：改变方向系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;

namespace InterationExample {
    public class ChangeRotationSystem : ReactiveSystem<GameEntity> {
        public ChangeRotationSystem(Contexts context) : base(context.game) {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
            return context.CreateCollector(GameMatcher.InterationExampleDirection);
        }

        protected override bool Filter(GameEntity entity) {
            return entity.hasInterationExampleDirection
                   && entity.hasInterationExampleView;
        }

        protected override void Execute(List<GameEntity> entities) {
            foreach (GameEntity entity in entities) {
                Transform view = entity.interationExampleView.viewTrans;
                var angle = entity.interationExampleDirection.direction;
                view.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            }
        }
    }
}