using System.Collections.Generic;
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

        //根物体
        public Transform root;

        //所有音效
        public List<GameObject> m_soundclips = new List<GameObject>();

        //所有音乐
        public List<SoundData> m_musciclips = new List<SoundData>();

        public List<string> m_loadinglist = new List<string>();

        public List<string> m_assetlist = new List<string>();   

        public float MusicVolume = 1f;
        public float SoundVolume = 1f;

        public void Awake()
        {
            this.root = GlobalComponent.Instance.Pool;
            this.m_soundclips.Clear();
            this.m_musciclips.Clear();
            this.m_loadinglist.Clear();

            this.InitMusicVolume();
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

        public string GetAudioPath(string fileName)
        {
            return $"Assets/Bundles/Audio/{fileName}.mp3";
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
                string assetpath = string.Empty;
                if (musicType == "ogg")
                {
                    assetpath = GetAudioOggPath(clipName);  //ogg
                }
                else 
                {
                    assetpath = GetAudioPath(clipName);     //mp3
                }
               
                audioClip = await ResourcesComponent.Instance.LoadAssetAsync<AudioClip>(assetpath);
                if (gameObject == null)
                {
                    return;
                }
                m_assetlist.Add(assetpath);
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

        /// <summary>
        /// 先释放所有的音效
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="sceneTypeEnum"></param>
        public void PlayBgmSound(int sceneTypeEnum, int sceneId, int sonsceneid)
        {
            DisposeAll();

            string music = "";
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.LoginScene:
                    music = "Login";
                    break;
                case (int)SceneTypeEnum.MainCityScene:
                    music = "MainCity";
                    break;
                case (int)SceneTypeEnum.TeamDungeon:
                case (int)SceneTypeEnum.JiaYuan:
                    music = SceneConfigCategory.Instance.Get(sceneId).Music;
                    break;
                case (int)SceneTypeEnum.CellDungeon:
                    music = ChapterConfigCategory.Instance.Get(sceneId).Music;
                    ChapterSonConfig chapterSonConfig = ChapterSonConfigCategory.Instance.Get(sonsceneid);
                    string[] monsters = chapterSonConfig.CreateMonster.Split('@');

                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (monsters[i] == "0")
                        {
                            continue;
                        }
                        string[] mondels = monsters[i].Split(';');
                        string[] monsterid = mondels[2].Split(',');
                        MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(int.Parse(monsterid[0]));
                        if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss)
                        {
                            music = "Boss";
                            break;
                        }
                    }
                    break;
                default:
                    music = "Fight_1";
                    break;
            }

            if (music != "")
            {
                PlayMusic(music).Coroutine();
            }
        }

        //播放SoundData
        public async ETTask PlayMusic(string clipName, float volume = 0.5f)
        {
            //if(clipName == "MainCity"|| clipName == "MainCity")
            if (!SettingHelper.PlaySound || SoundVolume <= 0f)
            {
                return;
            }


            string assetpath = ABPathHelper.GetSoundPath(clipName);
            m_assetlist.Add(assetpath);
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(assetpath);
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
            m_loadinglist.Clear();

            for (int i = 0; i < m_soundclips.Count; i++)
            {
                GameObject.Destroy(m_soundclips[i]);    
            }
            m_soundclips.Clear();

            for (int i = 0; i < m_musciclips.Count; i++)
            {
                m_musciclips[i].Dispose();
            }
            m_musciclips.Clear();

            for (int i = 0; i < m_assetlist.Count; i++)
            {
                ResourcesComponent.Instance.UnLoadAsset(m_assetlist[i] );
            }
            m_assetlist.Clear();
        }
    }
}