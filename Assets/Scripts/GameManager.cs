using UnityEngine;

namespace Assets.Scripts.Managers
{
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
            else
            {
                Instance = gameManagers[0];
            }
        }

        public void PlaySpawnSound()
        {
            _spawnSound.Play();
        }
    }
}