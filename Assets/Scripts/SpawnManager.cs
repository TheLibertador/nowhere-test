using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject _ballPrefab;

        private List<Ball> _balls;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpawnBallAtMouseAndGiveName(Input.mousePosition, "Colored Ball");
            }
            else if (Input.GetMouseButtonDown(1))
            {
                //TODO: This should remove all red balls, right?
                foreach (var ball in _balls)
                {
                    if (ball.Color == Color.red)
                    {
                        RemoveBall(ball);
                        break;
                    }
                }
            }
        }

        public void RemoveBall(Ball ball)
        {
            //TODO: Implement a way to remove a ball from the scene and the list.
        }

        private void SpawnBallAtMouseAndGiveName(Vector3 mousePosition, string name)
        {
            //TODO: Spawn a random color of ball at the position of the mouse click and play spawn sound.
            //OPTIONAL: Use events for playing sounds.
        }

        private Ball InstantiateBall(Vector3 position)
        {
            GameObject ballGameObject = Instantiate(_ballPrefab, position, Quaternion.identity);
            Ball ball = ballGameObject.GetComponent<Ball>(); //TODO: What's a better way to do this?
            ball.SetName(name);
            _balls.Add(ball);
            return ball;
        }
    }
}