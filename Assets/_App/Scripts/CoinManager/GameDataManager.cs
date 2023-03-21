using DOChoiAmthanh;
using UnityEngine;
using UnityEngine.Serialization;

[DefaultExecutionOrder(-100)]
public class GameDataManager : PersistentSingleton<GameDataManager>
{
    /*----Scriptable data-----------------------------------------------------------------------------------------------*/

    /*----Data variable-------------------------------------------------------------------------------------------------*/
    [FormerlySerializedAs("playerData")] [HideInInspector] public Player player;
/// <summary>
/// 
/// </summary>
    private void Start()
    {
        Application.targetFrameRate = Mathf.Max(60, Screen.currentResolution.refreshRate);
    }

    public void ResetData()
    {
        player.ResetData();
    }

/// <summary>
/// 
/// </summary>
    private void OnEnable()
    {
        player = new GameObject(Constant.DataKey_PlayerData).AddComponent<Player>();
        player.transform.parent = transform;
        player.Init();
    }

    
}