using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //Доступ для скриптов

    public PlayerManager playerManager;
    public AudioManager audioManager;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //объект не уничтожается
        }
        else
        {
            Destroy(gameObject); // если GameManager уже есть, новый уничтожается
        }

        //Автоматом подключаем менеджеров
        if (playerManager == null)
            playerManager = FindAnyObjectByType<PlayerManager>();
        if (audioManager == null)
            audioManager = FindAnyObjectByType<AudioManager>();
    }
    //Выход из игры
    public void QuitGames()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

