using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TirePressureTests
{
    public class Tests
    {
        Alarm alarm;
        bool lowPressureThresholdOverflow,
            highPressureThresholdOverflow,
            alarmShouldBeON;

        [SetUp]
        public void Setup()
        {
            alarm = new();
            alarm.Check();
        }

        [Test]
        public void Test()
        {
            (lowPressureThresholdOverflow, highPressureThresholdOverflow) =
                (alarm.PsiPressureValue < Alarm.LowPressureThreshold, alarm.PsiPressureValue > Alarm.HighPressureThreshold);
            alarmShouldBeON = lowPressureThresholdOverflow || highPressureThresholdOverflow;

            Assert.That(alarm.AlarmOn, Is.EqualTo(alarmShouldBeON),
                string.Format("alarmOn is {0} and should be {1}\n(lowPressureThresholdOverflow: {2}, highPressureThresholdOverflow: {3})",
                    alarm.AlarmOn, alarmShouldBeON, lowPressureThresholdOverflow, highPressureThresholdOverflow));
        }
    }
}
