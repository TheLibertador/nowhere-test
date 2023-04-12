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

        //TODO: Implement 2 types of balls which has red and blue colors.
        //OPTIONAL: Think outside the box.

        public Color[] colors = {Color.red, Color.blue,};

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
            int randomIndexOfColors = Random.Range(0, colors.Length);
            this.Color = colors[randomIndexOfColors];
        }
    }
}
