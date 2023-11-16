using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;                       

public class TextChangerDOTW : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("����� �������", 3f));
        sequence.Append(_text.DOText(" ��������", 3).SetRelative());
        sequence.Append(_text.DOColor(Color.black, 3));
        sequence.Append(_text.DOColor(Color.black, 3));
        sequence.Append(_text.DOText("������� ������", 3, true, ScrambleMode.All));

        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
