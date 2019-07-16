using UnityEngine;
using Grid;
using System.Collections;

public class Element : MonoBehaviour {
    // Is this a Mine?
    public bool mine;

    // Different Textures
    public Sprite[] emptyTextures;
    public Sprite mineTexture;

    // Use this for initialization
	void Start () {

        // Randomly decide if it's a mine or not
        mine = Random.value < 0.15;
        
        // Register in Grid
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        Grid.elements[x, y] = this;
    }
	
    // Load another texture
    public void loadTexture(int adjacentCount){
        if (mine){
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        }
        else{
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
        }
    }
    // Is it still covered
    public bool isCovered(){
        return GetComponent<SpriteRenderer>().sprite.texture.name == "Ground_Unclicked";
    }

    void OnMouseUpAsButton(){
        //Is Mine
        if (mine){
            // ToDo: Uncover all Mines

            // Game Over
            print("You Lose");
        }
        //No is mine
        else {
            // ToDo: Revale Tiles

            // ToDo: LoadTextures

            // ToDo: Uncover area without mines

            // Todo: see if game is Won
        }
    }
}
