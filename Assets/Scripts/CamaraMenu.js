#pragma strict

var velocidad:float=2.0;
var	angulo:float=60.0;

function Start () {

}

function Update () {
        transform.Rotate(0,angulo*Time.deltaTime,0);
}