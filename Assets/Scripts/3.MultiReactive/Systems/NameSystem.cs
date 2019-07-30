/****************************************************
    文件：NameSystem.cs
	作者：CaptainYun
    日期：2019/7/30 10:27:12
	功能：Nothing
*****************************************************/

using Entitas;
using System.Collections;
using System.Collections.Generic;
using MultiReactive;
using UnityEngine;

public class NameSystem : ReactiveSystem<GameEntity> {

    public NameSystem(IContext<GameEntity> context) : base(context) {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        throw new System.NotImplementedException();
    }

    protected override bool Filter(GameEntity entity) {
        throw new System.NotImplementedException();
    }

    protected override void Execute(List<GameEntity> entities) {
    }
}
