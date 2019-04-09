using System;

namespace Practices
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DayOfWeek DayOfWeek()
        {
            return DateTime.Today.DayOfWeek;
        }
    }
}
