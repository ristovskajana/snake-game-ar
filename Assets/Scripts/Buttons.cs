using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    public SC_SnakeGameGenerator gameGen;

    public void clickUp() {
        gameGen.upClicked();
    }

    public void clickDown() {
        gameGen.downClicked();
    }

    public void clickLeft() {
        gameGen.leftClicked();
    }

    public void clickRight() {
        gameGen.rightClicked();
    }

}
