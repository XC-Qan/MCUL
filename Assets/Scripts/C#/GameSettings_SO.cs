using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerType {OnlineMode,MicrosoftAccount,OfflineMode}
public enum ModType {Forge,Fabric,Liteloader}
[CreateAssetMenu(menuName = "MCUL/Game Setting")]
public class GameSettings_SO : ScriptableObject
{
    [Header("基本属性")]
    public string GameVersion;
    public string GameDir;
    public string AssetsDir;
    public int GameIndex;
    public List<string> Libraries = new List<string>();
    public PlayerType AccountType;
    public string GameTitle;
    public string Info;
    public string Username;

    [Header("额外设定")] 
    public bool HasMods;
    public ModType ModLoader;
    public List<string> ModsDir = new List<string>();
}
