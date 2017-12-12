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
	/// <summary>Sessions</summary>
	[PublishedContentModel("sessions")]
	public partial class Sessions : PublishedContentModel, IHeroMedia
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sessions";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Sessions(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sessions, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
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
	}
}
