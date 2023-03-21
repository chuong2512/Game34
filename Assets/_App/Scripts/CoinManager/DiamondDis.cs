using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class DiamondDis : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    void OnDestroy()
    {
        GameDataManager.Ins.player.onChangeDiamond -= i => OnChangeDiamond(i);
    }

    public TextMeshProUGUI diamondTmp;

    void Start()
    {
        GameDataManager.Ins.player.onChangeDiamond += i => OnChangeDiamond(i);
        diamondTmp.text = $"x{GameDataManager.Ins.player.intBullets}";
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