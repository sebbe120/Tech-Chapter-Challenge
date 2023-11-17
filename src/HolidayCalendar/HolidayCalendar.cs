using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HolidayCalendar;
public class HolidayCalendar : IHolidayCalendar
{
    public bool IsHoliday(DateTime date)
    {
        bool result = SendIsHolidayRequest(date).Result;

        return result;
    }

    public ICollection<DateTime> GetHolidays(DateTime startDate, DateTime endDate)
    {
        ICollection<DateTime> result = SendGetHolidaysRequest(startDate, endDate).Result;

        return result;
    }

    readonly string token = "50ba40e0-43d5-413d-b2a1-34dcc581e6fc";
    async Task<bool> SendIsHolidayRequest(DateTime date)
    {
        string url = $"https://api.sallinggroup.com/v1/holidays/is-holiday?date={date:yyyy-MM-dd}";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        string response = await client.GetStringAsync(url);
        bool result = bool.Parse(response);
        return result;
    }

    async Task<ICollection<DateTime>> SendGetHolidaysRequest(DateTime startDate, DateTime endDate)
    {
        ICollection<DateTime> dates = new List<DateTime>();

        string url = $"https://api.sallinggroup.com/v1/holidays?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        string response = await client.GetStringAsync(url);

        var obj = JArray.Parse(response);
        foreach (var dateItem in obj)
        {
            dates.Add(DateTime.Parse(dateItem["date"].ToString()));
        }

        return dates;
    }
}
