using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private AudioSource _spawnSound;

    private void Awake()
    {
        //TODO: What's a better way to implement this singleton?
        var gameManagers = FindObjectsOfType<GameManager>();

        if (gameManagers.Length > 1)
        {
            Destroy(gameObject);
        }
        else if (gameManagers.Length == 0)
        {
            Debug.LogError("No GameManager found in scene. Please add one to the scene.");
        }
        else
        {
            Instance = gameManagers[0];
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlaySpawnSound()
    {
        _spawnSound.Play();
    }
}