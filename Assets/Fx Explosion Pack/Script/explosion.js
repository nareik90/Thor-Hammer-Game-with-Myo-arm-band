var EffectName = ["Explosion1", "Explosion2", "Explosion3", "Explsoion4","Explosion5","Explosion6","Explosion7","Explosion8","Explosion9","Explosion10"];
var Effect = new Transform[53];
var i : int = 0;

function Start()
{
     //Instantiate(Effect[i], Vector3(0,0,0),Quaternion.identity);
}

function OnCollisionEnter (col : Collision)
    {
        if(col.gameObject.name == "Ground")
        {
            Debug.Log("Bang...");
            //Instantiate(Effect[i], Vector3(0,0,0),Quaternion.identity);
            var obx = Instantiate(Effect[i], Vector3(0,0,0),Quaternion.identity);
        }
}
