namespace DTM.HuellaDigital.Class
{
    public delegate void OnChangeHandler();
    public class AppData
    {
        public const int MaxFingers = 10;
        // shared data
        public int EnrolledFingersMask = 0;
        public int MaxEnrollFingerCount = MaxFingers;
        public bool IsEventHandlerSucceeds = true;
        public bool IsFeatureSetMatched = false;
        public int FalseAcceptRate = 0;
        public DPFP.Template[] Templates = new DPFP.Template[MaxFingers];

        // data change notification
        public void Update() { OnChange(); }        // just fires the OnChange() event
        public event OnChangeHandler OnChange;
    }
}
