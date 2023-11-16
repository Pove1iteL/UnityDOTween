using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;                       

public class TextChangerDOTW : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;

    private void Start()
    {
        _text.DOText("����� �������", 3f).SetLoops(-1,LoopType.Yoyo);  
        
        _text1.DOText(" ��������", 3).SetRelative().SetLoops(-1, LoopType.Yoyo);
        _text1.DOColor(Color.black, 3).SetLoops(-1, LoopType.Yoyo);

        _text2.DOText("������� ������", 3, true, ScrambleMode.All).SetLoops(-1, LoopType.Yoyo);
    }
}
