/****************************************************
    文件：Components.cs
	作者：CaptainYun
    日期：2019/7/30 10:11:20
	功能：多上下文公用的组件
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace MultiReactive {
    /// <summary>
    /// 多上下文公用的销毁组件
    /// </summary>
    [Game, Input, UI]
    public class DestroyedComponent : IComponent {

    }

    /// <summary>
    /// 多上下文公用的销毁组件
    /// </summary>
    [Game, Input, UI]
    public class ViewComponent : IComponent {
        public Transform viewTrans;
    }

    [Game, Event(EventTarget.Any)]
    public class NameComponent : IComponent {
        [EntityIndex] // 可用于搜索具有组件值的实体
        public string name;
    }
}

