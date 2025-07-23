namespace Douyin.Game
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// The unity thread dispatcher.
    /// </summary>
    [DisallowMultipleComponent]
    internal sealed class SDKInternalUnityDispatcher : MonoBehaviour
    {
        public enum TaskTag
        {
            Other,
            // ...
        }

        private class UnityDispatcherTask
        {
            public readonly Action Action;

            public UnityDispatcherTask(Action action)
            {
                Action = action;
            }
        }
        
        private static SDKInternalUnityDispatcher _instance;

        // The thread safe task queue.
        private static List<UnityDispatcherTask> postTasks = new List<UnityDispatcherTask>();

        // The executing buffer.
        private static List<UnityDispatcherTask> executing = new List<UnityDispatcherTask>();
        
        /// <summary>
        /// Work thread post a task to the main thread.
        /// </summary>
        public static void PostTask(Action action, bool callbackRunOnUnityThread = true)
        {
            if (!callbackRunOnUnityThread)
            {
                action?.Invoke();
                return;
            }

            lock (postTasks)
            {
                CheckInstance();
                var task = new UnityDispatcherTask(action);
                postTasks.Add(task);
            }
        }

        /// <summary>
        /// Start to run this dispatcher.
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        private static void CheckInstance()
        {
            if (_instance == null && Application.isPlaying)
            {
                var go = new GameObject(
                    "UnityDispatcher", typeof(SDKInternalUnityDispatcher));
                DontDestroyOnLoad(go);

                _instance = go.GetComponent<SDKInternalUnityDispatcher>();
            }
        }

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        private void OnDestroy()
        {
            lock (postTasks)
            {
                postTasks.Clear();
            }
            executing.Clear();
            _instance = null;
        }

        private void Update()
        {
            lock (postTasks)
            {
                if (postTasks.Count > 0)
                {
                    foreach (var t in postTasks)
                    {
                        executing.Add(t);
                    }

                    postTasks.Clear();
                }
            }

            foreach (var task in executing)
            {
                try
                {
                    task.Action?.Invoke();
                }
                catch (Exception e)
                {
                    SDKInternalLog.E(e);
                }
            }

            executing.Clear();
        }
    }
}