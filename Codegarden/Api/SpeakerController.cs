using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace CodeGarden.Api
{
    public class SpeakerController : UmbracoApiController
    {
        //Method for getting a single speaker

        [HttpGet]
        public Speaker GetSpeaker(int sID)
        {
            var cs = Services.ContentService;
            var speaker = cs.GetById(sID);
            if (speaker != null)
            {
                var s = new Speaker();

                s.Id = sID;
                s.Name = (speaker.Properties["speakerName"].Value != null) ? speaker.Properties["speakerName"].Value.ToString() : "Name";
                s.Title = (speaker.Properties["speakerTitle"].Value != null) ? speaker.Properties["speakerTitle"].Value.ToString() : "Title";
                s.Facebook = (speaker.Properties["speakerFacebook"].Value != null) ? speaker.Properties["speakerFacebook"].Value.ToString() : "Facebook";
                s.LinkedIn = (speaker.Properties["speakerLinkedin"].Value != null) ? speaker.Properties["speakerLinkedin"].Value.ToString() : "LinkedIn";
                s.Twitter = (speaker.Properties["speakerTwitter"].Value != null) ? speaker.Properties["speakerTwitter"].Value.ToString() : "Twitter";
                s.Description = (speaker.Properties["speakerDescription"].Value != null) ? speaker.Properties["speakerDescription"].Value.ToString() : "Description";
                //Get the image by calling the private method
                s.Picture = this.getImg(speaker.Properties["speakerPicture"].Value.ToString());

                return s;
            }
            else
            {
                return new Speaker();
            }
        }

        //Private Method for getting the image via MediaServices
        private string getImg(string guidString)
        {
            var ms = Services.MediaService;

            var imgGuid = Guid.Parse(guidString.Substring(12));

            var img = ms.GetById(imgGuid);

            return img.GetValue("umbracoFile").ToString();
        }

        //The speaker object
        public class Speaker
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Title { get; set; }

            public string Picture { get; set; }

            public string Facebook { get; set; }

            public string LinkedIn { get; set; }

            public string Twitter { get; set; }

            public string Description { get; set; }
        }


    }
}