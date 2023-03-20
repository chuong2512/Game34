using System;
using UnityEngine;

public class Constant
{
    public static string DataKey_PlayerData = "player_data";
    public static int countSong = 19;
    public static int priceUnlockSong = 1000;
}

public class PlayerData : BaseData
{
    /// <summary>
    /// 
    /// </summary>
    ///
    /// /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool CheckLock(int id)
    {
        return this.listSongs[id];
    }
    public int currentSong;

    public bool[] listSongs;

    public Action<int> onChangeDiamond;


    /// <summary>
    /// 
    /// </summary>
    public int intBullets;

    ///
  
    public override void Init()
    {
        prefString = Constant.DataKey_PlayerData;
        if (PlayerPrefs.GetString(prefString).Equals(""))
        {
            ResetData();
        }

        base.Init();
    }

    /// <summary>
    /// 
    /// </summary>
    public override void ResetData()
    {
        intBullets = 20;
        currentSong = 0;
        listSongs = new bool[Constant.countSong];

        for (int i = 0; i < 8; i++)
        {
            listSongs[i] = true;
        }

        Save();
    }


    public void Unlock(int id)
    {
        if (!listSongs[id])
        {
            listSongs[id] = true;
        }

        Save();
    }/// <summary>
     /// 
     /// </summary>
     /// <returns></returns>
    public bool CheckCanUnlock()
    {
        return intBullets >= Constant.priceUnlockSong;
    }
/// <summary>
/// 
/// </summary>
/// <param name="a"></param>
    public void SubDiamond(int a)
    {
        intBullets -= a;

        if (intBullets < 0)
        {
            intBullets = 0;
        }

        onChangeDiamond?.Invoke(intBullets);

        Save();
    }/// <summary>
     /// 
     /// </summary>
     /// <param name="a"></param>
    public void AddDiamond(int a)
    {
        intBullets += a;

        onChangeDiamond?.Invoke(intBullets);

        Save();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"></param>
    public void ChooseSong(int i)
    {
        currentSong = i;
        Save();
    }


}