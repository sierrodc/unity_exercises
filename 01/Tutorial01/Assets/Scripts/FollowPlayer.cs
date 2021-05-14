using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        this._offset = this.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        this.transform.position = this._offset + Player.transform.position;
    }
}
