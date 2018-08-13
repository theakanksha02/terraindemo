using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class apiscript : MonoBehaviour {

	string url="https://vignette.wikia.nocookie.net/psnplatinum/images/4/49/Game_of_Thrones_logo.png/revision/latest?cb=20151225003704";
	string url1= "https://vignette.wikia.nocookie.net/animal-jam-clans-1/images/1/1f/Netflix.png/revision/latest?cb=20170213221739";
	string url2= "https://vignette.wikia.nocookie.net/bigbrother/images/a/ab/BB_NS_3.png/revision/latest?cb=20161030034935";
	string url3="http://www.pngmart.com/files/4/The-Big-Bang-Theory-PNG-HD.png";
	string url4="https://thenextissuepodcast.files.wordpress.com/2018/02/black_panther_updated_logo_-_transparent.png";
	string url5="https://imaoyun.com/wp-content/uploads/2018/04/need_for_speed_icon_by_s7_by_sidyseven-d9f0w3i.png";
	Texture2D img;
	Texture2D img1;
	Texture2D img2;
	Texture2D img3;
	Texture2D img4;
	Texture2D img5;
	public Canvas canvas,canvas1;

	void Start()
	{
		canvas1.GetComponent<Canvas> ().enabled = false;
	}

	IEnumerator LoadImg()
	{
		
			yield return 0;
			WWW imgLink = new WWW (url);
			WWW imgLink1 = new WWW (url1);
		    WWW imgLink2 = new WWW (url2);
		    WWW imgLink3 = new WWW (url3);
		    WWW imgLink4 = new WWW (url4);
	     	WWW imgLink5 = new WWW (url5);


			yield return imgLink;
			yield return imgLink1;
		    yield return imgLink2;
		    yield return imgLink3;
		    yield return imgLink4;
		    yield return imgLink5;
		    img = imgLink.texture;
		    img1 = imgLink1.texture;
		    img2 = imgLink2.texture;
		    img3 = imgLink3.texture;
		    img4 = imgLink4.texture;
		    img5 = imgLink5.texture;

	}

	void OnGUI()
	{
		GUI.Label(new Rect(40, 20, 320,320), img);
		GUI.Label(new Rect(380, 20, 320,320), img1);
		GUI.Label(new Rect(40, 220, 320,320), img2);
		GUI.Label(new Rect(380, 180, 320,320), img3);
		GUI.Label(new Rect(725, 20, 320,320), img4);
		GUI.Label(new Rect(740, 180, 200,200), img5);
	}

	public void callmethod()
	{
		StartCoroutine (LoadImg ());
		canvas.GetComponent<Canvas> ().enabled = false;
		canvas1.GetComponent<Canvas> ().enabled = true;
	}
}
