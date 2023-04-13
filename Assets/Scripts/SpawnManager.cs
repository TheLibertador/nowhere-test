using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject _ballPrefab;

        private List<Ball> _balls = new List<Ball>();
        //private List<Ball> _ballsToRemove = new List<Ball>();

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpawnBallAtMouseAndGiveName(Input.mousePosition, "Colored Ball");
            }
            else if (Input.GetMouseButtonDown(1))
            {
                //TODO: This should remove all red balls, right?
                
                //We can't use only one foreach because in that situation we are trying to remove an item from the list 
                //while we are iterating over it. This gives an error. Instead of we can create another list and use two
                //foreach loops or we can use only one for loop. I choose using one for loop because it is more
                //efficient.

                
                for (int i = _balls.Count - 1; i >= 0; i--)
                {
                    if (_balls[i].Color == Color.red)
                    {
                        RemoveBall(_balls[i]);
                    }
                }
                
                /*
                other solution:
                 
                foreach (var ball in _balls)
                { 
                    if (ball.Color == Color.red)
                    {
                        _ballsToRemove.Add(ball);
                        //break;
                    }
                }

                foreach (var ball in _ballsToRemove)
                {
                    RemoveBall(ball);
                }*/
                
            }
        }

        public void RemoveBall(Ball ball)
        {
            //TODO: Implement a way to remove a ball from the scene and the list.
            _balls.Remove(ball);
            Destroy(ball.gameObject);
        }

        private void SpawnBallAtMouseAndGiveName(Vector3 mousePosition, string name)
        {
            //TODO: Spawn a random color of ball at the position of the mouse click and play spawn sound.
            //OPTIONAL: Use events for playing sounds.
            InstantiateBall(AdjustedInputToWorldPosition(mousePosition), name);
            EventsManager.Instance.BallGenerated();
        }

        private Ball InstantiateBall(Vector3 position, string name)
        { 
            //TODO: What's a better way to do this?
            //There is no need for gameObject declaration. We just need to use the ball component of the objects.
            
            Ball ball = Instantiate(_ballPrefab, position, Quaternion.identity).GetComponent<Ball>();
            ball.SetName(name);
            ball.SetColor();
            _balls.Add(ball);
            return ball;
        }

        private Vector3 AdjustedInputToWorldPosition(Vector3 position)
        {
            position = Camera.main.ScreenToWorldPoint(position);
            position.z = 0f;

            return position;
        }
    }
}