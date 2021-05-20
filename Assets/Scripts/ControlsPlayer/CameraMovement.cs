using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform target;
    public float smoothing;
    private WhereAmI WhereAmI;
    private CharacterSelector characterSelector;
    public GameObject[] characterList;


    // Start is called before the first frame update
    void Start()
    {
        WhereAmI = GetComponent<WhereAmI>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (CharacterSelector.index == 0)
        {
            target = characterList[0].transform;
        }
        else if (CharacterSelector.index == 1)
        {
            target = characterList[1].transform;
        }

        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, WhereAmI.minPosition.x, WhereAmI.maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, WhereAmI.minPosition.y, WhereAmI.maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
