using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmblemHolderManager : MonoBehaviour
{
	[SerializeField] private GameObject imageFade = null, BGFade = null;

	private Animator imageAnim = null, BGAnim = null;
	private Image image = null, BG = null;

	// Start is called before the first frame update
	void Start()
	{
		imageAnim = imageFade.GetComponent<Animator>();
		BGAnim = BGFade.GetComponent<Animator>();
		image = imageFade.GetComponent<Image>();
		BG = BGFade.GetComponent<Image>();

	}

	// Update is called once per frame
	void Update()
    {
        
    }

	public void PreviewImage(Sprite sprite)
	{
		BG.raycastTarget = true;

		image.sprite = sprite;
		imageAnim.Play("ImageFadeIn");
		BGAnim.Play("FadeIn");
	}

	public void ClosePreview()
	{
		BG.raycastTarget = false;

		imageAnim.Play("ImageFadeOut");
		BGAnim.Play("FadeOut");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
