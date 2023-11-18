using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;                       

public class TextChangerDOTW : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _speed = 3;
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("����� �������", _speed));
        sequence.Append(_text.DOText(" ��������", _speed).SetRelative());
        sequence.Append(_text.DOColor(Color.black, _speed));
        sequence.Append(_text.DOColor(Color.black, _speed));
        sequence.Append(_text.DOText("������� ������", _speed, true, ScrambleMode.All));

        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
