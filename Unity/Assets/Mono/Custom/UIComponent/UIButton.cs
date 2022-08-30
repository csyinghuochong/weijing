using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIButton : Button
    {
        public static float LastClickTime = 0;
        public bool IsInteractableRejected = false; //交互互斥
        public ButtonClickedEvent OnDown;

        public Vector3 oriScale = Vector3.one;

        public Transform tweenTarget
        {
            get { return _tweenTarget; }
            set { _tweenTarget = value; }
        }

        private Vector3 _scaleClick = new Vector3(1.05f, 1.05f, 1.05f);
        private Vector3 _scaleDown = new Vector3(0.85f, 0.85f, 0.85f);

        private float _scaleTime = 0.12f;
        private bool _hasDown = false;

        [UnityEngine.SerializeField]
        private Transform _tweenTarget;
        private float mDownScaleTime;
        private float mClickScaleTime;
        private float mClickScale2Time;
        private float mReleaseScaleTime;

        protected override void OnDisable()
        {
            base.OnDisable();
            CompleteAll();
        }

        protected override void Start()
        {
            if (tweenTarget == null)
                tweenTarget = transform;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            CompleteAll();
        }

        public void CompleteAll()
        {
            mDownScaleTime = mClickScaleTime = mClickScale2Time = mReleaseScaleTime = 0;
            if (tweenTarget != null)
                tweenTarget.localScale = oriScale;
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            if (!interactable)
                return;

            _hasDown = false;

            mClickScaleTime = _scaleTime;
            mClickScale2Time = _scaleTime;

            mDownScaleTime = 0;
            mReleaseScaleTime = 0;
            if (tweenTarget)
                tweenTarget.localScale = _scaleDown;

            if (IsInteractableRejected)
            {
                if (Time.realtimeSinceStartup - LastClickTime < 2f)
                    return;
                LastClickTime = Time.realtimeSinceStartup;
            }

            base.OnPointerClick(eventData);
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            if (_hasDown)
            {
                mReleaseScaleTime = _scaleTime;
            }

            base.OnPointerExit(eventData);
        }


        public override void OnPointerDown(PointerEventData eventData)
        {
            if (!interactable)
                return;

            _hasDown = true;

            mDownScaleTime = _scaleTime;

            if (OnDown != null)
            {
                OnDown.Invoke();
            }

            base.OnPointerDown(eventData);
        }
    }
}