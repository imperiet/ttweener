// Copyright (c) [2023], [Thor]
// All rights reserved
using System;
using UnityEngine;

namespace Imperiet.TTweener {
    public static class TTweeningHelper {
        private static TTweener instance;
        /// <summary>
        /// Creates a Tweening object that moves the object to the desired position using a Quadratic Ease-Out Function.
        /// </summary>
        /// <param name="transformToTween">The Transform to move</param>
        /// <param name="tweenTo">Target position</param>
        /// <param name="tweenTime">The time that the move should take</param>
        /// <param name="onComplete">Event will be called after move is completed</param> <summary>
        public static void TTWeenPosition(this Transform transformToTween, Vector3 tweenTo, float tweenTime, Action onComplete) {
            if (instance == null) {
                var go = new GameObject("Tweener");
                instance = (TTweener)go.AddComponent(typeof(TTweener));
            }
            instance.StartCoroutine(instance.DoMove(transformToTween, tweenTo, tweenTime, onComplete));
        }
    }
}
