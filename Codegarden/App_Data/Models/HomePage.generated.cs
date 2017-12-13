//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home page</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : PublishedContentModel, IHeroMedia, IMetaBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Buy ticket link: Enter the url of the ticket link
		///</summary>
		[ImplementPropertyType("buyTicketLink")]
		public string BuyTicketLink
		{
			get { return this.GetPropertyValue<string>("buyTicketLink"); }
		}

		///<summary>
		/// Buy ticket link text: Specify the link text
		///</summary>
		[ImplementPropertyType("buyTicketLinkText")]
		public string BuyTicketLinkText
		{
			get { return this.GetPropertyValue<string>("buyTicketLinkText"); }
		}

		///<summary>
		/// Event date headline: The date of the event
		///</summary>
		[ImplementPropertyType("eventDateHeadline")]
		public string EventDateHeadline
		{
			get { return this.GetPropertyValue<string>("eventDateHeadline"); }
		}

		///<summary>
		/// Event presentation: Enter a description for the event
		///</summary>
		[ImplementPropertyType("eventPresentation")]
		public IHtmlString EventPresentation
		{
			get { return this.GetPropertyValue<IHtmlString>("eventPresentation"); }
		}

		///<summary>
		/// Exclusive speaker link text: Link text for exclusive speaker link
		///</summary>
		[ImplementPropertyType("exclusiveSpeakerLinkText")]
		public string ExclusiveSpeakerLinkText
		{
			get { return this.GetPropertyValue<string>("exclusiveSpeakerLinkText"); }
		}

		///<summary>
		/// Link to exclusive speaker: Link to the exclusive speaker page
		///</summary>
		[ImplementPropertyType("linkToExclusiveSpeaker")]
		public string LinkToExclusiveSpeaker
		{
			get { return this.GetPropertyValue<string>("linkToExclusiveSpeaker"); }
		}

		///<summary>
		/// Masterclass banner: Pick a banner image for the masterclass
		///</summary>
		[ImplementPropertyType("masterclassBanner")]
		public IPublishedContent MasterclassBanner
		{
			get { return this.GetPropertyValue<IPublishedContent>("masterclassBanner"); }
		}

		///<summary>
		/// Masterclass headline: Enter a headline for the masterclass section
		///</summary>
		[ImplementPropertyType("masterclassHeadline")]
		public string MasterclassHeadline
		{
			get { return this.GetPropertyValue<string>("masterclassHeadline"); }
		}

		///<summary>
		/// Masterclass intro text: Enter an introduction to this years masterclasses
		///</summary>
		[ImplementPropertyType("masterclassIntroText")]
		public IHtmlString MasterclassIntroText
		{
			get { return this.GetPropertyValue<IHtmlString>("masterclassIntroText"); }
		}

		///<summary>
		/// Schedule link: Insert the link for the schedule page
		///</summary>
		[ImplementPropertyType("scheduleLink")]
		public string ScheduleLink
		{
			get { return this.GetPropertyValue<string>("scheduleLink"); }
		}

		///<summary>
		/// Schedule link text: Enter the text for the schedule link
		///</summary>
		[ImplementPropertyType("scheduleLinkText")]
		public string ScheduleLinkText
		{
			get { return this.GetPropertyValue<string>("scheduleLinkText"); }
		}

		///<summary>
		/// Speakers headline: Enter a headline for the speakers section
		///</summary>
		[ImplementPropertyType("speakersHeadline")]
		public string SpeakersHeadline
		{
			get { return this.GetPropertyValue<string>("speakersHeadline"); }
		}

		///<summary>
		/// Speakers intro text: Enter an introduction to this years speakers
		///</summary>
		[ImplementPropertyType("speakersIntroText")]
		public string SpeakersIntroText
		{
			get { return this.GetPropertyValue<string>("speakersIntroText"); }
		}

		///<summary>
		/// Speakers one line: The last line before the speakers images
		///</summary>
		[ImplementPropertyType("speakersOneLine")]
		public string SpeakersOneLine
		{
			get { return this.GetPropertyValue<string>("speakersOneLine"); }
		}

		///<summary>
		/// Themes headline: Headline for the themes left section
		///</summary>
		[ImplementPropertyType("themesHeadline")]
		public string ThemesHeadline
		{
			get { return this.GetPropertyValue<string>("themesHeadline"); }
		}

		///<summary>
		/// Themes presentation description: Enter a description for the themes
		///</summary>
		[ImplementPropertyType("themesPresentationDescription")]
		public IHtmlString ThemesPresentationDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("themesPresentationDescription"); }
		}

		///<summary>
		/// Themes present headline: Enter a headline for the themes on right
		///</summary>
		[ImplementPropertyType("themesPresentHeadline")]
		public string ThemesPresentHeadline
		{
			get { return this.GetPropertyValue<string>("themesPresentHeadline"); }
		}

		///<summary>
		/// Themes selector: Select themes to show
		///</summary>
		[ImplementPropertyType("themesSelector")]
		public IEnumerable<IPublishedContent> ThemesSelector
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("themesSelector"); }
		}

		///<summary>
		/// What you get headline: Enter a headline
		///</summary>
		[ImplementPropertyType("whatYouGetHeadline")]
		public string WhatYouGetHeadline
		{
			get { return this.GetPropertyValue<string>("whatYouGetHeadline"); }
		}

		///<summary>
		/// What you get link: Choose the pdf
		///</summary>
		[ImplementPropertyType("whatYouGetLink")]
		public IPublishedContent WhatYouGetLink
		{
			get { return this.GetPropertyValue<IPublishedContent>("whatYouGetLink"); }
		}

		///<summary>
		/// What you get link text: Specify the link text
		///</summary>
		[ImplementPropertyType("whatYouGetLinkText")]
		public string WhatYouGetLinkText
		{
			get { return this.GetPropertyValue<string>("whatYouGetLinkText"); }
		}

		///<summary>
		/// What you get list: Add list items to what you get section
		///</summary>
		[ImplementPropertyType("whatYouGetList")]
		public IEnumerable<string> WhatYouGetList
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("whatYouGetList"); }
		}

		///<summary>
		/// Workshop headline: Enter a headline for the workshop section
		///</summary>
		[ImplementPropertyType("workshopHeadline")]
		public string WorkshopHeadline
		{
			get { return this.GetPropertyValue<string>("workshopHeadline"); }
		}

		///<summary>
		/// Workshops main description: Enter a description for the workshops
		///</summary>
		[ImplementPropertyType("workshopsMainDescription")]
		public IHtmlString WorkshopsMainDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("workshopsMainDescription"); }
		}

		///<summary>
		/// Hero picker: Choose video or image for header
		///</summary>
		[ImplementPropertyType("heroPicker")]
		public IPublishedContent HeroPicker
		{
			get { return Umbraco.Web.PublishedContentModels.HeroMedia.GetHeroPicker(this); }
		}

		///<summary>
		/// Is video: Click this if a video was chosen
		///</summary>
		[ImplementPropertyType("isVideo")]
		public bool IsVideo
		{
			get { return Umbraco.Web.PublishedContentModels.HeroMedia.GetIsVideo(this); }
		}

		///<summary>
		/// Page title: Page title for banner heading
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.HeroMedia.GetPageTitle(this); }
		}

		///<summary>
		/// Meta Description: This is the page description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Keywords: This is the page keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaKeywords(this); }
		}

		///<summary>
		/// Meta Ttitle: This is the page title
		///</summary>
		[ImplementPropertyType("metaTtitle")]
		public string MetaTtitle
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaTtitle(this); }
		}

		///<summary>
		/// Hide in navigation?: Should this page be hidden from the navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetUmbracoNaviHide(this); }
		}
	}
}
