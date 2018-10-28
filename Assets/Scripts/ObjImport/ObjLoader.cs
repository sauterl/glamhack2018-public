﻿using System.Collections;
using UnityEngine;

namespace DefaultNamespace.ObjImport {
  public class ObjLoader : MonoBehaviour{

	  
	  
	  void Start() {
		  
	  }

	  public void Load(string url) {
		  StartCoroutine(LoadModel(url));
	  }

	  private IEnumerator LoadModel(string url) {
		  Debug.Log("Loading "+url);
		  using (WWW www = new WWW(url)) {
			  yield return www;
			  if (string.IsNullOrEmpty(www.error)) {
				  Debug.Log(www.text);
				  Mesh holderMesh = new Mesh();
		  
				  holderMesh = FastObjImporter.Instance.ImportFile(www.text);

				  MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
				  MeshFilter filter = gameObject.AddComponent<MeshFilter>();
				  filter.mesh = holderMesh;
			  } else {
				  Debug.LogError(www.error);
			  }
		  }
	  }
    
    
  }
  
  /*
   * private MeshRenderer _renderer;

	// Use this for initialization
	void Start () {
		_renderer = GetComponent<MeshRenderer>();
		//StartCoroutine(LoadImage());
	}
		
	private IEnumerator LoadImage(string url)
	{
		Texture2D tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
		using (WWW www = new WWW(url))
		{
			yield return www;
			www.LoadImageIntoTexture(tex);
			GetComponent<Renderer>().material.mainTexture = tex;
		}

		_renderer.material.mainTexture = tex;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="url"></param>
	public void ReloadImage(string url)
	{
		StartCoroutine(LoadImage(url));
	}
   */
}