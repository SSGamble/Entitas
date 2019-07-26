/****************************************************
    文件：AddViewSystem.cs
	作者：CaptainYun
    日期：2019/7/25 15:51:52
	功能：添加视图层的系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;
using Entitas.Unity;

namespace InterationExample {

    public class AddViewSystem : ReactiveSystem<GameEntity> {

        private Transform parentTrans; // 父物体
        private Contexts contexts; // 上下文

        public AddViewSystem(Contexts contexts) : base(contexts.game) {
            parentTrans = new GameObject("ViewParent").transform;
            this.contexts = contexts;
        }

        protected override bool Filter(GameEntity entity) {
            return entity.hasInterationExampleSprite && !entity.hasInterationExampleView;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
            return context.CreateCollector(GameMatcher.InterationExampleSprite);
        }

        protected override void Execute(List<GameEntity> entities) {
            foreach (GameEntity entity in entities) {
                // 创建物体
                GameObject go = new GameObject("View");
                go.transform.SetParent(parentTrans); // 将生成的物体放在父物体下
                // 关联到框架
                //go.Link(entity); // Entitas 对 Unity 的拓展方法
                go.Link(entity, contexts.game); // Entitas 对 Unity 的拓展方法
                entity.AddInterationExampleView(go.transform); // 给 GameObject 添加 View 组件
                entity.isInterationExampleMoveComplete = true;
            }
        }
    }
}

