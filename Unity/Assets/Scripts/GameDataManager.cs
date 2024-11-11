using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

[System.Serializable]

public class Player
{
    public int player_id;
    public string username;
    public int level;    
}
[System.Serializable]
public class InventoryItem
{
    public int item_id;
    public string name;
    public string description;
    public int value;
    public int quantity;
}
[System.Serializable]
public class Quest
{
    public int quest_id;
    public string title;
    public string description;
    public int rewaed_exp;
    public int rewaed_item_id;
    public string status;
}


public class GameDataManager : MonoBehaviour
{

    private string serverUrl = "http://localhost:3000";
    private Player currentPlayer;

    //데이터리스트
    public List<InventoryItem> inventoryItems = new List<InventoryItem>();
    public List<Quest>playerQuests=new List<Quest>();

    //로그린 성공 시 실행될 이벤트
    //OnLoginSuccessHandler

    //데이터 업데이트시 실행될 이벤트
    //ONInventoryUpdateHandler
    //OnQuestsUpdatehandler


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
