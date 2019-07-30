/****************************************************
    文件：MultiFeature.cs
	作者：CaptainYun
    日期：2019/7/30 10:28:54
	功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive {
    public class MultiFeature : Feature {
        public MultiFeature(Contexts contexts) {
            Add(new MultDestroySystem(contexts));
            Add(new MultiViewSystem(contexts));
        }
    }
}
