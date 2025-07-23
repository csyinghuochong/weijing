using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

namespace Douyin.Game
{
    // Unity中线程的工具类
    // 注意：！！！ android中的主线程和unity的主线程不是同一个线程，比如Resource.load 必须要放在unity自己的线程中执行...
    public class UnitThreadUtil : MonoBehaviour
    {
        private const int MaxThreads = 8;
        private static int numThreads;

        private static UnitThreadUtil _current;
        private int _count;

        public static UnitThreadUtil Current
        {
            get
            {
                Initialize();
                return _current;
            }
        }

        private void Awake()
        {
            _current = this;
            initialized = true;
        }

        private static bool initialized;

        private static void Initialize()
        {
            if (!initialized)
            {
                if (!Application.isPlaying)
                {
                    return;
                }

                initialized = true;
                var g = new GameObject("UnitThreadUtil");
                _current = g.AddComponent<UnitThreadUtil>();
            }
        }

        private List<Action> _actions = new List<Action>();

        private struct DelayedQueueItem
        {
            public float time;
            public Action action;
        }

        private List<DelayedQueueItem> _delayed = new List<DelayedQueueItem>();

        private List<DelayedQueueItem> _currentDelayed = new List<DelayedQueueItem>();

        public static void QueueOnMainThread(Action action, float time = 0f)
        {
            if (time != 0)
            {
                lock (Current._delayed)
                {
                    Current._delayed.Add(new DelayedQueueItem {time = Time.time + time, action = action});
                }
            }
            else
            {
                lock (Current._actions)
                {
                    Current._actions.Add(action);
                }
            }
        }

        public static Thread RunAsync(Action a)
        {
            Initialize();
            while (numThreads >= MaxThreads)
            {
                Thread.Sleep(1);
            }

            Interlocked.Increment(ref numThreads);
            ThreadPool.QueueUserWorkItem(RunAction, a);
            return null;
        }

        private static void RunAction(object action)
        {
            try
            {
                ((Action) action)();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            finally
            {
                Interlocked.Decrement(ref numThreads);
            }
        }


        private void OnDisable()
        {
            if (_current == this)
            {
                _current = null;
            }
        }


        private List<Action> _currentActions = new List<Action>();

        // Update is called once per frame
        private void Update()
        {
            lock (this._actions)
            {
                this._currentActions.Clear();
                this._currentActions.AddRange(this._actions);
                this._actions.Clear();
            }

            foreach (var a in this._currentActions)
            {
                a();
            }

            lock (this._delayed)
            {
                this._currentDelayed.Clear();
                this._currentDelayed.AddRange(this._delayed.Where(d => d.time <= Time.time));
                foreach (var item in this._currentDelayed)
                {
                    this._delayed.Remove(item);
                }
            }

            foreach (var delayed in this._currentDelayed)
            {
                delayed.action();
            }
        }
    }
}