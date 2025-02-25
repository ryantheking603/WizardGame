using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] Sprite[] charSprites;
    private Sprite currSprite;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = charSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) {
            currSprite = charSprites[0];
        }
        else if (Input.GetKey("s")) {
            currSprite = charSprites[1];
        }
        else if (Input.GetKey("a")) {
            currSprite = charSprites[2];
        }
        else if (Input.GetKey("d")) {
            currSprite = charSprites[3];
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = currSprite;
    }
}
