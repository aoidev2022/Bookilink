namespace Bookilink.Domain.Bookings;

public class DateRange
{
    public DateOnly Start { get; set; }
    public DateOnly End { get; set; }

    public int LengthInDays => End.DayNumber - Start.DayNumber;

    private DateRange() { }

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end) throw new ApplicationException("End date precedes start date");

        return new DateRange { End = end, Start = start };
    }
}