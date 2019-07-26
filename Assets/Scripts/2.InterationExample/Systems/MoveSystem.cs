/****************************************************
    文件：MoveSystem.cs
	作者：CaptainYun
    日期：2019/7/25 18:16:23
	功能：移动系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;
using DG.Tweening;

namespace InterationExample {
    public class MoveSystem : ReactiveSystem<GameEntity> {

        public MoveSystem(Contexts contexts) : base(contexts.game) {

        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
            return context.CreateCollector(GameMatcher.InterationExampleMove);
        }

        protected override bool Filter(GameEntity entity) {
            return entity.hasInterationExampleMove
                && entity.isInterationExampleMoveComplete
                && entity.hasInterationExampleView;
        }

        protected override void Execute(List<GameEntity> entities) {
            foreach (GameEntity entity in entities) {
                entity.interationExampleView.viewTrans.DOMove(entity.interationExampleMove.targetPos, 3);
            }
        }
    }
}