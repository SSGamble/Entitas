/****************************************************
    文件：GameController.cs
	作者：CaptainYun
    日期：2019/7/30 10:27:55
	功能：Nothing
*****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace MultiReactive {
    public class GameController : MonoBehaviour, ICleanupSystem {
        private Systems _systems;

        public void Cleanup() {
            throw new NotImplementedException();
        }

        void Start() {
            _systems = new Feature("Systems").Add(new MultiFeature(Contexts.sharedInstance));
            _systems.Initialize();
        }

        void Update() {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}
