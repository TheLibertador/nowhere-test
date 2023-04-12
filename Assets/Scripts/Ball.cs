using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Ball : MonoBehaviour
    {
        public Color Color { get => _spriteRenderer.color; }
        protected SpriteRenderer _spriteRenderer;

        //TODO: Implement 2 types of balls which has red and blue colors.
        //OPTIONAL: Think outside the box.

        protected virtual void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
