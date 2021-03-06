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
	/// <summary>Speakers</summary>
	[PublishedContentModel("speakers")]
	public partial class Speakers : PublishedContentModel, IHeroMedia, IMetaBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "speakers";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Speakers(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Speakers, TValue>> selector)
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
