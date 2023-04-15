using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Ball : MonoBehaviour
    {
        public Color Color 
        { 
            get => _spriteRenderer.color;
            set => _spriteRenderer.color = value;
        }
        protected SpriteRenderer _spriteRenderer;

        [SerializeField] private BallColorData _ballColorData;

        //TODO: Implement 2 types of balls which has red and blue colors.
        //OPTIONAL: Think outside the box.
        
        //I decided to use Scriptable Objects, rather then implementing the list in this script, in the sake of thinking
        //outside of the box :).  I also considered implementing factory pattern for ball creation but with that approach
        //to much changing needed to be made.I felt scriptable objects is the cleanest solution in this case. Also with this
        //way when we need to add different types of attributes to our ball it can be added easily to the ball data SO. 

        protected virtual void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetColor()
        {
            int randomIndexOfColors = Random.Range(0, _ballColorData.colors.Length);
            this.Color = _ballColorData.colors[randomIndexOfColors];
        }
    }
}
