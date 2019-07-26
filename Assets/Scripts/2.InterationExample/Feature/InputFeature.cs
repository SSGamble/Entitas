/****************************************************
    文件：InputFeature.cs
	作者：CaptainYun
    日期：2019/7/25 17:1:40
	功能：Nothing
*****************************************************/

using UnityEngine;
using Entitas;

namespace InterationExample {
    public class InputFeature : Feature {
        public InputFeature(Contexts contexts) {
            Add(new MouseSystem(contexts));
            Add(new CreaterSystem(contexts));
            Add(new StartMoveSystem(contexts));
        }
    }
}