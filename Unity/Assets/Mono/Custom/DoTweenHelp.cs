using DG.Tweening;
using UnityEngine;

namespace ET
{
    public static class DoTweenHelp
    {

        public static void DOScale(Transform transform, Vector3 vector3, float time)
        {
            //transform.DOScale(new Vector3(1f, 1f, 1f), time / 2).SetEase(Ease.OutCubic).SetDelay(time / 2);
            transform.DOScale(vector3, time).SetEase(Ease.OutCubic);  //.SetDelay(time / 2);
        }

        public static void DOLocalMove(Transform transform, Vector3 vector3, float time)
        {
            transform.DOLocalMove(vector3, time).SetEase(Ease.OutCubic);
        }
    }
}
