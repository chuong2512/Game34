using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class DiamondDisplay : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    void OnDestroy()
    {
        GameDataManager.Instance.playerData.onChangeDiamond -= i => OnChangeDiamond(i);
    }

    public TextMeshProUGUI diamondTmp;

    void Start()
    {
        GameDataManager.Instance.playerData.onChangeDiamond += i => OnChangeDiamond(i);
        diamondTmp.text = $"x{GameDataManager.Instance.playerData.intBullets}";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"></param>
    private void OnChangeDiamond(int i)
    {
        diamondTmp.text = $"x{i}";
    }

    void OnValidated()
    {
        diamondTmp = GetComponent<TextMeshProUGUI>();
    }
}