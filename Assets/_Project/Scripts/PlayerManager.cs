using UnityEngine;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public int health = 100;
    public int stamina = 100;

    public List<string> inventory = new List<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UseStamina(int amout)
    {
        stamina -= amout;
        stamina = Mathf.Clamp(stamina, 0, 100);
        Debug.Log("Player Stamina: " + stamina);
    }

    public void AddItem(string itemName)
    {
        inventory.Add(itemName);
        Debug.Log(itemName + " added to inventory.");
    }
}
