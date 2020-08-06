using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatrixJam.Team3
{
    public class ARGManager : MonoBehaviour
    {
        [SerializeField] private GameObject currentlEnabled;
        [SerializeField] private Dictionary<string, GameObject> Stages;
        
        [Serializable]
        public struct StageItem {
            public string name;
            public GameObject theObject;
        }
        
        [SerializeField] private List<StageItem> StagesList;
        
        // Start is called before the first frame update
        void Start()
        {
            Stages = new Dictionary<string, GameObject>();
            foreach ( StageItem item in StagesList)
            {
                
                Stages[item.name.ToLower()] = item.theObject;
            }
        }


        public void ChangeItem(string item)
        {            
            if (Stages.ContainsKey(item.ToLower())){
                currentlEnabled.SetActive(false);
                currentlEnabled = Stages[item.ToLower()];
                currentlEnabled.SetActive(true);
            }
        }
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}