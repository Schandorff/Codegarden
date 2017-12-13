using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace CodeGarden.Api
{
    public class SessionController : UmbracoApiController
    {
        [HttpGet]
        public Session GetSession(int sID)
        {
            var cs = Services.ContentService;
            var session = cs.GetById(sID);
            if (session != null)
            {
                var s = new Session();

                s.Id = sID;
                s.Title = (session.Properties["sessionTitle"].Value != null) ? session.Properties["sessionTitle"].Value.ToString() : "Title";
                s.DescriptionHeadline = (session.Properties["sessionDescriptionHeadline"].Value != null) ? session.Properties["sessionDescriptionHeadline"].Value.ToString() : "SessionDescHeadline";
                s.Description = (session.Properties["sessionDescription"].Value != null) ? session.Properties["sessionDescription"].Value.ToString() : "Description";
                var venue = (session.Properties["sessionVenue"].Value != null) ? session.Properties["sessionVenue"].Value.ToString() : "Venue";
                s.Venue = Umbraco.GetPreValueAsString(int.Parse(venue));

                var date = (session.Properties["sessionDate"].Value != null) ? session.Properties["sessionDate"].Value.ToString() : "Date";
                s.Date = Umbraco.GetPreValueAsString(int.Parse(date));

                var startTimeID = (session.Properties["sessionStartTime"].Value != null) ? session.Properties["sessionStartTime"].Value.ToString() : "Starttime";
                s.StartTime = Umbraco.GetPreValueAsString(int.Parse(startTimeID));

                var endTimeID = (session.Properties["sessionEndTime"].Value != null) ? session.Properties["sessionEndTime"].Value.ToString() : "endtime";
                s.EndTime = Umbraco.GetPreValueAsString(int.Parse(endTimeID));
                s.Presentation = (session.Properties["sessionPresentation"].Value != null) ? session.Properties["sessionPresentation"].Value.ToString() : "Presentation";
                s.Video = (session.Properties["sessionVideo"].Value != null) ? session.Properties["sessionVideo"].Value.ToString() : "Video";

                s.Speakers = this.getSpeaker(session.Properties["sessionSpeakers"].Value.ToString());

                return s;
            }
            else
            {
                return new Session();
            }
        }
        // umb://document/a051ef9064e2430c95fa71a1055fc49d
        //Get the speaker from Guid
        private List<Speaker> getSpeaker(string guidString)
        {
            var cs = Services.ContentService;

            string[] speakerString = guidString.Split(',');

            
            List<Speaker> speakers = new List<Speaker>();
            foreach (var speaker in speakerString)
            {
                var i = Guid.Parse(speaker.Substring(15));

                var sessionSpeaker = cs.GetById(i);
                var s = new Speaker();
                s.Id = sessionSpeaker.Id;
                s.Name = sessionSpeaker.Name;
                try
                {
                    s.Picture = this.getImg(sessionSpeaker.Properties["speakerPicture"].Value.ToString());
                }
                catch
                {
                    s.Picture = "/media/1002/cg-placeholder.svg";
                };

                


                speakers.Add(s);
            }

            return speakers;
        }

        private string getImg(string guidString)
        {
            var ms = Services.MediaService;

            var imgGuid = Guid.Parse(guidString.Substring(12));

            var img = ms.GetById(imgGuid);

            return Umbraco.Media(img.Id).Url;
        }

        //The session object
        public class Session
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string DescriptionHeadline { get; set; }

            public string Description { get; set; }

            public string Venue { get; set; }

            public string Date { get; set; }

            public string StartTime { get; set; }

            public string EndTime { get; set; }

            public string Presentation { get; set; }

            public string Video { get; set; }

            public List<Speaker> Speakers { get; set; }
        }
        public class Speaker
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Picture { get; set; }
        }


    }
}
