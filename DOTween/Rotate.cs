using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 0, 360), _speed,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart);
    }
}
