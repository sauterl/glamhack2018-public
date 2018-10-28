﻿using UnityEngine;

namespace DefaultNamespace
{    
	public class Ceiling : MonoBehaviour {       
		// Use this for initialization
		private void Start()
		{    
			//LoadTexture("STARS");
		}

		// Update is called once per frame
		private void Update() { }
        
		/// <summary>
		/// 
		/// </summary>
		public void LoadTexture(string materialName)
		{
			var material = TexturingUtility.getMaterial(materialName);
			
			Renderer rend = GetComponent<Renderer>();
			if (rend != null && material != null)
			{
				rend.material = material;
			}
		}
	}
}