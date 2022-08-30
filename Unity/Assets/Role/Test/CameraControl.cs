using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

//相机移动相关__待改进
public enum CaremaMoveType
{
    None,
    StoryBegin,     //剧情开始
    StoryEnd,       //剧情结束
    ArenaView,      //竞技场镜头
    DungeonOver,    //副本结束时镜头跳转
}

class CATask
{
    /// <summary>
    /// 执行当时的回调
    /// </summary>
    public Action playback;
    /// <summary>
    /// 执行完毕的回调
    /// </summary>
    public Action callback;
    public string state;
}

class CameraControl : MonoBehaviour
{
    // Use this for initialization
    [SerializeField] public Transform followTarget;

    public Vector3 offset = new Vector3(-15f, 20f, 20f);
    public Vector3 lookOffset = new Vector3(0, 0.5f, 0.3f);
    private bool mSetPosition;
    private Vector3 mTargetPos;
    private float mSpeed = 35f;

    private Vector3 m_targetpos;

    private Action mMovePositionCallback = null;
    private CaremaMoveType mMoveType = CaremaMoveType.None;
    Camera mCamera;
    Transform mTransform;

    bool mLookAtTarget = true;
    bool mDragCamera = false;

    /// <summary>
    /// 手指拖动屏幕查看其它地方的战况
    /// </summary>
    private float mTestMoveSpeed = 0.05f;
    //死亡时的焦点
    private Vector3? mLookAtPoint = null;

    const string cCamera = "Camera";
    const string cCameraShake = "CameraShake";
    const string cCameraAnimation = "CameraAnimation";
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            this.mTestMoveSpeed = 0.2f;
        }

        if (mCamera == null)
            mCamera = gameObject.GetComponent<Camera>();
        mTransform = this.transform;
    }

    public void SetFieldOfView(float value)
    {
        if (mCamera == null)
        {
            mCamera = gameObject.GetComponent<Camera>();
        }

        mCamera.fieldOfView = value;
        offset = new Vector3(10.93f, 9.9f, -2.1f);
    }


    public void SetActor(Transform actor)
    {
        this.followTarget = actor;
    }


    void Update()
    {
       
    }
    void LateUpdate()
    {
        if (this.followTarget)
        {
            Vector3 position = this.followTarget.position + offset;
            mTransform.position = position;
            if (mLookAtTarget)
            {
                mTransform.LookAt(this.followTarget.position + this.lookOffset);
            }
        }
    }


}