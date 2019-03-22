using UnityEngine;
using DG.Tweening;

public class Gato : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveX(5, 5).SetLoops(-1,LoopType.Yoyo);
        GetComponent<Renderer>().material.DOColor(Color.red, 5).SetLoops(-1);
        GetComponent<Renderer>().material.DOFade(0, 3).SetLoops(2).OnComplete(Destruir);
    }
    void Destruir()
    {
        //Destroy(this.gameObject);
    }
}
