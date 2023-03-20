using DOChoiAmthanh;
using UnityEngine;

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
        public AudioSource _AudioSource;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clip"></param>
        public void Play(AudioClip clip)
        {
            _AudioSource.PlayOneShot(clip);
        }
    }
}