/****************************************************
    文件：MultDestroySystem.cs
	作者：CaptainYun
    日期：2019/7/30 10:15:18
	功能：多上下文反应系统
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using Entitas;
using MultiReactive;
using UnityEngine;

namespace MultiReactive {
    /// <summary>
    /// 多上下文销毁反应系统
    /// </summary>
    public class MultDestroySystem : MultiReactiveSystem<IDestroySystem, Contexts> {
        public MultDestroySystem(Contexts contexts) : base(contexts) {
        }

        protected override ICollector[] GetTrigger(Contexts contexts) {
            return new ICollector[]
            {
                contexts.game.CreateCollector(GameMatcher.MultiReactiveDestroyed),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveDestroyed),
                contexts.uI.CreateCollector(UIMatcher.MultiReactiveDestroyed)
            };
        }

        protected override bool Filter(IDestroySystem entity) {
            return entity.isMultiReactiveDestroyed;
        }

        protected override void Execute(List<IDestroySystem> entities) {
            foreach (IDestroySystem entity in entities) {
                //if (entity.hasMultiReactiveView)
                //{
                //    Object.Destroy(entity.multiReactiveView.viewTrans.gameObject);
                //}
                Debug.Log("在" + entity.contextInfo.name + "上下文中销毁");
            }
        }
    }

    public interface IDestroySystem : IEntity, IMultiReactiveDestroyedEntity, IMultiReactiveViewEntity { }


}

public partial class GameEntity : IDestroySystem { }
public partial class InputEntity : IDestroySystem { }
public partial class UIEntity : IDestroySystem { }

