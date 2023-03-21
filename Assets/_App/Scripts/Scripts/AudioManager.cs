using DOChoiAmthanh;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assets.DoChoi.Scripts
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioManager : Singleton<AudioManager>
    {
        /// <summary>
        /// 
        /// </summary>
        [FormerlySerializedAs("_AudioSource")] public AudioSource AudioSource;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clip"></param>
        public void Play(AudioClip clip)
        {
            AudioSource.PlayOneShot(clip);
        }
    }
}