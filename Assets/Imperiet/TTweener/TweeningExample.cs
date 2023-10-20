// Copyright (c) [2023], [Thor]
// All rights reserved
using UnityEngine;

namespace Imperiet.TTweener {
    public class TweeningExample : MonoBehaviour {
        [ContextMenu("Tween")]
        public void Tween() {
            transform.TTWeenPosition(new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f)), 2f, () => { Debug.Log("Done!"); });
        }
    }
}
