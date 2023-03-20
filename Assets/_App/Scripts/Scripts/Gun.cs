using System.Collections;
using System.Collections.Generic;
using Assets.DoChoi.Scripts;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject spark;

    /// <summary>
    /// 
    /// </summary>
    public AudioClip _amThanh;

    /// <summary>
    /// 
    /// </summary>
    public float timeShot = 1;

    /// <summary>
    /// 
    /// </summary>
    private float _counter;


    /// <summary>
    /// //
    /// </summary>
    private WaitForSeconds _seconds = new WaitForSeconds(0.01f);

    /// <summary>
    /// 
    /// </summary>
    private void Shot()
    {
        if (gameObject.activeSelf)
        {
            if (_counter < 0)
            {
                if (GameDataManager.Instance.playerData.intBullets > 0)
                {
                    Debug.Log("------------------Shotttttttttttttttttttttt");

                    StartCoroutine(ShowSpark());

                    _counter = timeShot;

                    GameDataManager.Instance.playerData.SubDiamond(1);
                    AudioManager.Instance.Play(_amThanh);
                }
            }
        }

        IEnumerator ShowSpark()
        {
            spark?.SetActive(true);
            yield return _seconds;
            spark?.SetActive(false);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        _counter = 0;
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

        _counter -= Time.deltaTime;
    }
}