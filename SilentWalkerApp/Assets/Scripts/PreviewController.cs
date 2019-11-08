using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewController : MonoBehaviour
{
	[SerializeField] private EmblemHolderManager emblemManager = null;

	[SerializeField] private List<Image> imageList = null;

    // Start is called before the first frame update
    void Start()
    {
		//imageAnim = imageFade.GetComponent<Animator>();
		//BGAnim = BGFade.GetComponent<Animator>();
		//image = imageFade.GetComponent<Image>();
		//BG = BGFade.GetComponent<Image>();

	}

	// Update is called once per frame
	void Update()
    {
        
    }

	public void PreviewImage(int i)
	{
		emblemManager.PreviewImage(imageList[i].sprite);

		//BG.raycastTarget = true;
		//
		//image.sprite = imageList[i].sprite;
		//imageAnim.Play("ImageFadeIn");
		//BGAnim.Play("FadeIn");
	}

	//public void ClosePreview()
	//{
	//	BG.raycastTarget = false;

	//	imageAnim.Play("ImageFadeOut");
	//	BGAnim.Play("FadeOut");
	//}
}
