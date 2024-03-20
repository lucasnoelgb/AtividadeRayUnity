# AtividadeRayUnity


        void ShootRaycast() {

        RaycastHit hitInfo;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.GetForwardDirection(), out hitInfo, Mathf.Infinity, LayerMask.GetMask("hittable"))) {

            IShotHit hitted = hitInfo.transform.GetComponent<IShotHit>();
            if(hitted != null) {

                hitted.Hit(fpsCam.GetForwardDirection());
