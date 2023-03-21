using System.Collections;
using System.Collections.Generic;
using Assets.DoChoi.Scripts;
using UnityEngine;
using UnityEngine.Serialization;

public class TheGun : MonoBehaviour
{
    public GameObject sparks;

    /// <summary>
    /// 
    /// </summary>
    public AudioClip voice;

    /// <summary>
    /// 
    /// </summary>
    public float timeShot = 1;

    /// <summary>
    /// 
    /// </summary>
    private float _countDown;


    /// <summary>
    /// //
    /// </summary>
    private WaitForSeconds _seconds = new WaitForSeconds(0.01f);
    
    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        _countDown = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    // Update is called once per frame
    public void StopShot()
    {
        if (gameObject.activeSelf)
        {
            Debug.Log("-----------------------Stop Shotttttttttttttttttttttt");
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shot();
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            StopShot();
        }

        _countDown -= Time.deltaTime;
    }

    /// <summary>
    /// 
    /// </summary>
    private void Shot()
    {
        if (gameObject.activeSelf)
        {
            if (_countDown < 0)
            {
                if (GameDataManager.Ins.player.intBullets > 0)
                {
                    Debug.Log("------------------Shotttttttttttttttttttttt");

                    StartCoroutine(ShowSpark());

                    _countDown = timeShot;

                    GameDataManager.Ins.player.SubToy(1);
                    AudioManager.Instance.Play(voice);
                }
            }
        }

        IEnumerator ShowSpark()
        {
            sparks?.SetActive(true);
            yield return _seconds;
            sparks?.SetActive(false);
        }
    }

    

    
}