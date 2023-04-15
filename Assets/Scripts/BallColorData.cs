using UnityEngine;

[CreateAssetMenu(menuName = "Ball Color Data")]
public class BallColorData : ScriptableObject
{
    [SerializeField] public Color[] colors = {Color.blue, Color.red};
}