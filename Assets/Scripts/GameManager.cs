using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private AudioSource _spawnSound;

        private void Awake()
        {
            //TODO: What's a better way to implement this singleton?
            //We don't need to check all the objects to make sure we have only one instance.
            
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        }

        public void PlaySpawnSound()
        {
            _spawnSound.Play();
        }
    }
}