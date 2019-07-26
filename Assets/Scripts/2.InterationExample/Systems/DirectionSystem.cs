/****************************************************
    文件：DirectionSystem.cs
	作者：CaptainYun
    日期：2019/7/25 18:47:31
	功能：方向系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;
using DG.Tweening;

namespace InterationExample {
    /// <summary>
    /// 方向系统
    /// </summary>
    public class DirectionSystem : ReactiveSystem<GameEntity> {
        public DirectionSystem(Contexts context) : base(context.game) {
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
                Transform view = entity.interationExampleView.viewTrans;
                Vector3 targetPos = entity.interationExampleMove.targetPos;
                Vector3 direction = (targetPos - view.position).normalized;
                //四元数版本
                //Quaternion angleOffset = Quaternion.FromToRotation(view.up, direction);
                //view.rotation *= angleOffset;
                //普通版本
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                entity.ReplaceInterationExampleDirection(angle);
            }
        }
    }
}
