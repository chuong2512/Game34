using System;
using UnityEngine;

[Serializable]
public class DataBase : MonoBehaviour {
    protected string pref;

    public virtual void Init() {
        try {
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(pref), this);
        }
        catch (Exception e) {
            ResetData();
            Debug.LogError("Error On Load PlayerPrefs...");
            Debug.LogError("Error : " + e);
			
        }

        CheckAppendData();
    }

    public virtual void ResetData() { }
    
    protected void Save() {
        string json = JsonUtility.ToJson(this);
        // Debug.Log("json_______" + json);
        PlayerPrefs.SetString(pref, json);
    }
    protected virtual void CheckAppendData() { }
    
}
