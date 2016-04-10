var EffectName = ["Explosion1", "Explosion2", "Explosion3", "Explsoion4","Explosion5","Explosion6","Explosion7","Explosion8","Explosion9","Explosion10"];
var Effect = new Transform[10];
var i : int = 0;
var explosions:GameObject;
var monsterDestroy : boolean = false;

function OnCollisionEnter (col : Collision)
    {
       
       /* if(col.gameObject.name == "Terrain")
        {
            Debug.Log("Bang..." + EffectName[i]);
            Destroy(gameObject);
            //Instantiate(Effect[i], Vector3(0,0,0),Quaternion.identity);
            var boomz = Instantiate(explosions,transform.position, transform.rotation) ; 
            monsterDestroy = true;

            var cs = GameObject.Find("orc");
            var script = cs.GetComponent("Monster");
            script.KillMonster();
        }*/    
    }

    function Update () {
	
        if(Input.GetKeyDown(KeyCode.Z))
        {
             Destroy(gameObject);
            //Instantiate(Effect[i], Vector3(0,0,0),Quaternion.identity);
            var boomz = Instantiate(explosions,transform.position, transform.rotation) ; 
            monsterDestroy = true;
            //Destroy(gameObject.Find("Box"), 3);
            if(GameObject.Find("orc(Clone)"))
            {
                Debug.Log("Found...");
                Destroy(GameObject.Find("orc")); 
            }

            for(scan in GameObject.FindGameObjectsWithTag("Monster")) {
                GameObject.Destroy(scan);
            }
           
        }
    }

