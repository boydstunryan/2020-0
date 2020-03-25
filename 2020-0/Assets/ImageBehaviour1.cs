using UnityEngine;
using UnityEngine.UI;

public class ImageBehaviour1 : MonoBehaviour
{
    private Image ImageObj;
    public FloatData dataObj;
    // Start is called before the first frame update
    void Start()
    {
        ImageObj = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        ImageObj.fillAmount = dataObj.value;
    }
}
