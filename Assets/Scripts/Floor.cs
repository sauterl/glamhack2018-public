using UnityEngine;

namespace DefaultNamespace
{    
    public class Floor : MonoBehaviour {
        private void Start()
        {    
            //LoadTexture("WOOD3");
        }

        // Update is called once per frame
        private void Update() { }
        
        /// <summary>
        /// 
        /// </summary>
        public void LoadTexture(string materialName)
        {
            Debug.Log("Floor texture" + materialName);
            
            var material = TexturingUtility.getMaterial(materialName);
			
            Renderer rend = GetComponent<Renderer>();
            if (rend != null && material != null)
            {
                rend.material = material;
            }
        }
    }
}