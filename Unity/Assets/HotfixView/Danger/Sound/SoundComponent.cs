using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ET
{

    public class SoundComponentAwakeSystem : AwakeSystem<SoundComponent>
    {
        public override void Awake(SoundComponent self)
        {
            self.Awake();
        }
    }


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

        public List<string> m_loadinglist = new List<string>();

        //根物体
        public Transform root;

        public float MusicVolume = 1f;
        public float SoundVolume = 1f;

        public void Awake()
        {
            this.root = GlobalComponent.Instance.Pool;
            this.m_soundclips.Clear();
            this.m_musciclips.Clear();
            this.m_loadinglist.Clear();
        }

        public void InitMusicVolume()
        {
            string music = PlayerPrefsHelp.GetString(PlayerPrefsHelp.MusicVolume);
            string sound = PlayerPrefsHelp.GetString(PlayerPrefsHelp.SoundVolume);
            if (string.IsNullOrEmpty(music))
            {
                this.MusicVolume = 1f;
            }
            else
            {
                this.MusicVolume = float.Parse(music);
            }

            if (string.IsNullOrEmpty(sound))
            {
                this.SoundVolume = 1f;
            }
            else
            {
                this.SoundVolume = float.Parse(sound);
            }
        }

        public string GetAudioOggPath(string fileName)
        {
            return $"Assets/Bundles/Audio/{fileName}.ogg";
        }

        /// <summary>
        /// 短暂的声音和特效
        /// 无法暂停
        /// 异步加载音效
        /// </summary>
        public async ETTask PlayClip(string clipName,string musicType, float volume = 0.5f)
        {
            if (!SettingHelper.PlaySound || SoundVolume <= 0f)
            {
                return;
            }

            GameObject gameObject = null;
            for (int i = 0; i < m_soundclips.Count; i++)
            {
                if (m_soundclips[i].name != clipName)
                {
                    continue;
                }
                bool isplaying = m_soundclips[i].GetComponent<AudioSource>().isPlaying;
                if (isplaying)
                {
                    return;
                }
                else
                {
                    gameObject = m_soundclips[i];
                    break;
                }
            }

            if (gameObject != null)
            {
                gameObject.GetComponent<AudioSource>().volume = volume * SoundVolume;
                gameObject.GetComponent<AudioSource>().Play();
                return;
            }

            if (!m_loadinglist.Contains(clipName))
            {
                m_loadinglist.Add(clipName);
                gameObject = new GameObject(clipName);
                AudioClip audioClip;

                if (musicType == "ogg")
                {
                    audioClip = await ResourcesComponent.Instance.LoadAssetAsync<AudioClip>(GetAudioOggPath(clipName));
                }
                else 
                {
                    //mp3
                    audioClip = await ResourcesComponent.Instance.LoadAssetAsync<AudioClip>(ABPathHelper.GetAudioPath(clipName));
                }
                m_loadinglist.Remove(clipName);
                AudioSource audio = gameObject.AddComponent<AudioSource>();
                gameObject.transform.SetParent(root);
                m_soundclips.Add(gameObject);
                audio.clip = audioClip;
                gameObject.GetComponent<AudioSource>().volume = volume * SoundVolume;
                gameObject.GetComponent<AudioSource>().Play();
            }
        }

        /// <summary>
        /// 背景音效
        /// </summary>
        /// <param name="volume"></param>
        public void ChangeSoundVolume(float volume)
        {
            this.SoundVolume = volume;
            for (int i = 0; i < this.m_soundclips.Count; i++)
            {
                this.m_soundclips[i].GetComponent<AudioSource>().volume = volume;
            }
            PlayerPrefsHelp.SetString(PlayerPrefsHelp.SoundVolume, volume.ToString());
        }

        /// <summary>
        /// 音乐
        /// </summary>
        /// <param name="volume"></param>
        public void ChangeMusicVolume(float volume)
        {
            this.MusicVolume = volume;
            for (int i = 0; i < m_musciclips.Count; i++)
            {
                this.m_musciclips[i].audio.volume = volume;
            }
            PlayerPrefsHelp.SetString(PlayerPrefsHelp.MusicVolume, volume.ToString());
        }

        //播放SoundData
        public async ETTask PlayMusic(string clipName, float volume = 0.5f)
        {
            //if(clipName == "MainCity"|| clipName == "MainCity")
            if (!SettingHelper.PlaySound || SoundVolume <= 0f)
            {
                return;
            }

            for (int i = 0; i < m_musciclips.Count; i++)
            {
                m_musciclips[i].Dispose();
            }
            m_musciclips.Clear();
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(ABPathHelper.GetSoundPath(clipName));
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
            m_soundclips.Clear();
            m_musciclips.Clear();
            m_loadinglist.Clear();
        }
    }
}