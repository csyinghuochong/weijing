using ET;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class EffectDelayPlay : MonoBehaviour
    {
        /*
        public EffectDelayPlay(ILMonoBehaviour clrInstance) : base(clrInstance)
        {

        }
        */

        [SerializeField] private GameObject PlayEffectObj;
        [SerializeField] private float DelayTime;
        private float delayTimeSum;
        private bool ifPlayStatus;

        public void Awake() {

        }

        public void Start()
        {

        }

        public void Update()
        {
            if (ifPlayStatus == false)
            {
                //Log.Debug("delayTimeSum = " + delayTimeSum);
                delayTimeSum = delayTimeSum + Time.deltaTime;
                if (delayTimeSum >= DelayTime)
                {
                    ifPlayStatus = true;
                    PlayEffectObj.SetActive(true);
                }
            }
        }
    }
}