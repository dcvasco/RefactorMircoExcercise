namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        public const double LowPressureThreshold = 17;
        public const double HighPressureThreshold = 21;

        readonly Sensor _sensor = new Sensor();
        double _psiPressureValue;
        bool _alarmOn = false;

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
