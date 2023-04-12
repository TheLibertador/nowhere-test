using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject _ballPrefab;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpawnBallAtMouseAndGiveName(Input.mousePosition, "Ball");
            }
            else if (Input.GetMouseButtonDown(1))
            {
                //TODO: Spawn a ball named "AutoBall" every 3 seconds at clicked position
            }
        }

        private void SpawnBallAtMouseAndGiveName(Vector3 mousePosition, string name)
        {
            //TODO: Spawn an enemy at the position of the mouse click and play spawn sound
        }

        private Ball InstantiateBall(Vector3 position)
        {
            GameObject ballGameObject = Instantiate(_ballPrefab, position, Quaternion.identity);
            Ball ball = ballGameObject.GetComponent<Ball>(); //TODO: What's a better way to do this?
            ball.SetName(name);
            return ball;
        }
    }
}