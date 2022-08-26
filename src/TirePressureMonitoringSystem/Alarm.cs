namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private readonly Sensor _sensor;
        private double _psiPressureValue;
        private bool _alarmOn = false;

        public const double LowPressureThreshold = 17;
        public const double HighPressureThreshold = 21;

        public Alarm()
        {
            _sensor = new Sensor();
        }

        public void Check()
        {
            _psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (_psiPressureValue < LowPressureThreshold || HighPressureThreshold < _psiPressureValue)
                _alarmOn = true;
        }

        public double PsiPressureValue
        {
            get { return _psiPressureValue; }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
