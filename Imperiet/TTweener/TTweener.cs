// Copyright (c) [2023], [Thor]
// All rights reserved
using System;
using System.Collections;
using UnityEngine;

namespace Imperiet.TTweener {
    public class TTweener : MonoBehaviour {
        public IEnumerator DoMove(Transform transformToTween, Vector3 tweenTo, float tweenTime, Action onComplete) {
            float startTime = Time.time;
            float endTime = startTime + tweenTime;
            Vector3 startPosition = transformToTween.position;

            while (Time.time <= endTime) {
                var progress = Mathf.InverseLerp(startTime, endTime, Time.time);
                //Create ease-out lerp
                progress = 1f - Mathf.Pow(1f - progress, 3f);

                transformToTween.position = Vector3.Lerp(startPosition, tweenTo, progress);
                yield return null;
            }
            transformToTween.position = tweenTo;
            onComplete?.Invoke();
        }
    }
}
