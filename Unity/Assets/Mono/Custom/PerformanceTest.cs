using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;

namespace ET
{
    public class GPUPerformanceTest : MonoBehaviour
    {
        public Camera Camera;
        public Material Material;
        public Mesh Mesh;

        RenderTexture texture;

        float startTestTime;
        int sampleCounter;
        int skipCounter;
        public int skipSample = 1; // 丢弃采样，第一次渲染可能涉及shader编译，会影响统计数据
        public int maximumSampleCounter = 5;
        public int DrawTimesPerBatch = 100;
        public int BatchCountPerFrame = 1;
        public int FrameTimeMS = 10;
        public int DelayFramePerTest = 5;

        public float ScoreScale = 1;
        public float ScoreAdjust = 0;

        //public int MaximumDrawCount = 5000;

        long elapsedMS;

        [HideInInspector]
        public float TestScore = 0;// 性能测试评分

        private int _TotalDrawTimes = 0;
        private long _TotalDrawMilliseconds = 0;

        int delayFrameCounter;

        public bool RunOnStart = true;

        public Action OnComplete;

        enum TestState
        {
            Waiting,
            Tasting,
            Delaying,
            Completed,
            Freeze,
        }

        TestState State;

        private void Awake()
        {
            State = TestState.Waiting;
        }

        private void Start()
        {
            if (RunOnStart)
            {
                StartTest();
            }
        }

        public void StartTest()
        {
            sampleCounter = 0;
            skipCounter = 0;
            delayFrameCounter = 0;
            startTestTime = Time.realtimeSinceStartup;

            if (!this.gameObject.activeSelf)
            {
                this.gameObject.SetActive(true);
            }

            State = TestState.Tasting;
            Log.Info("Performance test begin-------------");
        }

        private void OnEnable()
        {
            //texture = RenderTexture.GetTemporary(Camera.pixelWidth, Camera.pixelHeight, 0, UnityEngine.Experimental.Rendering.GraphicsFormat.R16G16B16A16_SFloat);

            RenderPipelineManager.endCameraRendering += RenderPipelineManager_endCameraRendering;

        }
        void TestDrawMesh()
        {
            long milliseconds = 0;
            int draw_times = 0;

            var stopwatch = Stopwatch.StartNew();
            for (int n = 0; n < BatchCountPerFrame; ++n)
            {
                {

                    for (int i = 0; i < DrawTimesPerBatch; ++i)
                    {
                        CommandBuffer commandBuffer = new CommandBuffer();

                        Vector3 look = this.Camera.transform.TransformDirection(Vector3.forward);
                        Vector3 pos = this.Camera.transform.position + look.normalized * 10;
                        RenderTargetIdentifier targetIdentifier = new RenderTargetIdentifier(texture);
                        commandBuffer.DrawMesh(Mesh, Matrix4x4.TRS(pos, Quaternion.identity, Vector3.one), Material);

                        Graphics.ExecuteCommandBuffer(commandBuffer);

                        draw_times++;
                    }
                }

                if (stopwatch.ElapsedMilliseconds > FrameTimeMS)
                {
                    break;
                }

                //             if (_TotalDrawTimes >= MaximumDrawCount)
                //             {
                //                 break;
                //             }
            }
            stopwatch.Stop();

            milliseconds = stopwatch.ElapsedMilliseconds;

            _TotalDrawTimes += draw_times;
            _TotalDrawMilliseconds += milliseconds;
        }
        private void RenderPipelineManager_endCameraRendering(ScriptableRenderContext arg1, Camera arg2)
        {
            if (State != TestState.Tasting)
                return;

            TestDrawMesh();

            sampleCounter++;

            if (skipCounter < skipSample)
            {
                skipCounter++;

                sampleCounter = 0;
                _TotalDrawTimes = 0;
                _TotalDrawMilliseconds = 0;
            }

            if (sampleCounter >= maximumSampleCounter)
            //if (_TotalDrawTimes >= MaximumDrawCount)
            {
                State = TestState.Completed;
            }
            else
            {
                delayFrameCounter = 0;
                State = TestState.Delaying;
            }
        }

        private void Update()
        {
            switch (State)
            {
                case TestState.Delaying:
                    {
                        if (delayFrameCounter >= DelayFramePerTest)
                        {
                            State = TestState.Tasting;
                        }
                        delayFrameCounter++;
                    }
                    break;
                case TestState.Completed:
                    {
                        TestScore = 1.0f * _TotalDrawTimes / Mathf.Max(1, _TotalDrawMilliseconds);
                        TestScore = TestScore * ScoreScale + ScoreAdjust;

                        Log.Info($"Performance test draw mesh time(MS): {_TotalDrawMilliseconds}, draw times: {_TotalDrawTimes}, score: {TestScore}. ({Time.realtimeSinceStartup - startTestTime}s");

                        State = TestState.Freeze;

                        OnComplete?.Invoke();
                    }
                    break;
                case TestState.Freeze:
                    {
                        this.gameObject.SetActive(false);
                    }
                    break;
            }
        }
        private void OnDisable()
        {
            RenderPipelineManager.endCameraRendering -= RenderPipelineManager_endCameraRendering;

            //RenderTexture.ReleaseTemporary(texture);
        }
    }
}

