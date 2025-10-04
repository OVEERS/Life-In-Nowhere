using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //������ ��� ��������

    public PlayerManager playerManager;
    public AudioManager audioManager;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //������ �� ������������
        }
        else
        {
            Destroy(gameObject); // ���� GameManager ��� ����, ����� ������������
        }

        //��������� ���������� ����������
        if (playerManager == null)
            playerManager = FindAnyObjectByType<PlayerManager>();
        if (audioManager == null)
            audioManager = FindAnyObjectByType<AudioManager>();
    }
    //����� �� ����
    public void QuitGames()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

