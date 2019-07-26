/****************************************************
    文件：RenderSpriteSystem.cs
	作者：CaptainYun
    日期：2019/7/25 16:11:31
	功能：添加图片
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;

namespace InterationExample {
    public class RenderSpriteSystem : ReactiveSystem<GameEntity> {
        public RenderSpriteSystem(Contexts contexts) : base(contexts.game) {

        }

        protected override bool Filter(GameEntity entity) {
            return entity.hasInterationExampleSprite && entity.hasInterationExampleView;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
            return context.CreateCollector(GameMatcher.InterationExampleSprite);
        }

        protected override void Execute(List<GameEntity> entities) {
            foreach (GameEntity entity in entities) {
                Transform trans = entity.interationExampleView.viewTrans;
                SpriteRenderer sr = trans.GetComponent<SpriteRenderer>();
                if (sr == null) {
                    sr = trans.gameObject.AddComponent<SpriteRenderer>();
                }
                sr.sprite = Resources.Load<Sprite>(entity.interationExampleSprite.spriteName);
            }
        }
    }
}
