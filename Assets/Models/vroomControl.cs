namespace UnityEngine.XR.Content.Interaction
{
    public class vroomControl : MonoBehaviour
    {
        public GameObject leftWheel;
        public GameObject rightWheel;
        public XRSlider A;
        public XRSlider B;


        public GameObject car;
        public GameObject forwRef;
        Rigidbody rigid;

        //[Range(0, 90)] public float both;

        public float force = 1f;

        public Vector3 forceL = Vector3.zero;
        public Vector3 forceR = Vector3.zero;
        public Vector3 forw = Vector3.zero;


        // Start is called before the first frame update
        void Start()
        {
            rigid = car.GetComponent<Rigidbody>();
            forw = Forward();
        }

        // Update is called once per frame
        void Update()
        {
            //rotLeft = both;
            //rotRight = both;
            forw = Forward();

            Debug.Log(A.value);

            //Left
            forceL = (A.value - 0.5f) * 100f * 1.2f * force * forw;
            rigid.AddForceAtPosition(forceL, leftWheel.transform.position);

            //Right
            forceR = (B.value - 0.5f) * 100f * 1.2f * force * forw;
            rigid.AddForceAtPosition(forceR, rightWheel.transform.position);


        }

        /*public float CheckAngle(float past, float lOrR)
        {
            float mesured;
            if (lOrR == 0) { mesured = (A.value-0.5f); }
            else { mesured = (B.value-0.5f); }

            return mesured - past;
        }*/

        public Vector3 Forward()
        {
            return Vector3.Normalize(forwRef.transform.position - car.transform.position);
        }
    }

}
