using System;

namespace Douyin.Game
{
    public class MultipleClickDelegate
    {
        private long mDuration;
        private int mCount;
        private long[] mHits;
        private Action mAction;

        public MultipleClickDelegate(long mDuration, int mCount, Action action)
        {
            if (mCount <= 0)
            {
                throw new ArgumentException("count must > 0");
            }

            if (mDuration <= 0)
            {
                throw new ArgumentException("duration must > 0");
            }

            if (action == null)
            {
                throw new ArgumentException("action must not null");
            }

            this.mDuration = mDuration;
            this.mCount = mCount;
            this.mAction = action;
            this.mHits = new long[mCount];
        }

        public void OnClick()
        {
            Array.Copy(this.mHits, 1, this.mHits, 0, mHits.Length - 1);
            this.mHits[this.mHits.Length - 1] = TimeUtil.GetTimeStampLong();
            if (this.mHits[0] >= TimeUtil.GetTimeStampLong() - this.mDuration)
            {
                this.mAction.Invoke();
                this.ResetHints();
            }
        }

        private void ResetHints()
        {
            for (int i = 0; i < this.mHits.Length; i++)
            {
                this.mHits[i] = 0;
            }
        }
    }
}