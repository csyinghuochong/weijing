using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class SoundComponentAwakeSystem : AwakeSystem<SoundComponent>
    {
        public override void Awake(SoundComponent self)
        {
            self.Awake();
        }
    }

    [ObjectSystem]
    public class SoundComponentDestroySystem : DestroySystem<SoundComponent>
    {
        public override void Destroy(SoundComponent self)
        {
            self.DisposeAll();
        }
    }

    /// <summary>
    /// 游戏音效管理组件
    /// </summary>
    public class SoundComponent : Entity, IAwake, IDestroy
    {

        //所有音效
        public List<GameObject> m_soundclips = new List<GameObject>();

        //所有音乐
        public List<SoundData> m_musciclips = new List<SoundData>();

        //根物体
        public Transform root;

        public float MusicVolume = 1f;
        public float SoundVolume = 1f;

        public void Awake()
        {
            root = new GameObject("SoundDatas").transform;
            GameObject.DontDestroyOnLoad(root.gameObject);
        }

        public  void InitData(List<KeyValuePair> gameSettingInfos) 
        {
            for (int i = 0; i < gameSettingInfos.Count; i++)
            {
                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.MusicVolume)
                {
                    MusicVolume = float.Parse(gameSettingInfos[i].Value);
                }
                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.SoundVolume)
                {
                    SoundVolume = float.Parse(gameSettingInfos[i].Value);
                }
            }
        }

        /// <summary>
        /// 短暂的声音和特效
        /// 无法暂停
        /// 异步加载音效
        /// </summary>
        public async ETTask PlayClip(string clipName, float volume = 0.5f)
        {
            GameObject gameObject = null;
            for (int i = 0; i < m_soundclips.Count; i++)
            {
                if (m_soundclips[i].name == clipName && !m_soundclips[i].GetComponent<AudioSource>().isPlaying)
                {
                    gameObject = m_soundclips[i];
                    break;
                }
            }

            if (gameObject == null)
            {
                gameObject = new GameObject(clipName);
                await ETTask.CompletedTask;
                AudioClip audioClip = ResourcesComponent.Instance.LoadAsset<AudioClip>(ABPathHelper.GetAudioPath(clipName));
                AudioSource audio = gameObject.AddComponent<AudioSource>();
                gameObject.transform.SetParent(root);
                m_soundclips.Add(gameObject);
                audio.clip = audioClip;
            }

            gameObject.GetComponent<AudioSource>().volume = volume * SoundVolume;
            gameObject.GetComponent<AudioSource>().Play();
        }

        public void ChangeMusicVolume(float volume)
        {
            MusicVolume = volume;
            SoundVolume = volume;

            for (int i = 0; i < m_musciclips.Count; i++)
            {
                m_musciclips[i].audio.volume = volume;
            }
        }

        //播放SoundData
        public async ETTask PlayMusic(string clipName, float volume = 0.5f)
        {
            //if(clipName == "MainCity"|| clipName == "MainCity")

            for (int i = 0; i < m_musciclips.Count; i++)
            {
                m_musciclips[i].Dispose();
            }
            m_musciclips.Clear();
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetSoundPath(clipName));
            GameObject prefab = UnityEngine.Object.Instantiate(bundleGameObject);
            SoundData soundData = prefab.GetComponent<SoundData>();
            prefab.transform.SetParent(root);

            m_musciclips.Add(soundData);
            soundData.audio.volume = volume * MusicVolume; 
            soundData.audio.loop = true;
            soundData.audio.Play();
        }

        /// <summary>
        /// 停止并销毁音乐
        /// </summary>
        /// <param name="clipName"></param>
        public void Stop(string clipName)
        {

        }
        /// <summary>
        /// 销毁所有声音
        /// </summary>
        public void DisposeAll()
        {
            
        }
    }
}