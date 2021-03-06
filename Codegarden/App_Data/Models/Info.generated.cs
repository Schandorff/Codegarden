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
	/// <summary>Info</summary>
	[PublishedContentModel("info")]
	public partial class Info : PublishedContentModel, IHeroMedia, IMetaBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "info";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Info(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Info, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About description: Write an about information text
		///</summary>
		[ImplementPropertyType("aboutDescription")]
		public IHtmlString AboutDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutDescription"); }
		}

		///<summary>
		/// About headline: Enter a headline for about description
		///</summary>
		[ImplementPropertyType("aboutHeadline")]
		public string AboutHeadline
		{
			get { return this.GetPropertyValue<string>("aboutHeadline"); }
		}

		///<summary>
		/// About picture 1: Pick an image
		///</summary>
		[ImplementPropertyType("aboutPicture1")]
		public IPublishedContent AboutPicture1
		{
			get { return this.GetPropertyValue<IPublishedContent>("aboutPicture1"); }
		}

		///<summary>
		/// About picture 2: Pick an image
		///</summary>
		[ImplementPropertyType("aboutPicture2")]
		public IPublishedContent AboutPicture2
		{
			get { return this.GetPropertyValue<IPublishedContent>("aboutPicture2"); }
		}

		///<summary>
		/// About picture 3: Pick an image
		///</summary>
		[ImplementPropertyType("aboutPicture3")]
		public IPublishedContent AboutPicture3
		{
			get { return this.GetPropertyValue<IPublishedContent>("aboutPicture3"); }
		}

		///<summary>
		/// About picture 4: Pick an image
		///</summary>
		[ImplementPropertyType("aboutPicture4")]
		public IPublishedContent AboutPicture4
		{
			get { return this.GetPropertyValue<IPublishedContent>("aboutPicture4"); }
		}

		///<summary>
		/// Contact description: Write a contact information text
		///</summary>
		[ImplementPropertyType("contactDescription")]
		public IHtmlString ContactDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("contactDescription"); }
		}

		///<summary>
		/// Contact form holder: Insert the contact form macro
		///</summary>
		[ImplementPropertyType("contactFormHolder")]
		public IHtmlString ContactFormHolder
		{
			get { return this.GetPropertyValue<IHtmlString>("contactFormHolder"); }
		}

		///<summary>
		/// Contact headline: Enter a headline for the contact description
		///</summary>
		[ImplementPropertyType("contactHeadline")]
		public string ContactHeadline
		{
			get { return this.GetPropertyValue<string>("contactHeadline"); }
		}

		///<summary>
		/// Contact submit test: Enter text for contact form submit button
		///</summary>
		[ImplementPropertyType("contactSubmitTest")]
		public string ContactSubmitTest
		{
			get { return this.GetPropertyValue<string>("contactSubmitTest"); }
		}

		///<summary>
		/// Map description: Write a map information text
		///</summary>
		[ImplementPropertyType("mapDescription")]
		public IHtmlString MapDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("mapDescription"); }
		}

		///<summary>
		/// Map headline: Enter a headline for map description
		///</summary>
		[ImplementPropertyType("mapHeadline")]
		public string MapHeadline
		{
			get { return this.GetPropertyValue<string>("mapHeadline"); }
		}

		///<summary>
		/// Map holder: Insert map macro
		///</summary>
		[ImplementPropertyType("mapHolder")]
		public IHtmlString MapHolder
		{
			get { return this.GetPropertyValue<IHtmlString>("mapHolder"); }
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
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaTitle(this); }
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
