﻿using Newtonsoft.Json;

namespace EventbriteApiV3.Attendees
{
    public class AttendeeSearchEventbriteRequest : EventbriteRequestBase
    {
        private const string Path = "events/{0}/attendees/";

        public AttendeeSearchEventbriteRequest(EventbriteContext context, double eventId, BaseSearchCriterias criterias)
            : base(string.Format(Path, eventId), context, criterias.ToNameValueCollection())
        {
           
        }

        public AttendeeSearchApiResponse GetResponse()
        {
            var response = GetJsonResponse();

            return JsonConvert.DeserializeObject<AttendeeSearchApiResponse>(response);
        }
    }
}